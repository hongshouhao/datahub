using Microsoft.Xml.XMLGen;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace Geone.DataService.Core.SOAP
{
    class SoapEx
    {
        public static void sdf()
        {
            WsdlParser parser = WsdlParser.Load("");
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
        }
    }
}
