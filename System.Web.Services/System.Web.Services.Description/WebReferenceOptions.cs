// System.Web.Services.Description.WebReferenceOptions
using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;


[XmlType("webReferenceOptions", Namespace = "http://microsoft.com/webReference/")]
[XmlRoot("webReferenceOptions", Namespace = "http://microsoft.com/webReference/")]
public class WebReferenceOptions
{
    public const string TargetNamespace = "http://microsoft.com/webReference/";

    private static XmlSchema schema;

    private CodeGenerationOptions codeGenerationOptions = CodeGenerationOptions.GenerateOldAsync;

    private ServiceDescriptionImportStyle style;

    private StringCollection schemaImporterExtensions;

    private bool verbose;

    [XmlElement("codeGenerationOptions")]
    [DefaultValue(CodeGenerationOptions.GenerateOldAsync)]
    public CodeGenerationOptions CodeGenerationOptions
    {
        get
        {
            return codeGenerationOptions;
        }
        set
        {
            codeGenerationOptions = value;
        }
    }

    [XmlArray("schemaImporterExtensions")]
    [XmlArrayItem("type")]
    public StringCollection SchemaImporterExtensions
    {
        get
        {
            if (schemaImporterExtensions == null)
            {
                schemaImporterExtensions = new StringCollection();
            }
            return schemaImporterExtensions;
        }
    }

    [DefaultValue(ServiceDescriptionImportStyle.Client)]
    [XmlElement("style")]
    public ServiceDescriptionImportStyle Style
    {
        get
        {
            return style;
        }
        set
        {
            style = value;
        }
    }

    [XmlElement("verbose")]
    public bool Verbose
    {
        get
        {
            return verbose;
        }
        set
        {
            verbose = value;
        }
    }

    public static XmlSchema Schema
    {
        get
        {
            if (schema == null)
            {
                schema = XmlSchema.Read(new StringReader("<?xml version='1.0' encoding='UTF-8' ?>\r\n<xs:schema xmlns:tns='http://microsoft.com/webReference/' elementFormDefault='qualified' targetNamespace='http://microsoft.com/webReference/' xmlns:xs='http://www.w3.org/2001/XMLSchema'>\r\n  <xs:simpleType name='options'>\r\n    <xs:list>\r\n      <xs:simpleType>\r\n        <xs:restriction base='xs:string'>\r\n          <xs:enumeration value='properties' />\r\n          <xs:enumeration value='newAsync' />\r\n          <xs:enumeration value='oldAsync' />\r\n          <xs:enumeration value='order' />\r\n          <xs:enumeration value='enableDataBinding' />\r\n        </xs:restriction>\r\n      </xs:simpleType>\r\n    </xs:list>\r\n  </xs:simpleType>\r\n  <xs:simpleType name='style'>\r\n    <xs:restriction base='xs:string'>\r\n      <xs:enumeration value='client' />\r\n      <xs:enumeration value='server' />\r\n      <xs:enumeration value='serverInterface' />\r\n    </xs:restriction>\r\n  </xs:simpleType>\r\n  <xs:complexType name='webReferenceOptions'>\r\n    <xs:all>\r\n      <xs:element minOccurs='0' default='oldAsync' name='codeGenerationOptions' type='tns:options' />\r\n      <xs:element minOccurs='0' default='client' name='style' type='tns:style' />\r\n      <xs:element minOccurs='0' default='false' name='verbose' type='xs:boolean' />\r\n      <xs:element minOccurs='0' name='schemaImporterExtensions'>\r\n        <xs:complexType>\r\n          <xs:sequence>\r\n            <xs:element minOccurs='0' maxOccurs='unbounded' name='type' type='xs:string' />\r\n          </xs:sequence>\r\n        </xs:complexType>\r\n      </xs:element>\r\n    </xs:all>\r\n  </xs:complexType>\r\n  <xs:element name='webReferenceOptions' type='tns:webReferenceOptions' />\r\n  <xs:complexType name='wsdlParameters'>\r\n    <xs:all>\r\n      <xs:element minOccurs='0' name='appSettingBaseUrl' type='xs:string' />\r\n      <xs:element minOccurs='0' name='appSettingUrlKey' type='xs:string' />\r\n      <xs:element minOccurs='0' name='domain' type='xs:string' />\r\n      <xs:element minOccurs='0' name='out' type='xs:string' />\r\n      <xs:element minOccurs='0' name='password' type='xs:string' />\r\n      <xs:element minOccurs='0' name='proxy' type='xs:string' />\r\n      <xs:element minOccurs='0' name='proxydomain' type='xs:string' />\r\n      <xs:element minOccurs='0' name='proxypassword' type='xs:string' />\r\n      <xs:element minOccurs='0' name='proxyusername' type='xs:string' />\r\n      <xs:element minOccurs='0' name='username' type='xs:string' />\r\n      <xs:element minOccurs='0' name='namespace' type='xs:string' />\r\n      <xs:element minOccurs='0' name='language' type='xs:string' />\r\n      <xs:element minOccurs='0' name='protocol' type='xs:string' />\r\n      <xs:element minOccurs='0' name='nologo' type='xs:boolean' />\r\n      <xs:element minOccurs='0' name='parsableerrors' type='xs:boolean' />\r\n      <xs:element minOccurs='0' name='sharetypes' type='xs:boolean' />\r\n      <xs:element minOccurs='0' name='webReferenceOptions' type='tns:webReferenceOptions' />\r\n      <xs:element minOccurs='0' name='documents'>\r\n        <xs:complexType>\r\n          <xs:sequence>\r\n            <xs:element minOccurs='0' maxOccurs='unbounded' name='document' type='xs:string' />\r\n          </xs:sequence>\r\n        </xs:complexType>\r\n      </xs:element>\r\n    </xs:all>\r\n  </xs:complexType>\r\n  <xs:element name='wsdlParameters' type='tns:wsdlParameters' />\r\n</xs:schema>"), null);
            }
            return schema;
        }
    }

