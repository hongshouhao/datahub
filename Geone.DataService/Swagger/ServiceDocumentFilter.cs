using Geone.DataService.Core;
using Geone.DataService.Core.Repository;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Geone.DataService.Swagger
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
                ServiceMeta svcMeta = svcEntity.Deserialize<ServiceMeta>();

                OpenApiPathItem pathItem = new OpenApiPathItem();
                pathItem.Summary = svcMeta.Summary;
                pathItem.Description = svcMeta.Description;

                OpenApiOperation operation = new OpenApiOperation();
                pathItem.AddOperation(OperationType.Post, operation);

                operation.RequestBody = new OpenApiRequestBody();
                operation.RequestBody.Required = true;
                operation.Tags.Add(new OpenApiTag() { Name = "Service" });
                operation.Responses.Add("200", new OpenApiResponse() { Description = "Success" });

                OpenApiMediaType mediaType = new OpenApiMediaType();
                operation.RequestBody.Content.Add("application/json", mediaType);
                mediaType.Schema = new OpenApiSchema();
                mediaType.Schema.Type = "object";

                Dictionary<string, object> example = new Dictionary<string, object>();
                foreach (var paramItem in svcMeta.Parameters)
                {
                    example.Add(paramItem.Name, GetDefaultValue(paramItem));
                }

                mediaType.Example = new OpenApiRawString(JsonConvert.SerializeObject(example, Formatting.Indented));

                swaggerDoc.Paths.Add($"/service/{svcEntity.Name}", pathItem);
            }
        }

        object GetDefaultValue(Parameter paramItem)
        {
            switch (paramItem.Type)
            {
                case DataType.String:
                    return paramItem.Value == null ? "name" : paramItem.Value.ToString();
                case DataType.Boolean:
                    bool.TryParse(Convert.ToString(paramItem.Value), out bool boolVal);
                    return paramItem.Value == null ? false : boolVal;
                case DataType.Datetime:
                    DateTime.TryParse(Convert.ToString(paramItem.Value), out DateTime dateVal);
                    return paramItem.Value == null ? DateTime.UtcNow : dateVal;
                case DataType.Int:
                    int.TryParse(Convert.ToString(paramItem.Value), out int intVal);
                    return paramItem.Value == null ? 0 : intVal;
                case DataType.Double:
                    double.TryParse(Convert.ToString(paramItem.Value), out double doubleVal);
                    return paramItem.Value == null ? 0 : doubleVal;
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
