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

        public string JsonSchema { get; set; }

        public void CheckValid()
        {
            if (string.IsNullOrWhiteSpace(JsonSchema))
            {
                throw new ArgumentException("Json Schema 不能为空");
            }
            try
            {
                JObject.Parse(JsonSchema);
            }
            catch (JsonException ex)
            {
                throw new Exception("Json字符串不合法", ex);
            }
        }
    }
}
