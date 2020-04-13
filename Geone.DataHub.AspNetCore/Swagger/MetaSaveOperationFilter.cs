using Geone.DataHub.AspNetCore.Models;
using Geone.DataHub.Core.Metadata;
using Geone.DataHub.Core.Repository;
using Geone.DataHub.Core.Service.Aggregate;
using Geone.DataHub.Core.Service.DBaaS;
using Geone.DataHub.Core.Service.REST;
using Geone.DataHub.Core.Service.SOAP;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;

namespace Geone.DataHub.AspNetCore.Swagger
{
    public class MetaSaveOperationFilter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            AddDbMeta(operation);
            AddDBaaSMeta(operation);
            AddSoapMeta(operation);
            AddRestMeta(operation);
            AddAggregateMeta(operation);
            AddServiceTestMeta(operation);
        }

        private static void AddDbMeta(OpenApiOperation operation)
        {
            MetaModel model = new MetaModel();
            model.Id = 0;
            model.Name = "name";
            model.MetaType = MetaType.Db;
            model.CreatedDate = DateTime.UtcNow;
            model.ModifiedDate = DateTime.UtcNow;
            model.Metadata = new DbMeta()
            {
                ConnectionString = "Data Source=服务器名;Initial Catalog=数据库名; User Id=用户名;Password=密码",
                Type = DbTypes.MsSql
            };

            AddSwaggerExample(operation, model, MetaType.Db.ToString());
        }

        private static void AddDBaaSMeta(OpenApiOperation operation)
        {
            MetaModel model = new MetaModel();
            model.Id = 0;
            model.Name = "dbaas";
            model.MetaType = MetaType.Service;
            model.CreatedDate = DateTime.UtcNow;
            model.ModifiedDate = DateTime.UtcNow;

            ServiceMeta service = new ServiceMeta();
            service.Type = ServiceType.DBaaS;
            service.ParamsExample = new { a = "val" };
            service.Content = new DbCommandMeta()
            {
                CommandText = "select * from table where a = @a",
                CommandTimeout = 30,
                Database = "database"
            };
            model.Metadata = service;

            AddSwaggerExample(operation, model, ServiceType.DBaaS.ToString());
        }

        private static void AddSoapMeta(OpenApiOperation operation)
        {
            MetaModel model = new MetaModel();
            model.Id = 0;
            model.Name = Samples.Soap.ServiceName;
            model.MetaType = MetaType.Service;
            model.CreatedDate = DateTime.UtcNow;
            model.ModifiedDate = DateTime.UtcNow;

            ServiceMeta service = new ServiceMeta();
            service.Type = ServiceType.SOAP;

            service.ParamsExample = Samples.Soap.Parameters;

            service.Content = new SoapMeta()
            {
                Uri = Samples.Soap.Uri
            };
            model.Metadata = service;

            AddSwaggerExample(operation, model, ServiceType.SOAP.ToString());
        }

        private static void AddRestMeta(OpenApiOperation operation)
        {
            MetaModel model = new MetaModel();
            model.Id = 0;
            model.Name = "rest";
            model.MetaType = MetaType.Service;
            model.CreatedDate = DateTime.UtcNow;
            model.ModifiedDate = DateTime.UtcNow;

            ServiceMeta service = new ServiceMeta();
            service.Type = ServiceType.REST;
            service.Content = new RestMeta()
            {
                CURL = Samples.Rest.CURL
            };
            service.ParamsExample = Samples.Rest.Parameters;
            model.Metadata = service;

            AddSwaggerExample(operation, model, ServiceType.REST.ToString());
        }

        private static void AddAggregateMeta(OpenApiOperation operation)
        {
            MetaModel model = new MetaModel();
            model.Id = 0;
            model.Name = "aggregate";
            model.MetaType = MetaType.Service;
            model.CreatedDate = DateTime.UtcNow;
            model.ModifiedDate = DateTime.UtcNow;

            ServiceMeta service = new ServiceMeta();
            service.Type = ServiceType.Aggregate;
            service.Content = new AggregateMeta()
            {
                JsonSchema = new JRaw(JsonConvert.SerializeObject(Samples.Aggregate.Schema))
            };
            service.ParamsExample = Samples.Aggregate.Parameters;
            model.Metadata = service;

            AddSwaggerExample(operation, model, ServiceType.Aggregate.ToString());
        }

        private static void AddServiceTestMeta(OpenApiOperation operation)
        {
            MetaModel model = new MetaModel();
            model.Id = 0;
            model.Name = "soap_add_test";
            model.MetaType = MetaType.ServiceTest;
            model.CreatedDate = DateTime.UtcNow;
            model.ModifiedDate = DateTime.UtcNow;

            ServiceTestMeta test = new ServiceTestMeta();
            test.ServiceName = Samples.Soap.ServiceName;
            test.Body = Samples.Soap.Parameters;
            model.Metadata = test;

            AddSwaggerExample(operation, model, MetaType.ServiceTest.ToString());
        }

        private static void AddSwaggerExample(OpenApiOperation operation, MetaModel model, string key)
        {
            OpenApiExample example = new OpenApiExample();
            example.Value = new OpenApiRawString(JsonConvert.SerializeObject(model));

            foreach (var content in operation.RequestBody.Content)
            {
                content.Value.Examples.Add(key, example);
            }
        }
    }
}
