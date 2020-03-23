using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace Geone.DataService.Core.Service.Aggregate
{
    public class AggregateMeta : IServiceContent
    {
        public AggregateMeta()
        {
        }

        public JRaw JsonSchema { get; set; }

        public void CheckValid()
        {
            string json = JsonSchema.ToString();
            if (string.IsNullOrWhiteSpace(json))
            {
                throw new ArgumentException("参数错误: Json Schema不能为空");
            }
            try
            {
                JObject.Parse(json);
            }
            catch (JsonException ex)
            {
                throw new Exception("Json字符串不合法", ex);
            }
        }
    }
}
