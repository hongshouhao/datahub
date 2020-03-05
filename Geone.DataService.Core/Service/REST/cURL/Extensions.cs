using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Web;

namespace Geone.DataService.Core.Service.REST.cURL
{
    public static class Extensions
    {
        public static void AppendUrlEncoded(this StringBuilder sb, string name, string value)
        {
            if (sb.Length != 0)
                sb.Append("&");
            sb.Append(HttpUtility.UrlEncode(name));
            sb.Append("=");
            sb.Append(HttpUtility.UrlEncode(value));
        }
    }
}