    public static WebReferenceOptions Read(TextReader reader, ValidationEventHandler validationEventHandler)
    {
        XmlTextReader readerNew = new XmlTextReader(reader);
        readerNew.XmlResolver = null;
        readerNew.DtdProcessing = DtdProcessing.Prohibit;
        return Read(readerNew, validationEventHandler);
    }

    public static WebReferenceOptions Read(Stream stream, ValidationEventHandler validationEventHandler)
    {
        XmlTextReader readerNew = new XmlTextReader(stream);
        readerNew.XmlResolver = null;
        readerNew.DtdProcessing = DtdProcessing.Prohibit;
        return Read(readerNew, validationEventHandler);
    }

    public static WebReferenceOptions Read(XmlReader xmlReader, ValidationEventHandler validationEventHandler)
    {
        XmlValidatingReader validatingReader = new XmlValidatingReader(xmlReader);
        validatingReader.ValidationType = ValidationType.Schema;
        if (validationEventHandler != null)
        {
            validatingReader.ValidationEventHandler += validationEventHandler;
        }
        else
        {
            validatingReader.ValidationEventHandler += SchemaValidationHandler;
        }
        validatingReader.Schemas.Add(Schema);
        webReferenceOptionsSerializer ser = new webReferenceOptionsSerializer();
        try
        {
            return (WebReferenceOptions)ser.Deserialize(validatingReader);
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            validatingReader.Close();
        }
    }

    private static void SchemaValidationHandler(object sender, ValidationEventArgs args)
    {
        if (args.Severity == XmlSeverityType.Error)
        {
            string wsdlInstanceValidationDetails = ResWebServices.WsdlInstanceValidationDetails;
            object[] obj = new object[3]
            {
                args.Message,
                null,
                null
            };
            int num = args.Exception.LineNumber;
            obj[1] = num.ToString(CultureInfo.InvariantCulture);
            num = args.Exception.LinePosition;
            obj[2] = num.ToString(CultureInfo.InvariantCulture);
            throw new InvalidOperationException(ResWebServices.GetString(wsdlInstanceValidationDetails, obj));
        }
    }
}
