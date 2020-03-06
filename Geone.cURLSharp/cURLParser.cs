﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;

namespace Geone.cURL
{
    public class cURLParser
    {
        public static HttpRequestMessage CreateHttpRequest(string requestString, Action<ExtractedParams> afterExtracted = null)
        {
            string contentType = "text/plain";
            ExtractedParams details = Parse(requestString);
            afterExtracted?.Invoke(details);

            HttpRequestMessage request = new HttpRequestMessage();
            request.Method = new HttpMethod(details.Method);
            request.RequestUri = new Uri(details.URL);

            var hdrs = details.Headers.ToArray();
            foreach (var hd in hdrs)
            {
                if (hd.GetType() != typeof(string)) continue;
                string hdr = (string)hd;
                if (hdr == "") { continue; }
                var res = hdr.Split(':');
                string section = res[0].Trim();
                switch (section.ToLower())
                {
                    case "authorization":
                        request.Headers.TryAddWithoutValidation("Authorization", res[1].Trim());
                        break;
                    case "content-type":
                        contentType = res[1].Trim();
                        break;
                }
            }
            foreach (var content in details.Data)
            {
                string cnt = (string)content;
                cnt = cnt.Replace("\\\"", "\"");
                request.Content = new StringContent(cnt, Encoding.UTF8, contentType);
            }
            return request;
        }

        public static ExtractedParams Parse(string requestString)
        {
            requestString = requestString.Replace("\\\r\n", "").Replace("\r\n", "").Replace("\n", "");
            ExtractedParams p = new ExtractedParams();
            p.RawCurl = requestString;
            bool hasPostData = false;
            StringBuilder postData = new StringBuilder();

            List<Dictionary<string, string>> x = new List<Dictionary<string, string>>();
            string[] options = requestString.Split(new string[] { " --", " -" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string item in options)
            {
                bool matchd = false;
                int delimiter = item.IndexOf(" ");
                Dictionary<string, string> itm = new Dictionary<string, string>();
                string trimmed = item.Trim(new char[] { '\'', ' ' });
                if (delimiter <= 0)
                {
                    if (trimmed.IndexOf("http") != 0) { p.URL = trimmed; continue; }
                    continue;
                };
                string key = item.Substring(0, delimiter).Trim(new char[] { '-' });
                string value = item.Substring(delimiter).Trim().Trim(new char[] { '\'', '"' });
                switch (key.ToLower())
                {
                    case "header":
                    case "h":
                        p.Headers.Add(value); matchd = true;
                        break;
                    case "data":
                    case "d":
                        p.Data.Add(value); matchd = true;
                        break;
                    case "url":
                        p.URL = value; matchd = true;
                        break;
                    case "request":
                    case "x":
                        int notClean = value.IndexOf(" ");
                        p.Method = (notClean == -1) ? value : value.Substring(0, notClean); matchd = true;
                        break;
                    case "f":
                        string[] kv = value.Split('=');
                        postData.AppendUrlEncoded(kv[0].Trim(new char[] { '\'' }), kv[1].Trim(new char[] { '\'' })); hasPostData = true; matchd = true;
                        break;
                    case "u":
                        var dict = new Dictionary<string, string>();
                        var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes(value));
                        dict.Add("Authorization", $"Basic {base64authorization}");
                        p.Headers.Add(dict);
                        matchd = true;
                        break;
                };
                if (!matchd)
                {
                    if (trimmed.IndexOf("http") != -1) { p.URL = trimmed.Substring(trimmed.IndexOf("http")); continue; }
                }
                string pattern = "(?<=\")(http|smtp|https):\\/\\/.+?(?=\")";
                Regex rg = new Regex(pattern);
                if (!rg.IsMatch(p.URL)) { p.URL = ""; }
                if (string.IsNullOrEmpty(p.URL))
                {
                    MatchCollection found = rg.Matches(trimmed);
                    if (found.Count > 0) { p.URL = found[0].Value; }
                }
            };

            if (hasPostData)
            {
                p.Data.Add(postData.ToString());
            }

            return p;
        }
    }
}