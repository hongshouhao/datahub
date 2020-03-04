using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Geone.DataService.Swagger
{
    public class Samples
    {
        public class Soap
        {
            public const string ServiceName = "soap";
            public const string Uri = "http://www.dneonline.com/calculator.asmx";
            public static JRaw Parameters;

            static Soap()
            {
                XElement ele = new XElement("Add");
                ele.SetAttributeValue("xmlns", "http://tempuri.org/");
                ele.SetElementValue("intA", 1);
                ele.SetElementValue("intB", 2);

                Parameters = new JRaw(JsonConvert.SerializeXNode(ele));
            }
        }
    }
}
