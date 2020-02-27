// System.Web.Services.Description.WebReferenceOptionsSerializationWriter
using System;
using System.Collections.Specialized;
using System.Globalization;
using System.Xml;
using System.Xml.Serialization;


internal class WebReferenceOptionsSerializationWriter : XmlSerializationWriter
{
    private string Write1_CodeGenerationOptions(CodeGenerationOptions v)
    {
        string s = null;
        switch (v)
        {
            case CodeGenerationOptions.GenerateProperties:
                return "properties";
            case CodeGenerationOptions.GenerateNewAsync:
                return "newAsync";
            case CodeGenerationOptions.GenerateOldAsync:
                return "oldAsync";
            case CodeGenerationOptions.GenerateOrder:
                return "order";
            case CodeGenerationOptions.EnableDataBinding:
                return "enableDataBinding";
            default:
                return XmlSerializationWriter.FromEnum((long)v, new string[5]
                {
                "properties",
                "newAsync",
                "oldAsync",
                "order",
                "enableDataBinding"
                }, new long[5]
                {
                1L,
                2L,
                4L,
                8L,
                16L
                }, "System.Xml.Serialization.CodeGenerationOptions");
        }
    }

    private string Write2_ServiceDescriptionImportStyle(ServiceDescriptionImportStyle v)
    {
        string s = null;
        switch (v)
        {
            case ServiceDescriptionImportStyle.Client:
                return "client";
            case ServiceDescriptionImportStyle.Server:
                return "server";
            case ServiceDescriptionImportStyle.ServerInterface:
                return "serverInterface";
            default:
                throw CreateInvalidEnumValueException(((long)v).ToString((IFormatProvider)CultureInfo.InvariantCulture), "System.Web.Services.Description.ServiceDescriptionImportStyle");
        }
    }

    private void Write4_WebReferenceOptions(string n, string ns, WebReferenceOptions o, bool isNullable, bool needType)
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
                if (!(t == typeof(WebReferenceOptions)))
                {
                    throw CreateUnknownTypeException(o);
                }
            }
            base.EscapeName = false;
            WriteStartElement(n, ns, o);
            if (needType)
            {
                WriteXsiType("webReferenceOptions", "http://microsoft.com/webReference/");
            }
            if (o.CodeGenerationOptions != CodeGenerationOptions.GenerateOldAsync)
            {
                WriteElementString("codeGenerationOptions", "http://microsoft.com/webReference/", Write1_CodeGenerationOptions(o.CodeGenerationOptions));
            }
            StringCollection a = o.SchemaImporterExtensions;
            if (a != null)
            {
                WriteStartElement("schemaImporterExtensions", "http://microsoft.com/webReference/");
                for (int ia = 0; ia < a.Count; ia++)
                {
                    WriteNullableStringLiteral("type", "http://microsoft.com/webReference/", a[ia]);
                }
                WriteEndElement();
            }
            if (o.Style != 0)
            {
                WriteElementString("style", "http://microsoft.com/webReference/", Write2_ServiceDescriptionImportStyle(o.Style));
            }
            WriteElementStringRaw("verbose", "http://microsoft.com/webReference/", XmlConvert.ToString(o.Verbose));
            WriteEndElement(o);
        }
    }

    protected override void InitCallbacks()
    {
    }

    internal void Write5_webReferenceOptions(object o)
    {
        WriteStartDocument();
        if (o == null)
        {
            WriteNullTagLiteral("webReferenceOptions", "http://microsoft.com/webReference/");
        }
        else
        {
            TopLevelElement();
            Write4_WebReferenceOptions("webReferenceOptions", "http://microsoft.com/webReference/", (WebReferenceOptions)o, true, false);
        }
    }
}
