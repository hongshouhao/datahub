using Geone.DataHub.AspNetCore.Models;
using Geone.DataHub.AspNetCore.Swagger;
using Geone.DataHub.Core.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ServiceStack.OrmLite;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.Linq;

namespace Geone.DataHub.AspNetCore.Controllers
{
    [ApiController]
    [Route("metadata")]
    [Produces("application/json", "application/problem+json")]
    [Authorize]
    public class MetadataController : ControllerBase
    {
        private readonly ILogger<MetadataController> _logger;
        private readonly MetaRepository _repository;

        public MetadataController(MetaRepository repository, ILogger<MetadataController> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        [HttpGet]
        [Route("{metaType}/{name}")]
        public MetaModel Get(MetaType metaType, string name)
        {
            MetaEntity entity = _repository.Get(metaType, name);
            return MetaModel.From(entity);
        }

        [HttpGet]
        [Route("{metaType}")]
        public MetaModel[] GetAll(MetaType metaType)
        {
            List<MetaEntity> list = _repository.Query(x => x.MetaType == metaType);
            return list.Select(e => MetaModel.From(e)).ToArray();
        }

        [HttpDelete]
        [Route("{metaType}/{name}")]
        public void Delete(MetaType metaType, string name)
        {
            _repository.Delete(metaType, name);
        }

        [HttpPost]
        [SwaggerOperationFilter(typeof(MetaSaveOperationFilter))]
        public void Post(MetaModel meta)
        {
            var entity = meta.ToEntity();
            entity.GetMetadata().CheckValid();
            _repository.Insert(entity);
        }

        [HttpPut]
        [SwaggerOperationFilter(typeof(MetaSaveOperationFilter))]
        public void Put(MetaModel meta)
        {
            var entity = meta.ToEntity();
            entity.GetMetadata().CheckValid();
            _repository.Update(entity);
        }
    }
}
