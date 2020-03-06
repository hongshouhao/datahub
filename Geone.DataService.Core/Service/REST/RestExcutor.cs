using Geone.cURL;
using Geone.DataService.Core.Metadata;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace Geone.DataService.Core.Service.REST
{
    public class RestExcutor : IExcutor
    {
        public RestExcutor()
        {
        }

        public object Excute(ServiceMeta service, object arguments)
        {
            if (service.Type != ServiceType.REST)
                throw new ArgumentException("服务类型不匹配");

            RestMeta restMeta = (RestMeta)service.Content;
            restMeta.CheckValid();
            string curl = restMeta.CURL;

            JObject jarg = null;
            if (arguments != null)
            {
                jarg = (JObject)arguments;
            }

            HttpRequestMessage httpRequest = cURLParser.CreateHttpRequest(curl, parameters => SetCurl(parameters, jarg));
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.SendAsync(httpRequest, HttpCompletionOption.ResponseContentRead).Result;
                response.EnsureSuccessStatusCode();

                return response.Content.ReadAsStringAsync().Result;
            }
        }

        void SetCurl(ExtractedParams parameters, JObject argument)
        {
            bool hasBody = parameters.Data.Count > 0;
            bool hasHeader = parameters.Headers.Count > 0;
            bool hasQuery = Regex.IsMatch(parameters.URL, @"\{[a-zA-Z0-9_]+\}");

            if (hasBody || hasHeader || hasQuery)
            {
                if (argument == null)
                {
                    throw new ArgumentException("服务输入参数不正确");
                }
            }

            if (hasBody && (hasHeader || hasQuery))
            {
                SetHeaderAndQuery(parameters, argument, hasHeader, hasQuery);
                parameters.Data[0] = GetFinalStringValue(parameters.Data[0].ToString(), argument);
            }
            else if (hasBody && !(hasHeader || hasQuery))
            {
                parameters.Data[0] = Escape(argument.ToString());
            }
            else if (!hasBody && (hasHeader || hasQuery))
            {
                SetHeaderAndQuery(parameters, argument, hasHeader, hasQuery);
            }
            else if (!hasBody && !(hasHeader || hasQuery))
            {
            }
            else
            {
                throw new Exception();
            }
        }

        private void SetHeaderAndQuery(ExtractedParams parameters, JObject argument, bool hasHeader, bool hasQuery)
        {
            if (hasQuery)
            {
                parameters.URL = GetFinalStringValue(parameters.URL, argument);
            }

            if (hasHeader)
            {
                for (int i = 0; i < parameters.Headers.Count; i++)
                {
                    if (parameters.Headers[i] is string)
                    {
                        parameters.Headers[i] = GetFinalStringValue(parameters.Headers[i].ToString(), argument);
                    }
                }
            }
        }

        string GetFinalStringValue(string input, JObject jobj)
        {
            string result = input;
            MatchCollection matches = Regex.Matches(input, @"\{(?<prop>[a-zA-Z0-9_]+)\}");
            string[] props = matches.Cast<Match>().Select(x => x.Groups["prop"].Value).ToArray();
            foreach (var item in props)
            {
                string valString = jobj[item]?.ToString();
                valString = Escape(valString);
                result = result.Replace($"{{{item}}}", valString);
            }

            return result;
        }

        string Escape(string input)
        {
            return input?.Replace("\\", "\\\\").Replace("\"", "\\\"");
        }
    }
}
