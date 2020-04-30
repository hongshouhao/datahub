using Geone.DataHub.AspNetCore.Config;
using Geone.DataHub.Core.Metadata;
using Geone.DataHub.Core.Repository;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Collections.Generic;
using System.Linq;

namespace Geone.DataHub.AspNetCore.Swagger
{
    public class ServiceDocumentFilter : IDocumentFilter
    {
        readonly MetaRepository _repository;
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
                operation.Summary = svcEntity.Description;
                operation.Description = JsonConvert.SerializeObject(svcMeta);

                operation.Tags.Add(new OpenApiTag() { Name = "Service" });

                operation.Security =
                    new List<OpenApiSecurityRequirement>
                    {
                        new OpenApiSecurityRequirement
                        {
                            {
                                new OpenApiSecurityScheme
                                {
                                    Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "oauth2" }
                                },
                                new[] { Root.Value.Server.Name + "." + svcEntity.Name }
                            }
                        }
                    };

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
