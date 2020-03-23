using Geone.DataService.Core.Repository;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.ComponentModel.DataAnnotations;

namespace Geone.DataService.AspNetCore.Models
{
    public class MetaModel
    {
        public MetaModel()
        {
        }

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public MetaType MetaType { get; set; }
        [Required]
        public object Metadata { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public static MetaModel From(MetaEntity metaEntity)
        {
            MetaModel model = new MetaModel();
            model.Id = metaEntity.Id;
            model.Name = metaEntity.Name;
            model.MetaType = metaEntity.MetaType;
            model.Description = metaEntity.Description;
            model.CreatedDate = metaEntity.CreatedDate;
            model.ModifiedDate = metaEntity.ModifiedDate;
            model.Metadata = metaEntity.GetMetadata();
            return model;
        }

        public MetaEntity ToEntity()
        {
            MetaEntity metaEntity = new MetaEntity();

            metaEntity.Id = this.Id;
            metaEntity.Name = this.Name;
            metaEntity.MetaType = this.MetaType;
            metaEntity.Description = this.Description;
            metaEntity.CreatedDate = this.CreatedDate;
            metaEntity.ModifiedDate = this.ModifiedDate;

            if (this.Metadata is JObject
                || this.Metadata is string)
            {
                metaEntity.Metadata = this.Metadata?.ToString();
            }
            else
            {
                metaEntity.Metadata = JsonConvert.SerializeObject(this.Metadata);
            }

            return metaEntity;
        }
    }
}
