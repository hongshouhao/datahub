using System;

namespace Geone.DataService.Core
{
    [Serializable]
    public class Parameter
    {
        public string Name { get; set; }
        public DataType Type { get; set; }
        public object Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    public enum DataType
    {
        String,
        Boolean,
        Datetime,
        Int,
        Double
        //Binary
    }
}
