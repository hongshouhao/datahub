using Geone.DataService.Core.Metadata;
using Geone.DataService.Core.Repository;
using Newtonsoft.Json.Linq;
using System;

namespace Geone.DataService.Core.Service.DBaaS
{
    public class DBaaSExcutor
    {
        readonly DbCommandExcutor _commandExcutor;
        public DBaaSExcutor(MetaRepository repository)
        {
            _commandExcutor = new DbCommandExcutor(repository);
        }

        public string Excute(ServiceMeta service, object arguments)
        {
            if (service.Type != ServiceType.DBaaS)
                throw new ArgumentException("服务类型不匹配");

            DbCommandMeta cmd = (DbCommandMeta)service.Content;
            cmd.CheckValid();

            if (arguments != null)
            {
                JObject jarg = (JObject)arguments;
                foreach (var jprop in jarg.Properties())
                {
                    string propName = jprop.Name;
                    if (!propName.StartsWith("@"))
                    {
                        propName = $"@{propName}";
                    }
                    object val = ((JValue)jprop.Value).Value;
                    if (val == null)
                    {
                        throw new ArgumentException($"输入参数非法[{propName}]");
                    }
                    cmd.Parameters.Add(propName, val);
                }
            }

            return _commandExcutor.Excute(cmd);
        }
    }
}
