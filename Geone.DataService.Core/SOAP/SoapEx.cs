using Microsoft.Xml.XMLGen;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace Geone.DataService.Core.SOAP
{
   public class SoapEx
    {
        public static void Excute(ServiceMeta service, Dictionary<string, object> arguments)
        {
            if (service.Type != ServiceType.SOAP)
                throw new ArgumentException("服务类型不匹配");

            JObject jobj = service.Content as JObject;
            if (jobj == null)
                throw new ArgumentException($"服务内容不是合法的{nameof(SoapCommandMeta)}对象");

            SoapCommandMeta cmd;
            try
            {
                cmd = jobj.ToObject<SoapCommandMeta>();
            }
            catch (Exception e)
            {
                throw new ArgumentException($"服务内容不是合法的{nameof(SoapCommandMeta)}对象", e);
            }

            if (string.IsNullOrWhiteSpace(cmd.Url))
            {
                throw new ArgumentException($"服务内容不是合法的{nameof(SoapCommandMeta)}对象");
            }



            WsdlParser parser = WsdlParser.Load(cmd.Url);
            Message message = parser.GetInputMessage(null);
            XmlSchemaObject xmlSchema = parser.GetMessageSchema(message.Parts[0]);

            XmlSchemaSet schemas = new XmlSchemaSet();
            schemas.Add(parser.serviceDescription.Types.Schemas[0]);
            XmlQualifiedName qname = XmlQualifiedName.Empty;
            XmlTextWriter textWriter = new XmlTextWriter("Sample.xml", null)
            {
                Formatting = Formatting.Indented
            };
            XmlSampleGenerator genr = new XmlSampleGenerator(schemas, qname);
            genr.WriteXml(textWriter);
        }
    }
}
