using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;

namespace Geone.DataService.AspNetCore.Swagger
{
    public class Samples
    {
        public class Soap
        {
            public const string ServiceName = "soap";
            public const string Uri = "http://www.dneonline.com/calculator.asmx";
            public static JRaw Parameters;

            static Soap()
            {
                XElement ele = new XElement("Add");
                ele.SetAttributeValue("xmlns", "http://tempuri.org/");
                ele.SetElementValue("intA", 1);
                ele.SetElementValue("intB", 2);

                Parameters = new JRaw(JsonConvert.SerializeXNode(ele));
            }
        }

        public class Rest
        {
            public static string CURL = "curl -X GET \"http://www.7timer.info/bin/astro.php?lon={lon}&lat={lat}&ac=0&unit=metric&output=json&tzshift=0\"";
            public static object Parameters = new
            {
                lon = 113.2,
                lat = 23.1
            };
        }

        public class Aggregate
        {
            public static object Schema;
            public static object Parameters;

            static Aggregate()
            {
                Schema = new
                {
                    Porperty1 = "$soap(add)",
                    Porperty2 = "$rest(lonlat).dataseries",
                };

                Parameters = new
                {
                    add = Soap.Parameters,
                    lonlat = new
                    {
                        lon = 113.2,
                        lat = 23.1
                    }
                };
            }
        }
    }
}
