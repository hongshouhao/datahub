using Geone.DataHub.Core.Metadata;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using ServiceStack.DataAnnotations;
using System;

namespace Geone.DataHub.Core.Repository
{
    public class MetaEntity : IAudit
    {
        [AutoIncrement]
        public int Id { get; set; }
        [Required]
        [Unique]
        [StringLength(200)]
        public string Name { get; set; }
        [Required]
        [StringLength(200)]
        public MetaType MetaType { get; set; }
        [Required]
        [StringLength(StringLengthAttribute.MaxText)]
        public string Metadata { get; set; }
        [StringLength(StringLengthAttribute.MaxText)]
        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public IMeta GetMetadata()
        {
            if (string.IsNullOrWhiteSpace(Metadata))
            {
                throw new Exception("Metadata为空");
            }

            switch (MetaType)
            {
                case MetaType.Db:
                    return JsonConvert.DeserializeObject<DbMeta>(Metadata);
                case MetaType.Service:
                    return JsonConvert.DeserializeObject<ServiceMeta>(Metadata);
                case MetaType.ServiceTest:
                    return JsonConvert.DeserializeObject<ServiceTestMeta>(Metadata);
                default:
                    throw new NotSupportedException();
            }
        }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum MetaType
    {
        Db,
        Service,
        ServiceTest
    }

    public static class MetaType_
    {
        public static string GetDescription(this MetaType metaType)
        {
            switch (metaType)
            {
                case MetaType.Db:
                    return "数据库";
                case MetaType.Service:
                    return "服务";
                case MetaType.ServiceTest:
                    return "服务测试";
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
