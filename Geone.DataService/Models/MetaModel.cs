using Geone.DataService.Core;
using Geone.DataService.Core.DBaaS;
using Geone.DataService.Core.Repository;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace Geone.DataService.Models
{
    public class MetaModel
    {
        public MetaModel()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public MetaType MetaType { get; set; }
        public object Metadata { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public static MetaModel From<TMeta>(MetaEntity metaEntity) where TMeta : IMeta
        {
            MetaModel model = new MetaModel();
            model.Id = metaEntity.Id;
            model.Name = metaEntity.Name;
            model.MetaType = metaEntity.MetaType;
            model.CreatedDate = metaEntity.CreatedDate;
            model.ModifiedDate = metaEntity.ModifiedDate;

            if (!string.IsNullOrWhiteSpace(metaEntity.Metadata))
            {
                TMeta tmeta = JsonConvert.DeserializeObject<TMeta>(metaEntity.Metadata);
                if (tmeta is ServiceMeta serviceMeta)
                {
                    switch (serviceMeta.Type)
                    {
                        case ServiceType.REST:
                            break;
                        case ServiceType.SOAP:
                            break;
                        case ServiceType.DBaaS:
                            serviceMeta.Content = ((JObject)serviceMeta.Content).ToObject<DbCommandMeta>();
                            break;
                        case ServiceType.Aggregate:
                            break;
                        default:
                            break;
                    }
                }
                model.Metadata = tmeta;
            }

            return model;
        }

        public MetaEntity ToEntity()
        {
            MetaEntity metaEntity = new MetaEntity();

            metaEntity.Id = this.Id;
            metaEntity.Name = this.Name;
            metaEntity.MetaType = this.MetaType;
            metaEntity.CreatedDate = this.CreatedDate;
            metaEntity.ModifiedDate = this.ModifiedDate;

            if (this.Metadata != null)
            {
                metaEntity.Metadata = this.Metadata.ToString();
            }

            return metaEntity;
        }
    }
}
