using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geone.DataHub
{
    public static class HttpContextBodyExtension
    {
        class ContentType
        {
            public ContentType(StringValues values)
            {
                foreach (string item in values)
                {
                    if (item.IndexOf("/") > 0)
                    {
                        MediaType = item;
                    }
                    else if (item.StartsWith("charset=", StringComparison.OrdinalIgnoreCase))
                    {
                        CharSet = item.Substring(8);
                    }
                }
            }

            public Encoding GetEncoding()
            {
                if (!string.IsNullOrWhiteSpace(CharSet))
                {
                    return Encoding.GetEncoding(CharSet);
                }
                else
                {
                    return null;
                }
            }

            public string MediaType { get; private set; }
            public string CharSet { get; private set; }
        }

        public static string BodyAsString(this HttpRequest request)
        {
            ContentType contentType = new ContentType(request.ContentType);
            Encoding encoding = contentType.GetEncoding();
            if (encoding == null)
                encoding = Encoding.UTF8;

            var bodyStream = new MemoryStream();
            request.Body.CopyToAsync(bodyStream);
            bodyStream.Seek(0, SeekOrigin.Begin);
            string requestBodyText = new StreamReader(bodyStream, encoding).ReadToEnd();
            bodyStream.Seek(0, SeekOrigin.Begin);

            request.Body.Close();
            request.Body = bodyStream;

            return requestBodyText;
        }
    }
}
