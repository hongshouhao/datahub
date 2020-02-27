// System.Web.Services.Configuration.WebServicesSection
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Xml.Serialization;

public sealed class WebServicesSection
{
    private Type[] defaultFormatTypes = new Type[21]
    {
        typeof(HttpAddressBinding),
        typeof(HttpBinding),
        typeof(HttpOperationBinding),
        typeof(HttpUrlEncodedBinding),
        typeof(HttpUrlReplacementBinding),
        typeof(MimeContentBinding),
        typeof(MimeXmlBinding),
        typeof(MimeMultipartRelatedBinding),
        typeof(MimeTextBinding),
        typeof(SoapBinding),
        typeof(SoapOperationBinding),
        typeof(SoapBodyBinding),
        typeof(SoapFaultBinding),
        typeof(SoapHeaderBinding),
        typeof(SoapAddressBinding),
        typeof(Soap12Binding),
        typeof(Soap12OperationBinding),
        typeof(Soap12BodyBinding),
        typeof(Soap12FaultBinding),
        typeof(Soap12HeaderBinding),
        typeof(Soap12AddressBinding)
    };

    public static WebServicesSection Current => new WebServicesSection();

    internal static void LoadXmlFormatExtensions(Type[] extensionTypes, XmlAttributeOverrides overrides, XmlSerializerNamespaces namespaces)
    {
        Hashtable table = new Hashtable();
        table.Add(typeof(ServiceDescription), new XmlAttributes());
        table.Add(typeof(Import), new XmlAttributes());
        table.Add(typeof(Port), new XmlAttributes());
        table.Add(typeof(Service), new XmlAttributes());
        table.Add(typeof(FaultBinding), new XmlAttributes());
        table.Add(typeof(InputBinding), new XmlAttributes());
        table.Add(typeof(OutputBinding), new XmlAttributes());
        table.Add(typeof(OperationBinding), new XmlAttributes());
        table.Add(typeof(Binding), new XmlAttributes());
        table.Add(typeof(OperationFault), new XmlAttributes());
        table.Add(typeof(OperationInput), new XmlAttributes());
        table.Add(typeof(OperationOutput), new XmlAttributes());
        table.Add(typeof(Operation), new XmlAttributes());
        table.Add(typeof(PortType), new XmlAttributes());
        table.Add(typeof(Message), new XmlAttributes());
        table.Add(typeof(MessagePart), new XmlAttributes());
        table.Add(typeof(Types), new XmlAttributes());
        Hashtable extensions = new Hashtable();
        foreach (Type extensionType in extensionTypes)
        {
            if (extensions[extensionType] == null)
            {
                extensions.Add(extensionType, extensionType);
                object[] attrs2 = new List<object>(extensionType.GetTypeInfo().GetCustomAttributes(typeof(XmlFormatExtensionAttribute), false)).ToArray();
                if (attrs2.Length == 0)
                {
                    throw new ArgumentException(ResWebServices.GetString(ResWebServices.RequiredXmlFormatExtensionAttributeIsMissing1, extensionType.FullName), "extensionTypes");
                }
                XmlFormatExtensionAttribute extensionAttr = (XmlFormatExtensionAttribute)attrs2[0];
                Type[] extensionPoints = extensionAttr.ExtensionPoints;
                foreach (Type extensionPointType in extensionPoints)
                {
                    XmlAttributes xmlAttrs = (XmlAttributes)table[extensionPointType];
                    if (xmlAttrs == null)
                    {
                        xmlAttrs = new XmlAttributes();
                        table.Add(extensionPointType, xmlAttrs);
                    }
                    XmlElementAttribute xmlAttr = new XmlElementAttribute(extensionAttr.ElementName, extensionType);
                    xmlAttr.Namespace = extensionAttr.Namespace;
                    xmlAttrs.XmlElements.Add(xmlAttr);
                }
                attrs2 = new List<object>(extensionType.GetTypeInfo().GetCustomAttributes(typeof(XmlFormatExtensionPrefixAttribute), false)).ToArray();
                string[] prefixes = new string[attrs2.Length];
                Hashtable nsDefs = new Hashtable();
                for (int j = 0; j < attrs2.Length; j++)
                {
                    XmlFormatExtensionPrefixAttribute prefixAttr = (XmlFormatExtensionPrefixAttribute)attrs2[j];
                    prefixes[j] = prefixAttr.Prefix;
                    nsDefs.Add(prefixAttr.Prefix, prefixAttr.Namespace);
                }
                Array.Sort(prefixes);
                for (int i = 0; i < prefixes.Length; i++)
                {
                    namespaces.Add(prefixes[i], (string)nsDefs[prefixes[i]]);
                }
            }
        }
        foreach (Type key in table.Keys)
        {
            XmlFormatExtensionPointAttribute attr = GetExtensionPointAttribute(key);
            XmlAttributes xmlAttrs2 = (XmlAttributes)table[key];
            if (attr.AllowElements)
            {
                xmlAttrs2.XmlAnyElements.Add(new XmlAnyElementAttribute());
            }
            overrides.Add(key, attr.MemberName, xmlAttrs2);
        }
    }

    internal Type[] GetAllFormatExtensionTypes()
    {
        return defaultFormatTypes;
    }

    private static XmlFormatExtensionPointAttribute GetExtensionPointAttribute(Type type)
    {
        object[] attrs = new List<object>(type.GetTypeInfo().GetCustomAttributes(typeof(XmlFormatExtensionPointAttribute), false)).ToArray();
        if (attrs.Length == 0)
        {
            throw new ArgumentException(ResWebServices.GetString(ResWebServices.TheSyntaxOfTypeMayNotBeExtended1, type.FullName), "type");
        }
        return (XmlFormatExtensionPointAttribute)attrs[0];
    }
}
