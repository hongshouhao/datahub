using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace Geone.DataService.Core.Metadata
{
    [Serializable]
    public class DbMeta : IMeta
    {
        public DbTypes Type { get; set; }
        public string ConnectionString { get; set; }

        public void CheckValid()
        {
            if (string.IsNullOrWhiteSpace(ConnectionString))
            {
                throw new ArgumentException("参数错误: 数据库连接字符串不能为空");
            }
        }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DbTypes
    {
        MsSql,
        PostgreSql,
        MySql
    }
}
