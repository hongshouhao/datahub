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
                if (arguments is JObject jarg)
                {
                    foreach (var jprop in jarg.Properties())
                    {
                        AddParameter(cmd, jprop);
                    }
                }
                else if (arguments is JValue jval)
                {
                    JProperty jprop = (JProperty)jval.Parent;
                    AddParameter(cmd, jprop);
                }
                else
                {
                    throw new ArgumentException($"参数错误: [{arguments}]必须是Json对象");
                }
            }

            return _commandExcutor.Excute(cmd);
        }

        private static void AddParameter(DbCommandMeta cmd, JProperty jprop)
        {
            string propName = jprop.Name;
            if (!jprop.Name.StartsWith("@"))
            {
                propName = $"@{jprop.Name}";
            }
            object val = ((JValue)jprop.Value).Value;
            if (val == null)
            {
                throw new ArgumentException($"参数错误: {propName}值不能为空");
            }
            cmd.Parameters.Add(propName, val);
        }
    }
}
