using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Linq;
using System.Xml.Schema;

namespace Geone.DataService.Core.SOAP
{
    public class WsdlParser
    {
        public ServiceDescription serviceDescription;

        private WsdlParser()
        {
        }

        public static WsdlParser Load(string url)
        {
            WsdlParser parser = new WsdlParser();
            UriBuilder uriBuilder = new UriBuilder(url);
            if (!url.ToLower().EndsWith("?wsdl"))
            {
                uriBuilder.Query = "WSDL";
            }

            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(uriBuilder.Uri);
            webRequest.ContentType = "text/xml;charset=\"utf-8\"";
            webRequest.Method = "GET";
            webRequest.Accept = "text/xml";

            using (WebResponse response = webRequest.GetResponse())
            {
                using (Stream stream = response.GetResponseStream())
                {
                    parser.serviceDescription = ServiceDescription.Read(stream);
                }
            }

            return parser;
        }

        public IEnumerable<Operation> GetAllOperations()
        {
            foreach (PortType portType in serviceDescription.PortTypes)
            {
                foreach (Operation operation in portType.Operations)
                {
                    yield return operation;
                }
            }
        }

        public Operation GetOperation(string qualifiedName, bool throwIfNotFound)
        {
            Operation targ = GetAllOperations().FirstOrDefault(x => $"{x.PortType.Name}.{x.Name}" == qualifiedName);
            if (targ == null && throwIfNotFound)
            {
                throw new Exception($"没有找到方法: {qualifiedName}");
            }

            return targ;
        }

        public Message GetInputMessage(Operation operation)
        {
            foreach (var message in operation.Messages)
            {
                if (message is OperationInput input)
                {
                    return serviceDescription.Messages.Cast<Message>().First(x => x.Name == input.Message.Name);
                }
            }

            return null;
        }

        public Message GetOutputMessage(Operation operation)
        {
            foreach (var message in operation.Messages)
            {
                if (message is OperationOutput output)
                {
                    return serviceDescription.Messages.Cast<Message>().First(x => x.Name == output.Message.Name);
                }
            }

            return null;
        }

        public XmlSchemaObject GetMessageSchema(MessagePart parameter)
        {
            XmlSchema xmlSchema = serviceDescription.Types.Schemas[0];

            foreach (XmlSchemaObject item in xmlSchema.Items)
            {
                if (item is XmlSchemaElement schemaElement)
                {
                    if (schemaElement.QualifiedName.ToString() == parameter.Element.ToString())
                    {
                        if (schemaElement.SchemaType is XmlSchemaComplexType schemaComplexType)
                        {
                            return schemaComplexType.Particle;
                        }
                        else
                        {
                            return schemaElement;
                        }
                    }
                }
                else if (item is XmlSchemaComplexType complexType)
                {
                    if (complexType.QualifiedName.ToString() == parameter.Element.ToString())
                    {
                        return complexType.Particle;
                    }
                }
            }

            throw new Exception();
        }


