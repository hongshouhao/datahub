using Geone.CADLib.CLI.cURL;
using Geone.DataService.Core.DBaaS;
using Geone.DataService.Core.Repository;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;


namespace Geone.DataService.Core.REST
{
    public class RestExcutor
    {
        public string Excute(ServiceMeta service, Dictionary<string, object> arguments)
        {
            if (service.Type != ServiceType.REST)
                throw new ArgumentException("服务类型不匹配");

            JObject jobj = service.Content as JObject;
            if (jobj == null)
                throw new ArgumentException($"服务内容不是合法的{nameof(RestCommandMeta)}对象");

            RestCommandMeta cmd;
            try
            {
                cmd = jobj.ToObject<RestCommandMeta>();
            }
            catch (Exception e)
            {
                throw new ArgumentException($"服务内容不是合法的{nameof(RestCommandMeta)}对象", e);
            }

            if (string.IsNullOrWhiteSpace(cmd.Curl))
            {
                throw new ArgumentException($"服务内容不是合法的{nameof(RestCommandMeta)}对象");
            }

            cmd.Parameters.AddRange(service.Parameters);
            foreach (var pitem in cmd.Parameters)
            {
                string valString = null;
                if (arguments.TryGetValue(pitem.Name, out object val))
                {
                    pitem.Name = "{" + pitem.Name + "}";
                    valString = Convert.ToString(val);
                    cmd.Curl = cmd.Curl.Replace(pitem.Name, valString);
                }
            }
            HttpRequestMessage httpRequest = CURLParser.CreateHttpRequest(cmd.Curl);
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.SendAsync(httpRequest, HttpCompletionOption.ResponseContentRead).Result;
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception(response.ReasonPhrase);
                }
                else
                {
                    response.EnsureSuccessStatusCode();
                    string responseBodyAsText = response.Content.ReadAsStringAsync().Result;
                    return responseBodyAsText;
                }
            }
        }
    }
}
