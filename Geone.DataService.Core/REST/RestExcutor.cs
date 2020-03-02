using Geone.DataService.Core.DBaaS;
using Geone.DataService.Core.Repository;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;


namespace Geone.DataService.Core.REST
{
    public class RestExcutor
    {
        readonly DbCommandExcutor _commandExcutor;
        public RestExcutor(MetaRepository repository)
        {
            _commandExcutor = new DbCommandExcutor(repository);
        }

        public string Excute(ServiceMeta service, Dictionary<string, object> arguments)
        {
            if (service.Type != ServiceType.REST)
                throw new ArgumentException("服务类型不匹配");

            JObject jobj = service.Content as JObject;
            if (jobj == null)
                throw new ArgumentException($"服务内容不是合法的{nameof(DbCommandMeta)}对象");

            RestCommandMeta cmd;
            try
            {
                cmd = jobj.ToObject<RestCommandMeta>();
            }
            catch (Exception e)
            {
                throw new ArgumentException($"服务内容不是合法的{nameof(RestCommandMeta)}对象", e);
            }

            if (string.IsNullOrWhiteSpace(cmd.Curl))
            {
                throw new ArgumentException($"服务内容不是合法的{nameof(RestCommandMeta)}对象");
            }

            cmd.Parameters.AddRange(service.Parameters);



            return "";
        }

    }
}
