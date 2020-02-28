using Geone.DataService.Core.Repository;
using Newtonsoft.Json.Linq;
using System;

namespace Geone.DataService.Core.DBaaS
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

            JObject jmeta = service.Content as JObject;
            DbCommandMeta cmd;
            try
            {
                cmd = jmeta.ToObject<DbCommandMeta>();
            }
            catch (Exception e)
            {
                throw new ArgumentException($"服务内容不是合法的{nameof(DbCommandMeta)}对象", e);
            }

            if (string.IsNullOrWhiteSpace(cmd.Database)
                || string.IsNullOrWhiteSpace(cmd.CommandText))
            {
                throw new ArgumentException($"服务内容不是合法的{nameof(DbCommandMeta)}对象");
            }

            cmd.Parameters.AddRange(service.Parameters);

            if (cmd.Parameters.Count > 0)
            {
                if (arguments == null)
                    arguments = new JObject();

                JObject jarg = (JObject)arguments;
                foreach (var pitem in cmd.Parameters)
                {
                    string valString = null;
                    JToken jval = jarg.GetValue(pitem.Name);
                    if (jval.HasValues)
                    {
                        valString = Convert.ToString(jval);
                    }

                    pitem.Name = $"@{pitem.Name}";

                    if (string.IsNullOrWhiteSpace(valString)) continue;

                    switch (pitem.Type)
                    {
                        case DataType.String:
                            pitem.Value = valString;
                            break;
                        case DataType.Boolean:
                            if (bool.TryParse(valString, out bool boolVal))
                                pitem.Value = boolVal;
                            else
                                throw new ArgumentException($"数据类型转换错误: {valString} => {DataType.Boolean.ToString()}");
                            break;
                        case DataType.Datetime:
                            if (DateTime.TryParse(valString, out DateTime dateTimeVal))
                                pitem.Value = dateTimeVal;
                            else
                                throw new ArgumentException($"数据类型转换错误: {valString} => {DataType.Datetime.ToString()}");
                            break;
                        case DataType.Double:
                            if (double.TryParse(valString, out double doubleVal))
                                pitem.Value = doubleVal;
                            else
                                throw new ArgumentException($"数据类型转换错误: {valString} => {DataType.Double.ToString()}");
                            break;
                        case DataType.Int:
                            if (int.TryParse(valString, out int intVal))
                                pitem.Value = intVal;
                            else
                                throw new ArgumentException($"数据类型转换错误: {valString} => {DataType.Int.ToString()}");
                            break;
                        default:
                            throw new NotSupportedException();
                    }
                }
            }

            return _commandExcutor.Excute(cmd);
        }
    }
}
