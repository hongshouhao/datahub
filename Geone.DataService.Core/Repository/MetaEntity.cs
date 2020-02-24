using ServiceStack.DataAnnotations;
using System;

namespace Geone.DataService.Core.Repository
{
    public class MetaEntity : IAudit
    {
        [AutoIncrement]
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Name { get; set; }
        [Required]
        [StringLength(200)]
        public MetaType MetaType { get; set; }
        [Required]
        [StringLength(StringLengthAttribute.MaxText)]
        public string Metadata { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public T Deserialize<T>() where T : IMeta
        {
            if (string.IsNullOrWhiteSpace(Metadata))
            {
                throw new Exception("Json为空");
            }
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(Metadata);
        }
    }

    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MetaType
    {
        Db,
        Service
    }
}
