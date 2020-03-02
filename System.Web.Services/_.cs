//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Xml.Schema;

//namespace System.Xml.Schema
//{
//    public static class _
//    {
//        public static IEnumerable<Operation> GetAllOperations(this ServiceDescription service)
//        {
//            foreach (PortType portType in service.PortTypes)
//            {
//                foreach (Operation operation in portType.Operations)
//                {
//                    yield return operation;
//                }
//            }
//        }

//        public static Operation GetOperation(this ServiceDescription service, string operationName, bool throwIfNotFound = true)
//        {
//            Operation targ = GetAllOperations(service).FirstOrDefault(x => x.Name == operationName);
//            if (targ == null && throwIfNotFound)
//            {
//                throw new Exception($"没有找到方法: {operationName}");
//            }

//            return targ;
//        }

//        public static Message GetInputMessage(this Operation operation)
//        {
//            foreach (var message in operation.Messages)
//            {
//                if (message is OperationInput input)
//                {
//                    return operation.PortType.ServiceDescription.Messages.Cast<Message>()
//                        .First(x => x.Name == input.Message.Name);
//                }
//            }

//            return null;
//        }

//        public static Message GetOutputMessage(this Operation operation)
//        {
//            foreach (var message in operation.Messages)
//            {
//                if (message is OperationOutput output)
//                {
//                    return operation.PortType.ServiceDescription.Messages.Cast<Message>()
//                        .First(x => x.Name == output.Message.Name);
//                }
//            }

//            return null;
//        }

//        public static XmlSchemaObject GetMessageSchema(this MessagePart parameter)
//        {
//            XmlSchema xmlSchema = parameter.Message.ServiceDescription.Types.Schemas[0];

//            foreach (XmlSchemaObject item in xmlSchema.Items)
//            {
//                if (item is XmlSchemaElement schemaElement)
//                {
//                    if (schemaElement.QualifiedName.ToString() == parameter.Element.ToString())
//                    {
//                        if (schemaElement.SchemaType is XmlSchemaComplexType schemaComplexType)
//                        {
//                            return schemaComplexType.Particle;
//                        }
//                        else
//                        {
//                            return schemaElement;
//                        }
//                    }
//                }
//                else if (item is XmlSchemaComplexType complexType)
//                {
//                    if (complexType.QualifiedName.ToString() == parameter.Element.ToString())
//                    {
//                        return complexType.Particle;
//                    }
//                }
//            }

//            throw new Exception();
//        }

//        public static XmlSchema Clean(this XmlSchema xmlSchema)
//        {
//            RemoveRefSchemaElement(xmlSchema.Items);
//            return xmlSchema;
//        }

//        static void RemoveRefSchemaElement(this XmlSchemaObjectCollection collection)
//        {
//            List<XmlSchemaElement> toReomve = new List<XmlSchemaElement>();
//            foreach (var item in collection)
//            {
//                if (item is XmlSchemaElement element)
//                {
//                    if (element.SchemaType is XmlSchemaComplexType complexType)
//                    {
//                        if (complexType.Particle is XmlSchemaSequence sequence)
//                        {
//                            RemoveRefSchemaElement(sequence.Items);
//                        }
//                        else if (complexType.Particle is XmlSchemaChoice choice)
//                        {
//                            RemoveRefSchemaElement(choice.Items);
//                        }
//                        else if (complexType.Particle is XmlSchemaAll all)
//                        {
//                            RemoveRefSchemaElement(all.Items);
//                        }
//                    }
//                    if (element.RefName.Name == "schema")
//                    {
//                        toReomve.Add(element);
//                    }
//                }
//                else if (item is XmlSchemaComplexType complexType)
//                {
//                    if (complexType.Particle is XmlSchemaSequence sequence)
//                    {
//                        RemoveRefSchemaElement(sequence.Items);
//                    }
//                    else if (complexType.Particle is XmlSchemaChoice choice)
//                    {
//                        RemoveRefSchemaElement(choice.Items);
//                    }
//                    else if (complexType.Particle is XmlSchemaAll all)
//                    {
//                        RemoveRefSchemaElement(all.Items);
//                    }
//                }
//            }

//            foreach (var item in toReomve)
//            {
//                int idx = collection.IndexOf(item);
//                collection.RemoveAt(idx);
//                collection.Insert(idx, new XmlSchemaAny() { Namespace = item.QualifiedName.Namespace });
//            }
//        }
//    }
//}
