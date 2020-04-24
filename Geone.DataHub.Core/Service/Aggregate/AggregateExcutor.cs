using Geone.DataHub.Core.Metadata;
using Geone.DataHub.Core.Repository;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;

namespace Geone.DataHub.Core.Service.Aggregate
{
    public class AggregateExcutor : IExcutor
    {
        private readonly MetaRepository _repository;
        private readonly SingleServiceExcutor _excutor;

        public AggregateExcutor(MetaRepository repository, SingleServiceExcutor excutor)
        {
            _repository = repository;
            _excutor = excutor;
        }

        public object Excute(ServiceMeta service, object arguments)
        {
            if (service.Type != ServiceType.Aggregate)
                throw new ArgumentException("参数错误: 服务类型不匹配");

            AggregateMeta meta = (AggregateMeta)service.Content;
            meta.CheckValid();

            JSchemaParser parser = new JSchemaParser(meta.JsonSchema.ToString());

            string[] svcNames = parser.ValRefs.Select(x => x.FuncName).ToArray();
            var funcs = _repository.Query(x => svcNames.Contains(x.Name) && x.MetaType == MetaType.Service)
                .ToDictionary(x => x.Name, x => x.GetMetadata() as ServiceMeta, StringComparer.CurrentCultureIgnoreCase);


            JObject jarg = (JObject)arguments;
            try
            {
                Parallel.For(0, parser.ValRefs.Length, (i) =>
                {
                    var vrefItem = parser.ValRefs[i];
                    if (funcs.TryGetValue(vrefItem.FuncName, out ServiceMeta svcMeta))
                    {
                        JToken jsvcArg = null;
                        if (string.IsNullOrWhiteSpace(vrefItem.Parameter))
                        {
                            jsvcArg = jarg;
                        }
                        else
                        {
                            jsvcArg = jarg[vrefItem.Parameter];
                            if (jsvcArg == null)
                            {
                                throw new Exception($"服务引用指定参数有误: {vrefItem.ToString()}");
                            }

                            object result = _excutor.Excute(svcMeta, jsvcArg);
                            if (result is string resultString)
                            {
                                JToken jtoken;
                                if (resultString.StartsWith("["))
                                {
                                    jtoken = JArray.Parse(resultString);
                                    vrefItem.Property.Value = jtoken;
                                }
                                else if (resultString.StartsWith("{"))
                                {
                                    jtoken = JObject.Parse(resultString);
                                    vrefItem.Property.Value = jtoken;
                                }
                                else
                                {
                                    vrefItem.Property.Value = result?.ToString();
                                }
                            }
                            else if (result is JToken jtoken)
                            {
                                vrefItem.Property.Value = jtoken.SelectToken(vrefItem.ValuePath);
                            }
                            else
                            {
                                vrefItem.Property.Value = new JValue(result);
                            }
                        }
                    }
                    else
                    {
                        vrefItem.Property.Value = vrefItem.GetExpression() + "//服务不存在";
                    }
                });
            }
            catch (AggregateException e)
            {
                throw e.InnerException;
            }

            return parser.ValueObject;
        }
    }
}
