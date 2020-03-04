using Geone.DataService.Core;
using Geone.DataService.Core.Aggregate;
using Geone.DataService.Core.DBaaS;
using Geone.DataService.Core.Repository;
using Geone.DataService.Core.REST;
using Geone.DataService.Core.SOAP;
using Geone.DataService.Models;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;

namespace Geone.DataService.Swagger
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
            AddExample(operation, model, MetaType.Db.ToString());
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
            service.Parameters.Add(new Parameter() { Name = "a", Value = "val", Type = DataType.String });
            service.Content = new DbCommandMeta()
            {
                CommandText = "select * from table where a = @a",
                CommandTimeout = 30,
                Database = "database"
            };
            model.Metadata = service;
            AddExample(operation, model, ServiceType.DBaaS.ToString());
        }

        private static void AddSoapMeta(OpenApiOperation operation)
        {
            MetaModel model = new MetaModel();
            model.Id = 0;
            model.Name = "soap";
            model.MetaType = MetaType.Service;
            model.CreatedDate = DateTime.UtcNow;
            model.ModifiedDate = DateTime.UtcNow;

            ServiceMeta service = new ServiceMeta();
            service.Type = ServiceType.SOAP;
            service.Parameters = null;
            service.Content = new SoapMeta()
            {
                Uri = "http://www.dneonline.com/calculator.asmx"
            };
            model.Metadata = service;
            AddExample(operation, model, ServiceType.SOAP.ToString());
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
            service.Parameters.Add(new Parameter() { Name = "reprojectKey", Value = "my", Type = DataType.String });
            service.Content = new RestMeta()
            {
                Curl = "curl -X GET \"http://192.168.122.17:9864/all-supported-projections/{reprojectKey}\" -H \"accept: text/plain\""
            };
            model.Metadata = service;
            AddExample(operation, model, ServiceType.REST.ToString());
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

            service.Parameters.Add(new Parameter() { Name = "reprojectKey", Value = "my", Type = DataType.String });
            service.Parameters.Add(new Parameter() { Name = "Add", Value = "{\"Add\": {\"@xmlns\":\"http://tempuri.org/\", \"intA\" : 1,  \"intB\" : 2}}", Type = DataType.String });

            service.Content = new AggregateMeta()
            {
                AggregateJson = "{\"A\":\"REST$(reprojectKey)\",\"B\":\"soap$(Add)\"}"
            };
            model.Metadata = service;
            AddExample(operation, model, ServiceType.Aggregate.ToString());
        }

        private static void AddExample(OpenApiOperation operation, MetaModel model, string key)
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
