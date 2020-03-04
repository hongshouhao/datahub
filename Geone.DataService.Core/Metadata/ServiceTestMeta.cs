using Newtonsoft.Json.Linq;
using System;

namespace Geone.DataService.Core.Metadata
{
    [Serializable]
    public class ServiceTestMeta : IMeta
    {
        public string ServiceName { get; set; }
        public JRaw Header { get; set; }
        public JRaw Body { get; set; }
        public string Description { get; set; }

        public void CheckValid()
        {
            if (string.IsNullOrWhiteSpace(ServiceName))
            {
                throw new ArgumentException("未指定服务名");
            }
        }
    }
}
