using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Geone.DataHub.Core.Service.DBaaS
{
    public class DbCommandMeta : IServiceContent
    {
        public DbCommandMeta()
        {
        }

        public string Database { get; set; }
        public string CommandText { get; set; }
        public int CommandTimeout { get; set; }

        [JsonIgnore]
        public Dictionary<string, object> Parameters { get; private set; } = new Dictionary<string, object>();

        public void CheckValid()
        {
            if (string.IsNullOrWhiteSpace(Database))
            {
                throw new ArgumentException("参数错误: 未指定数据库");
            }

            if (string.IsNullOrWhiteSpace(CommandText))
            {
                throw new ArgumentException("参数错误: SQL不能为空");
            }
        }
    }
}
