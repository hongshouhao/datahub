// System.Web.Services.Description.SoapBinding
using System.ComponentModel;
using System.IO;
using System.Xml.Schema;
using System.Xml.Serialization;


[XmlFormatExtension("binding", "http://schemas.xmlsoap.org/wsdl/soap/", typeof(Binding))]
[XmlFormatExtensionPrefix("soap", "http://schemas.xmlsoap.org/wsdl/soap/")]
[XmlFormatExtensionPrefix("soapenc", "http://schemas.xmlsoap.org/soap/encoding/")]
public class SoapBinding : ServiceDescriptionFormatExtension
{
    private SoapBindingStyle style = SoapBindingStyle.Document;

    private string transport;

    private static XmlSchema schema;

    public const string Namespace = "http://schemas.xmlsoap.org/wsdl/soap/";

    public const string HttpTransport = "http://schemas.xmlsoap.org/soap/http";

    [XmlAttribute("transport")]
    public string Transport
    {
        get
        {
            if (transport != null)
            {
                return transport;
            }
            return string.Empty;
        }
        set
        {
            transport = value;
        }
    }

    [XmlAttribute("style")]
    [DefaultValue(SoapBindingStyle.Document)]
    public SoapBindingStyle Style
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

    public static XmlSchema Schema
    {
        get
        {
            if (schema == null)
            {
                schema = XmlSchema.Read(new StringReader("<?xml version='1.0' encoding='UTF-8' ?> \r\n<xs:schema xmlns:soap='http://schemas.xmlsoap.org/wsdl/soap/' xmlns:wsdl='http://schemas.xmlsoap.org/wsdl/' targetNamespace='http://schemas.xmlsoap.org/wsdl/soap/' xmlns:xs='http://www.w3.org/2001/XMLSchema'>\r\n  <xs:import namespace='http://schemas.xmlsoap.org/wsdl/' />\r\n  <xs:simpleType name='encodingStyle'>\r\n    <xs:annotation>\r\n      <xs:documentation>\r\n      'encodingStyle' indicates any canonicalization conventions followed in the contents of the containing element.  For example, the value 'http://schemas.xmlsoap.org/soap/encoding/' indicates the pattern described in SOAP specification\r\n      </xs:documentation>\r\n    </xs:annotation>\r\n    <xs:list itemType='xs:anyURI' />\r\n  </xs:simpleType>\r\n  <xs:element name='binding' type='soap:tBinding' />\r\n  <xs:complexType name='tBinding'>\r\n    <xs:complexContent mixed='false'>\r\n      <xs:extension base='wsdl:tExtensibilityElement'>\r\n        <xs:attribute name='transport' type='xs:anyURI' use='required' />\r\n        <xs:attribute name='style' type='soap:tStyleChoice' use='optional' />\r\n      </xs:extension>\r\n    </xs:complexContent>\r\n  </xs:complexType>\r\n  <xs:simpleType name='tStyleChoice'>\r\n    <xs:restriction base='xs:string'>\r\n      <xs:enumeration value='rpc' />\r\n      <xs:enumeration value='document' />\r\n    </xs:restriction>\r\n  </xs:simpleType>\r\n  <xs:element name='operation' type='soap:tOperation' />\r\n  <xs:complexType name='tOperation'>\r\n    <xs:complexContent mixed='false'>\r\n      <xs:extension base='wsdl:tExtensibilityElement'>\r\n        <xs:attribute name='soapAction' type='xs:anyURI' use='optional' />\r\n        <xs:attribute name='style' type='soap:tStyleChoice' use='optional' />\r\n      </xs:extension>\r\n    </xs:complexContent>\r\n  </xs:complexType>\r\n  <xs:element name='body' type='soap:tBody' />\r\n  <xs:attributeGroup name='tBodyAttributes'>\r\n    <xs:attribute name='encodingStyle' type='soap:encodingStyle' use='optional' />\r\n    <xs:attribute name='use' type='soap:useChoice' use='optional' />\r\n    <xs:attribute name='namespace' type='xs:anyURI' use='optional' />\r\n  </xs:attributeGroup>\r\n  <xs:complexType name='tBody'>\r\n    <xs:complexContent mixed='false'>\r\n      <xs:extension base='wsdl:tExtensibilityElement'>\r\n        <xs:attribute name='parts' type='xs:NMTOKENS' use='optional' />\r\n        <xs:attributeGroup ref='soap:tBodyAttributes' />\r\n      </xs:extension>\r\n    </xs:complexContent>\r\n  </xs:complexType>\r\n  <xs:simpleType name='useChoice'>\r\n    <xs:restriction base='xs:string'>\r\n      <xs:enumeration value='literal' />\r\n      <xs:enumeration value='encoded' />\r\n    </xs:restriction>\r\n  </xs:simpleType>\r\n  <xs:element name='fault' type='soap:tFault' />\r\n  <xs:complexType name='tFaultRes' abstract='true'>\r\n    <xs:complexContent mixed='false'>\r\n      <xs:restriction base='soap:tBody'>\r\n        <xs:attribute ref='wsdl:required' use='optional' />\r\n        <xs:attribute name='parts' type='xs:NMTOKENS' use='prohibited' />\r\n        <xs:attributeGroup ref='soap:tBodyAttributes' />\r\n      </xs:restriction>\r\n    </xs:complexContent>\r\n  </xs:complexType>\r\n  <xs:complexType name='tFault'>\r\n    <xs:complexContent mixed='false'>\r\n      <xs:extension base='soap:tFaultRes'>\r\n        <xs:attribute name='name' type='xs:NCName' use='required' />\r\n      </xs:extension>\r\n    </xs:complexContent>\r\n  </xs:complexType>\r\n  <xs:element name='header' type='soap:tHeader' />\r\n  <xs:attributeGroup name='tHeaderAttributes'>\r\n    <xs:attribute name='message' type='xs:QName' use='required' />\r\n    <xs:attribute name='part' type='xs:NMTOKEN' use='required' />\r\n    <xs:attribute name='use' type='soap:useChoice' use='required' />\r\n    <xs:attribute name='encodingStyle' type='soap:encodingStyle' use='optional' />\r\n    <xs:attribute name='namespace' type='xs:anyURI' use='optional' />\r\n  </xs:attributeGroup>\r\n  <xs:complexType name='tHeader'>\r\n    <xs:complexContent mixed='false'>\r\n      <xs:extension base='wsdl:tExtensibilityElement'>\r\n        <xs:sequence>\r\n          <xs:element minOccurs='0' maxOccurs='unbounded' ref='soap:headerfault' />\r\n        </xs:sequence>\r\n        <xs:attributeGroup ref='soap:tHeaderAttributes' />\r\n      </xs:extension>\r\n    </xs:complexContent>\r\n  </xs:complexType>\r\n  <xs:element name='headerfault' type='soap:tHeaderFault' />\r\n  <xs:complexType name='tHeaderFault'>\r\n    <xs:attributeGroup ref='soap:tHeaderAttributes' />\r\n  </xs:complexType>\r\n  <xs:element name='address' type='soap:tAddress' />\r\n  <xs:complexType name='tAddress'>\r\n    <xs:complexContent mixed='false'>\r\n      <xs:extension base='wsdl:tExtensibilityElement'>\r\n        <xs:attribute name='location' type='xs:anyURI' use='required' />\r\n      </xs:extension>\r\n    </xs:complexContent>\r\n  </xs:complexType>\r\n</xs:schema>"), null);
            }
            return schema;
        }
    }
}
