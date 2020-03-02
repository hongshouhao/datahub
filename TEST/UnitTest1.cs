//using Geone.DataService.Core.SOAP;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Microsoft.Xml.XMLGen;
//using ServiceStack;
//using System;
//using System.Web.Services;
//using System.Xml;
//using System.Xml.Schema;

//namespace TEST
//{
//    [TestClass]
//    public class UnitTest1
//    {
//        [TestMethod]
//        public void TestMethod1()
//        {
//            ServiceDescription parser = WsdlReader.Read("http://sys89.gxzjt.gov.cn:8080/RegisterUser/BuildMarket/WebService/BuildMarketWebService.asmx?wsdl");

//            //XmlSchemaElement elementCat = new XmlSchemaElement();
//            //elementCat.Name = "schema";
//            //elementCat.SchemaTypeName = new XmlQualifiedName("schema", "http://www.w3.org/2001/XMLSchema");

//            XmlSchema schema = parser.Types.Schemas[0];
//            schema.Clean();

//            Operation operation = parser.GetOperation("ProjectInfoOperation");
//            Message input = operation.GetInputMessage();

//            //schema.Items.Add(elementCat);

//            XmlReaderSettings settings = new XmlReaderSettings();
//            settings.ValidationType = ValidationType.Schema;
//            settings.ValidationFlags |= XmlSchemaValidationFlags.ProcessInlineSchema;
//            settings.ValidationFlags |= XmlSchemaValidationFlags.ProcessSchemaLocation;
//            settings.ValidationEventHandler += new ValidationEventHandler(ValidationCallBack);
//            settings.Schemas.Add(schema);

//            //settings.Schemas.Add(null, @"C:\Users\hongsh\Desktop\ÏîÄ¿.xsd");

//            XmlReader reader = XmlReader.Create(@"C:\Users\hongsh\Desktop\HeliocentricTrajectoriesService.xml", settings);
//            reader.Dispose();

//            XmlSchemaSet schemas = new XmlSchemaSet();
//            schemas.Add(schema);
//            //schemas.Add(null, @"C:\Users\hongsh\Desktop\_contosobooks.xsd");
//            XmlQualifiedName qname = new XmlQualifiedName(input.Name, input.Namespaces) { };
//            XmlTextWriter textWriter = new XmlTextWriter(@"C:\Users\hongsh\Desktop\HeliocentricTrajectoriesService.xml", null)
//            {
//                Formatting = Formatting.Indented
//            };
//            XmlSampleGenerator genr = new XmlSampleGenerator(schemas, qname);
//            genr.WriteXml(textWriter);
//            //  Message message = parser.GetInputMessage(null);
//            //  XmlSchemaObject xmlSchema = parser.GetMessageSchema(message.Parts[0]);
//        }

//        private static void ValidationCallBack(object sender, ValidationEventArgs args)
//        {
//            Console.WriteLine("Error in Schema - ");
//            Console.WriteLine(args.Message);
//        }
//    }
//}