        private void Mainasd()
        {
            //Loop through the port types in the service description and list all of the 
            //web service's operations and each operations input/output
            foreach (PortType portType in serviceDescription.PortTypes)
            {
                foreach (Operation operation in portType.Operations)
                {
                    foreach (var message in operation.Messages)
                    {
                        if (message is OperationInput)
                            Console.Out.WriteLine("Input Message: {0}", ((OperationInput)message).Message.Name);
                        if (message is OperationOutput)
                            Console.Out.WriteLine("Output Message: {0}", ((OperationOutput)message).Message.Name);

                        foreach (Message messagePart in serviceDescription.Messages)
                        {
                            if (messagePart.Name != ((OperationMessage)message).Message.Name) continue;

                            foreach (MessagePart part in messagePart.Parts)
                            {
                                Console.Out.WriteLine(part.Name);
                            }
                        }
                    }
                }
            } //End listing of types

            //Drill down into the WSDL's complex types to list out the individual schema elements 
            //and their data types
            Types types = serviceDescription.Types;
            XmlSchema xmlSchema = types.Schemas[0];

            foreach (object item in xmlSchema.Items)
            {
                XmlSchemaElement schemaElement = item as XmlSchemaElement;
                XmlSchemaComplexType complexType = item as XmlSchemaComplexType;

                if (schemaElement != null)
                {
                    Console.Out.WriteLine("Schema Element: {0}", schemaElement.Name);

                    XmlSchemaType schemaType = schemaElement.SchemaType;
                    XmlSchemaComplexType schemaComplexType = schemaType as XmlSchemaComplexType;

                    if (schemaComplexType != null)
                    {
                        XmlSchemaParticle particle = schemaComplexType.Particle;
                        XmlSchemaSequence sequence = particle as XmlSchemaSequence;
                        if (sequence != null)
                        {
                            foreach (XmlSchemaElement childElement in sequence.Items)
                            {
                                Console.Out.WriteLine("Element/Type: {0}:{1}", childElement.Name, childElement.SchemaTypeName.Name);
                            }
                        }
                    }
                }
                else if (complexType != null)
                {
                    Console.Out.WriteLine("Complex Type: {0}", complexType.Name);
                    OutputElements(complexType.Particle);
                }
                Console.Out.WriteLine();
            }

            Console.Out.WriteLine();
            Console.In.ReadLine();
        }

        private static void OutputElements(XmlSchemaParticle particle)
        {
            XmlSchemaSequence sequence = particle as XmlSchemaSequence;
            XmlSchemaChoice choice = particle as XmlSchemaChoice;
            XmlSchemaAll all = particle as XmlSchemaAll;

            if (sequence != null)
            {
                Console.Out.WriteLine("  Sequence");

                for (int i = 0; i < sequence.Items.Count; i++)
                {
                    XmlSchemaElement childElement = sequence.Items[i] as XmlSchemaElement;
                    XmlSchemaSequence innerSequence = sequence.Items[i] as XmlSchemaSequence;
                    XmlSchemaChoice innerChoice = sequence.Items[i] as XmlSchemaChoice;
                    XmlSchemaAll innerAll = sequence.Items[i] as XmlSchemaAll;

                    if (childElement != null)
                    {
                        Console.Out.WriteLine("Element/Type: {0}:{1}", childElement.Name, childElement.SchemaTypeName.Name);
                    }
                    else OutputElements(sequence.Items[i] as XmlSchemaParticle);
                }
            }
            else if (choice != null)
            {
                Console.Out.WriteLine("  Choice");
                for (int i = 0; i < choice.Items.Count; i++)
                {
                    XmlSchemaElement childElement = choice.Items[i] as XmlSchemaElement;
                    XmlSchemaSequence innerSequence = choice.Items[i] as XmlSchemaSequence;
                    XmlSchemaChoice innerChoice = choice.Items[i] as XmlSchemaChoice;
                    XmlSchemaAll innerAll = choice.Items[i] as XmlSchemaAll;

                    if (childElement != null)
                    {
                        Console.Out.WriteLine("    Element/Type: {0}:{1}", childElement.Name,
                                              childElement.SchemaTypeName.Name);
                    }
                    else OutputElements(choice.Items[i] as XmlSchemaParticle);
                }

                Console.Out.WriteLine();
            }
            else if (all != null)
            {
                Console.Out.WriteLine("  All");
                for (int i = 0; i < all.Items.Count; i++)
                {
                    XmlSchemaElement childElement = all.Items[i] as XmlSchemaElement;
                    XmlSchemaSequence innerSequence = all.Items[i] as XmlSchemaSequence;
                    XmlSchemaChoice innerChoice = all.Items[i] as XmlSchemaChoice;
                    XmlSchemaAll innerAll = all.Items[i] as XmlSchemaAll;

                    if (childElement != null)
                    {
                        Console.Out.WriteLine("Element/Type: {0}:{1}", childElement.Name, childElement.SchemaTypeName.Name);
                    }
                    else OutputElements(all.Items[i] as XmlSchemaParticle);
                }
                Console.Out.WriteLine();
            }
        }
    }
}
