using Geone.DataService.Core.Metadata;
using Geone.DataService.Core.Service.REST.cURL;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace Geone.DataService.Core.Service.REST
{
    public class RestExcutor
    {
        public RestExcutor()
        {
        }

        public string Excute(ServiceMeta service, object arguments)
        {
            if (service.Type != ServiceType.REST)
                throw new ArgumentException("服务类型不匹配");

            RestMeta restMeta = (RestMeta)service.Content;
            restMeta.CheckValid();

            if (arguments != null)
            {
                JObject jarg = (JObject)arguments;

                foreach (var prop in jarg)
                {
                    object val = ((JValue)prop.Value).Value;
                    if (val == null)
                    {
                        throw new ArgumentException($"输入参数非法[{prop.Key}]");
                    }

                    string finalString;
                    if (val is string valStr)
                    {
                        finalString = valStr.Replace("\\", "\\\\").Replace("\"", "\\\"");
                    }
                    else
                    {
                        finalString = val.ToString();
                    }

                    restMeta.CURL = restMeta.CURL.Replace($"{{{prop.Key}}}", finalString, StringComparison.CurrentCultureIgnoreCase);
                }
            }

            HttpRequestMessage httpRequest = CURLParser.CreateHttpRequest(restMeta.CURL);
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.SendAsync(httpRequest, HttpCompletionOption.ResponseContentRead).Result;
                response.EnsureSuccessStatusCode();

                return response.Content.ReadAsStringAsync().Result;
            }
        }
    }
}
