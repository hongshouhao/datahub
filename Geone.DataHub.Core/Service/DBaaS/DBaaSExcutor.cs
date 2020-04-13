using Geone.DataHub.Core.Metadata;
using Geone.DataHub.Core.Repository;
using Newtonsoft.Json.Linq;
using System;

namespace Geone.DataHub.Core.Service.DBaaS
{
    public class DBaaSExcutor : IExcutor
    {
        readonly DbCommandExcutor _commandExcutor;
        public DBaaSExcutor(MetaRepository repository)
        {
            _commandExcutor = new DbCommandExcutor(repository);
        }

        public object Excute(ServiceMeta service, object arguments)
        {
            if (service.Type != ServiceType.DBaaS)
                throw new ArgumentException("参数错误: 服务类型不匹配");

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
                        throw new ArgumentException($"参数错误: {propName}值不能为空");
                    }
                    cmd.Parameters.Add(propName, val);
                }
            }

            return _commandExcutor.Excute(cmd);
        }
    }
}
