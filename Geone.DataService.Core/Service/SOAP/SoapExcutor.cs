using Geone.DataService.Core.Metadata;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SoapHttpClient;
using SoapHttpClient.Enums;
using System;
using System.Xml;
using System.Xml.Linq;

namespace Geone.DataService.Core.Service.SOAP
{
    public class SoapExcutor
    {
        public SoapExcutor()
        {
        }

        public string Excute(ServiceMeta service, object arguments)
        {
            if (service.Type != ServiceType.SOAP)
                throw new ArgumentException("服务类型不匹配");

            SoapMeta soapMeta = (SoapMeta)service.Content;
            soapMeta.CheckValid();

            XDocument xdoc = null;
            if (arguments != null)
            {
                xdoc = JsonConvert.DeserializeXNode(arguments.ToString());
            }

            XElement xele = null;
            if (xdoc != null)
            {
                xele = xdoc.Root;
            }

            var soapClient = new SoapClient();
            var result = soapClient.Post(new Uri(soapMeta.Uri), SoapVersion.Soap11, body: xele);

            if (!result.IsSuccessStatusCode)
            {
                throw new Exception("服务代理失败: " + result.ReasonPhrase);
            }
            else
            {
                string xml = result.Content.ReadAsStringAsync().Result;
                XmlDocument xmlRes = new XmlDocument();
                xmlRes.LoadXml(xml);
                XmlNode resNode = xmlRes.ChildNodes[1].FirstChild.FirstChild.FirstChild;
                if (resNode.HasChildNodes && resNode.FirstChild is XmlElement)
                {
                    return JsonConvert.SerializeXmlNode(resNode.FirstChild);
                }
                else
                {
                    return resNode.InnerText;
                }
            }
        }
    }
}
