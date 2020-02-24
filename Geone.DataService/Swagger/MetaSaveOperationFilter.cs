using Geone.DataService.Core;
using Geone.DataService.Core.DBaaS;
using Geone.DataService.Core.Repository;
using Geone.DataService.Models;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;

namespace Geone.DataService.Swagger
{
    public class MetaSaveOperationFilter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            AddDbMeta(operation);
            AddDbCommandServiceMeta(operation);
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

            OpenApiExample example = new OpenApiExample();
            example.Value = new OpenApiRawString(JsonConvert.SerializeObject(model));

            foreach (var content in operation.RequestBody.Content)
            {
                content.Value.Examples.Add(MetaType.Db.ToString(), example);
            }
        }

        private static void AddDbCommandServiceMeta(OpenApiOperation operation)
        {
            MetaModel model = new MetaModel();
            model.Id = 0;
            model.Name = "name";
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

            OpenApiExample example = new OpenApiExample();
            example.Value = new OpenApiRawString(JsonConvert.SerializeObject(model));

            foreach (var content in operation.RequestBody.Content)
            {
                content.Value.Examples.Add(MetaType.Service.ToString(), example);
            }
        }
    }
}
