using CurlHttpParser;
using Geone.DataService.Core.REST;
using Geone.DataService.Core.SOAP;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xml.XMLGen;
using Newtonsoft.Json;
using ServiceStack;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace TEST
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IOneWayClient oneWay = ClientFactory.Create("http://sys89.gxzjt.gov.cn:8080/RegisterUser/BuildMarket/WebService/BuildMarketWebService.asmx?wsdl");
        }

        [TestMethod]
        public void sdf()
        {
            WsdlParser parser = WsdlParser.Load("https://sscweb.sci.gsfc.nasa.gov/WS/helio/1/HeliocentricTrajectoriesService?wsdl");
            //Message message = parser.GetInputMessage(null);
            //XmlSchemaObject xmlSchema = parser.GetMessageSchema(message.Parts[0]);

            XmlSchemaSet schemas = new XmlSchemaSet();
            schemas.Add(parser.serviceDescription.Types.Schemas[0]);

            XmlQualifiedName qname = XmlQualifiedName.Empty;
            XmlTextWriter textWriter = new XmlTextWriter("Sample.xml", Encoding.UTF8)
            {
                Formatting = System.Xml.Formatting.Indented
            };
            XmlSampleGenerator genr = new XmlSampleGenerator(schemas, qname);

            genr.WriteXml(textWriter);
        }

        [TestMethod]
        public void sdffff()
        {
            //XmlSchema xmlSchema = XmlSchema.Read(XmlReader.Create(File.OpenRead(@"C:\Users\zhangmj\Downloads\EnglishChinese.xml")), (s, e) =>
            //{
            //});

            XmlSchema xmlSchema = XmlSchema.Read(File.OpenRead(@"C:\Users\zhangmj\Downloads\EnglishChinese.xml"), (s, e) =>
            {
            });

            XmlSchemaSet schemas = new XmlSchemaSet();
            schemas.Add(xmlSchema);
            XmlQualifiedName qname = XmlQualifiedName.Empty;
            XmlTextWriter textWriter = new XmlTextWriter("Sample.xml", Encoding.UTF8)
            {
                Formatting = System.Xml.Formatting.Indented
            };

            XmlSampleGenerator genr = new XmlSampleGenerator(schemas, qname);
            genr.WriteXml(textWriter);
        }

        [TestMethod]
        public void restTest() 
        {
            //读取cad模板文件测试
            //ProcessStartInfo start = new ProcessStartInfo();
            //start.FileName = @"C:\Windows\System32\curl.exe";  // Specify exe name.
            //start.Arguments = "-X GET \"http://192.168.122.17:9864/all-supported-TemplateFileNames\" -H \"accept: text/plain\"";
            //start.UseShellExecute = false;
            //start.RedirectStandardOutput = true;

            //// Start the process.
            //using (Process p = Process.Start(start))
            //{
            //    // Read in all the text from the process with the StreamReader
            //    using (StreamReader reader = p.StandardOutput)
            //    {
            //        string result = reader.ReadToEnd();
            //    }
            //}


            //读取cad坐标系测试
            //ProcessStartInfo start = new ProcessStartInfo();
            //start.FileName = @"C:\Windows\System32\curl.exe";  // Specify exe name.
            //start.Arguments = "-X GET \"http://192.168.122.17:9864/all-supported-projections/my\" -H \"accept: text/plain\"";
            //start.UseShellExecute = false;
            //start.RedirectStandardOutput = true;

            //// Start the process.
            //using (Process p = Process.Start(start))
            //{
            //    // Read in all the text from the process with the StreamReader
            //    using (StreamReader reader = p.StandardOutput)
            //    {
            //        string result = reader.ReadToEnd();
            //    }
            //}



            //读取cad测试
            //ProcessStartInfo start = new ProcessStartInfo();
            //start.FileName = @"C:\Windows\System32\curl.exe";  // Specify exe name.
            //start.Arguments = "-X POST \"http://192.168.122.17:9864/read-cad\" -H \"accept: text/plain\" -H \"Content-Type: multipart/form-data\" -F \"CadFile=@C:/Users/zhangmj/Desktop/aaaa.dgn\" -F \"TemplateFileName=template\"";
            //start.UseShellExecute = false;
            //start.RedirectStandardOutput = true;

            //// Start the process.
            //using (Process p = Process.Start(start))
            //{
            //    // Read in all the text from the process with the StreamReader
            //    using (StreamReader reader = p.StandardOutput)
            //    {
            //        string result = reader.ReadToEnd();
            //    }
            //}


            //读取徐州规管application测试
            //ProcessStartInfo start = new ProcessStartInfo();
            //start.FileName = @"C:\Windows\System32\curl.exe";  // Specify exe name.
            //start.Arguments = " -X GET \"http://192.168.84.124:8098/applications/7\" -H \"accept: text/plain\" -H \"authorization: Bearer eyJhbGciOiJSUzI1NiIsImtpZCI6ImQ2ZjU1ZTNkYTRhODczYzlmNDZlNThlYWYwODE1MDU2IiwidHlwIjoiSldUIn0.eyJuYmYiOjE1ODI4NzAxMjgsImV4cCI6MTU4Mjg3MzcyOCwiaXNzIjoiaHR0cDovLzE5Mi4xNjguODQuMTI0Ojg2MTAiLCJhdWQiOlsiaHR0cDovLzE5Mi4xNjguODQuMTI0Ojg2MTAvcmVzb3VyY2VzIiwiWHV6aG91LUd1aWh1YU9BLVdlYkFQSSJdLCJjbGllbnRfaWQiOiJYdXpob3UtR3VpaHVhT0EtU3dhZ2dlclVJIiwic3ViIjoiNWQxMmJjMmEtNjExOS00MTljLWJiOTgtOWIzMmI5MGMzODMyIiwiYXV0aF90aW1lIjoxNTgyODcwMTI4LCJpZHAiOiJsb2NhbCIsImNubmFtZSI6IueuoeeQhuWRmCIsInJvbGUiOlsiU2tvcnViYUlkZW50aXR5QWRtaW5BZG1pbmlzdHJhdG9yIiwic2EiXSwibmFtZSI6ImFkbWluIiwic2NvcGUiOlsieHV6aG91LW9hLWZ1bGxhY2Nlc3MiXSwiYW1yIjpbInB3ZCJdfQ.N4fok3pdabd9IkgmQsTwoof7YsNUnI7mDVN1iCt6CWeHa1-ZsDsAPiAETRtcYkYYLgPMUYPUcMxIVF4VhwSG7icSE-3XXQtwt5siCilhU-VI6rmlhg_0_WIaFvyjLxmyYFqHy6XbBFYuvBDYMakMW2E9vDN9uQeg1XGceo5TYpG1bTqeQZbBAN85CZrvuGwBLRlzogT5M4fzlvOvl-xx_IZ4oJcCcoloHa4sgXnCJgAMjliHoiGqY7Si1JMDy-r-iYIuY7xr_MBtvLscZ8P8OWL-pr1O3IygWyRCLgw1_10DvO90WLmY-HNautiVbk62vjtt_kG7-QeM5jWksg7h1Q\"";
            //start.UseShellExecute = false;
            //start.StandardOutputEncoding = Encoding.UTF8;
            //start.RedirectStandardOutput = true;

            //// Start the process.
            //using (Process p = Process.Start(start))
            //{
            //    // Read in all the text from the process with the StreamReader
            //    using (StreamReader reader = p.StandardOutput)
            //    {
            //        string result = reader.ReadToEnd();
            //    }
            //}


            //CurlHttpParser.StringParser stringParser = new CurlHttpParser.StringParser();
            //ExtractedParams extractedParams = stringParser.Parse("curl -X GET \"http://192.168.122.17:9864/all-supported-TemplateFileNames\" -H \"accept: text/plain\"");

            //HttpRequestMessage requestMessage = stringParser.CreateHttpRequest("curl -X GET \"http://192.168.122.17:9864/all-supported-TemplateFileNames\" -H \"accept: text/plain\"");

            //requestMessage.GetResponseStatus();



            


        }
    }
}
