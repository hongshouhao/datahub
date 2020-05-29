using Geone.AuthorisationFilter;
using Geone.DataHub.AspNetCore.Swagger;
using Geone.DataHub.Core.Metadata;
using Geone.DataHub.Core.Repository;
using Geone.DataHub.Core.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using Swashbuckle.AspNetCore.Annotations;
using System.Linq;

namespace Geone.DataHub.AspNetCore.Controllers
{
    [Route(serviceRoute)]
    [ApiController]
    [Produces("application/json", "application/problem+json")]
    [SwaggerOperationFilter(typeof(AuthorizeCheckOperationFilter))]
    public class ServiceController : ControllerBase
    {
        public const string serviceRoute = "service";

        private readonly MetaRepository _repository;
        private readonly ServiceExcutor _excutor;
        private readonly ILogger<ServiceController> _logger;

        public ServiceController(
            MetaRepository repository,
            ServiceExcutor excutor,
            ILogger<ServiceController> logger)
        {
            _repository = repository;
            _excutor = excutor;
            _logger = logger;
        }

        [HttpPost]
        [Route("{name}")]
        [DynamicAuthorize]
        public object Post([FromRoute]string name, [FromBody]object arguments)
        {
            MetaEntity entity = _repository.Get(MetaType.Service, name);
            ServiceMeta serviceMeta = entity.GetMetadata() as ServiceMeta;
            var result = _excutor.Excute(serviceMeta, arguments);
            if (result is string)
            {
                return new JRaw(result);
            }
            else
            {
                return result;
            }
        }

        [HttpGet]
        [Route("apis")]
        [Authorize]
        public object APIs()
        {
            return _repository.Query(x => x.MetaType == MetaType.Service)
                .ToArray()
                .Select(x => new
                {
                    Name = x.Name,
                    Parh = $"/{serviceRoute}/{x.Name}",
                    FullUrl = $"{Request.Host}/{serviceRoute}/{x.Name}",
                    Description = x.Description
                })
                .ToArray();
        }
    }
}
