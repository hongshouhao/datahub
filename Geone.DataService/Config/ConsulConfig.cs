using Consul;
using Newtonsoft.Json;
using System;

namespace Geone.DataService.Config
{
    public class ConsulConfig
    {
        public string BaseURL { get; set; }
        [JsonConverter(typeof(DurationTimespanConverter))]
        public TimeSpan? Interval { get; set; } = new TimeSpan(0, 10, 0);
    }
}
