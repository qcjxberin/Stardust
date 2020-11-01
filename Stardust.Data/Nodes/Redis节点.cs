using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Web.Script.Serialization;
using System.Xml.Serialization;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace Stardust.Data.Nodes
{
    /// <summary>Redis节点。Redis管理</summary>
    [Serializable]
    [DataObject]
    [Description("Redis节点。Redis管理")]
    [BindIndex("IU_RedisNode_Server", true, "Server")]
    [BindTable("RedisNode", Description = "Redis节点。Redis管理", ConnName = "Node", DbType = DatabaseType.None)]
    public partial class RedisNode
    {
        #region 属性
        private Int32 _Id;
        /// <summary>编号</summary>
        [DisplayName("编号")]
        [Description("编号")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("Id", "编号", "")]
        public Int32 Id { get => _Id; set { if (OnPropertyChanging("Id", value)) { _Id = value; OnPropertyChanged("Id"); } } }

        private String _Name;
        /// <summary>名称</summary>
        [DisplayName("名称")]
        [Description("名称")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Name", "名称", "", Master = true)]
        public String Name { get => _Name; set { if (OnPropertyChanging("Name", value)) { _Name = value; OnPropertyChanged("Name"); } } }

        private String _Category;
        /// <summary>分类</summary>
        [DisplayName("分类")]
        [Description("分类")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Category", "分类", "")]
        public String Category { get => _Category; set { if (OnPropertyChanging("Category", value)) { _Category = value; OnPropertyChanged("Category"); } } }

        private String _Server;
        /// <summary>地址。含端口</summary>
        [DisplayName("地址")]
        [Description("地址。含端口")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Server", "地址。含端口", "")]
        public String Server { get => _Server; set { if (OnPropertyChanging("Server", value)) { _Server = value; OnPropertyChanged("Server"); } } }

        private String _Password;
        /// <summary>密码</summary>
        [DisplayName("密码")]
        [Description("密码")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Password", "密码", "")]
        public String Password { get => _Password; set { if (OnPropertyChanging("Password", value)) { _Password = value; OnPropertyChanged("Password"); } } }

        private String _Version;
        /// <summary>版本</summary>
        [DisplayName("版本")]
        [Description("版本")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Version", "版本", "")]
        public String Version { get => _Version; set { if (OnPropertyChanging("Version", value)) { _Version = value; OnPropertyChanged("Version"); } } }

        private String _Mode;
        /// <summary>模式</summary>
        [DisplayName("模式")]
        [Description("模式")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Mode", "模式", "")]
        public String Mode { get => _Mode; set { if (OnPropertyChanging("Mode", value)) { _Mode = value; OnPropertyChanged("Mode"); } } }

        private Int32 _MaxMemory;
        /// <summary>内存容量。单位MB</summary>
        [DisplayName("内存容量")]
        [Description("内存容量。单位MB")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("MaxMemory", "内存容量。单位MB", "")]
        public Int32 MaxMemory { get => _MaxMemory; set { if (OnPropertyChanging("MaxMemory", value)) { _MaxMemory = value; OnPropertyChanged("MaxMemory"); } } }

        private String _MemoryPolicy;
        /// <summary>内存策略。缓存淘汰策略</summary>
        [DisplayName("内存策略")]
        [Description("内存策略。缓存淘汰策略")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("MemoryPolicy", "内存策略。缓存淘汰策略", "")]
        public String MemoryPolicy { get => _MemoryPolicy; set { if (OnPropertyChanging("MemoryPolicy", value)) { _MemoryPolicy = value; OnPropertyChanged("MemoryPolicy"); } } }

        private String _MemoryAllocator;
        /// <summary>分配器。内存分配器，低版本有内存泄漏</summary>
        [DisplayName("分配器")]
        [Description("分配器。内存分配器，低版本有内存泄漏")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("MemoryAllocator", "分配器。内存分配器，低版本有内存泄漏", "")]
        public String MemoryAllocator { get => _MemoryAllocator; set { if (OnPropertyChanging("MemoryAllocator", value)) { _MemoryAllocator = value; OnPropertyChanged("MemoryAllocator"); } } }

        private Boolean _Enable;
        /// <summary>启用。停用的节点不再执行监控</summary>
        [DisplayName("启用")]
        [Description("启用。停用的节点不再执行监控")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Enable", "启用。停用的节点不再执行监控", "")]
        public Boolean Enable { get => _Enable; set { if (OnPropertyChanging("Enable", value)) { _Enable = value; OnPropertyChanged("Enable"); } } }

        private Boolean _DiscoverQueue;
        /// <summary>队列。自动扫描发现消息队列，默认true</summary>
        [DisplayName("队列")]
        [Description("队列。自动扫描发现消息队列，默认true")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("DiscoverQueue", "队列。自动扫描发现消息队列，默认true", "")]
        public Boolean DiscoverQueue { get => _DiscoverQueue; set { if (OnPropertyChanging("DiscoverQueue", value)) { _DiscoverQueue = value; OnPropertyChanged("DiscoverQueue"); } } }

        private String _CreateUser;
        /// <summary>创建人</summary>
        [DisplayName("创建人")]
        [Description("创建人")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("CreateUser", "创建人", "")]
        public String CreateUser { get => _CreateUser; set { if (OnPropertyChanging("CreateUser", value)) { _CreateUser = value; OnPropertyChanged("CreateUser"); } } }

        private Int32 _CreateUserID;
        /// <summary>创建者</summary>
        [DisplayName("创建者")]
        [Description("创建者")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("CreateUserID", "创建者", "")]
        public Int32 CreateUserID { get => _CreateUserID; set { if (OnPropertyChanging("CreateUserID", value)) { _CreateUserID = value; OnPropertyChanged("CreateUserID"); } } }

        private DateTime _CreateTime;
        /// <summary>创建时间</summary>
        [DisplayName("创建时间")]
        [Description("创建时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("CreateTime", "创建时间", "")]
        public DateTime CreateTime { get => _CreateTime; set { if (OnPropertyChanging("CreateTime", value)) { _CreateTime = value; OnPropertyChanged("CreateTime"); } } }

        private String _CreateIP;
        /// <summary>创建地址</summary>
        [DisplayName("创建地址")]
        [Description("创建地址")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("CreateIP", "创建地址", "")]
        public String CreateIP { get => _CreateIP; set { if (OnPropertyChanging("CreateIP", value)) { _CreateIP = value; OnPropertyChanged("CreateIP"); } } }

        private String _UpdateUser;
        /// <summary>更新人</summary>
        [DisplayName("更新人")]
        [Description("更新人")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("UpdateUser", "更新人", "")]
        public String UpdateUser { get => _UpdateUser; set { if (OnPropertyChanging("UpdateUser", value)) { _UpdateUser = value; OnPropertyChanged("UpdateUser"); } } }

        private Int32 _UpdateUserID;
        /// <summary>更新者</summary>
        [DisplayName("更新者")]
        [Description("更新者")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("UpdateUserID", "更新者", "")]
        public Int32 UpdateUserID { get => _UpdateUserID; set { if (OnPropertyChanging("UpdateUserID", value)) { _UpdateUserID = value; OnPropertyChanged("UpdateUserID"); } } }

        private DateTime _UpdateTime;
        /// <summary>更新时间</summary>
        [DisplayName("更新时间")]
        [Description("更新时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("UpdateTime", "更新时间", "")]
        public DateTime UpdateTime { get => _UpdateTime; set { if (OnPropertyChanging("UpdateTime", value)) { _UpdateTime = value; OnPropertyChanged("UpdateTime"); } } }

        private String _UpdateIP;
        /// <summary>更新地址</summary>
        [DisplayName("更新地址")]
        [Description("更新地址")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("UpdateIP", "更新地址", "")]
        public String UpdateIP { get => _UpdateIP; set { if (OnPropertyChanging("UpdateIP", value)) { _UpdateIP = value; OnPropertyChanged("UpdateIP"); } } }

        private String _Remark;
        /// <summary>备注</summary>
        [DisplayName("备注")]
        [Description("备注")]
        [DataObjectField(false, false, true, 500)]
        [BindColumn("Remark", "备注", "")]
        public String Remark { get => _Remark; set { if (OnPropertyChanging("Remark", value)) { _Remark = value; OnPropertyChanged("Remark"); } } }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        public override Object this[String name]
        {
            get
            {
                switch (name)
                {
                    case "Id": return _Id;
                    case "Name": return _Name;
                    case "Category": return _Category;
                    case "Server": return _Server;
                    case "Password": return _Password;
                    case "Version": return _Version;
                    case "Mode": return _Mode;
                    case "MaxMemory": return _MaxMemory;
                    case "MemoryPolicy": return _MemoryPolicy;
                    case "MemoryAllocator": return _MemoryAllocator;
                    case "Enable": return _Enable;
                    case "DiscoverQueue": return _DiscoverQueue;
                    case "CreateUser": return _CreateUser;
                    case "CreateUserID": return _CreateUserID;
                    case "CreateTime": return _CreateTime;
                    case "CreateIP": return _CreateIP;
                    case "UpdateUser": return _UpdateUser;
                    case "UpdateUserID": return _UpdateUserID;
                    case "UpdateTime": return _UpdateTime;
                    case "UpdateIP": return _UpdateIP;
                    case "Remark": return _Remark;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case "Id": _Id = value.ToInt(); break;
                    case "Name": _Name = Convert.ToString(value); break;
                    case "Category": _Category = Convert.ToString(value); break;
                    case "Server": _Server = Convert.ToString(value); break;
                    case "Password": _Password = Convert.ToString(value); break;
                    case "Version": _Version = Convert.ToString(value); break;
                    case "Mode": _Mode = Convert.ToString(value); break;
                    case "MaxMemory": _MaxMemory = value.ToInt(); break;
                    case "MemoryPolicy": _MemoryPolicy = Convert.ToString(value); break;
                    case "MemoryAllocator": _MemoryAllocator = Convert.ToString(value); break;
                    case "Enable": _Enable = value.ToBoolean(); break;
                    case "DiscoverQueue": _DiscoverQueue = value.ToBoolean(); break;
                    case "CreateUser": _CreateUser = Convert.ToString(value); break;
                    case "CreateUserID": _CreateUserID = value.ToInt(); break;
                    case "CreateTime": _CreateTime = value.ToDateTime(); break;
                    case "CreateIP": _CreateIP = Convert.ToString(value); break;
                    case "UpdateUser": _UpdateUser = Convert.ToString(value); break;
                    case "UpdateUserID": _UpdateUserID = value.ToInt(); break;
                    case "UpdateTime": _UpdateTime = value.ToDateTime(); break;
                    case "UpdateIP": _UpdateIP = Convert.ToString(value); break;
                    case "Remark": _Remark = Convert.ToString(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得Redis节点字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>编号</summary>
            public static readonly Field Id = FindByName("Id");

            /// <summary>名称</summary>
            public static readonly Field Name = FindByName("Name");

            /// <summary>分类</summary>
            public static readonly Field Category = FindByName("Category");

            /// <summary>地址。含端口</summary>
            public static readonly Field Server = FindByName("Server");

            /// <summary>密码</summary>
            public static readonly Field Password = FindByName("Password");

            /// <summary>版本</summary>
            public static readonly Field Version = FindByName("Version");

            /// <summary>模式</summary>
            public static readonly Field Mode = FindByName("Mode");

            /// <summary>内存容量。单位MB</summary>
            public static readonly Field MaxMemory = FindByName("MaxMemory");

            /// <summary>内存策略。缓存淘汰策略</summary>
            public static readonly Field MemoryPolicy = FindByName("MemoryPolicy");

            /// <summary>分配器。内存分配器，低版本有内存泄漏</summary>
            public static readonly Field MemoryAllocator = FindByName("MemoryAllocator");

            /// <summary>启用。停用的节点不再执行监控</summary>
            public static readonly Field Enable = FindByName("Enable");

            /// <summary>队列。自动扫描发现消息队列，默认true</summary>
            public static readonly Field DiscoverQueue = FindByName("DiscoverQueue");

            /// <summary>创建人</summary>
            public static readonly Field CreateUser = FindByName("CreateUser");

            /// <summary>创建者</summary>
            public static readonly Field CreateUserID = FindByName("CreateUserID");

            /// <summary>创建时间</summary>
            public static readonly Field CreateTime = FindByName("CreateTime");

            /// <summary>创建地址</summary>
            public static readonly Field CreateIP = FindByName("CreateIP");

            /// <summary>更新人</summary>
            public static readonly Field UpdateUser = FindByName("UpdateUser");

            /// <summary>更新者</summary>
            public static readonly Field UpdateUserID = FindByName("UpdateUserID");

            /// <summary>更新时间</summary>
            public static readonly Field UpdateTime = FindByName("UpdateTime");

            /// <summary>更新地址</summary>
            public static readonly Field UpdateIP = FindByName("UpdateIP");

            /// <summary>备注</summary>
            public static readonly Field Remark = FindByName("Remark");

            static Field FindByName(String name) => Meta.Table.FindByName(name);
        }

        /// <summary>取得Redis节点字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>编号</summary>
            public const String Id = "Id";

            /// <summary>名称</summary>
            public const String Name = "Name";

            /// <summary>分类</summary>
            public const String Category = "Category";

            /// <summary>地址。含端口</summary>
            public const String Server = "Server";

            /// <summary>密码</summary>
            public const String Password = "Password";

            /// <summary>版本</summary>
            public const String Version = "Version";

            /// <summary>模式</summary>
            public const String Mode = "Mode";

            /// <summary>内存容量。单位MB</summary>
            public const String MaxMemory = "MaxMemory";

            /// <summary>内存策略。缓存淘汰策略</summary>
            public const String MemoryPolicy = "MemoryPolicy";

            /// <summary>分配器。内存分配器，低版本有内存泄漏</summary>
            public const String MemoryAllocator = "MemoryAllocator";

            /// <summary>启用。停用的节点不再执行监控</summary>
            public const String Enable = "Enable";

            /// <summary>队列。自动扫描发现消息队列，默认true</summary>
            public const String DiscoverQueue = "DiscoverQueue";

            /// <summary>创建人</summary>
            public const String CreateUser = "CreateUser";

            /// <summary>创建者</summary>
            public const String CreateUserID = "CreateUserID";

            /// <summary>创建时间</summary>
            public const String CreateTime = "CreateTime";

            /// <summary>创建地址</summary>
            public const String CreateIP = "CreateIP";

            /// <summary>更新人</summary>
            public const String UpdateUser = "UpdateUser";

            /// <summary>更新者</summary>
            public const String UpdateUserID = "UpdateUserID";

            /// <summary>更新时间</summary>
            public const String UpdateTime = "UpdateTime";

            /// <summary>更新地址</summary>
            public const String UpdateIP = "UpdateIP";

            /// <summary>备注</summary>
            public const String Remark = "Remark";
        }
        #endregion
    }
}