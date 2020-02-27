using Geone.DataService.Core;
using Geone.DataService.Core.DBaaS;
using Geone.DataService.Core.Repository;
using Geone.DataService.Models;
using Geone.DataService.Swagger;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ServiceStack.OrmLite;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Geone.DataService.Controllers
{
    [ApiController]
    [Route("meta")]
    public class MetaController : ControllerBase
    {
        private readonly ILogger<MetaController> _logger;
        private readonly MetaRepository _repository;

        public MetaController(MetaRepository repository, ILogger<MetaController> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        [HttpGet]
        [Route("{metaType}/{name}")]
        public MetaModel Get(MetaType metaType, string name)
        {
            switch (metaType)
            {
                case MetaType.Db:
                    return MetaModel.From<DbMeta>(_repository.Get(metaType, name));
                case MetaType.Service:
                    return MetaModel.From<ServiceMeta>(_repository.Get(metaType, name));
                default:
                    throw new NotSupportedException();
            }
        }

        [HttpGet]
        [Route("{metaType}")]
        public MetaModel[] GetAll(MetaType metaType)
        {
            List<MetaEntity> list = _repository.Query(x => x.MetaType == metaType);
            switch (metaType)
            {
                case MetaType.Db:
                    return list.Select(e => MetaModel.From<DbMeta>(e)).ToArray();
                case MetaType.Service:
                    return list.Select(e => MetaModel.From<ServiceMeta>(e)).ToArray();
                default:
                    throw new NotSupportedException();
            }
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
            _repository.Insert(meta.ToEntity());
        }

        [HttpPut]
        [SwaggerOperationFilter(typeof(MetaSaveOperationFilter))]
        public void Put(MetaModel meta)
        {
            _repository.Update(meta.ToEntity());
        }
    }
}
