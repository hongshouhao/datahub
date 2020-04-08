using Consul;
using Newtonsoft.Json;
using System;

namespace Geone.DataService.AspNetCore.Config
{
    public class ConsulConfig
    {
        public string BaseUrl { get; set; }
        [JsonConverter(typeof(DurationTimespanConverter))]
        public TimeSpan? Interval { get; set; } = new TimeSpan(0, 10, 0);
    }
}
