using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace Geone.DataService.Core.DBaaS
{
    [Serializable]
    public class DbMeta : IMeta
    {
        public DbTypes Type { get; set; }
        public string ConnectionString { get; set; }

        //public string LastInsertIdSelectText
        //{
        //    get
        //    {
        //        switch (Type)
        //        {
        //            case DbTypes.MsSql:
        //                return "SELECT @@IDENTITY";

        //            case DbTypes.Sqlite:
        //                return "SELECT last_insert_rowid()";

        //            case DbTypes.PostgreSql:
        //                return "SELECT lastval()";

        //            case DbTypes.MySql:
        //                return "SELECT LAST_INSERT_ID()";

        //            default:
        //                throw new NotSupportedException($"不支持数据库类型: {Type}");
        //        }
        //    }
        //}
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DbTypes
    {
        MsSql,
        Sqlite,
        PostgreSql,
        MySql
    }
}
