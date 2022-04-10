﻿using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using NewLife;
using NewLife.Web;
using Stardust.Registry;
using HttpContext = Microsoft.AspNetCore.Http.HttpContext;

namespace Stardust.Extensions
{
    /// <summary>注册服务中间件</summary>
    public class RegistryMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IServiceProvider _serviceProvider;

        /// <summary>用户访问地址。记录用户通过哪个地址访问本系统</summary>
        public static Uri UserUri { get; set; }

        /// <summary>实例化</summary>
        /// <param name="next"></param>
        /// <param name="serviceProvider"></param>
        public RegistryMiddleware(RequestDelegate next, IServiceProvider serviceProvider)
        {
            _next = next ?? throw new ArgumentNullException(nameof(next));
            _serviceProvider = serviceProvider;

            // 加载本地缓存
            var file = NewLife.Setting.Current.DataPath.CombinePath("server_address.config").GetBasePath();
            if (File.Exists(file))
            {
                var str = File.ReadAllText(file);
                if (!str.IsNullOrEmpty()) UserUri = new Uri(str);
            }
        }

        /// <summary>调用</summary>
        /// <param name="ctx"></param>
        /// <returns></returns>
        public async Task Invoke(HttpContext ctx)
        {
            CheckUserUri(ctx);

            await _next.Invoke(ctx);
        }

        private Boolean _inited;
        private void CheckUserUri(HttpContext ctx)
        {
            if (_inited) return;

            //var uri = UserUri;
            //if (uri != null && !uri.Host.EqualIgnoreCase("localhost", "127.0.0.1", "::1")) return;

            var uri = ctx.Request.GetRawUrl();
            if (uri == null || uri.Host.EqualIgnoreCase("localhost", "127.0.0.1", "::1")) return;

            var url = uri.ToString();
            var p = url.IndexOf('/', "https://".Length);
            if (p > 0) url = url[..p];

            UserUri = new Uri(url);
            _inited = true;

            // 更新地址
            var registry = _serviceProvider.GetService<IRegistry>();
            if (registry is AppClient app)
            {
                app.SetServerAddress(url);
            }

            try
            {
                var file = NewLife.Setting.Current.DataPath.CombinePath("server_address.config").GetBasePath();
                File.WriteAllText(file, url);
            }
            catch { }
        }
    }
}