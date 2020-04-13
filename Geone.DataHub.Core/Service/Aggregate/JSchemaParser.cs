using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Geone.DataHub.Core.Service.Aggregate
{
    public class JSchemaParser
    {
        public JSchemaParser(string jsonSchema)
        {
            ValueObject = JObject.Parse(jsonSchema);
            ValRefs = ParseJson(ValueObject).ToArray();
        }

        public JObject ValueObject { get; private set; }

        IEnumerable<ValRef> ParseJson(JObject jobj)
        {
            foreach (JProperty pitem in jobj.Properties())
            {
                if (pitem.Value is JObject jpropObj)
                {
                    ParseJson(jpropObj);
                }
                else if (pitem.Value is JValue jval)
                {
                    if (ParseExpression(jval.Value?.ToString(), out string func, out string parameter, out string vpath))
                    {
                        yield return new ValRef()
                        {
                            Property = pitem,
                            FuncName = func,
                            Parameter = parameter,
                            ValuePath = vpath
                        };
                    }
                }
            }
        }

        bool ParseExpression(string exp, out string func, out string parameter, out string vpath)
        {
            Match m = Regex.Match(exp, @"^\$(?<service>[a-zA-Z0-9_]+)\((?<arg>[a-zA-Z0-9_]+)\)(?<path>\.[a-zA-Z0-9_\.\[\]]+)?");
            if (m.Success)
            {
                func = m.Groups["service"].Value;
                parameter = m.Groups["arg"].Value;
                vpath = m.Groups["path"].Value;
                return true;
            }
            else
            {
                func = null;
                parameter = null;
                vpath = null;
                return false;
            }
        }

        public ValRef[] ValRefs { get; private set; }

        public class ValRef
        {
            public JProperty Property { get; set; }
            public string FuncName { get; set; }
            public string Parameter { get; set; }
            public string ValuePath { get; set; }

            public string GetExpression()
            {
                return $"${FuncName}({Parameter}){ValuePath}";
            }

            public override string ToString()
            {
                return $"{Property.Name}:${FuncName}({Parameter}){ValuePath}";
            }
        }
    }
}
