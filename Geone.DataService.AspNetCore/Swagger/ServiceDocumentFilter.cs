using Geone.DataService.Core.Metadata;
using Geone.DataService.Core.Repository;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Linq;

namespace Geone.DataService.AspNetCore.Swagger
{
    public class ServiceDocumentFilter : IDocumentFilter
    {
        MetaRepository _repository;
        public ServiceDocumentFilter(MetaRepository repository)
        {
            _repository = repository;
        }

        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            CreateService(swaggerDoc, context);
        }

        void CreateService(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            var servicePath = swaggerDoc.Paths.FirstOrDefault(x => x.Key.ToLower() == "/service/{name}");

            if (!string.IsNullOrWhiteSpace(servicePath.Key))
            {
                swaggerDoc.Paths.Remove(servicePath.Key);
            }

            var services = _repository.Query(x => x.MetaType == MetaType.Service);
            foreach (var svcEntity in services)
            {
                ServiceMeta svcMeta = svcEntity.GetMetadata() as ServiceMeta;

                OpenApiPathItem pathItem = new OpenApiPathItem();

                OpenApiOperation operation = new OpenApiOperation();
                pathItem.AddOperation(OperationType.Post, operation);

                operation.RequestBody = new OpenApiRequestBody();
                operation.RequestBody.Required = true;
                operation.Summary = svcMeta.Description;
                operation.Description = JsonConvert.SerializeObject(svcMeta);

                operation.Tags.Add(new OpenApiTag() { Name = "Service" });
                operation.Responses.Add("200", new OpenApiResponse() { Description = "Success" });

                OpenApiMediaType mediaType = new OpenApiMediaType();
                operation.RequestBody.Content.Add("application/json", mediaType);
                mediaType.Schema = new OpenApiSchema();
                mediaType.Schema.Type = "object";

                mediaType.Example = new OpenApiRawString(svcMeta.ParamsExample?.ToString());
                swaggerDoc.Paths.Add($"/service/{svcEntity.Name}", pathItem);
            }
        }
    }
}
