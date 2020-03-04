using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SoapHttpClient;
using SoapHttpClient.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace Geone.DataService.Core.SOAP
{
    public class SoapExcutor
    {
        public SoapExcutor()
        {
        }

        public string Excute(ServiceMeta service, Dictionary<string, object> arguments)
        {
            if (service.Type != ServiceType.SOAP)
                throw new ArgumentException("服务类型不匹配");

            JObject jmeta = service.Content as JObject;
            SoapMeta soapMeta;
            try
            {
                soapMeta = jmeta.ToObject<SoapMeta>();
            }
            catch (Exception e)
            {
                throw new ArgumentException($"服务内容不是合法的{nameof(SoapMeta)}对象", e);
            }

            if (string.IsNullOrWhiteSpace(soapMeta.Uri))
            {
                throw new ArgumentException($"服务内容不是合法的{nameof(SoapMeta)}对象");
            }

            XmlDocument xdoc = null;
            if (arguments != null && arguments.Count > 0)
            {
                var keyValue = arguments.FirstOrDefault();

                StringBuilder sb = new StringBuilder();
                sb.Append("{");
                sb.Append("\"" + keyValue.Key + "\"");
                sb.Append(":");
                sb.Append(Convert.ToString(keyValue.Value));
                sb.Append("}");

                xdoc = JsonConvert.DeserializeXmlNode(sb.ToString());
            }

            XElement xele = null;
            if (xdoc != null)
            {
                xele = XElement.Load(new XmlNodeReader(xdoc));
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
