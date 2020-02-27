// System.Web.Services.Description.ServiceDescriptionSerializationWriter
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using System;
using System.Collections;
using System.Globalization;
using System.Text;

internal class ServiceDescriptionSerializationWriter : XmlSerializationWriter
{
    public void Write125_definitions(object o)
    {
        WriteStartDocument();
        if (o == null)
        {
            WriteNullTagLiteral("definitions", "http://schemas.xmlsoap.org/wsdl/");
        }
        else
        {
            TopLevelElement();
            Write124_ServiceDescription("definitions", "http://schemas.xmlsoap.org/wsdl/", (ServiceDescription)o, true, false);
        }
    }

    private void Write124_ServiceDescription(string n, string ns, ServiceDescription o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(ServiceDescription)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("ServiceDescription", "http://schemas.xmlsoap.org/wsdl/");
            }
            XmlAttribute[] a7 = o.ExtensibleAttributes;
            if (a7 != null)
            {
                foreach (XmlAttribute ai in a7)
                {
                    WriteXmlAttribute(ai, o);
                }
            }
            WriteAttribute("name", "", o.Name);
            WriteAttribute("targetNamespace", "", o.TargetNamespace);
            if (o.DocumentationElement == null && o.DocumentationElement != null)
            {
                throw CreateInvalidAnyTypeException(o.DocumentationElement);
            }
            WriteElementLiteral(o.DocumentationElement, "documentation", "http://schemas.xmlsoap.org/wsdl/", false, true);
            ServiceDescriptionFormatExtensionCollection a6 = o.Extensions;
            if (a6 != null)
            {
                for (int ia6 = 0; ia6 < ((ICollection)a6).Count; ia6++)
                {
                    if (!(a6[ia6] is XmlNode) && a6[ia6] != null)
                    {
                        throw CreateInvalidAnyTypeException(a6[ia6]);
                    }
                    WriteElementLiteral((XmlNode)a6[ia6], "", null, false, true);
                }
            }
            ImportCollection a5 = o.Imports;
            if (a5 != null)
            {
                for (int ia5 = 0; ia5 < ((ICollection)a5).Count; ia5++)
                {
                    Write4_Import("import", "http://schemas.xmlsoap.org/wsdl/", a5[ia5], false, false);
                }
            }
            Write67_Types("types", "http://schemas.xmlsoap.org/wsdl/", o.Types, false, false);
            MessageCollection a4 = o.Messages;
            if (a4 != null)
            {
                for (int ia4 = 0; ia4 < ((ICollection)a4).Count; ia4++)
                {
                    Write69_Message("message", "http://schemas.xmlsoap.org/wsdl/", a4[ia4], false, false);
                }
            }
            PortTypeCollection a3 = o.PortTypes;
            if (a3 != null)
            {
                for (int ia3 = 0; ia3 < ((ICollection)a3).Count; ia3++)
                {
                    Write75_PortType("portType", "http://schemas.xmlsoap.org/wsdl/", a3[ia3], false, false);
                }
            }
            BindingCollection a2 = o.Bindings;
            if (a2 != null)
            {
                for (int ia2 = 0; ia2 < ((ICollection)a2).Count; ia2++)
                {
                    Write117_Binding("binding", "http://schemas.xmlsoap.org/wsdl/", a2[ia2], false, false);
                }
            }
            ServiceCollection a = o.Services;
            if (a != null)
            {
                for (int ia = 0; ia < ((ICollection)a).Count; ia++)
                {
                    Write123_Service("service", "http://schemas.xmlsoap.org/wsdl/", a[ia], false, false);
                }
            }
            WriteEndElement(o);
        }
    }

    private void Write123_Service(string n, string ns, Service o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(Service)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("Service", "http://schemas.xmlsoap.org/wsdl/");
            }
            XmlAttribute[] a3 = o.ExtensibleAttributes;
            if (a3 != null)
            {
                foreach (XmlAttribute ai in a3)
                {
                    WriteXmlAttribute(ai, o);
                }
            }
            WriteAttribute("name", "", o.Name);
            if (o.DocumentationElement == null && o.DocumentationElement != null)
            {
                throw CreateInvalidAnyTypeException(o.DocumentationElement);
            }
            WriteElementLiteral(o.DocumentationElement, "documentation", "http://schemas.xmlsoap.org/wsdl/", false, true);
            ServiceDescriptionFormatExtensionCollection a2 = o.Extensions;
            if (a2 != null)
            {
                for (int ia2 = 0; ia2 < ((ICollection)a2).Count; ia2++)
                {
                    if (!(a2[ia2] is XmlNode) && a2[ia2] != null)
                    {
                        throw CreateInvalidAnyTypeException(a2[ia2]);
                    }
                    WriteElementLiteral((XmlNode)a2[ia2], "", null, false, true);
                }
            }
            PortCollection a = o.Ports;
            if (a != null)
            {
                for (int ia = 0; ia < ((ICollection)a).Count; ia++)
                {
                    Write122_Port("port", "http://schemas.xmlsoap.org/wsdl/", a[ia], false, false);
                }
            }
            WriteEndElement(o);
        }
    }

    private void Write122_Port(string n, string ns, Port o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(Port)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("Port", "http://schemas.xmlsoap.org/wsdl/");
            }
            XmlAttribute[] a2 = o.ExtensibleAttributes;
            if (a2 != null)
            {
                foreach (XmlAttribute ai2 in a2)
                {
                    WriteXmlAttribute(ai2, o);
                }
            }
            WriteAttribute("name", "", o.Name);
            WriteAttribute("binding", "", FromXmlQualifiedName(o.Binding));
            if (o.DocumentationElement == null && o.DocumentationElement != null)
            {
                throw CreateInvalidAnyTypeException(o.DocumentationElement);
            }
            WriteElementLiteral(o.DocumentationElement, "documentation", "http://schemas.xmlsoap.org/wsdl/", false, true);
            ServiceDescriptionFormatExtensionCollection a = o.Extensions;
            if (a != null)
            {
                for (int ia = 0; ia < ((ICollection)a).Count; ia++)
                {
                    object ai = a[ia];
                    if (ai is Soap12AddressBinding)
                    {
                        Write121_Soap12AddressBinding("address", "http://schemas.xmlsoap.org/wsdl/soap12/", (Soap12AddressBinding)ai, false, false);
                    }
                    else if (ai is HttpAddressBinding)
                    {
                        Write118_HttpAddressBinding("address", "http://schemas.xmlsoap.org/wsdl/http/", (HttpAddressBinding)ai, false, false);
                    }
                    else if (ai is SoapAddressBinding)
                    {
                        Write119_SoapAddressBinding("address", "http://schemas.xmlsoap.org/wsdl/soap/", (SoapAddressBinding)ai, false, false);
                    }
                    else if (ai is XmlElement)
                    {
                        XmlElement elem = (XmlElement)ai;
                        if (elem == null && elem != null)
                        {
                            throw CreateInvalidAnyTypeException(elem);
                        }
                        WriteElementLiteral(elem, "", null, false, true);
                    }
                    else if (ai != null)
                    {
                        throw CreateUnknownTypeException(ai);
                    }
                }
            }
            WriteEndElement(o);
        }
    }

    private void Write119_SoapAddressBinding(string n, string ns, SoapAddressBinding o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(SoapAddressBinding)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType)
            {
                WriteXsiType("SoapAddressBinding", "http://schemas.xmlsoap.org/wsdl/soap/");
            }
            if (o.Required)
            {
                WriteAttribute("required", "http://schemas.xmlsoap.org/wsdl/", XmlConvert.ToString(o.Required));
            }
            WriteAttribute("location", "", o.Location);
            WriteEndElement(o);
        }
    }

    private void Write118_HttpAddressBinding(string n, string ns, HttpAddressBinding o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(HttpAddressBinding)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType)
            {
                WriteXsiType("HttpAddressBinding", "http://schemas.xmlsoap.org/wsdl/http/");
            }
            if (o.Required)
            {
                WriteAttribute("required", "http://schemas.xmlsoap.org/wsdl/", XmlConvert.ToString(o.Required));
            }
            WriteAttribute("location", "", o.Location);
            WriteEndElement(o);
        }
    }

    private void Write121_Soap12AddressBinding(string n, string ns, Soap12AddressBinding o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(Soap12AddressBinding)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType)
            {
                WriteXsiType("Soap12AddressBinding", "http://schemas.xmlsoap.org/wsdl/soap12/");
            }
            if (o.Required)
            {
                WriteAttribute("required", "http://schemas.xmlsoap.org/wsdl/", XmlConvert.ToString(o.Required));
            }
            WriteAttribute("location", "", o.Location);
            WriteEndElement(o);
        }
    }

    private void Write117_Binding(string n, string ns, Binding o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(Binding)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("Binding", "http://schemas.xmlsoap.org/wsdl/");
            }
            XmlAttribute[] a3 = o.ExtensibleAttributes;
            if (a3 != null)
            {
                foreach (XmlAttribute ai2 in a3)
                {
                    WriteXmlAttribute(ai2, o);
                }
            }
            WriteAttribute("name", "", o.Name);
            WriteAttribute("type", "", FromXmlQualifiedName(o.Type));
            if (o.DocumentationElement == null && o.DocumentationElement != null)
            {
                throw CreateInvalidAnyTypeException(o.DocumentationElement);
            }
            WriteElementLiteral(o.DocumentationElement, "documentation", "http://schemas.xmlsoap.org/wsdl/", false, true);
            ServiceDescriptionFormatExtensionCollection a2 = o.Extensions;
            if (a2 != null)
            {
                for (int ia2 = 0; ia2 < ((ICollection)a2).Count; ia2++)
                {
                    object ai = a2[ia2];
                    if (ai is Soap12Binding)
                    {
                        Write84_Soap12Binding("binding", "http://schemas.xmlsoap.org/wsdl/soap12/", (Soap12Binding)ai, false, false);
                    }
                    else if (ai is HttpBinding)
                    {
                        Write77_HttpBinding("binding", "http://schemas.xmlsoap.org/wsdl/http/", (HttpBinding)ai, false, false);
                    }
                    else if (ai is SoapBinding)
                    {
                        Write80_SoapBinding("binding", "http://schemas.xmlsoap.org/wsdl/soap/", (SoapBinding)ai, false, false);
                    }
                    else if (ai is XmlElement)
                    {
                        XmlElement elem = (XmlElement)ai;
                        if (elem == null && elem != null)
                        {
                            throw CreateInvalidAnyTypeException(elem);
                        }
                        WriteElementLiteral(elem, "", null, false, true);
                    }
                    else if (ai != null)
                    {
                        throw CreateUnknownTypeException(ai);
                    }
                }
            }
            OperationBindingCollection a = o.Operations;
            if (a != null)
            {
                for (int ia = 0; ia < ((ICollection)a).Count; ia++)
                {
                    Write116_OperationBinding("operation", "http://schemas.xmlsoap.org/wsdl/", a[ia], false, false);
                }
            }
            WriteEndElement(o);
        }
    }

    private void Write116_OperationBinding(string n, string ns, OperationBinding o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(OperationBinding)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("OperationBinding", "http://schemas.xmlsoap.org/wsdl/");
            }
            XmlAttribute[] a3 = o.ExtensibleAttributes;
            if (a3 != null)
            {
                foreach (XmlAttribute ai2 in a3)
                {
                    WriteXmlAttribute(ai2, o);
                }
            }
            WriteAttribute("name", "", o.Name);
            if (o.DocumentationElement == null && o.DocumentationElement != null)
            {
                throw CreateInvalidAnyTypeException(o.DocumentationElement);
            }
            WriteElementLiteral(o.DocumentationElement, "documentation", "http://schemas.xmlsoap.org/wsdl/", false, true);
            ServiceDescriptionFormatExtensionCollection a2 = o.Extensions;
            if (a2 != null)
            {
                for (int ia2 = 0; ia2 < ((ICollection)a2).Count; ia2++)
                {
                    object ai = a2[ia2];
                    if (ai is Soap12OperationBinding)
                    {
                        Write88_Soap12OperationBinding("operation", "http://schemas.xmlsoap.org/wsdl/soap12/", (Soap12OperationBinding)ai, false, false);
                    }
                    else if (ai is HttpOperationBinding)
                    {
                        Write85_HttpOperationBinding("operation", "http://schemas.xmlsoap.org/wsdl/http/", (HttpOperationBinding)ai, false, false);
                    }
                    else if (ai is SoapOperationBinding)
                    {
                        Write86_SoapOperationBinding("operation", "http://schemas.xmlsoap.org/wsdl/soap/", (SoapOperationBinding)ai, false, false);
                    }
                    else if (ai is XmlElement)
                    {
                        XmlElement elem = (XmlElement)ai;
                        if (elem == null && elem != null)
                        {
                            throw CreateInvalidAnyTypeException(elem);
                        }
                        WriteElementLiteral(elem, "", null, false, true);
                    }
                    else if (ai != null)
                    {
                        throw CreateUnknownTypeException(ai);
                    }
                }
            }
            Write110_InputBinding("input", "http://schemas.xmlsoap.org/wsdl/", o.Input, false, false);
            Write111_OutputBinding("output", "http://schemas.xmlsoap.org/wsdl/", o.Output, false, false);
            FaultBindingCollection a = o.Faults;
            if (a != null)
            {
                for (int ia = 0; ia < ((ICollection)a).Count; ia++)
                {
                    Write115_FaultBinding("fault", "http://schemas.xmlsoap.org/wsdl/", a[ia], false, false);
                }
            }
            WriteEndElement(o);
        }
    }

    private void Write115_FaultBinding(string n, string ns, FaultBinding o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(FaultBinding)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("FaultBinding", "http://schemas.xmlsoap.org/wsdl/");
            }
            XmlAttribute[] a2 = o.ExtensibleAttributes;
            if (a2 != null)
            {
                foreach (XmlAttribute ai2 in a2)
                {
                    WriteXmlAttribute(ai2, o);
                }
            }
            WriteAttribute("name", "", o.Name);
            if (o.DocumentationElement == null && o.DocumentationElement != null)
            {
                throw CreateInvalidAnyTypeException(o.DocumentationElement);
            }
            WriteElementLiteral(o.DocumentationElement, "documentation", "http://schemas.xmlsoap.org/wsdl/", false, true);
            ServiceDescriptionFormatExtensionCollection a = o.Extensions;
            if (a != null)
            {
                for (int ia = 0; ia < ((ICollection)a).Count; ia++)
                {
                    object ai = a[ia];
                    if (ai is Soap12FaultBinding)
                    {
                        Write114_Soap12FaultBinding("fault", "http://schemas.xmlsoap.org/wsdl/soap12/", (Soap12FaultBinding)ai, false, false);
                    }
                    else if (ai is SoapFaultBinding)
                    {
                        Write112_SoapFaultBinding("fault", "http://schemas.xmlsoap.org/wsdl/soap/", (SoapFaultBinding)ai, false, false);
                    }
                    else if (ai is XmlElement)
                    {
                        XmlElement elem = (XmlElement)ai;
                        if (elem == null && elem != null)
                        {
                            throw CreateInvalidAnyTypeException(elem);
                        }
                        WriteElementLiteral(elem, "", null, false, true);
                    }
                    else if (ai != null)
                    {
                        throw CreateUnknownTypeException(ai);
                    }
                }
            }
            WriteEndElement(o);
        }
    }

    private void Write112_SoapFaultBinding(string n, string ns, SoapFaultBinding o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(SoapFaultBinding)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType)
            {
                WriteXsiType("SoapFaultBinding", "http://schemas.xmlsoap.org/wsdl/soap/");
            }
            if (o.Required)
            {
                WriteAttribute("required", "http://schemas.xmlsoap.org/wsdl/", XmlConvert.ToString(o.Required));
            }
            if (o.Use != 0)
            {
                WriteAttribute("use", "", Write98_SoapBindingUse(o.Use));
            }
            WriteAttribute("name", "", o.Name);
            WriteAttribute("namespace", "", o.Namespace);
            if (o.Encoding != null && o.Encoding.Length != 0)
            {
                WriteAttribute("encodingStyle", "", o.Encoding);
            }
            WriteEndElement(o);
        }
    }

    private string Write98_SoapBindingUse(SoapBindingUse v)
    {
        string s = null;
        switch (v)
        {
            case SoapBindingUse.Encoded:
                return "encoded";
            case SoapBindingUse.Literal:
                return "literal";
            default:
                throw CreateInvalidEnumValueException(((long)v).ToString((IFormatProvider)CultureInfo.InvariantCulture), "System.Web.Services.Description.SoapBindingUse");
        }
    }

    private void Write114_Soap12FaultBinding(string n, string ns, Soap12FaultBinding o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(Soap12FaultBinding)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType)
            {
                WriteXsiType("Soap12FaultBinding", "http://schemas.xmlsoap.org/wsdl/soap12/");
            }
            if (o.Required)
            {
                WriteAttribute("required", "http://schemas.xmlsoap.org/wsdl/", XmlConvert.ToString(o.Required));
            }
            if (o.Use != 0)
            {
                WriteAttribute("use", "", Write100_SoapBindingUse(o.Use));
            }
            WriteAttribute("name", "", o.Name);
            WriteAttribute("namespace", "", o.Namespace);
            if (o.Encoding != null && o.Encoding.Length != 0)
            {
                WriteAttribute("encodingStyle", "", o.Encoding);
            }
            WriteEndElement(o);
        }
    }

    private string Write100_SoapBindingUse(SoapBindingUse v)
    {
        string s = null;
        switch (v)
        {
            case SoapBindingUse.Encoded:
                return "encoded";
            case SoapBindingUse.Literal:
                return "literal";
            default:
                throw CreateInvalidEnumValueException(((long)v).ToString((IFormatProvider)CultureInfo.InvariantCulture), "System.Web.Services.Description.SoapBindingUse");
        }
    }

    private void Write111_OutputBinding(string n, string ns, OutputBinding o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(OutputBinding)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("OutputBinding", "http://schemas.xmlsoap.org/wsdl/");
            }
            XmlAttribute[] a2 = o.ExtensibleAttributes;
            if (a2 != null)
            {
                foreach (XmlAttribute ai2 in a2)
                {
                    WriteXmlAttribute(ai2, o);
                }
            }
            WriteAttribute("name", "", o.Name);
            if (o.DocumentationElement == null && o.DocumentationElement != null)
            {
                throw CreateInvalidAnyTypeException(o.DocumentationElement);
            }
            WriteElementLiteral(o.DocumentationElement, "documentation", "http://schemas.xmlsoap.org/wsdl/", false, true);
            ServiceDescriptionFormatExtensionCollection a = o.Extensions;
            if (a != null)
            {
                for (int ia = 0; ia < ((ICollection)a).Count; ia++)
                {
                    object ai = a[ia];
                    if (ai is Soap12BodyBinding)
                    {
                        Write102_Soap12BodyBinding("body", "http://schemas.xmlsoap.org/wsdl/soap12/", (Soap12BodyBinding)ai, false, false);
                    }
                    else if (ai is Soap12HeaderBinding)
                    {
                        Write109_Soap12HeaderBinding("header", "http://schemas.xmlsoap.org/wsdl/soap12/", (Soap12HeaderBinding)ai, false, false);
                    }
                    else if (ai is SoapHeaderBinding)
                    {
                        Write106_SoapHeaderBinding("header", "http://schemas.xmlsoap.org/wsdl/soap/", (SoapHeaderBinding)ai, false, false);
                    }
                    else if (ai is SoapBodyBinding)
                    {
                        Write99_SoapBodyBinding("body", "http://schemas.xmlsoap.org/wsdl/soap/", (SoapBodyBinding)ai, false, false);
                    }
                    else if (ai is MimeXmlBinding)
                    {
                        Write94_MimeXmlBinding("mimeXml", "http://schemas.xmlsoap.org/wsdl/mime/", (MimeXmlBinding)ai, false, false);
                    }
                    else if (ai is MimeContentBinding)
                    {
                        Write93_MimeContentBinding("content", "http://schemas.xmlsoap.org/wsdl/mime/", (MimeContentBinding)ai, false, false);
                    }
                    else if (ai is MimeTextBinding)
                    {
                        Write97_MimeTextBinding("text", "http://microsoft.com/wsdl/mime/textMatching/", (MimeTextBinding)ai, false, false);
                    }
                    else if (ai is MimeMultipartRelatedBinding)
                    {
                        Write104_MimeMultipartRelatedBinding("multipartRelated", "http://schemas.xmlsoap.org/wsdl/mime/", (MimeMultipartRelatedBinding)ai, false, false);
                    }
                    else if (ai is XmlElement)
                    {
                        XmlElement elem = (XmlElement)ai;
                        if (elem == null && elem != null)
                        {
                            throw CreateInvalidAnyTypeException(elem);
                        }
                        WriteElementLiteral(elem, "", null, false, true);
                    }
                    else if (ai != null)
                    {
                        throw CreateUnknownTypeException(ai);
                    }
                }
            }
            WriteEndElement(o);
        }
    }

    private void Write104_MimeMultipartRelatedBinding(string n, string ns, MimeMultipartRelatedBinding o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(MimeMultipartRelatedBinding)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType)
            {
                WriteXsiType("MimeMultipartRelatedBinding", "http://schemas.xmlsoap.org/wsdl/mime/");
            }
            if (o.Required)
            {
                WriteAttribute("required", "http://schemas.xmlsoap.org/wsdl/", XmlConvert.ToString(o.Required));
            }
            MimePartCollection a = o.Parts;
            if (a != null)
            {
                for (int ia = 0; ia < ((ICollection)a).Count; ia++)
                {
                    Write103_MimePart("part", "http://schemas.xmlsoap.org/wsdl/mime/", a[ia], false, false);
                }
            }
            WriteEndElement(o);
        }
    }

    private void Write103_MimePart(string n, string ns, MimePart o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(MimePart)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType)
            {
                WriteXsiType("MimePart", "http://schemas.xmlsoap.org/wsdl/mime/");
            }
            if (o.Required)
            {
                WriteAttribute("required", "http://schemas.xmlsoap.org/wsdl/", XmlConvert.ToString(o.Required));
            }
            ServiceDescriptionFormatExtensionCollection a = o.Extensions;
            if (a != null)
            {
                for (int ia = 0; ia < ((ICollection)a).Count; ia++)
                {
                    object ai = a[ia];
                    if (ai is Soap12BodyBinding)
                    {
                        Write102_Soap12BodyBinding("body", "http://schemas.xmlsoap.org/wsdl/soap12/", (Soap12BodyBinding)ai, false, false);
                    }
                    else if (ai is SoapBodyBinding)
                    {
                        Write99_SoapBodyBinding("body", "http://schemas.xmlsoap.org/wsdl/soap/", (SoapBodyBinding)ai, false, false);
                    }
                    else if (ai is MimeContentBinding)
                    {
                        Write93_MimeContentBinding("content", "http://schemas.xmlsoap.org/wsdl/mime/", (MimeContentBinding)ai, false, false);
                    }
                    else if (ai is MimeXmlBinding)
                    {
                        Write94_MimeXmlBinding("mimeXml", "http://schemas.xmlsoap.org/wsdl/mime/", (MimeXmlBinding)ai, false, false);
                    }
                    else if (ai is MimeTextBinding)
                    {
                        Write97_MimeTextBinding("text", "http://microsoft.com/wsdl/mime/textMatching/", (MimeTextBinding)ai, false, false);
                    }
                    else if (ai is XmlElement)
                    {
                        XmlElement elem = (XmlElement)ai;
                        if (elem == null && elem != null)
                        {
                            throw CreateInvalidAnyTypeException(elem);
                        }
                        WriteElementLiteral(elem, "", null, false, true);
                    }
                    else if (ai != null)
                    {
                        throw CreateUnknownTypeException(ai);
                    }
                }
            }
            WriteEndElement(o);
        }
    }

    private void Write97_MimeTextBinding(string n, string ns, MimeTextBinding o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(MimeTextBinding)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType)
            {
                WriteXsiType("MimeTextBinding", "http://microsoft.com/wsdl/mime/textMatching/");
            }
            if (o.Required)
            {
                WriteAttribute("required", "http://schemas.xmlsoap.org/wsdl/", XmlConvert.ToString(o.Required));
            }
            MimeTextMatchCollection a = o.Matches;
            if (a != null)
            {
                for (int ia = 0; ia < ((ICollection)a).Count; ia++)
                {
                    Write96_MimeTextMatch("match", "http://microsoft.com/wsdl/mime/textMatching/", a[ia], false, false);
                }
            }
            WriteEndElement(o);
        }
    }

    private void Write96_MimeTextMatch(string n, string ns, MimeTextMatch o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(MimeTextMatch)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType)
            {
                WriteXsiType("MimeTextMatch", "http://microsoft.com/wsdl/mime/textMatching/");
            }
            WriteAttribute("name", "", o.Name);
            WriteAttribute("type", "", o.Type);
            if (o.Group != 1)
            {
                WriteAttribute("group", "", XmlConvert.ToString(o.Group));
            }
            if (o.Capture != 0)
            {
                WriteAttribute("capture", "", XmlConvert.ToString(o.Capture));
            }
            if (o.RepeatsString != "1")
            {
                WriteAttribute("repeats", "", o.RepeatsString);
            }
            WriteAttribute("pattern", "", o.Pattern);
            WriteAttribute("ignoreCase", "", XmlConvert.ToString(o.IgnoreCase));
            MimeTextMatchCollection a = o.Matches;
            if (a != null)
            {
                for (int ia = 0; ia < ((ICollection)a).Count; ia++)
                {
                    Write96_MimeTextMatch("match", "http://microsoft.com/wsdl/mime/textMatching/", a[ia], false, false);
                }
            }
            WriteEndElement(o);
        }
    }

    private void Write94_MimeXmlBinding(string n, string ns, MimeXmlBinding o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(MimeXmlBinding)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType)
            {
                WriteXsiType("MimeXmlBinding", "http://schemas.xmlsoap.org/wsdl/mime/");
            }
            if (o.Required)
            {
                WriteAttribute("required", "http://schemas.xmlsoap.org/wsdl/", XmlConvert.ToString(o.Required));
            }
            WriteAttribute("part", "", o.Part);
            WriteEndElement(o);
        }
    }

    private void Write93_MimeContentBinding(string n, string ns, MimeContentBinding o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(MimeContentBinding)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType)
            {
                WriteXsiType("MimeContentBinding", "http://schemas.xmlsoap.org/wsdl/mime/");
            }
            if (o.Required)
            {
                WriteAttribute("required", "http://schemas.xmlsoap.org/wsdl/", XmlConvert.ToString(o.Required));
            }
            WriteAttribute("part", "", o.Part);
            WriteAttribute("type", "", o.Type);
            WriteEndElement(o);
        }
    }

    private void Write99_SoapBodyBinding(string n, string ns, SoapBodyBinding o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(SoapBodyBinding)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType)
            {
                WriteXsiType("SoapBodyBinding", "http://schemas.xmlsoap.org/wsdl/soap/");
            }
            if (o.Required)
            {
                WriteAttribute("required", "http://schemas.xmlsoap.org/wsdl/", XmlConvert.ToString(o.Required));
            }
            if (o.Use != 0)
            {
                WriteAttribute("use", "", Write98_SoapBindingUse(o.Use));
            }
            if (o.Namespace != null && o.Namespace.Length != 0)
            {
                WriteAttribute("namespace", "", o.Namespace);
            }
            if (o.Encoding != null && o.Encoding.Length != 0)
            {
                WriteAttribute("encodingStyle", "", o.Encoding);
            }
            WriteAttribute("parts", "", o.PartsString);
            WriteEndElement(o);
        }
    }

    private void Write102_Soap12BodyBinding(string n, string ns, Soap12BodyBinding o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(Soap12BodyBinding)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType)
            {
                WriteXsiType("Soap12BodyBinding", "http://schemas.xmlsoap.org/wsdl/soap12/");
            }
            if (o.Required)
            {
                WriteAttribute("required", "http://schemas.xmlsoap.org/wsdl/", XmlConvert.ToString(o.Required));
            }
            if (o.Use != 0)
            {
                WriteAttribute("use", "", Write100_SoapBindingUse(o.Use));
            }
            if (o.Namespace != null && o.Namespace.Length != 0)
            {
                WriteAttribute("namespace", "", o.Namespace);
            }
            if (o.Encoding != null && o.Encoding.Length != 0)
            {
                WriteAttribute("encodingStyle", "", o.Encoding);
            }
            WriteAttribute("parts", "", o.PartsString);
            WriteEndElement(o);
        }
    }

    private void Write106_SoapHeaderBinding(string n, string ns, SoapHeaderBinding o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(SoapHeaderBinding)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType)
            {
                WriteXsiType("SoapHeaderBinding", "http://schemas.xmlsoap.org/wsdl/soap/");
            }
            if (o.Required)
            {
                WriteAttribute("required", "http://schemas.xmlsoap.org/wsdl/", XmlConvert.ToString(o.Required));
            }
            WriteAttribute("message", "", FromXmlQualifiedName(o.Message));
            WriteAttribute("part", "", o.Part);
            if (o.Use != 0)
            {
                WriteAttribute("use", "", Write98_SoapBindingUse(o.Use));
            }
            if (o.Encoding != null && o.Encoding.Length != 0)
            {
                WriteAttribute("encodingStyle", "", o.Encoding);
            }
            if (o.Namespace != null && o.Namespace.Length != 0)
            {
                WriteAttribute("namespace", "", o.Namespace);
            }
            Write105_SoapHeaderFaultBinding("headerfault", "http://schemas.xmlsoap.org/wsdl/soap/", o.Fault, false, false);
            WriteEndElement(o);
        }
    }

    private void Write105_SoapHeaderFaultBinding(string n, string ns, SoapHeaderFaultBinding o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(SoapHeaderFaultBinding)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType)
            {
                WriteXsiType("SoapHeaderFaultBinding", "http://schemas.xmlsoap.org/wsdl/soap/");
            }
            if (o.Required)
            {
                WriteAttribute("required", "http://schemas.xmlsoap.org/wsdl/", XmlConvert.ToString(o.Required));
            }
            WriteAttribute("message", "", FromXmlQualifiedName(o.Message));
            WriteAttribute("part", "", o.Part);
            if (o.Use != 0)
            {
                WriteAttribute("use", "", Write98_SoapBindingUse(o.Use));
            }
            if (o.Encoding != null && o.Encoding.Length != 0)
            {
                WriteAttribute("encodingStyle", "", o.Encoding);
            }
            if (o.Namespace != null && o.Namespace.Length != 0)
            {
                WriteAttribute("namespace", "", o.Namespace);
            }
            WriteEndElement(o);
        }
    }

    private void Write109_Soap12HeaderBinding(string n, string ns, Soap12HeaderBinding o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(Soap12HeaderBinding)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType)
            {
                WriteXsiType("Soap12HeaderBinding", "http://schemas.xmlsoap.org/wsdl/soap12/");
            }
            if (o.Required)
            {
                WriteAttribute("required", "http://schemas.xmlsoap.org/wsdl/", XmlConvert.ToString(o.Required));
            }
            WriteAttribute("message", "", FromXmlQualifiedName(o.Message));
            WriteAttribute("part", "", o.Part);
            if (o.Use != 0)
            {
                WriteAttribute("use", "", Write100_SoapBindingUse(o.Use));
            }
            if (o.Encoding != null && o.Encoding.Length != 0)
            {
                WriteAttribute("encodingStyle", "", o.Encoding);
            }
            if (o.Namespace != null && o.Namespace.Length != 0)
            {
                WriteAttribute("namespace", "", o.Namespace);
            }
            Write107_SoapHeaderFaultBinding("headerfault", "http://schemas.xmlsoap.org/wsdl/soap12/", o.Fault, false, false);
            WriteEndElement(o);
        }
    }

    private void Write107_SoapHeaderFaultBinding(string n, string ns, SoapHeaderFaultBinding o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(SoapHeaderFaultBinding)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType)
            {
                WriteXsiType("SoapHeaderFaultBinding", "http://schemas.xmlsoap.org/wsdl/soap12/");
            }
            if (o.Required)
            {
                WriteAttribute("required", "http://schemas.xmlsoap.org/wsdl/", XmlConvert.ToString(o.Required));
            }
            WriteAttribute("message", "", FromXmlQualifiedName(o.Message));
            WriteAttribute("part", "", o.Part);
            if (o.Use != 0)
            {
                WriteAttribute("use", "", Write100_SoapBindingUse(o.Use));
            }
            if (o.Encoding != null && o.Encoding.Length != 0)
            {
                WriteAttribute("encodingStyle", "", o.Encoding);
            }
            if (o.Namespace != null && o.Namespace.Length != 0)
            {
                WriteAttribute("namespace", "", o.Namespace);
            }
            WriteEndElement(o);
        }
    }

    private void Write110_InputBinding(string n, string ns, InputBinding o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(InputBinding)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("InputBinding", "http://schemas.xmlsoap.org/wsdl/");
            }
            XmlAttribute[] a2 = o.ExtensibleAttributes;
            if (a2 != null)
            {
                foreach (XmlAttribute ai2 in a2)
                {
                    WriteXmlAttribute(ai2, o);
                }
            }
            WriteAttribute("name", "", o.Name);
            if (o.DocumentationElement == null && o.DocumentationElement != null)
            {
                throw CreateInvalidAnyTypeException(o.DocumentationElement);
            }
            WriteElementLiteral(o.DocumentationElement, "documentation", "http://schemas.xmlsoap.org/wsdl/", false, true);
            ServiceDescriptionFormatExtensionCollection a = o.Extensions;
            if (a != null)
            {
                for (int ia = 0; ia < ((ICollection)a).Count; ia++)
                {
                    object ai = a[ia];
                    if (ai is Soap12BodyBinding)
                    {
                        Write102_Soap12BodyBinding("body", "http://schemas.xmlsoap.org/wsdl/soap12/", (Soap12BodyBinding)ai, false, false);
                    }
                    else if (ai is Soap12HeaderBinding)
                    {
                        Write109_Soap12HeaderBinding("header", "http://schemas.xmlsoap.org/wsdl/soap12/", (Soap12HeaderBinding)ai, false, false);
                    }
                    else if (ai is SoapBodyBinding)
                    {
                        Write99_SoapBodyBinding("body", "http://schemas.xmlsoap.org/wsdl/soap/", (SoapBodyBinding)ai, false, false);
                    }
                    else if (ai is SoapHeaderBinding)
                    {
                        Write106_SoapHeaderBinding("header", "http://schemas.xmlsoap.org/wsdl/soap/", (SoapHeaderBinding)ai, false, false);
                    }
                    else if (ai is MimeTextBinding)
                    {
                        Write97_MimeTextBinding("text", "http://microsoft.com/wsdl/mime/textMatching/", (MimeTextBinding)ai, false, false);
                    }
                    else if (ai is HttpUrlReplacementBinding)
                    {
                        Write91_HttpUrlReplacementBinding("urlReplacement", "http://schemas.xmlsoap.org/wsdl/http/", (HttpUrlReplacementBinding)ai, false, false);
                    }
                    else if (ai is HttpUrlEncodedBinding)
                    {
                        Write90_HttpUrlEncodedBinding("urlEncoded", "http://schemas.xmlsoap.org/wsdl/http/", (HttpUrlEncodedBinding)ai, false, false);
                    }
                    else if (ai is MimeContentBinding)
                    {
                        Write93_MimeContentBinding("content", "http://schemas.xmlsoap.org/wsdl/mime/", (MimeContentBinding)ai, false, false);
                    }
                    else if (ai is MimeMultipartRelatedBinding)
                    {
                        Write104_MimeMultipartRelatedBinding("multipartRelated", "http://schemas.xmlsoap.org/wsdl/mime/", (MimeMultipartRelatedBinding)ai, false, false);
                    }
                    else if (ai is MimeXmlBinding)
                    {
                        Write94_MimeXmlBinding("mimeXml", "http://schemas.xmlsoap.org/wsdl/mime/", (MimeXmlBinding)ai, false, false);
                    }
                    else if (ai is XmlElement)
                    {
                        XmlElement elem = (XmlElement)ai;
                        if (elem == null && elem != null)
                        {
                            throw CreateInvalidAnyTypeException(elem);
                        }
                        WriteElementLiteral(elem, "", null, false, true);
                    }
                    else if (ai != null)
                    {
                        throw CreateUnknownTypeException(ai);
                    }
                }
            }
            WriteEndElement(o);
        }
    }

    private void Write90_HttpUrlEncodedBinding(string n, string ns, HttpUrlEncodedBinding o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(HttpUrlEncodedBinding)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType)
            {
                WriteXsiType("HttpUrlEncodedBinding", "http://schemas.xmlsoap.org/wsdl/http/");
            }
            if (o.Required)
            {
                WriteAttribute("required", "http://schemas.xmlsoap.org/wsdl/", XmlConvert.ToString(o.Required));
            }
            WriteEndElement(o);
        }
    }

    private void Write91_HttpUrlReplacementBinding(string n, string ns, HttpUrlReplacementBinding o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(HttpUrlReplacementBinding)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType)
            {
                WriteXsiType("HttpUrlReplacementBinding", "http://schemas.xmlsoap.org/wsdl/http/");
            }
            if (o.Required)
            {
                WriteAttribute("required", "http://schemas.xmlsoap.org/wsdl/", XmlConvert.ToString(o.Required));
            }
            WriteEndElement(o);
        }
    }

    private void Write86_SoapOperationBinding(string n, string ns, SoapOperationBinding o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(SoapOperationBinding)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType)
            {
                WriteXsiType("SoapOperationBinding", "http://schemas.xmlsoap.org/wsdl/soap/");
            }
            if (o.Required)
            {
                WriteAttribute("required", "http://schemas.xmlsoap.org/wsdl/", XmlConvert.ToString(o.Required));
            }
            WriteAttribute("soapAction", "", o.SoapAction);
            if (o.Style != 0)
            {
                WriteAttribute("style", "", Write79_SoapBindingStyle(o.Style));
            }
            WriteEndElement(o);
        }
    }

    private string Write79_SoapBindingStyle(SoapBindingStyle v)
    {
        string s = null;
        switch (v)
        {
            case SoapBindingStyle.Document:
                return "document";
            case SoapBindingStyle.Rpc:
                return "rpc";
            default:
                throw CreateInvalidEnumValueException(((long)v).ToString((IFormatProvider)CultureInfo.InvariantCulture), "System.Web.Services.Description.SoapBindingStyle");
        }
    }

    private void Write85_HttpOperationBinding(string n, string ns, HttpOperationBinding o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(HttpOperationBinding)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType)
            {
                WriteXsiType("HttpOperationBinding", "http://schemas.xmlsoap.org/wsdl/http/");
            }
            if (o.Required)
            {
                WriteAttribute("required", "http://schemas.xmlsoap.org/wsdl/", XmlConvert.ToString(o.Required));
            }
            WriteAttribute("location", "", o.Location);
            WriteEndElement(o);
        }
    }

    private void Write88_Soap12OperationBinding(string n, string ns, Soap12OperationBinding o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(Soap12OperationBinding)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType)
            {
                WriteXsiType("Soap12OperationBinding", "http://schemas.xmlsoap.org/wsdl/soap12/");
            }
            if (o.Required)
            {
                WriteAttribute("required", "http://schemas.xmlsoap.org/wsdl/", XmlConvert.ToString(o.Required));
            }
            WriteAttribute("soapAction", "", o.SoapAction);
            if (o.Style != 0)
            {
                WriteAttribute("style", "", Write82_SoapBindingStyle(o.Style));
            }
            if (o.SoapActionRequired)
            {
                WriteAttribute("soapActionRequired", "", XmlConvert.ToString(o.SoapActionRequired));
            }
            WriteEndElement(o);
        }
    }

    private string Write82_SoapBindingStyle(SoapBindingStyle v)
    {
        string s = null;
        switch (v)
        {
            case SoapBindingStyle.Document:
                return "document";
            case SoapBindingStyle.Rpc:
                return "rpc";
            default:
                throw CreateInvalidEnumValueException(((long)v).ToString((IFormatProvider)CultureInfo.InvariantCulture), "System.Web.Services.Description.SoapBindingStyle");
        }
    }

    private void Write80_SoapBinding(string n, string ns, SoapBinding o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(SoapBinding)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType)
            {
                WriteXsiType("SoapBinding", "http://schemas.xmlsoap.org/wsdl/soap/");
            }
            if (o.Required)
            {
                WriteAttribute("required", "http://schemas.xmlsoap.org/wsdl/", XmlConvert.ToString(o.Required));
            }
            WriteAttribute("transport", "", o.Transport);
            if (o.Style != SoapBindingStyle.Document)
            {
                WriteAttribute("style", "", Write79_SoapBindingStyle(o.Style));
            }
            WriteEndElement(o);
        }
    }

    private void Write77_HttpBinding(string n, string ns, HttpBinding o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(HttpBinding)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType)
            {
                WriteXsiType("HttpBinding", "http://schemas.xmlsoap.org/wsdl/http/");
            }
            if (o.Required)
            {
                WriteAttribute("required", "http://schemas.xmlsoap.org/wsdl/", XmlConvert.ToString(o.Required));
            }
            WriteAttribute("verb", "", o.Verb);
            WriteEndElement(o);
        }
    }

    private void Write84_Soap12Binding(string n, string ns, Soap12Binding o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(Soap12Binding)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType)
            {
                WriteXsiType("Soap12Binding", "http://schemas.xmlsoap.org/wsdl/soap12/");
            }
            if (o.Required)
            {
                WriteAttribute("required", "http://schemas.xmlsoap.org/wsdl/", XmlConvert.ToString(o.Required));
            }
            WriteAttribute("transport", "", o.Transport);
            if (o.Style != SoapBindingStyle.Document)
            {
                WriteAttribute("style", "", Write82_SoapBindingStyle(o.Style));
            }
            WriteEndElement(o);
        }
    }

    private void Write75_PortType(string n, string ns, PortType o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(PortType)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("PortType", "http://schemas.xmlsoap.org/wsdl/");
            }
            XmlAttribute[] a3 = o.ExtensibleAttributes;
            if (a3 != null)
            {
                foreach (XmlAttribute ai in a3)
                {
                    WriteXmlAttribute(ai, o);
                }
            }
            WriteAttribute("name", "", o.Name);
            if (o.DocumentationElement == null && o.DocumentationElement != null)
            {
                throw CreateInvalidAnyTypeException(o.DocumentationElement);
            }
            WriteElementLiteral(o.DocumentationElement, "documentation", "http://schemas.xmlsoap.org/wsdl/", false, true);
            ServiceDescriptionFormatExtensionCollection a2 = o.Extensions;
            if (a2 != null)
            {
                for (int ia2 = 0; ia2 < ((ICollection)a2).Count; ia2++)
                {
                    if (!(a2[ia2] is XmlNode) && a2[ia2] != null)
                    {
                        throw CreateInvalidAnyTypeException(a2[ia2]);
                    }
                    WriteElementLiteral((XmlNode)a2[ia2], "", null, false, true);
                }
            }
            OperationCollection a = o.Operations;
            if (a != null)
            {
                for (int ia = 0; ia < ((ICollection)a).Count; ia++)
                {
                    Write74_Operation("operation", "http://schemas.xmlsoap.org/wsdl/", a[ia], false, false);
                }
            }
            WriteEndElement(o);
        }
    }

    private void Write74_Operation(string n, string ns, Operation o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(Operation)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("Operation", "http://schemas.xmlsoap.org/wsdl/");
            }
            XmlAttribute[] a4 = o.ExtensibleAttributes;
            if (a4 != null)
            {
                foreach (XmlAttribute ai2 in a4)
                {
                    WriteXmlAttribute(ai2, o);
                }
            }
            WriteAttribute("name", "", o.Name);
            if (o.ParameterOrderString != null && o.ParameterOrderString.Length != 0)
            {
                WriteAttribute("parameterOrder", "", o.ParameterOrderString);
            }
            if (o.DocumentationElement == null && o.DocumentationElement != null)
            {
                throw CreateInvalidAnyTypeException(o.DocumentationElement);
            }
            WriteElementLiteral(o.DocumentationElement, "documentation", "http://schemas.xmlsoap.org/wsdl/", false, true);
            ServiceDescriptionFormatExtensionCollection a3 = o.Extensions;
            if (a3 != null)
            {
                for (int ia3 = 0; ia3 < ((ICollection)a3).Count; ia3++)
                {
                    if (!(a3[ia3] is XmlNode) && a3[ia3] != null)
                    {
                        throw CreateInvalidAnyTypeException(a3[ia3]);
                    }
                    WriteElementLiteral((XmlNode)a3[ia3], "", null, false, true);
                }
            }
            OperationMessageCollection a2 = o.Messages;
            if (a2 != null)
            {
                for (int ia2 = 0; ia2 < ((ICollection)a2).Count; ia2++)
                {
                    OperationMessage ai = a2[ia2];
                    if (ai is OperationOutput)
                    {
                        Write72_OperationOutput("output", "http://schemas.xmlsoap.org/wsdl/", (OperationOutput)ai, false, false);
                    }
                    else if (ai is OperationInput)
                    {
                        Write71_OperationInput("input", "http://schemas.xmlsoap.org/wsdl/", (OperationInput)ai, false, false);
                    }
                    else if (ai != null)
                    {
                        throw CreateUnknownTypeException(ai);
                    }
                }
            }
            OperationFaultCollection a = o.Faults;
            if (a != null)
            {
                for (int ia = 0; ia < ((ICollection)a).Count; ia++)
                {
                    Write73_OperationFault("fault", "http://schemas.xmlsoap.org/wsdl/", a[ia], false, false);
                }
            }
            WriteEndElement(o);
        }
    }

    private void Write73_OperationFault(string n, string ns, OperationFault o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(OperationFault)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("OperationFault", "http://schemas.xmlsoap.org/wsdl/");
            }
            XmlAttribute[] a2 = o.ExtensibleAttributes;
            if (a2 != null)
            {
                foreach (XmlAttribute ai in a2)
                {
                    WriteXmlAttribute(ai, o);
                }
            }
            WriteAttribute("name", "", o.Name);
            WriteAttribute("message", "", FromXmlQualifiedName(o.Message));
            if (o.DocumentationElement == null && o.DocumentationElement != null)
            {
                throw CreateInvalidAnyTypeException(o.DocumentationElement);
            }
            WriteElementLiteral(o.DocumentationElement, "documentation", "http://schemas.xmlsoap.org/wsdl/", false, true);
            ServiceDescriptionFormatExtensionCollection a = o.Extensions;
            if (a != null)
            {
                for (int ia = 0; ia < ((ICollection)a).Count; ia++)
                {
                    if (!(a[ia] is XmlNode) && a[ia] != null)
                    {
                        throw CreateInvalidAnyTypeException(a[ia]);
                    }
                    WriteElementLiteral((XmlNode)a[ia], "", null, false, true);
                }
            }
            WriteEndElement(o);
        }
    }

    private void Write71_OperationInput(string n, string ns, OperationInput o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(OperationInput)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("OperationInput", "http://schemas.xmlsoap.org/wsdl/");
            }
            XmlAttribute[] a2 = o.ExtensibleAttributes;
            if (a2 != null)
            {
                foreach (XmlAttribute ai in a2)
                {
                    WriteXmlAttribute(ai, o);
                }
            }
            WriteAttribute("name", "", o.Name);
            WriteAttribute("message", "", FromXmlQualifiedName(o.Message));
            if (o.DocumentationElement == null && o.DocumentationElement != null)
            {
                throw CreateInvalidAnyTypeException(o.DocumentationElement);
            }
            WriteElementLiteral(o.DocumentationElement, "documentation", "http://schemas.xmlsoap.org/wsdl/", false, true);
            ServiceDescriptionFormatExtensionCollection a = o.Extensions;
            if (a != null)
            {
                for (int ia = 0; ia < ((ICollection)a).Count; ia++)
                {
                    if (!(a[ia] is XmlNode) && a[ia] != null)
                    {
                        throw CreateInvalidAnyTypeException(a[ia]);
                    }
                    WriteElementLiteral((XmlNode)a[ia], "", null, false, true);
                }
            }
            WriteEndElement(o);
        }
    }

    private void Write72_OperationOutput(string n, string ns, OperationOutput o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(OperationOutput)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("OperationOutput", "http://schemas.xmlsoap.org/wsdl/");
            }
            XmlAttribute[] a2 = o.ExtensibleAttributes;
            if (a2 != null)
            {
                foreach (XmlAttribute ai in a2)
                {
                    WriteXmlAttribute(ai, o);
                }
            }
            WriteAttribute("name", "", o.Name);
            WriteAttribute("message", "", FromXmlQualifiedName(o.Message));
            if (o.DocumentationElement == null && o.DocumentationElement != null)
            {
                throw CreateInvalidAnyTypeException(o.DocumentationElement);
            }
            WriteElementLiteral(o.DocumentationElement, "documentation", "http://schemas.xmlsoap.org/wsdl/", false, true);
            ServiceDescriptionFormatExtensionCollection a = o.Extensions;
            if (a != null)
            {
                for (int ia = 0; ia < ((ICollection)a).Count; ia++)
                {
                    if (!(a[ia] is XmlNode) && a[ia] != null)
                    {
                        throw CreateInvalidAnyTypeException(a[ia]);
                    }
                    WriteElementLiteral((XmlNode)a[ia], "", null, false, true);
                }
            }
            WriteEndElement(o);
        }
    }

    private void Write69_Message(string n, string ns, Message o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(Message)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("Message", "http://schemas.xmlsoap.org/wsdl/");
            }
            XmlAttribute[] a3 = o.ExtensibleAttributes;
            if (a3 != null)
            {
                foreach (XmlAttribute ai in a3)
                {
                    WriteXmlAttribute(ai, o);
                }
            }
            WriteAttribute("name", "", o.Name);
            if (o.DocumentationElement == null && o.DocumentationElement != null)
            {
                throw CreateInvalidAnyTypeException(o.DocumentationElement);
            }
            WriteElementLiteral(o.DocumentationElement, "documentation", "http://schemas.xmlsoap.org/wsdl/", false, true);
            ServiceDescriptionFormatExtensionCollection a2 = o.Extensions;
            if (a2 != null)
            {
                for (int ia2 = 0; ia2 < ((ICollection)a2).Count; ia2++)
                {
                    if (!(a2[ia2] is XmlNode) && a2[ia2] != null)
                    {
                        throw CreateInvalidAnyTypeException(a2[ia2]);
                    }
                    WriteElementLiteral((XmlNode)a2[ia2], "", null, false, true);
                }
            }
            MessagePartCollection a = o.Parts;
            if (a != null)
            {
                for (int ia = 0; ia < ((ICollection)a).Count; ia++)
                {
                    Write68_MessagePart("part", "http://schemas.xmlsoap.org/wsdl/", a[ia], false, false);
                }
            }
            WriteEndElement(o);
        }
    }

    private void Write68_MessagePart(string n, string ns, MessagePart o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(MessagePart)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("MessagePart", "http://schemas.xmlsoap.org/wsdl/");
            }
            XmlAttribute[] a2 = o.ExtensibleAttributes;
            if (a2 != null)
            {
                foreach (XmlAttribute ai in a2)
                {
                    WriteXmlAttribute(ai, o);
                }
            }
            WriteAttribute("name", "", o.Name);
            WriteAttribute("element", "", FromXmlQualifiedName(o.Element));
            WriteAttribute("type", "", FromXmlQualifiedName(o.Type));
            if (o.DocumentationElement == null && o.DocumentationElement != null)
            {
                throw CreateInvalidAnyTypeException(o.DocumentationElement);
            }
            WriteElementLiteral(o.DocumentationElement, "documentation", "http://schemas.xmlsoap.org/wsdl/", false, true);
            ServiceDescriptionFormatExtensionCollection a = o.Extensions;
            if (a != null)
            {
                for (int ia = 0; ia < ((ICollection)a).Count; ia++)
                {
                    if (!(a[ia] is XmlNode) && a[ia] != null)
                    {
                        throw CreateInvalidAnyTypeException(a[ia]);
                    }
                    WriteElementLiteral((XmlNode)a[ia], "", null, false, true);
                }
            }
            WriteEndElement(o);
        }
    }

    private void Write67_Types(string n, string ns, Types o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(Types)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("Types", "http://schemas.xmlsoap.org/wsdl/");
            }
            XmlAttribute[] a3 = o.ExtensibleAttributes;
            if (a3 != null)
            {
                foreach (XmlAttribute ai in a3)
                {
                    WriteXmlAttribute(ai, o);
                }
            }
            if (o.DocumentationElement == null && o.DocumentationElement != null)
            {
                throw CreateInvalidAnyTypeException(o.DocumentationElement);
            }
            WriteElementLiteral(o.DocumentationElement, "documentation", "http://schemas.xmlsoap.org/wsdl/", false, true);
            ServiceDescriptionFormatExtensionCollection a2 = o.Extensions;
            if (a2 != null)
            {
                for (int ia2 = 0; ia2 < ((ICollection)a2).Count; ia2++)
                {
                    if (!(a2[ia2] is XmlNode) && a2[ia2] != null)
                    {
                        throw CreateInvalidAnyTypeException(a2[ia2]);
                    }
                    WriteElementLiteral((XmlNode)a2[ia2], "", null, false, true);
                }
            }
            XmlSchemas a = o.Schemas;
            if (a != null)
            {
                for (int ia = 0; ia < ((ICollection)a).Count; ia++)
                {
                    Write66_XmlSchema("schema", "http://www.w3.org/2001/XMLSchema", a[ia], false, false);
                }
            }
            WriteEndElement(o);
        }
    }

    private void Write66_XmlSchema(string n, string ns, XmlSchema o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(XmlSchema)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            base.EscapeName = false;
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("XmlSchema", "http://www.w3.org/2001/XMLSchema");
            }
            if (o.AttributeFormDefault != 0)
            {
                WriteAttribute("attributeFormDefault", "", Write6_XmlSchemaForm(o.AttributeFormDefault));
            }
            if (o.BlockDefault != XmlSchemaDerivationMethod.None)
            {
                WriteAttribute("blockDefault", "", Write7_XmlSchemaDerivationMethod(o.BlockDefault));
            }
            if (o.FinalDefault != XmlSchemaDerivationMethod.None)
            {
                WriteAttribute("finalDefault", "", Write7_XmlSchemaDerivationMethod(o.FinalDefault));
            }
            if (o.ElementFormDefault != 0)
            {
                WriteAttribute("elementFormDefault", "", Write6_XmlSchemaForm(o.ElementFormDefault));
            }
            WriteAttribute("targetNamespace", "", o.TargetNamespace);
            WriteAttribute("version", "", o.Version);
            WriteAttribute("id", "", o.Id);
            XmlAttribute[] a3 = o.UnhandledAttributes;
            if (a3 != null)
            {
                foreach (XmlAttribute ai3 in a3)
                {
                    WriteXmlAttribute(ai3, o);
                }
            }
            XmlSchemaObjectCollection a2 = o.Includes;
            if (a2 != null)
            {
                for (int ia2 = 0; ia2 < ((ICollection)a2).Count; ia2++)
                {
                    XmlSchemaObject ai2 = a2[ia2];
                    if (ai2 is XmlSchemaRedefine)
                    {
                        Write64_XmlSchemaRedefine("redefine", "http://www.w3.org/2001/XMLSchema", (XmlSchemaRedefine)ai2, false, false);
                    }
                    else if (ai2 is XmlSchemaImport)
                    {
                        Write13_XmlSchemaImport("import", "http://www.w3.org/2001/XMLSchema", (XmlSchemaImport)ai2, false, false);
                    }
                    else if (ai2 is XmlSchemaInclude)
                    {
                        Write12_XmlSchemaInclude("include", "http://www.w3.org/2001/XMLSchema", (XmlSchemaInclude)ai2, false, false);
                    }
                    else if (ai2 != null)
                    {
                        throw CreateUnknownTypeException(ai2);
                    }
                }
            }
            XmlSchemaObjectCollection a = o.Items;
            if (a != null)
            {
                for (int ia = 0; ia < ((ICollection)a).Count; ia++)
                {
                    XmlSchemaObject ai = a[ia];
                    if (ai is XmlSchemaElement)
                    {
                        Write52_XmlSchemaElement("element", "http://www.w3.org/2001/XMLSchema", (XmlSchemaElement)ai, false, false);
                    }
                    else if (ai is XmlSchemaComplexType)
                    {
                        Write62_XmlSchemaComplexType("complexType", "http://www.w3.org/2001/XMLSchema", (XmlSchemaComplexType)ai, false, false);
                    }
                    else if (ai is XmlSchemaSimpleType)
                    {
                        Write34_XmlSchemaSimpleType("simpleType", "http://www.w3.org/2001/XMLSchema", (XmlSchemaSimpleType)ai, false, false);
                    }
                    else if (ai is XmlSchemaAttribute)
                    {
                        Write36_XmlSchemaAttribute("attribute", "http://www.w3.org/2001/XMLSchema", (XmlSchemaAttribute)ai, false, false);
                    }
                    else if (ai is XmlSchemaAttributeGroup)
                    {
                        Write40_XmlSchemaAttributeGroup("attributeGroup", "http://www.w3.org/2001/XMLSchema", (XmlSchemaAttributeGroup)ai, false, false);
                    }
                    else if (ai is XmlSchemaNotation)
                    {
                        Write65_XmlSchemaNotation("notation", "http://www.w3.org/2001/XMLSchema", (XmlSchemaNotation)ai, false, false);
                    }
                    else if (ai is XmlSchemaGroup)
                    {
                        Write63_XmlSchemaGroup("group", "http://www.w3.org/2001/XMLSchema", (XmlSchemaGroup)ai, false, false);
                    }
                    else if (ai is XmlSchemaAnnotation)
                    {
                        Write11_XmlSchemaAnnotation("annotation", "http://www.w3.org/2001/XMLSchema", (XmlSchemaAnnotation)ai, false, false);
                    }
                    else if (ai != null)
                    {
                        throw CreateUnknownTypeException(ai);
                    }
                }
            }
            WriteEndElement(o);
        }
    }

    private void Write11_XmlSchemaAnnotation(string n, string ns, XmlSchemaAnnotation o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(XmlSchemaAnnotation)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            base.EscapeName = false;
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("XmlSchemaAnnotation", "http://www.w3.org/2001/XMLSchema");
            }
            WriteAttribute("id", "", o.Id);
            XmlAttribute[] a2 = o.UnhandledAttributes;
            if (a2 != null)
            {
                foreach (XmlAttribute ai2 in a2)
                {
                    WriteXmlAttribute(ai2, o);
                }
            }
            XmlSchemaObjectCollection a = o.Items;
            if (a != null)
            {
                for (int ia = 0; ia < ((ICollection)a).Count; ia++)
                {
                    XmlSchemaObject ai = a[ia];
                    if (ai is XmlSchemaAppInfo)
                    {
                        Write10_XmlSchemaAppInfo("appinfo", "http://www.w3.org/2001/XMLSchema", (XmlSchemaAppInfo)ai, false, false);
                    }
                    else if (ai is XmlSchemaDocumentation)
                    {
                        Write9_XmlSchemaDocumentation("documentation", "http://www.w3.org/2001/XMLSchema", (XmlSchemaDocumentation)ai, false, false);
                    }
                    else if (ai != null)
                    {
                        throw CreateUnknownTypeException(ai);
                    }
                }
            }
            WriteEndElement(o);
        }
    }

    private void Write9_XmlSchemaDocumentation(string n, string ns, XmlSchemaDocumentation o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(XmlSchemaDocumentation)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            base.EscapeName = false;
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("XmlSchemaDocumentation", "http://www.w3.org/2001/XMLSchema");
            }
            WriteAttribute("source", "", o.Source);
            WriteAttribute("lang", "http://www.w3.org/XML/1998/namespace", o.Language);
            XmlNode[] a = o.Markup;
            if (a != null)
            {
                foreach (XmlNode ai in a)
                {
                    if (ai is XmlElement)
                    {
                        XmlElement elem = (XmlElement)ai;
                        if (elem == null && elem != null)
                        {
                            throw CreateInvalidAnyTypeException(elem);
                        }
                        WriteElementLiteral(elem, "", null, false, true);
                    }
                    else if (ai != null)
                    {
                        ai.WriteTo(base.Writer);
                    }
                    else if (ai != null)
                    {
                        throw CreateUnknownTypeException(ai);
                    }
                }
            }
            WriteEndElement(o);
        }
    }

    private void Write10_XmlSchemaAppInfo(string n, string ns, XmlSchemaAppInfo o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(XmlSchemaAppInfo)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            base.EscapeName = false;
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("XmlSchemaAppInfo", "http://www.w3.org/2001/XMLSchema");
            }
            WriteAttribute("source", "", o.Source);
            XmlNode[] a = o.Markup;
            if (a != null)
            {
                foreach (XmlNode ai in a)
                {
                    if (ai is XmlElement)
                    {
                        XmlElement elem = (XmlElement)ai;
                        if (elem == null && elem != null)
                        {
                            throw CreateInvalidAnyTypeException(elem);
                        }
                        WriteElementLiteral(elem, "", null, false, true);
                    }
                    else if (ai != null)
                    {
                        ai.WriteTo(base.Writer);
                    }
                    else if (ai != null)
                    {
                        throw CreateUnknownTypeException(ai);
                    }
                }
            }
            WriteEndElement(o);
        }
    }

    private void Write63_XmlSchemaGroup(string n, string ns, XmlSchemaGroup o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(XmlSchemaGroup)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            base.EscapeName = false;
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("XmlSchemaGroup", "http://www.w3.org/2001/XMLSchema");
            }
            WriteAttribute("id", "", o.Id);
            XmlAttribute[] a = o.UnhandledAttributes;
            if (a != null)
            {
                foreach (XmlAttribute ai in a)
                {
                    WriteXmlAttribute(ai, o);
                }
            }
            WriteAttribute("name", "", o.Name);
            Write11_XmlSchemaAnnotation("annotation", "http://www.w3.org/2001/XMLSchema", o.Annotation, false, false);
            if (o.Particle is XmlSchemaAll)
            {
                Write55_XmlSchemaAll("all", "http://www.w3.org/2001/XMLSchema", (XmlSchemaAll)o.Particle, false, false);
            }
            else if (o.Particle is XmlSchemaChoice)
            {
                Write54_XmlSchemaChoice("choice", "http://www.w3.org/2001/XMLSchema", (XmlSchemaChoice)o.Particle, false, false);
            }
            else if (o.Particle is XmlSchemaSequence)
            {
                Write53_XmlSchemaSequence("sequence", "http://www.w3.org/2001/XMLSchema", (XmlSchemaSequence)o.Particle, false, false);
            }
            else if (o.Particle != null)
            {
                throw CreateUnknownTypeException(o.Particle);
            }
            WriteEndElement(o);
        }
    }

    private void Write53_XmlSchemaSequence(string n, string ns, XmlSchemaSequence o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(XmlSchemaSequence)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            base.EscapeName = false;
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("XmlSchemaSequence", "http://www.w3.org/2001/XMLSchema");
            }
            WriteAttribute("id", "", o.Id);
            XmlAttribute[] a2 = o.UnhandledAttributes;
            if (a2 != null)
            {
                foreach (XmlAttribute ai2 in a2)
                {
                    WriteXmlAttribute(ai2, o);
                }
            }
            WriteAttribute("minOccurs", "", o.MinOccursString);
            WriteAttribute("maxOccurs", "", o.MaxOccursString);
            Write11_XmlSchemaAnnotation("annotation", "http://www.w3.org/2001/XMLSchema", o.Annotation, false, false);
            XmlSchemaObjectCollection a = o.Items;
            if (a != null)
            {
                for (int ia = 0; ia < ((ICollection)a).Count; ia++)
                {
                    XmlSchemaObject ai = a[ia];
                    if (ai is XmlSchemaChoice)
                    {
                        Write54_XmlSchemaChoice("choice", "http://www.w3.org/2001/XMLSchema", (XmlSchemaChoice)ai, false, false);
                    }
                    else if (ai is XmlSchemaSequence)
                    {
                        Write53_XmlSchemaSequence("sequence", "http://www.w3.org/2001/XMLSchema", (XmlSchemaSequence)ai, false, false);
                    }
                    else if (ai is XmlSchemaGroupRef)
                    {
                        Write44_XmlSchemaGroupRef("group", "http://www.w3.org/2001/XMLSchema", (XmlSchemaGroupRef)ai, false, false);
                    }
                    else if (ai is XmlSchemaElement)
                    {
                        Write52_XmlSchemaElement("element", "http://www.w3.org/2001/XMLSchema", (XmlSchemaElement)ai, false, false);
                    }
                    else if (ai is XmlSchemaAny)
                    {
                        Write46_XmlSchemaAny("any", "http://www.w3.org/2001/XMLSchema", (XmlSchemaAny)ai, false, false);
                    }
                    else if (ai != null)
                    {
                        throw CreateUnknownTypeException(ai);
                    }
                }
            }
            WriteEndElement(o);
        }
    }

    private void Write46_XmlSchemaAny(string n, string ns, XmlSchemaAny o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(XmlSchemaAny)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            base.EscapeName = false;
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("XmlSchemaAny", "http://www.w3.org/2001/XMLSchema");
            }
            WriteAttribute("id", "", o.Id);
            XmlAttribute[] a = o.UnhandledAttributes;
            if (a != null)
            {
                foreach (XmlAttribute ai in a)
                {
                    WriteXmlAttribute(ai, o);
                }
            }
            WriteAttribute("minOccurs", "", o.MinOccursString);
            WriteAttribute("maxOccurs", "", o.MaxOccursString);
            WriteAttribute("namespace", "", o.Namespace);
            if (o.ProcessContents != 0)
            {
                WriteAttribute("processContents", "", Write38_XmlSchemaContentProcessing(o.ProcessContents));
            }
            Write11_XmlSchemaAnnotation("annotation", "http://www.w3.org/2001/XMLSchema", o.Annotation, false, false);
            WriteEndElement(o);
        }
    }

    private string Write38_XmlSchemaContentProcessing(XmlSchemaContentProcessing v)
    {
        string s = null;
        switch (v)
        {
            case XmlSchemaContentProcessing.Skip:
                return "skip";
            case XmlSchemaContentProcessing.Lax:
                return "lax";
            case XmlSchemaContentProcessing.Strict:
                return "strict";
            default:
                throw CreateInvalidEnumValueException(((long)v).ToString((IFormatProvider)CultureInfo.InvariantCulture), "System.Xml.Schema.XmlSchemaContentProcessing");
        }
    }

    private void Write52_XmlSchemaElement(string n, string ns, XmlSchemaElement o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(XmlSchemaElement)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            base.EscapeName = false;
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("XmlSchemaElement", "http://www.w3.org/2001/XMLSchema");
            }
            WriteAttribute("id", "", o.Id);
            XmlAttribute[] a2 = o.UnhandledAttributes;
            if (a2 != null)
            {
                foreach (XmlAttribute ai2 in a2)
                {
                    WriteXmlAttribute(ai2, o);
                }
            }
            WriteAttribute("minOccurs", "", o.MinOccursString);
            WriteAttribute("maxOccurs", "", o.MaxOccursString);
            if (o.IsAbstract)
            {
                WriteAttribute("abstract", "", XmlConvert.ToString(o.IsAbstract));
            }
            if (o.Block != XmlSchemaDerivationMethod.None)
            {
                WriteAttribute("block", "", Write7_XmlSchemaDerivationMethod(o.Block));
            }
            WriteAttribute("default", "", o.DefaultValue);
            if (o.Final != XmlSchemaDerivationMethod.None)
            {
                WriteAttribute("final", "", Write7_XmlSchemaDerivationMethod(o.Final));
            }
            WriteAttribute("fixed", "", o.FixedValue);
            if (o.Form != 0)
            {
                WriteAttribute("form", "", Write6_XmlSchemaForm(o.Form));
            }
            if (o.Name != null && o.Name.Length != 0)
            {
                WriteAttribute("name", "", o.Name);
            }
            if (o.IsNillable)
            {
                WriteAttribute("nillable", "", XmlConvert.ToString(o.IsNillable));
            }
            WriteAttribute("ref", "", FromXmlQualifiedName(o.RefName));
            WriteAttribute("substitutionGroup", "", FromXmlQualifiedName(o.SubstitutionGroup));
            WriteAttribute("type", "", FromXmlQualifiedName(o.SchemaTypeName));
            Write11_XmlSchemaAnnotation("annotation", "http://www.w3.org/2001/XMLSchema", o.Annotation, false, false);
            if (o.SchemaType is XmlSchemaComplexType)
            {
                Write62_XmlSchemaComplexType("complexType", "http://www.w3.org/2001/XMLSchema", (XmlSchemaComplexType)o.SchemaType, false, false);
            }
            else if (o.SchemaType is XmlSchemaSimpleType)
            {
                Write34_XmlSchemaSimpleType("simpleType", "http://www.w3.org/2001/XMLSchema", (XmlSchemaSimpleType)o.SchemaType, false, false);
            }
            else if (o.SchemaType != null)
            {
                throw CreateUnknownTypeException(o.SchemaType);
            }
            XmlSchemaObjectCollection a = o.Constraints;
            if (a != null)
            {
                for (int ia = 0; ia < ((ICollection)a).Count; ia++)
                {
                    XmlSchemaObject ai = a[ia];
                    if (ai is XmlSchemaKeyref)
                    {
                        Write51_XmlSchemaKeyref("keyref", "http://www.w3.org/2001/XMLSchema", (XmlSchemaKeyref)ai, false, false);
                    }
                    else if (ai is XmlSchemaUnique)
                    {
                        Write50_XmlSchemaUnique("unique", "http://www.w3.org/2001/XMLSchema", (XmlSchemaUnique)ai, false, false);
                    }
                    else if (ai is XmlSchemaKey)
                    {
                        Write49_XmlSchemaKey("key", "http://www.w3.org/2001/XMLSchema", (XmlSchemaKey)ai, false, false);
                    }
                    else if (ai != null)
                    {
                        throw CreateUnknownTypeException(ai);
                    }
                }
            }
            WriteEndElement(o);
        }
    }

    private void Write49_XmlSchemaKey(string n, string ns, XmlSchemaKey o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(XmlSchemaKey)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            base.EscapeName = false;
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("XmlSchemaKey", "http://www.w3.org/2001/XMLSchema");
            }
            WriteAttribute("id", "", o.Id);
            XmlAttribute[] a2 = o.UnhandledAttributes;
            if (a2 != null)
            {
                foreach (XmlAttribute ai in a2)
                {
                    WriteXmlAttribute(ai, o);
                }
            }
            WriteAttribute("name", "", o.Name);
            Write11_XmlSchemaAnnotation("annotation", "http://www.w3.org/2001/XMLSchema", o.Annotation, false, false);
            Write47_XmlSchemaXPath("selector", "http://www.w3.org/2001/XMLSchema", o.Selector, false, false);
            XmlSchemaObjectCollection a = o.Fields;
            if (a != null)
            {
                for (int ia = 0; ia < ((ICollection)a).Count; ia++)
                {
                    Write47_XmlSchemaXPath("field", "http://www.w3.org/2001/XMLSchema", (XmlSchemaXPath)a[ia], false, false);
                }
            }
            WriteEndElement(o);
        }
    }

    private void Write47_XmlSchemaXPath(string n, string ns, XmlSchemaXPath o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(XmlSchemaXPath)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            base.EscapeName = false;
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("XmlSchemaXPath", "http://www.w3.org/2001/XMLSchema");
            }
            WriteAttribute("id", "", o.Id);
            XmlAttribute[] a = o.UnhandledAttributes;
            if (a != null)
            {
                foreach (XmlAttribute ai in a)
                {
                    WriteXmlAttribute(ai, o);
                }
            }
            if (o.XPath != null && o.XPath.Length != 0)
            {
                WriteAttribute("xpath", "", o.XPath);
            }
            Write11_XmlSchemaAnnotation("annotation", "http://www.w3.org/2001/XMLSchema", o.Annotation, false, false);
            WriteEndElement(o);
        }
    }

    private void Write50_XmlSchemaUnique(string n, string ns, XmlSchemaUnique o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(XmlSchemaUnique)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            base.EscapeName = false;
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("XmlSchemaUnique", "http://www.w3.org/2001/XMLSchema");
            }
            WriteAttribute("id", "", o.Id);
            XmlAttribute[] a2 = o.UnhandledAttributes;
            if (a2 != null)
            {
                foreach (XmlAttribute ai in a2)
                {
                    WriteXmlAttribute(ai, o);
                }
            }
            WriteAttribute("name", "", o.Name);
            Write11_XmlSchemaAnnotation("annotation", "http://www.w3.org/2001/XMLSchema", o.Annotation, false, false);
            Write47_XmlSchemaXPath("selector", "http://www.w3.org/2001/XMLSchema", o.Selector, false, false);
            XmlSchemaObjectCollection a = o.Fields;
            if (a != null)
            {
                for (int ia = 0; ia < ((ICollection)a).Count; ia++)
                {
                    Write47_XmlSchemaXPath("field", "http://www.w3.org/2001/XMLSchema", (XmlSchemaXPath)a[ia], false, false);
                }
            }
            WriteEndElement(o);
        }
    }

    private void Write51_XmlSchemaKeyref(string n, string ns, XmlSchemaKeyref o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(XmlSchemaKeyref)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            base.EscapeName = false;
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("XmlSchemaKeyref", "http://www.w3.org/2001/XMLSchema");
            }
            WriteAttribute("id", "", o.Id);
            XmlAttribute[] a2 = o.UnhandledAttributes;
            if (a2 != null)
            {
                foreach (XmlAttribute ai in a2)
                {
                    WriteXmlAttribute(ai, o);
                }
            }
            WriteAttribute("name", "", o.Name);
            WriteAttribute("refer", "", FromXmlQualifiedName(o.Refer));
            Write11_XmlSchemaAnnotation("annotation", "http://www.w3.org/2001/XMLSchema", o.Annotation, false, false);
            Write47_XmlSchemaXPath("selector", "http://www.w3.org/2001/XMLSchema", o.Selector, false, false);
            XmlSchemaObjectCollection a = o.Fields;
            if (a != null)
            {
                for (int ia = 0; ia < ((ICollection)a).Count; ia++)
                {
                    Write47_XmlSchemaXPath("field", "http://www.w3.org/2001/XMLSchema", (XmlSchemaXPath)a[ia], false, false);
                }
            }
            WriteEndElement(o);
        }
    }

    private void Write34_XmlSchemaSimpleType(string n, string ns, XmlSchemaSimpleType o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(XmlSchemaSimpleType)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            base.EscapeName = false;
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("XmlSchemaSimpleType", "http://www.w3.org/2001/XMLSchema");
            }
            WriteAttribute("id", "", o.Id);
            XmlAttribute[] a = o.UnhandledAttributes;
            if (a != null)
            {
                foreach (XmlAttribute ai in a)
                {
                    WriteXmlAttribute(ai, o);
                }
            }
            WriteAttribute("name", "", o.Name);
            if (o.Final != XmlSchemaDerivationMethod.None)
            {
                WriteAttribute("final", "", Write7_XmlSchemaDerivationMethod(o.Final));
            }
            Write11_XmlSchemaAnnotation("annotation", "http://www.w3.org/2001/XMLSchema", o.Annotation, false, false);
            if (o.Content is XmlSchemaSimpleTypeUnion)
            {
                Write33_XmlSchemaSimpleTypeUnion("union", "http://www.w3.org/2001/XMLSchema", (XmlSchemaSimpleTypeUnion)o.Content, false, false);
            }
            else if (o.Content is XmlSchemaSimpleTypeRestriction)
            {
                Write32_XmlSchemaSimpleTypeRestriction("restriction", "http://www.w3.org/2001/XMLSchema", (XmlSchemaSimpleTypeRestriction)o.Content, false, false);
            }
            else if (o.Content is XmlSchemaSimpleTypeList)
            {
                Write17_XmlSchemaSimpleTypeList("list", "http://www.w3.org/2001/XMLSchema", (XmlSchemaSimpleTypeList)o.Content, false, false);
            }
            else if (o.Content != null)
            {
                throw CreateUnknownTypeException(o.Content);
            }
            WriteEndElement(o);
        }
    }

    private void Write17_XmlSchemaSimpleTypeList(string n, string ns, XmlSchemaSimpleTypeList o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(XmlSchemaSimpleTypeList)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            base.EscapeName = false;
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("XmlSchemaSimpleTypeList", "http://www.w3.org/2001/XMLSchema");
            }
            WriteAttribute("id", "", o.Id);
            XmlAttribute[] a = o.UnhandledAttributes;
            if (a != null)
            {
                foreach (XmlAttribute ai in a)
                {
                    WriteXmlAttribute(ai, o);
                }
            }
            WriteAttribute("itemType", "", FromXmlQualifiedName(o.ItemTypeName));
            Write11_XmlSchemaAnnotation("annotation", "http://www.w3.org/2001/XMLSchema", o.Annotation, false, false);
            Write34_XmlSchemaSimpleType("simpleType", "http://www.w3.org/2001/XMLSchema", o.ItemType, false, false);
            WriteEndElement(o);
        }
    }

    private void Write32_XmlSchemaSimpleTypeRestriction(string n, string ns, XmlSchemaSimpleTypeRestriction o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(XmlSchemaSimpleTypeRestriction)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            base.EscapeName = false;
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("XmlSchemaSimpleTypeRestriction", "http://www.w3.org/2001/XMLSchema");
            }
            WriteAttribute("id", "", o.Id);
            XmlAttribute[] a2 = o.UnhandledAttributes;
            if (a2 != null)
            {
                foreach (XmlAttribute ai2 in a2)
                {
                    WriteXmlAttribute(ai2, o);
                }
            }
            WriteAttribute("base", "", FromXmlQualifiedName(o.BaseTypeName));
            Write11_XmlSchemaAnnotation("annotation", "http://www.w3.org/2001/XMLSchema", o.Annotation, false, false);
            Write34_XmlSchemaSimpleType("simpleType", "http://www.w3.org/2001/XMLSchema", o.BaseType, false, false);
            XmlSchemaObjectCollection a = o.Facets;
            if (a != null)
            {
                for (int ia = 0; ia < ((ICollection)a).Count; ia++)
                {
                    XmlSchemaObject ai = a[ia];
                    if (ai is XmlSchemaLengthFacet)
                    {
                        Write23_XmlSchemaLengthFacet("length", "http://www.w3.org/2001/XMLSchema", (XmlSchemaLengthFacet)ai, false, false);
                    }
                    else if (ai is XmlSchemaTotalDigitsFacet)
                    {
                        Write24_XmlSchemaTotalDigitsFacet("totalDigits", "http://www.w3.org/2001/XMLSchema", (XmlSchemaTotalDigitsFacet)ai, false, false);
                    }
                    else if (ai is XmlSchemaMaxLengthFacet)
                    {
                        Write22_XmlSchemaMaxLengthFacet("maxLength", "http://www.w3.org/2001/XMLSchema", (XmlSchemaMaxLengthFacet)ai, false, false);
                    }
                    else if (ai is XmlSchemaFractionDigitsFacet)
                    {
                        Write20_XmlSchemaFractionDigitsFacet("fractionDigits", "http://www.w3.org/2001/XMLSchema", (XmlSchemaFractionDigitsFacet)ai, false, false);
                    }
                    else if (ai is XmlSchemaMinLengthFacet)
                    {
                        Write31_XmlSchemaMinLengthFacet("minLength", "http://www.w3.org/2001/XMLSchema", (XmlSchemaMinLengthFacet)ai, false, false);
                    }
                    else if (ai is XmlSchemaMaxExclusiveFacet)
                    {
                        Write28_XmlSchemaMaxExclusiveFacet("maxExclusive", "http://www.w3.org/2001/XMLSchema", (XmlSchemaMaxExclusiveFacet)ai, false, false);
                    }
                    else if (ai is XmlSchemaWhiteSpaceFacet)
                    {
                        Write29_XmlSchemaWhiteSpaceFacet("whiteSpace", "http://www.w3.org/2001/XMLSchema", (XmlSchemaWhiteSpaceFacet)ai, false, false);
                    }
                    else if (ai is XmlSchemaMinExclusiveFacet)
                    {
                        Write30_XmlSchemaMinExclusiveFacet("minExclusive", "http://www.w3.org/2001/XMLSchema", (XmlSchemaMinExclusiveFacet)ai, false, false);
                    }
                    else if (ai is XmlSchemaPatternFacet)
                    {
                        Write25_XmlSchemaPatternFacet("pattern", "http://www.w3.org/2001/XMLSchema", (XmlSchemaPatternFacet)ai, false, false);
                    }
                    else if (ai is XmlSchemaMinInclusiveFacet)
                    {
                        Write21_XmlSchemaMinInclusiveFacet("minInclusive", "http://www.w3.org/2001/XMLSchema", (XmlSchemaMinInclusiveFacet)ai, false, false);
                    }
                    else if (ai is XmlSchemaMaxInclusiveFacet)
                    {
                        Write27_XmlSchemaMaxInclusiveFacet("maxInclusive", "http://www.w3.org/2001/XMLSchema", (XmlSchemaMaxInclusiveFacet)ai, false, false);
                    }
                    else if (ai is XmlSchemaEnumerationFacet)
                    {
                        Write26_XmlSchemaEnumerationFacet("enumeration", "http://www.w3.org/2001/XMLSchema", (XmlSchemaEnumerationFacet)ai, false, false);
                    }
                    else if (ai != null)
                    {
                        throw CreateUnknownTypeException(ai);
                    }
                }
            }
            WriteEndElement(o);
        }
    }

    private void Write26_XmlSchemaEnumerationFacet(string n, string ns, XmlSchemaEnumerationFacet o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(XmlSchemaEnumerationFacet)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            base.EscapeName = false;
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("XmlSchemaEnumerationFacet", "http://www.w3.org/2001/XMLSchema");
            }
            WriteAttribute("id", "", o.Id);
            XmlAttribute[] a = o.UnhandledAttributes;
            if (a != null)
            {
                foreach (XmlAttribute ai in a)
                {
                    WriteXmlAttribute(ai, o);
                }
            }
            WriteAttribute("value", "", o.Value);
            if (o.IsFixed)
            {
                WriteAttribute("fixed", "", XmlConvert.ToString(o.IsFixed));
            }
            Write11_XmlSchemaAnnotation("annotation", "http://www.w3.org/2001/XMLSchema", o.Annotation, false, false);
            WriteEndElement(o);
        }
    }

    private void Write27_XmlSchemaMaxInclusiveFacet(string n, string ns, XmlSchemaMaxInclusiveFacet o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(XmlSchemaMaxInclusiveFacet)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            base.EscapeName = false;
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("XmlSchemaMaxInclusiveFacet", "http://www.w3.org/2001/XMLSchema");
            }
            WriteAttribute("id", "", o.Id);
            XmlAttribute[] a = o.UnhandledAttributes;
            if (a != null)
            {
                foreach (XmlAttribute ai in a)
                {
                    WriteXmlAttribute(ai, o);
                }
            }
            WriteAttribute("value", "", o.Value);
            if (o.IsFixed)
            {
                WriteAttribute("fixed", "", XmlConvert.ToString(o.IsFixed));
            }
            Write11_XmlSchemaAnnotation("annotation", "http://www.w3.org/2001/XMLSchema", o.Annotation, false, false);
            WriteEndElement(o);
        }
    }

    private void Write21_XmlSchemaMinInclusiveFacet(string n, string ns, XmlSchemaMinInclusiveFacet o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(XmlSchemaMinInclusiveFacet)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            base.EscapeName = false;
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("XmlSchemaMinInclusiveFacet", "http://www.w3.org/2001/XMLSchema");
            }
            WriteAttribute("id", "", o.Id);
            XmlAttribute[] a = o.UnhandledAttributes;
            if (a != null)
            {
                foreach (XmlAttribute ai in a)
                {
                    WriteXmlAttribute(ai, o);
                }
            }
            WriteAttribute("value", "", o.Value);
            if (o.IsFixed)
            {
                WriteAttribute("fixed", "", XmlConvert.ToString(o.IsFixed));
            }
            Write11_XmlSchemaAnnotation("annotation", "http://www.w3.org/2001/XMLSchema", o.Annotation, false, false);
            WriteEndElement(o);
        }
    }

    private void Write25_XmlSchemaPatternFacet(string n, string ns, XmlSchemaPatternFacet o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(XmlSchemaPatternFacet)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            base.EscapeName = false;
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("XmlSchemaPatternFacet", "http://www.w3.org/2001/XMLSchema");
            }
            WriteAttribute("id", "", o.Id);
            XmlAttribute[] a = o.UnhandledAttributes;
            if (a != null)
            {
                foreach (XmlAttribute ai in a)
                {
                    WriteXmlAttribute(ai, o);
                }
            }
            WriteAttribute("value", "", o.Value);
            if (o.IsFixed)
            {
                WriteAttribute("fixed", "", XmlConvert.ToString(o.IsFixed));
            }
            Write11_XmlSchemaAnnotation("annotation", "http://www.w3.org/2001/XMLSchema", o.Annotation, false, false);
            WriteEndElement(o);
        }
    }

    private void Write30_XmlSchemaMinExclusiveFacet(string n, string ns, XmlSchemaMinExclusiveFacet o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(XmlSchemaMinExclusiveFacet)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            base.EscapeName = false;
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("XmlSchemaMinExclusiveFacet", "http://www.w3.org/2001/XMLSchema");
            }
            WriteAttribute("id", "", o.Id);
            XmlAttribute[] a = o.UnhandledAttributes;
            if (a != null)
            {
                foreach (XmlAttribute ai in a)
                {
                    WriteXmlAttribute(ai, o);
                }
            }
            WriteAttribute("value", "", o.Value);
            if (o.IsFixed)
            {
                WriteAttribute("fixed", "", XmlConvert.ToString(o.IsFixed));
            }
            Write11_XmlSchemaAnnotation("annotation", "http://www.w3.org/2001/XMLSchema", o.Annotation, false, false);
            WriteEndElement(o);
        }
    }

    private void Write29_XmlSchemaWhiteSpaceFacet(string n, string ns, XmlSchemaWhiteSpaceFacet o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(XmlSchemaWhiteSpaceFacet)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            base.EscapeName = false;
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("XmlSchemaWhiteSpaceFacet", "http://www.w3.org/2001/XMLSchema");
            }
            WriteAttribute("id", "", o.Id);
            XmlAttribute[] a = o.UnhandledAttributes;
            if (a != null)
            {
                foreach (XmlAttribute ai in a)
                {
                    WriteXmlAttribute(ai, o);
                }
            }
            WriteAttribute("value", "", o.Value);
            if (o.IsFixed)
            {
                WriteAttribute("fixed", "", XmlConvert.ToString(o.IsFixed));
            }
            Write11_XmlSchemaAnnotation("annotation", "http://www.w3.org/2001/XMLSchema", o.Annotation, false, false);
            WriteEndElement(o);
        }
    }

    private void Write28_XmlSchemaMaxExclusiveFacet(string n, string ns, XmlSchemaMaxExclusiveFacet o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(XmlSchemaMaxExclusiveFacet)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            base.EscapeName = false;
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("XmlSchemaMaxExclusiveFacet", "http://www.w3.org/2001/XMLSchema");
            }
            WriteAttribute("id", "", o.Id);
            XmlAttribute[] a = o.UnhandledAttributes;
            if (a != null)
            {
                foreach (XmlAttribute ai in a)
                {
                    WriteXmlAttribute(ai, o);
                }
            }
            WriteAttribute("value", "", o.Value);
            if (o.IsFixed)
            {
                WriteAttribute("fixed", "", XmlConvert.ToString(o.IsFixed));
            }
            Write11_XmlSchemaAnnotation("annotation", "http://www.w3.org/2001/XMLSchema", o.Annotation, false, false);
            WriteEndElement(o);
        }
    }

    private void Write31_XmlSchemaMinLengthFacet(string n, string ns, XmlSchemaMinLengthFacet o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(XmlSchemaMinLengthFacet)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            base.EscapeName = false;
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("XmlSchemaMinLengthFacet", "http://www.w3.org/2001/XMLSchema");
            }
            WriteAttribute("id", "", o.Id);
            XmlAttribute[] a = o.UnhandledAttributes;
            if (a != null)
            {
                foreach (XmlAttribute ai in a)
                {
                    WriteXmlAttribute(ai, o);
                }
            }
            WriteAttribute("value", "", o.Value);
            if (o.IsFixed)
            {
                WriteAttribute("fixed", "", XmlConvert.ToString(o.IsFixed));
            }
            Write11_XmlSchemaAnnotation("annotation", "http://www.w3.org/2001/XMLSchema", o.Annotation, false, false);
            WriteEndElement(o);
        }
    }

    private void Write20_XmlSchemaFractionDigitsFacet(string n, string ns, XmlSchemaFractionDigitsFacet o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(XmlSchemaFractionDigitsFacet)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            base.EscapeName = false;
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("XmlSchemaFractionDigitsFacet", "http://www.w3.org/2001/XMLSchema");
            }
            WriteAttribute("id", "", o.Id);
            XmlAttribute[] a = o.UnhandledAttributes;
            if (a != null)
            {
                foreach (XmlAttribute ai in a)
                {
                    WriteXmlAttribute(ai, o);
                }
            }
            WriteAttribute("value", "", o.Value);
            if (o.IsFixed)
            {
                WriteAttribute("fixed", "", XmlConvert.ToString(o.IsFixed));
            }
            Write11_XmlSchemaAnnotation("annotation", "http://www.w3.org/2001/XMLSchema", o.Annotation, false, false);
            WriteEndElement(o);
        }
    }

    private void Write22_XmlSchemaMaxLengthFacet(string n, string ns, XmlSchemaMaxLengthFacet o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(XmlSchemaMaxLengthFacet)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            base.EscapeName = false;
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("XmlSchemaMaxLengthFacet", "http://www.w3.org/2001/XMLSchema");
            }
            WriteAttribute("id", "", o.Id);
            XmlAttribute[] a = o.UnhandledAttributes;
            if (a != null)
            {
                foreach (XmlAttribute ai in a)
                {
                    WriteXmlAttribute(ai, o);
                }
            }
            WriteAttribute("value", "", o.Value);
            if (o.IsFixed)
            {
                WriteAttribute("fixed", "", XmlConvert.ToString(o.IsFixed));
            }
            Write11_XmlSchemaAnnotation("annotation", "http://www.w3.org/2001/XMLSchema", o.Annotation, false, false);
            WriteEndElement(o);
        }
    }

    private void Write24_XmlSchemaTotalDigitsFacet(string n, string ns, XmlSchemaTotalDigitsFacet o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(XmlSchemaTotalDigitsFacet)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            base.EscapeName = false;
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("XmlSchemaTotalDigitsFacet", "http://www.w3.org/2001/XMLSchema");
            }
            WriteAttribute("id", "", o.Id);
            XmlAttribute[] a = o.UnhandledAttributes;
            if (a != null)
            {
                foreach (XmlAttribute ai in a)
                {
                    WriteXmlAttribute(ai, o);
                }
            }
            WriteAttribute("value", "", o.Value);
            if (o.IsFixed)
            {
                WriteAttribute("fixed", "", XmlConvert.ToString(o.IsFixed));
            }
            Write11_XmlSchemaAnnotation("annotation", "http://www.w3.org/2001/XMLSchema", o.Annotation, false, false);
            WriteEndElement(o);
        }
    }

    private void Write23_XmlSchemaLengthFacet(string n, string ns, XmlSchemaLengthFacet o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(XmlSchemaLengthFacet)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            base.EscapeName = false;
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("XmlSchemaLengthFacet", "http://www.w3.org/2001/XMLSchema");
            }
            WriteAttribute("id", "", o.Id);
            XmlAttribute[] a = o.UnhandledAttributes;
            if (a != null)
            {
                foreach (XmlAttribute ai in a)
                {
                    WriteXmlAttribute(ai, o);
                }
            }
            WriteAttribute("value", "", o.Value);
            if (o.IsFixed)
            {
                WriteAttribute("fixed", "", XmlConvert.ToString(o.IsFixed));
            }
            Write11_XmlSchemaAnnotation("annotation", "http://www.w3.org/2001/XMLSchema", o.Annotation, false, false);
            WriteEndElement(o);
        }
    }

    private void Write33_XmlSchemaSimpleTypeUnion(string n, string ns, XmlSchemaSimpleTypeUnion o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(XmlSchemaSimpleTypeUnion)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            base.EscapeName = false;
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("XmlSchemaSimpleTypeUnion", "http://www.w3.org/2001/XMLSchema");
            }
            WriteAttribute("id", "", o.Id);
            XmlAttribute[] a3 = o.UnhandledAttributes;
            if (a3 != null)
            {
                foreach (XmlAttribute ai2 in a3)
                {
                    WriteXmlAttribute(ai2, o);
                }
            }
            XmlQualifiedName[] a2 = o.MemberTypes;
            if (a2 != null)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < a2.Length; i++)
                {
                    XmlQualifiedName ai = a2[i];
                    if (i != 0)
                    {
                        sb.Append(" ");
                    }
                    sb.Append(FromXmlQualifiedName(ai));
                }
                if (sb.Length != 0)
                {
                    WriteAttribute("memberTypes", "", sb.ToString());
                }
            }
            Write11_XmlSchemaAnnotation("annotation", "http://www.w3.org/2001/XMLSchema", o.Annotation, false, false);
            XmlSchemaObjectCollection a = o.BaseTypes;
            if (a != null)
            {
                for (int ia = 0; ia < ((ICollection)a).Count; ia++)
                {
                    Write34_XmlSchemaSimpleType("simpleType", "http://www.w3.org/2001/XMLSchema", (XmlSchemaSimpleType)a[ia], false, false);
                }
            }
            WriteEndElement(o);
        }
    }

    private string Write7_XmlSchemaDerivationMethod(XmlSchemaDerivationMethod v)
    {
        string s = null;
        switch (v)
        {
            case XmlSchemaDerivationMethod.Empty:
                return "";
            case XmlSchemaDerivationMethod.Substitution:
                return "substitution";
            case XmlSchemaDerivationMethod.Extension:
                return "extension";
            case XmlSchemaDerivationMethod.Restriction:
                return "restriction";
            case XmlSchemaDerivationMethod.List:
                return "list";
            case XmlSchemaDerivationMethod.Union:
                return "union";
            case XmlSchemaDerivationMethod.All:
                return "#all";
            default:
                return XmlSerializationWriter.FromEnum((long)v, new string[7]
                {
                "",
                "substitution",
                "extension",
                "restriction",
                "list",
                "union",
                "#all"
                }, new long[7]
                {
                0L,
                1L,
                2L,
                4L,
                8L,
                16L,
                255L
                }, "System.Xml.Schema.XmlSchemaDerivationMethod");
        }
    }

    private void Write62_XmlSchemaComplexType(string n, string ns, XmlSchemaComplexType o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(XmlSchemaComplexType)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            base.EscapeName = false;
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("XmlSchemaComplexType", "http://www.w3.org/2001/XMLSchema");
            }
            WriteAttribute("id", "", o.Id);
            XmlAttribute[] a2 = o.UnhandledAttributes;
            if (a2 != null)
            {
                foreach (XmlAttribute ai2 in a2)
                {
                    WriteXmlAttribute(ai2, o);
                }
            }
            WriteAttribute("name", "", o.Name);
            if (o.Final != XmlSchemaDerivationMethod.None)
            {
                WriteAttribute("final", "", Write7_XmlSchemaDerivationMethod(o.Final));
            }
            if (o.IsAbstract)
            {
                WriteAttribute("abstract", "", XmlConvert.ToString(o.IsAbstract));
            }
            if (o.Block != XmlSchemaDerivationMethod.None)
            {
                WriteAttribute("block", "", Write7_XmlSchemaDerivationMethod(o.Block));
            }
            if (o.IsMixed)
            {
                WriteAttribute("mixed", "", XmlConvert.ToString(o.IsMixed));
            }
            Write11_XmlSchemaAnnotation("annotation", "http://www.w3.org/2001/XMLSchema", o.Annotation, false, false);
            if (o.ContentModel is XmlSchemaSimpleContent)
            {
                Write61_XmlSchemaSimpleContent("simpleContent", "http://www.w3.org/2001/XMLSchema", (XmlSchemaSimpleContent)o.ContentModel, false, false);
            }
            else if (o.ContentModel is XmlSchemaComplexContent)
            {
                Write58_XmlSchemaComplexContent("complexContent", "http://www.w3.org/2001/XMLSchema", (XmlSchemaComplexContent)o.ContentModel, false, false);
            }
            else if (o.ContentModel != null)
            {
                throw CreateUnknownTypeException(o.ContentModel);
            }
            if (o.Particle is XmlSchemaChoice)
            {
                Write54_XmlSchemaChoice("choice", "http://www.w3.org/2001/XMLSchema", (XmlSchemaChoice)o.Particle, false, false);
            }
            else if (o.Particle is XmlSchemaAll)
            {
                Write55_XmlSchemaAll("all", "http://www.w3.org/2001/XMLSchema", (XmlSchemaAll)o.Particle, false, false);
            }
            else if (o.Particle is XmlSchemaSequence)
            {
                Write53_XmlSchemaSequence("sequence", "http://www.w3.org/2001/XMLSchema", (XmlSchemaSequence)o.Particle, false, false);
            }
            else if (o.Particle is XmlSchemaGroupRef)
            {
                Write44_XmlSchemaGroupRef("group", "http://www.w3.org/2001/XMLSchema", (XmlSchemaGroupRef)o.Particle, false, false);
            }
            else if (o.Particle != null)
            {
                throw CreateUnknownTypeException(o.Particle);
            }
            XmlSchemaObjectCollection a = o.Attributes;
            if (a != null)
            {
                for (int ia = 0; ia < ((ICollection)a).Count; ia++)
                {
                    XmlSchemaObject ai = a[ia];
                    if (ai is XmlSchemaAttributeGroupRef)
                    {
                        Write37_XmlSchemaAttributeGroupRef("attributeGroup", "http://www.w3.org/2001/XMLSchema", (XmlSchemaAttributeGroupRef)ai, false, false);
                    }
                    else if (ai is XmlSchemaAttribute)
                    {
                        Write36_XmlSchemaAttribute("attribute", "http://www.w3.org/2001/XMLSchema", (XmlSchemaAttribute)ai, false, false);
                    }
                    else if (ai != null)
                    {
                        throw CreateUnknownTypeException(ai);
                    }
                }
            }
            Write39_XmlSchemaAnyAttribute("anyAttribute", "http://www.w3.org/2001/XMLSchema", o.AnyAttribute, false, false);
            WriteEndElement(o);
        }
    }

    private void Write39_XmlSchemaAnyAttribute(string n, string ns, XmlSchemaAnyAttribute o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(XmlSchemaAnyAttribute)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            base.EscapeName = false;
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("XmlSchemaAnyAttribute", "http://www.w3.org/2001/XMLSchema");
            }
            WriteAttribute("id", "", o.Id);
            XmlAttribute[] a = o.UnhandledAttributes;
            if (a != null)
            {
                foreach (XmlAttribute ai in a)
                {
                    WriteXmlAttribute(ai, o);
                }
            }
            WriteAttribute("namespace", "", o.Namespace);
            if (o.ProcessContents != 0)
            {
                WriteAttribute("processContents", "", Write38_XmlSchemaContentProcessing(o.ProcessContents));
            }
            Write11_XmlSchemaAnnotation("annotation", "http://www.w3.org/2001/XMLSchema", o.Annotation, false, false);
            WriteEndElement(o);
        }
    }

    private void Write36_XmlSchemaAttribute(string n, string ns, XmlSchemaAttribute o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(XmlSchemaAttribute)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            base.EscapeName = false;
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("XmlSchemaAttribute", "http://www.w3.org/2001/XMLSchema");
            }
            WriteAttribute("id", "", o.Id);
            XmlAttribute[] a = o.UnhandledAttributes;
            if (a != null)
            {
                foreach (XmlAttribute ai in a)
                {
                    WriteXmlAttribute(ai, o);
                }
            }
            WriteAttribute("default", "", o.DefaultValue);
            WriteAttribute("fixed", "", o.FixedValue);
            if (o.Form != 0)
            {
                WriteAttribute("form", "", Write6_XmlSchemaForm(o.Form));
            }
            WriteAttribute("name", "", o.Name);
            WriteAttribute("ref", "", FromXmlQualifiedName(o.RefName));
            WriteAttribute("type", "", FromXmlQualifiedName(o.SchemaTypeName));
            if (o.Use != 0)
            {
                WriteAttribute("use", "", Write35_XmlSchemaUse(o.Use));
            }
            Write11_XmlSchemaAnnotation("annotation", "http://www.w3.org/2001/XMLSchema", o.Annotation, false, false);
            Write34_XmlSchemaSimpleType("simpleType", "http://www.w3.org/2001/XMLSchema", o.SchemaType, false, false);
            WriteEndElement(o);
        }
    }

    private string Write35_XmlSchemaUse(XmlSchemaUse v)
    {
        string s = null;
        switch (v)
        {
            case XmlSchemaUse.Optional:
                return "optional";
            case XmlSchemaUse.Prohibited:
                return "prohibited";
            case XmlSchemaUse.Required:
                return "required";
            default:
                throw CreateInvalidEnumValueException(((long)v).ToString((IFormatProvider)CultureInfo.InvariantCulture), "System.Xml.Schema.XmlSchemaUse");
        }
    }

    private string Write6_XmlSchemaForm(XmlSchemaForm v)
    {
        string s = null;
        switch (v)
        {
            case XmlSchemaForm.Qualified:
                return "qualified";
            case XmlSchemaForm.Unqualified:
                return "unqualified";
            default:
                throw CreateInvalidEnumValueException(((long)v).ToString((IFormatProvider)CultureInfo.InvariantCulture), "System.Xml.Schema.XmlSchemaForm");
        }
    }

    private void Write37_XmlSchemaAttributeGroupRef(string n, string ns, XmlSchemaAttributeGroupRef o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(XmlSchemaAttributeGroupRef)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            base.EscapeName = false;
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("XmlSchemaAttributeGroupRef", "http://www.w3.org/2001/XMLSchema");
            }
            WriteAttribute("id", "", o.Id);
            XmlAttribute[] a = o.UnhandledAttributes;
            if (a != null)
            {
                foreach (XmlAttribute ai in a)
                {
                    WriteXmlAttribute(ai, o);
                }
            }
            WriteAttribute("ref", "", FromXmlQualifiedName(o.RefName));
            Write11_XmlSchemaAnnotation("annotation", "http://www.w3.org/2001/XMLSchema", o.Annotation, false, false);
            WriteEndElement(o);
        }
    }

    private void Write44_XmlSchemaGroupRef(string n, string ns, XmlSchemaGroupRef o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(XmlSchemaGroupRef)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            base.EscapeName = false;
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("XmlSchemaGroupRef", "http://www.w3.org/2001/XMLSchema");
            }
            WriteAttribute("id", "", o.Id);
            XmlAttribute[] a = o.UnhandledAttributes;
            if (a != null)
            {
                foreach (XmlAttribute ai in a)
                {
                    WriteXmlAttribute(ai, o);
                }
            }
            WriteAttribute("minOccurs", "", o.MinOccursString);
            WriteAttribute("maxOccurs", "", o.MaxOccursString);
            WriteAttribute("ref", "", FromXmlQualifiedName(o.RefName));
            Write11_XmlSchemaAnnotation("annotation", "http://www.w3.org/2001/XMLSchema", o.Annotation, false, false);
            WriteEndElement(o);
        }
    }

    private void Write55_XmlSchemaAll(string n, string ns, XmlSchemaAll o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(XmlSchemaAll)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            base.EscapeName = false;
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("XmlSchemaAll", "http://www.w3.org/2001/XMLSchema");
            }
            WriteAttribute("id", "", o.Id);
            XmlAttribute[] a2 = o.UnhandledAttributes;
            if (a2 != null)
            {
                foreach (XmlAttribute ai in a2)
                {
                    WriteXmlAttribute(ai, o);
                }
            }
            WriteAttribute("minOccurs", "", o.MinOccursString);
            WriteAttribute("maxOccurs", "", o.MaxOccursString);
            Write11_XmlSchemaAnnotation("annotation", "http://www.w3.org/2001/XMLSchema", o.Annotation, false, false);
            XmlSchemaObjectCollection a = o.Items;
            if (a != null)
            {
                for (int ia = 0; ia < ((ICollection)a).Count; ia++)
                {
                    Write52_XmlSchemaElement("element", "http://www.w3.org/2001/XMLSchema", (XmlSchemaElement)a[ia], false, false);
                }
            }
            WriteEndElement(o);
        }
    }

    private void Write54_XmlSchemaChoice(string n, string ns, XmlSchemaChoice o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(XmlSchemaChoice)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            base.EscapeName = false;
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("XmlSchemaChoice", "http://www.w3.org/2001/XMLSchema");
            }
            WriteAttribute("id", "", o.Id);
            XmlAttribute[] a2 = o.UnhandledAttributes;
            if (a2 != null)
            {
                foreach (XmlAttribute ai2 in a2)
                {
                    WriteXmlAttribute(ai2, o);
                }
            }
            WriteAttribute("minOccurs", "", o.MinOccursString);
            WriteAttribute("maxOccurs", "", o.MaxOccursString);
            Write11_XmlSchemaAnnotation("annotation", "http://www.w3.org/2001/XMLSchema", o.Annotation, false, false);
            XmlSchemaObjectCollection a = o.Items;
            if (a != null)
            {
                for (int ia = 0; ia < ((ICollection)a).Count; ia++)
                {
                    XmlSchemaObject ai = a[ia];
                    if (ai is XmlSchemaSequence)
                    {
                        Write53_XmlSchemaSequence("sequence", "http://www.w3.org/2001/XMLSchema", (XmlSchemaSequence)ai, false, false);
                    }
                    else if (ai is XmlSchemaChoice)
                    {
                        Write54_XmlSchemaChoice("choice", "http://www.w3.org/2001/XMLSchema", (XmlSchemaChoice)ai, false, false);
                    }
                    else if (ai is XmlSchemaGroupRef)
                    {
                        Write44_XmlSchemaGroupRef("group", "http://www.w3.org/2001/XMLSchema", (XmlSchemaGroupRef)ai, false, false);
                    }
                    else if (ai is XmlSchemaElement)
                    {
                        Write52_XmlSchemaElement("element", "http://www.w3.org/2001/XMLSchema", (XmlSchemaElement)ai, false, false);
                    }
                    else if (ai is XmlSchemaAny)
                    {
                        Write46_XmlSchemaAny("any", "http://www.w3.org/2001/XMLSchema", (XmlSchemaAny)ai, false, false);
                    }
                    else if (ai != null)
                    {
                        throw CreateUnknownTypeException(ai);
                    }
                }
            }
            WriteEndElement(o);
        }
    }

    private void Write58_XmlSchemaComplexContent(string n, string ns, XmlSchemaComplexContent o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(XmlSchemaComplexContent)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            base.EscapeName = false;
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("XmlSchemaComplexContent", "http://www.w3.org/2001/XMLSchema");
            }
            WriteAttribute("id", "", o.Id);
            XmlAttribute[] a = o.UnhandledAttributes;
            if (a != null)
            {
                foreach (XmlAttribute ai in a)
                {
                    WriteXmlAttribute(ai, o);
                }
            }
            WriteAttribute("mixed", "", XmlConvert.ToString(o.IsMixed));
            Write11_XmlSchemaAnnotation("annotation", "http://www.w3.org/2001/XMLSchema", o.Annotation, false, false);
            if (o.Content is XmlSchemaComplexContentRestriction)
            {
                Write57_Item("restriction", "http://www.w3.org/2001/XMLSchema", (XmlSchemaComplexContentRestriction)o.Content, false, false);
            }
            else if (o.Content is XmlSchemaComplexContentExtension)
            {
                Write56_Item("extension", "http://www.w3.org/2001/XMLSchema", (XmlSchemaComplexContentExtension)o.Content, false, false);
            }
            else if (o.Content != null)
            {
                throw CreateUnknownTypeException(o.Content);
            }
            WriteEndElement(o);
        }
    }

    private void Write56_Item(string n, string ns, XmlSchemaComplexContentExtension o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(XmlSchemaComplexContentExtension)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            base.EscapeName = false;
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("XmlSchemaComplexContentExtension", "http://www.w3.org/2001/XMLSchema");
            }
            WriteAttribute("id", "", o.Id);
            XmlAttribute[] a2 = o.UnhandledAttributes;
            if (a2 != null)
            {
                foreach (XmlAttribute ai2 in a2)
                {
                    WriteXmlAttribute(ai2, o);
                }
            }
            WriteAttribute("base", "", FromXmlQualifiedName(o.BaseTypeName));
            Write11_XmlSchemaAnnotation("annotation", "http://www.w3.org/2001/XMLSchema", o.Annotation, false, false);
            if (o.Particle is XmlSchemaAll)
            {
                Write55_XmlSchemaAll("all", "http://www.w3.org/2001/XMLSchema", (XmlSchemaAll)o.Particle, false, false);
            }
            else if (o.Particle is XmlSchemaSequence)
            {
                Write53_XmlSchemaSequence("sequence", "http://www.w3.org/2001/XMLSchema", (XmlSchemaSequence)o.Particle, false, false);
            }
            else if (o.Particle is XmlSchemaChoice)
            {
                Write54_XmlSchemaChoice("choice", "http://www.w3.org/2001/XMLSchema", (XmlSchemaChoice)o.Particle, false, false);
            }
            else if (o.Particle is XmlSchemaGroupRef)
            {
                Write44_XmlSchemaGroupRef("group", "http://www.w3.org/2001/XMLSchema", (XmlSchemaGroupRef)o.Particle, false, false);
            }
            else if (o.Particle != null)
            {
                throw CreateUnknownTypeException(o.Particle);
            }
            XmlSchemaObjectCollection a = o.Attributes;
            if (a != null)
            {
                for (int ia = 0; ia < ((ICollection)a).Count; ia++)
                {
                    XmlSchemaObject ai = a[ia];
                    if (ai is XmlSchemaAttribute)
                    {
                        Write36_XmlSchemaAttribute("attribute", "http://www.w3.org/2001/XMLSchema", (XmlSchemaAttribute)ai, false, false);
                    }
                    else if (ai is XmlSchemaAttributeGroupRef)
                    {
                        Write37_XmlSchemaAttributeGroupRef("attributeGroup", "http://www.w3.org/2001/XMLSchema", (XmlSchemaAttributeGroupRef)ai, false, false);
                    }
                    else if (ai != null)
                    {
                        throw CreateUnknownTypeException(ai);
                    }
                }
            }
            Write39_XmlSchemaAnyAttribute("anyAttribute", "http://www.w3.org/2001/XMLSchema", o.AnyAttribute, false, false);
            WriteEndElement(o);
        }
    }

    private void Write57_Item(string n, string ns, XmlSchemaComplexContentRestriction o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(XmlSchemaComplexContentRestriction)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            base.EscapeName = false;
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("XmlSchemaComplexContentRestriction", "http://www.w3.org/2001/XMLSchema");
            }
            WriteAttribute("id", "", o.Id);
            XmlAttribute[] a2 = o.UnhandledAttributes;
            if (a2 != null)
            {
                foreach (XmlAttribute ai2 in a2)
                {
                    WriteXmlAttribute(ai2, o);
                }
            }
            WriteAttribute("base", "", FromXmlQualifiedName(o.BaseTypeName));
            Write11_XmlSchemaAnnotation("annotation", "http://www.w3.org/2001/XMLSchema", o.Annotation, false, false);
            if (o.Particle is XmlSchemaAll)
            {
                Write55_XmlSchemaAll("all", "http://www.w3.org/2001/XMLSchema", (XmlSchemaAll)o.Particle, false, false);
            }
            else if (o.Particle is XmlSchemaSequence)
            {
                Write53_XmlSchemaSequence("sequence", "http://www.w3.org/2001/XMLSchema", (XmlSchemaSequence)o.Particle, false, false);
            }
            else if (o.Particle is XmlSchemaChoice)
            {
                Write54_XmlSchemaChoice("choice", "http://www.w3.org/2001/XMLSchema", (XmlSchemaChoice)o.Particle, false, false);
            }
            else if (o.Particle is XmlSchemaGroupRef)
            {
                Write44_XmlSchemaGroupRef("group", "http://www.w3.org/2001/XMLSchema", (XmlSchemaGroupRef)o.Particle, false, false);
            }
            else if (o.Particle != null)
            {
                throw CreateUnknownTypeException(o.Particle);
            }
            XmlSchemaObjectCollection a = o.Attributes;
            if (a != null)
            {
                for (int ia = 0; ia < ((ICollection)a).Count; ia++)
                {
                    XmlSchemaObject ai = a[ia];
                    if (ai is XmlSchemaAttribute)
                    {
                        Write36_XmlSchemaAttribute("attribute", "http://www.w3.org/2001/XMLSchema", (XmlSchemaAttribute)ai, false, false);
                    }
                    else if (ai is XmlSchemaAttributeGroupRef)
                    {
                        Write37_XmlSchemaAttributeGroupRef("attributeGroup", "http://www.w3.org/2001/XMLSchema", (XmlSchemaAttributeGroupRef)ai, false, false);
                    }
                    else if (ai != null)
                    {
                        throw CreateUnknownTypeException(ai);
                    }
                }
            }
            Write39_XmlSchemaAnyAttribute("anyAttribute", "http://www.w3.org/2001/XMLSchema", o.AnyAttribute, false, false);
            WriteEndElement(o);
        }
    }

    private void Write61_XmlSchemaSimpleContent(string n, string ns, XmlSchemaSimpleContent o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(XmlSchemaSimpleContent)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            base.EscapeName = false;
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("XmlSchemaSimpleContent", "http://www.w3.org/2001/XMLSchema");
            }
            WriteAttribute("id", "", o.Id);
            XmlAttribute[] a = o.UnhandledAttributes;
            if (a != null)
            {
                foreach (XmlAttribute ai in a)
                {
                    WriteXmlAttribute(ai, o);
                }
            }
            Write11_XmlSchemaAnnotation("annotation", "http://www.w3.org/2001/XMLSchema", o.Annotation, false, false);
            if (o.Content is XmlSchemaSimpleContentExtension)
            {
                Write60_Item("extension", "http://www.w3.org/2001/XMLSchema", (XmlSchemaSimpleContentExtension)o.Content, false, false);
            }
            else if (o.Content is XmlSchemaSimpleContentRestriction)
            {
                Write59_Item("restriction", "http://www.w3.org/2001/XMLSchema", (XmlSchemaSimpleContentRestriction)o.Content, false, false);
            }
            else if (o.Content != null)
            {
                throw CreateUnknownTypeException(o.Content);
            }
            WriteEndElement(o);
        }
    }

    private void Write59_Item(string n, string ns, XmlSchemaSimpleContentRestriction o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(XmlSchemaSimpleContentRestriction)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            base.EscapeName = false;
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("XmlSchemaSimpleContentRestriction", "http://www.w3.org/2001/XMLSchema");
            }
            WriteAttribute("id", "", o.Id);
            XmlAttribute[] a3 = o.UnhandledAttributes;
            if (a3 != null)
            {
                foreach (XmlAttribute ai3 in a3)
                {
                    WriteXmlAttribute(ai3, o);
                }
            }
            WriteAttribute("base", "", FromXmlQualifiedName(o.BaseTypeName));
            Write11_XmlSchemaAnnotation("annotation", "http://www.w3.org/2001/XMLSchema", o.Annotation, false, false);
            Write34_XmlSchemaSimpleType("simpleType", "http://www.w3.org/2001/XMLSchema", o.BaseType, false, false);
            XmlSchemaObjectCollection a2 = o.Facets;
            if (a2 != null)
            {
                for (int ia2 = 0; ia2 < ((ICollection)a2).Count; ia2++)
                {
                    XmlSchemaObject ai2 = a2[ia2];
                    if (ai2 is XmlSchemaMinLengthFacet)
                    {
                        Write31_XmlSchemaMinLengthFacet("minLength", "http://www.w3.org/2001/XMLSchema", (XmlSchemaMinLengthFacet)ai2, false, false);
                    }
                    else if (ai2 is XmlSchemaMaxLengthFacet)
                    {
                        Write22_XmlSchemaMaxLengthFacet("maxLength", "http://www.w3.org/2001/XMLSchema", (XmlSchemaMaxLengthFacet)ai2, false, false);
                    }
                    else if (ai2 is XmlSchemaLengthFacet)
                    {
                        Write23_XmlSchemaLengthFacet("length", "http://www.w3.org/2001/XMLSchema", (XmlSchemaLengthFacet)ai2, false, false);
                    }
                    else if (ai2 is XmlSchemaFractionDigitsFacet)
                    {
                        Write20_XmlSchemaFractionDigitsFacet("fractionDigits", "http://www.w3.org/2001/XMLSchema", (XmlSchemaFractionDigitsFacet)ai2, false, false);
                    }
                    else if (ai2 is XmlSchemaTotalDigitsFacet)
                    {
                        Write24_XmlSchemaTotalDigitsFacet("totalDigits", "http://www.w3.org/2001/XMLSchema", (XmlSchemaTotalDigitsFacet)ai2, false, false);
                    }
                    else if (ai2 is XmlSchemaMinExclusiveFacet)
                    {
                        Write30_XmlSchemaMinExclusiveFacet("minExclusive", "http://www.w3.org/2001/XMLSchema", (XmlSchemaMinExclusiveFacet)ai2, false, false);
                    }
                    else if (ai2 is XmlSchemaMaxInclusiveFacet)
                    {
                        Write27_XmlSchemaMaxInclusiveFacet("maxInclusive", "http://www.w3.org/2001/XMLSchema", (XmlSchemaMaxInclusiveFacet)ai2, false, false);
                    }
                    else if (ai2 is XmlSchemaMaxExclusiveFacet)
                    {
                        Write28_XmlSchemaMaxExclusiveFacet("maxExclusive", "http://www.w3.org/2001/XMLSchema", (XmlSchemaMaxExclusiveFacet)ai2, false, false);
                    }
                    else if (ai2 is XmlSchemaMinInclusiveFacet)
                    {
                        Write21_XmlSchemaMinInclusiveFacet("minInclusive", "http://www.w3.org/2001/XMLSchema", (XmlSchemaMinInclusiveFacet)ai2, false, false);
                    }
                    else if (ai2 is XmlSchemaWhiteSpaceFacet)
                    {
                        Write29_XmlSchemaWhiteSpaceFacet("whiteSpace", "http://www.w3.org/2001/XMLSchema", (XmlSchemaWhiteSpaceFacet)ai2, false, false);
                    }
                    else if (ai2 is XmlSchemaEnumerationFacet)
                    {
                        Write26_XmlSchemaEnumerationFacet("enumeration", "http://www.w3.org/2001/XMLSchema", (XmlSchemaEnumerationFacet)ai2, false, false);
                    }
                    else if (ai2 is XmlSchemaPatternFacet)
                    {
                        Write25_XmlSchemaPatternFacet("pattern", "http://www.w3.org/2001/XMLSchema", (XmlSchemaPatternFacet)ai2, false, false);
                    }
                    else if (ai2 != null)
                    {
                        throw CreateUnknownTypeException(ai2);
                    }
                }
            }
            XmlSchemaObjectCollection a = o.Attributes;
            if (a != null)
            {
                for (int ia = 0; ia < ((ICollection)a).Count; ia++)
                {
                    XmlSchemaObject ai = a[ia];
                    if (ai is XmlSchemaAttribute)
                    {
                        Write36_XmlSchemaAttribute("attribute", "http://www.w3.org/2001/XMLSchema", (XmlSchemaAttribute)ai, false, false);
                    }
                    else if (ai is XmlSchemaAttributeGroupRef)
                    {
                        Write37_XmlSchemaAttributeGroupRef("attributeGroup", "http://www.w3.org/2001/XMLSchema", (XmlSchemaAttributeGroupRef)ai, false, false);
                    }
                    else if (ai != null)
                    {
                        throw CreateUnknownTypeException(ai);
                    }
                }
            }
            Write39_XmlSchemaAnyAttribute("anyAttribute", "http://www.w3.org/2001/XMLSchema", o.AnyAttribute, false, false);
            WriteEndElement(o);
        }
    }

    private void Write60_Item(string n, string ns, XmlSchemaSimpleContentExtension o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(XmlSchemaSimpleContentExtension)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            base.EscapeName = false;
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("XmlSchemaSimpleContentExtension", "http://www.w3.org/2001/XMLSchema");
            }
            WriteAttribute("id", "", o.Id);
            XmlAttribute[] a2 = o.UnhandledAttributes;
            if (a2 != null)
            {
                foreach (XmlAttribute ai2 in a2)
                {
                    WriteXmlAttribute(ai2, o);
                }
            }
            WriteAttribute("base", "", FromXmlQualifiedName(o.BaseTypeName));
            Write11_XmlSchemaAnnotation("annotation", "http://www.w3.org/2001/XMLSchema", o.Annotation, false, false);
            XmlSchemaObjectCollection a = o.Attributes;
            if (a != null)
            {
                for (int ia = 0; ia < ((ICollection)a).Count; ia++)
                {
                    XmlSchemaObject ai = a[ia];
                    if (ai is XmlSchemaAttribute)
                    {
                        Write36_XmlSchemaAttribute("attribute", "http://www.w3.org/2001/XMLSchema", (XmlSchemaAttribute)ai, false, false);
                    }
                    else if (ai is XmlSchemaAttributeGroupRef)
                    {
                        Write37_XmlSchemaAttributeGroupRef("attributeGroup", "http://www.w3.org/2001/XMLSchema", (XmlSchemaAttributeGroupRef)ai, false, false);
                    }
                    else if (ai != null)
                    {
                        throw CreateUnknownTypeException(ai);
                    }
                }
            }
            Write39_XmlSchemaAnyAttribute("anyAttribute", "http://www.w3.org/2001/XMLSchema", o.AnyAttribute, false, false);
            WriteEndElement(o);
        }
    }

    private void Write65_XmlSchemaNotation(string n, string ns, XmlSchemaNotation o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(XmlSchemaNotation)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            base.EscapeName = false;
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("XmlSchemaNotation", "http://www.w3.org/2001/XMLSchema");
            }
            WriteAttribute("id", "", o.Id);
            XmlAttribute[] a = o.UnhandledAttributes;
            if (a != null)
            {
                foreach (XmlAttribute ai in a)
                {
                    WriteXmlAttribute(ai, o);
                }
            }
            WriteAttribute("name", "", o.Name);
            WriteAttribute("public", "", o.Public);
            WriteAttribute("system", "", o.System);
            Write11_XmlSchemaAnnotation("annotation", "http://www.w3.org/2001/XMLSchema", o.Annotation, false, false);
            WriteEndElement(o);
        }
    }

    private void Write40_XmlSchemaAttributeGroup(string n, string ns, XmlSchemaAttributeGroup o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(XmlSchemaAttributeGroup)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            base.EscapeName = false;
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("XmlSchemaAttributeGroup", "http://www.w3.org/2001/XMLSchema");
            }
            WriteAttribute("id", "", o.Id);
            XmlAttribute[] a2 = o.UnhandledAttributes;
            if (a2 != null)
            {
                foreach (XmlAttribute ai2 in a2)
                {
                    WriteXmlAttribute(ai2, o);
                }
            }
            WriteAttribute("name", "", o.Name);
            Write11_XmlSchemaAnnotation("annotation", "http://www.w3.org/2001/XMLSchema", o.Annotation, false, false);
            XmlSchemaObjectCollection a = o.Attributes;
            if (a != null)
            {
                for (int ia = 0; ia < ((ICollection)a).Count; ia++)
                {
                    XmlSchemaObject ai = a[ia];
                    if (ai is XmlSchemaAttributeGroupRef)
                    {
                        Write37_XmlSchemaAttributeGroupRef("attributeGroup", "http://www.w3.org/2001/XMLSchema", (XmlSchemaAttributeGroupRef)ai, false, false);
                    }
                    else if (ai is XmlSchemaAttribute)
                    {
                        Write36_XmlSchemaAttribute("attribute", "http://www.w3.org/2001/XMLSchema", (XmlSchemaAttribute)ai, false, false);
                    }
                    else if (ai != null)
                    {
                        throw CreateUnknownTypeException(ai);
                    }
                }
            }
            Write39_XmlSchemaAnyAttribute("anyAttribute", "http://www.w3.org/2001/XMLSchema", o.AnyAttribute, false, false);
            WriteEndElement(o);
        }
    }

    private void Write12_XmlSchemaInclude(string n, string ns, XmlSchemaInclude o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(XmlSchemaInclude)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            base.EscapeName = false;
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("XmlSchemaInclude", "http://www.w3.org/2001/XMLSchema");
            }
            WriteAttribute("schemaLocation", "", o.SchemaLocation);
            WriteAttribute("id", "", o.Id);
            XmlAttribute[] a = o.UnhandledAttributes;
            if (a != null)
            {
                foreach (XmlAttribute ai in a)
                {
                    WriteXmlAttribute(ai, o);
                }
            }
            Write11_XmlSchemaAnnotation("annotation", "http://www.w3.org/2001/XMLSchema", o.Annotation, false, false);
            WriteEndElement(o);
        }
    }

    private void Write13_XmlSchemaImport(string n, string ns, XmlSchemaImport o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(XmlSchemaImport)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            base.EscapeName = false;
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("XmlSchemaImport", "http://www.w3.org/2001/XMLSchema");
            }
            WriteAttribute("schemaLocation", "", o.SchemaLocation);
            WriteAttribute("id", "", o.Id);
            XmlAttribute[] a = o.UnhandledAttributes;
            if (a != null)
            {
                foreach (XmlAttribute ai in a)
                {
                    WriteXmlAttribute(ai, o);
                }
            }
            WriteAttribute("namespace", "", o.Namespace);
            Write11_XmlSchemaAnnotation("annotation", "http://www.w3.org/2001/XMLSchema", o.Annotation, false, false);
            WriteEndElement(o);
        }
    }

    private void Write64_XmlSchemaRedefine(string n, string ns, XmlSchemaRedefine o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(XmlSchemaRedefine)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            base.EscapeName = false;
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("XmlSchemaRedefine", "http://www.w3.org/2001/XMLSchema");
            }
            WriteAttribute("schemaLocation", "", o.SchemaLocation);
            WriteAttribute("id", "", o.Id);
            XmlAttribute[] a2 = o.UnhandledAttributes;
            if (a2 != null)
            {
                foreach (XmlAttribute ai2 in a2)
                {
                    WriteXmlAttribute(ai2, o);
                }
            }
            XmlSchemaObjectCollection a = o.Items;
            if (a != null)
            {
                for (int ia = 0; ia < ((ICollection)a).Count; ia++)
                {
                    XmlSchemaObject ai = a[ia];
                    if (ai is XmlSchemaSimpleType)
                    {
                        Write34_XmlSchemaSimpleType("simpleType", "http://www.w3.org/2001/XMLSchema", (XmlSchemaSimpleType)ai, false, false);
                    }
                    else if (ai is XmlSchemaComplexType)
                    {
                        Write62_XmlSchemaComplexType("complexType", "http://www.w3.org/2001/XMLSchema", (XmlSchemaComplexType)ai, false, false);
                    }
                    else if (ai is XmlSchemaGroup)
                    {
                        Write63_XmlSchemaGroup("group", "http://www.w3.org/2001/XMLSchema", (XmlSchemaGroup)ai, false, false);
                    }
                    else if (ai is XmlSchemaAttributeGroup)
                    {
                        Write40_XmlSchemaAttributeGroup("attributeGroup", "http://www.w3.org/2001/XMLSchema", (XmlSchemaAttributeGroup)ai, false, false);
                    }
                    else if (ai is XmlSchemaAnnotation)
                    {
                        Write11_XmlSchemaAnnotation("annotation", "http://www.w3.org/2001/XMLSchema", (XmlSchemaAnnotation)ai, false, false);
                    }
                    else if (ai != null)
                    {
                        throw CreateUnknownTypeException(ai);
                    }
                }
            }
            WriteEndElement(o);
        }
    }

    private void Write4_Import(string n, string ns, Import o, bool isNullable, bool needType)
    {
        if (o == null)
        {
            if (isNullable)
            {
                WriteNullTagLiteral(n, ns);
            }
        }
        else
        {
            if (!needType)
            {
                Type t = o.GetType();
                if (!(t == typeof(Import)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, o.Namespaces);
            if (needType)
            {
                WriteXsiType("Import", "http://schemas.xmlsoap.org/wsdl/");
            }
            XmlAttribute[] a2 = o.ExtensibleAttributes;
            if (a2 != null)
            {
                foreach (XmlAttribute ai in a2)
                {
                    WriteXmlAttribute(ai, o);
                }
            }
            WriteAttribute("namespace", "", o.Namespace);
            WriteAttribute("location", "", o.Location);
            if (o.DocumentationElement == null && o.DocumentationElement != null)
            {
                throw CreateInvalidAnyTypeException(o.DocumentationElement);
            }
            WriteElementLiteral(o.DocumentationElement, "documentation", "http://schemas.xmlsoap.org/wsdl/", false, true);
            ServiceDescriptionFormatExtensionCollection a = o.Extensions;
            if (a != null)
            {
                for (int ia = 0; ia < ((ICollection)a).Count; ia++)
                {
                    if (!(a[ia] is XmlNode) && a[ia] != null)
                    {
                        throw CreateInvalidAnyTypeException(a[ia]);
                    }
                    WriteElementLiteral((XmlNode)a[ia], "", null, false, true);
                }
            }
            WriteEndElement(o);
        }
    }

    protected override void InitCallbacks()
    {
    }
}
