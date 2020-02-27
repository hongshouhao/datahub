using Geone.DataService.Core.Repository;
using Microsoft.Xml.XMLGen;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace Geone.DataService.Core.SOAP
{
    public class SoapExcutor
    {
        public SoapExcutor(MetaRepository repository)
        {

        }

        public string Excute(ServiceMeta service, Dictionary<string, object> arguments)
        {
            if (service.Type != ServiceType.SOAP)
                throw new ArgumentException("服务类型不匹配");

            XmlSampleGenerator generator = new XmlSampleGenerator("https://sscweb.sci.gsfc.nasa.gov/WS/helio/1/HeliocentricTrajectoriesService?wsdl", XmlQualifiedName.Empty);

            var sb = new StringBuilder();
            using var xw = XmlWriter.Create(sb, new XmlWriterSettings { Indent = true });
           
            // generate sample xml
            generator.WriteXml(xw);
            var xml = sb.ToString();

           // File.WriteAllText("d:\\xml.xml", xml);


            //WebServiceClient.CreateWebService( out string error);
            //WebServiceClient.CreateWebService("http://fy.webxml.com.cn/webservices/EnglishChinese.asmx",out string error);


            //Hashtable hashTable = new Hashtable();
            //hashTable.Add("wordKey", "yes");
            //XmlDocument doc = WebServiceCaller.QuerySoapWebService("http://fy.webxml.com.cn/webservices/EnglishChinese.asmx", "TranslatorString", hashTable);

            //string json = JsonConvert.SerializeXmlNode(doc);

            return "";
        }
    }
}
