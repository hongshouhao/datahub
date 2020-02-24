using System;
using System.Collections.Generic;

namespace Geone.DataService.Core
{
    [Serializable]
    public class ServiceMeta : IMeta
    {
        public ServiceType Type { get; set; }
        public object Content { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }

        public List<Parameter> Parameters { get; set; } = new List<Parameter>();
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    public enum ServiceType
    {
        REST,
        SOAP,
        DBaaS,
        Aggregate
    }
}
