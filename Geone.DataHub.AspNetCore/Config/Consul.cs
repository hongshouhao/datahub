using Consul;
using Newtonsoft.Json;
using System;

namespace Geone.DataHub.AspNetCore.Config
{
    public class Consul
    {
        public string BaseUrl { get; set; }
        [JsonConverter(typeof(DurationTimespanConverter))]
        public TimeSpan? Interval { get; set; } = new TimeSpan(0, 10, 0);
    }
}
