using Geone.CADLib.CLI.cURL;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;

namespace Geone.DataService.Core.REST
{
    public class RestExcutor
    {
        public RestExcutor()
        {

        }
        public string Excute(ServiceMeta service, Dictionary<string, object> arguments)
        {
            if (service.Type != ServiceType.REST)
                throw new ArgumentException("服务类型不匹配");

            JObject jobj = service.Content as JObject;
            if (jobj == null)
                throw new ArgumentException($"服务内容不是合法的{nameof(RestMeta)}对象");

            RestMeta restMeta;
            try
            {
                restMeta = jobj.ToObject<RestMeta>();
            }
            catch (Exception e)
            {
                throw new ArgumentException($"服务内容不是合法的{nameof(RestMeta)}对象", e);
            }

            if (string.IsNullOrWhiteSpace(restMeta.Curl))
            {
                throw new ArgumentException($"服务内容不是合法的{nameof(RestMeta)}对象");
            }

            restMeta.Parameters.AddRange(service.Parameters);
            foreach (var pitem in restMeta.Parameters)
            {
                string valString = null;
                if (arguments.TryGetValue(pitem.Name, out object val))
                {
                    pitem.Name = "{" + pitem.Name + "}";
                    valString = Convert.ToString(val);
                    restMeta.Curl = restMeta.Curl.Replace(pitem.Name, valString);
                }
            }

            HttpRequestMessage httpRequest = CURLParser.CreateHttpRequest(restMeta.Curl);
            if (httpRequest.Content != null)
            {
                string fdata = httpRequest.Content.ReadAsStringAsync().Result;
                string[] fdataItems = fdata.Split('&');
                MultipartFormDataContent multipartFormDataContent = new MultipartFormDataContent();
                foreach (var item in fdataItems)
                {
                    string data = HttpUtility.UrlDecode(item);
                    if (data.Contains('@'))
                    {
                        string[] fileNameAndPath = data.Split(';')[0].Split('=');
                        string filePath = fileNameAndPath[1].Replace("@", "");
                        string fileName = Path.GetFileName(filePath);
                        multipartFormDataContent.Add(new StreamContent(File.OpenRead(filePath)), fileNameAndPath[0], fileName);
                    }
                    else
                    {
                        multipartFormDataContent.Add(new StringContent(data, Encoding.UTF8, "text/plain"));
                    }
                }

                httpRequest.Content = multipartFormDataContent;
            }

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
                    return response.Content.ReadAsStringAsync().Result;
                }
            }
        }
    }
}
