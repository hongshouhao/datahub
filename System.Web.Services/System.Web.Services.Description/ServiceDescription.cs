// System.Web.Services.Description.ServiceDescription
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;

[XmlRoot("definitions", Namespace = "http://schemas.xmlsoap.org/wsdl/")]
[XmlFormatExtensionPoint("Extensions")]
public sealed class ServiceDescription : NamedItem
{
    internal class ServiceDescriptionSerializer : XmlSerializer
    {
        protected override XmlSerializationReader CreateReader()
        {
            return new ServiceDescriptionSerializationReader();
        }

        protected override XmlSerializationWriter CreateWriter()
        {
            return new ServiceDescriptionSerializationWriter();
        }

        public override bool CanDeserialize(XmlReader xmlReader)
        {
            return xmlReader.IsStartElement("definitions", "http://schemas.xmlsoap.org/wsdl/");
        }

        protected override void Serialize(object objectToSerialize, XmlSerializationWriter writer)
        {
            ((ServiceDescriptionSerializationWriter)writer).Write125_definitions(objectToSerialize);
        }

        protected override object Deserialize(XmlSerializationReader reader)
        {
            return ((ServiceDescriptionSerializationReader)reader).Read125_definitions();
        }
    }

    public const string Namespace = "http://schemas.xmlsoap.org/wsdl/";

    internal const string Prefix = "wsdl";

    private Types types;

    private ImportCollection imports;

    private MessageCollection messages;

    private PortTypeCollection portTypes;

    private BindingCollection bindings;

    private ServiceCollection services;

    private string targetNamespace;

    private ServiceDescriptionFormatExtensionCollection extensions;

    private ServiceDescriptionCollection parent;

    private string appSettingUrlKey;

    private string appSettingBaseUrl;

    private string retrievalUrl;

    private static XmlSerializer serializer;

    private static XmlSerializerNamespaces namespaces;

    private const WsiProfiles SupportedClaims = WsiProfiles.BasicProfile1_1;

    private static XmlSchema schema = null;

    private static XmlSchema soapEncodingSchema = null;

    private StringCollection validationWarnings;

    private static StringCollection warnings = new StringCollection();

    private ServiceDescription next;

    [XmlIgnore]
    public string RetrievalUrl
    {
        get
        {
            if (retrievalUrl != null)
            {
                return retrievalUrl;
            }
            return string.Empty;
        }
        set
        {
            retrievalUrl = value;
        }
    }

    [XmlIgnore]
    public ServiceDescriptionCollection ServiceDescriptions
    {
        get
        {
            return parent;
        }
    }

    [XmlIgnore]
    public override ServiceDescriptionFormatExtensionCollection Extensions
    {
        get
        {
            if (extensions == null)
            {
                extensions = new ServiceDescriptionFormatExtensionCollection(this);
            }
            return extensions;
        }
    }

    [XmlElement("import")]
    public ImportCollection Imports
    {
        get
        {
            if (imports == null)
            {
                imports = new ImportCollection(this);
            }
            return imports;
        }
    }

    [XmlElement("types")]
    public Types Types
    {
        get
        {
            if (types == null)
            {
                types = new Types();
            }
            return types;
        }
        set
        {
            types = value;
        }
    }

    [XmlElement("message")]
    public MessageCollection Messages
    {
        get
        {
            if (messages == null)
            {
                messages = new MessageCollection(this);
            }
            return messages;
        }
    }

    [XmlElement("portType")]
    public PortTypeCollection PortTypes
    {
        get
        {
            if (portTypes == null)
            {
                portTypes = new PortTypeCollection(this);
            }
            return portTypes;
        }
    }

    [XmlElement("binding")]
    public BindingCollection Bindings
    {
        get
        {
            if (bindings == null)
            {
                bindings = new BindingCollection(this);
            }
            return bindings;
        }
    }

    [XmlElement("service")]
    public ServiceCollection Services
    {
        get
        {
            if (services == null)
            {
                services = new ServiceCollection(this);
            }
            return services;
        }
    }

    [XmlAttribute("targetNamespace")]
    public string TargetNamespace
    {
        get
        {
            return targetNamespace;
        }
        set
        {
            targetNamespace = value;
        }
    }

    public static XmlSchema Schema
    {
        get
        {
            if (schema == null)
            {
                schema = XmlSchema.Read(new StringReader("<?xml version='1.0' encoding='UTF-8' ?> \r\n<xs:schema xmlns:xs='http://www.w3.org/2001/XMLSchema'\r\n           xmlns:wsdl='http://schemas.xmlsoap.org/wsdl/'\r\n           targetNamespace='http://schemas.xmlsoap.org/wsdl/'\r\n           elementFormDefault='qualified' >\r\n   \r\n  <xs:complexType mixed='true' name='tDocumentation' >\r\n    <xs:sequence>\r\n      <xs:any minOccurs='0' maxOccurs='unbounded' processContents='lax' />\r\n    </xs:sequence>\r\n  </xs:complexType>\r\n\r\n  <xs:complexType name='tDocumented' >\r\n    <xs:annotation>\r\n      <xs:documentation>\r\n      This type is extended by  component types to allow them to be documented\r\n      </xs:documentation>\r\n    </xs:annotation>\r\n    <xs:sequence>\r\n      <xs:element name='documentation' type='wsdl:tDocumentation' minOccurs='0' />\r\n    </xs:sequence>\r\n  </xs:complexType>\r\n <!-- allow extensibility via elements and attributes on all elements swa124 -->\r\n <xs:complexType name='tExtensibleAttributesDocumented' abstract='true' >\r\n    <xs:complexContent>\r\n      <xs:extension base='wsdl:tDocumented' >\r\n        <xs:annotation>\r\n          <xs:documentation>\r\n          This type is extended by component types to allow attributes from other namespaces to be added.\r\n          </xs:documentation>\r\n        </xs:annotation>\r\n        <xs:sequence>\r\n          <xs:any namespace='##other' minOccurs='0' maxOccurs='unbounded' processContents='lax' />\r\n        </xs:sequence>\r\n        <xs:anyAttribute namespace='##other' processContents='lax' />   \r\n      </xs:extension>\r\n    </xs:complexContent>\r\n  </xs:complexType>\r\n  <xs:complexType name='tExtensibleDocumented' abstract='true' >\r\n    <xs:complexContent>\r\n      <xs:extension base='wsdl:tDocumented' >\r\n        <xs:annotation>\r\n          <xs:documentation>\r\n          This type is extended by component types to allow elements from other namespaces to be added.\r\n          </xs:documentation>\r\n        </xs:annotation>\r\n        <xs:sequence>\r\n          <xs:any namespace='##other' minOccurs='0' maxOccurs='unbounded' processContents='lax' />\r\n        </xs:sequence>\r\n        <xs:anyAttribute namespace='##other' processContents='lax' />   \r\n      </xs:extension>\r\n    </xs:complexContent>\r\n  </xs:complexType>\r\n  <!-- original wsdl removed as part of swa124 resolution\r\n  <xs:complexType name='tExtensibleAttributesDocumented' abstract='true' >\r\n    <xs:complexContent>\r\n      <xs:extension base='wsdl:tDocumented' >\r\n        <xs:annotation>\r\n          <xs:documentation>\r\n          This type is extended by component types to allow attributes from other namespaces to be added.\r\n          </xs:documentation>\r\n        </xs:annotation>\r\n        <xs:anyAttribute namespace='##other' processContents='lax' />    \r\n      </xs:extension>\r\n    </xs:complexContent>\r\n  </xs:complexType>\r\n\r\n  <xs:complexType name='tExtensibleDocumented' abstract='true' >\r\n    <xs:complexContent>\r\n      <xs:extension base='wsdl:tDocumented' >\r\n        <xs:annotation>\r\n          <xs:documentation>\r\n          This type is extended by component types to allow elements from other namespaces to be added.\r\n          </xs:documentation>\r\n        </xs:annotation>\r\n        <xs:sequence>\r\n          <xs:any namespace='##other' minOccurs='0' maxOccurs='unbounded' processContents='lax' />\r\n        </xs:sequence>\r\n      </xs:extension>\r\n    </xs:complexContent>\r\n  </xs:complexType>\r\n -->\r\n  <xs:element name='definitions' type='wsdl:tDefinitions' >\r\n    <xs:key name='message' >\r\n      <xs:selector xpath='wsdl:message' />\r\n      <xs:field xpath='@name' />\r\n    </xs:key>\r\n    <xs:key name='portType' >\r\n      <xs:selector xpath='wsdl:portType' />\r\n      <xs:field xpath='@name' />\r\n    </xs:key>\r\n    <xs:key name='binding' >\r\n      <xs:selector xpath='wsdl:binding' />\r\n      <xs:field xpath='@name' />\r\n    </xs:key>\r\n    <xs:key name='service' >\r\n      <xs:selector xpath='wsdl:service' />\r\n      <xs:field xpath='@name' />\r\n    </xs:key>\r\n    <xs:key name='import' >\r\n      <xs:selector xpath='wsdl:import' />\r\n      <xs:field xpath='@namespace' />\r\n    </xs:key>\r\n  </xs:element>\r\n\r\n  <xs:group name='anyTopLevelOptionalElement' >\r\n    <xs:annotation>\r\n      <xs:documentation>\r\n      Any top level optional element allowed to appear more then once - any child of definitions element except wsdl:types. Any extensibility element is allowed in any place.\r\n      </xs:documentation>\r\n    </xs:annotation>\r\n    <xs:choice>\r\n      <xs:element name='import' type='wsdl:tImport' />\r\n      <xs:element name='types' type='wsdl:tTypes' />                     \r\n      <xs:element name='message'  type='wsdl:tMessage' >\r\n        <xs:unique name='part' >\r\n          <xs:selector xpath='wsdl:part' />\r\n          <xs:field xpath='@name' />\r\n        </xs:unique>\r\n      </xs:element>\r\n      <xs:element name='portType' type='wsdl:tPortType' />\r\n      <xs:element name='binding'  type='wsdl:tBinding' />\r\n      <xs:element name='service'  type='wsdl:tService' >\r\n        <xs:unique name='port' >\r\n          <xs:selector xpath='wsdl:port' />\r\n          <xs:field xpath='@name' />\r\n        </xs:unique>\r\n      </xs:element>\r\n    </xs:choice>\r\n  </xs:group>\r\n\r\n  <xs:complexType name='tDefinitions' >\r\n    <xs:complexContent>\r\n      <xs:extension base='wsdl:tExtensibleDocumented' >\r\n        <xs:sequence>\r\n          <xs:group ref='wsdl:anyTopLevelOptionalElement'  minOccurs='0'   maxOccurs='unbounded' />\r\n        </xs:sequence>\r\n        <xs:attribute name='targetNamespace' type='xs:anyURI' use='optional' />\r\n        <xs:attribute name='name' type='xs:NCName' use='optional' />\r\n      </xs:extension>\r\n    </xs:complexContent>\r\n  </xs:complexType>\r\n   \r\n  <xs:complexType name='tImport' >\r\n    <xs:complexContent>\r\n      <xs:extension base='wsdl:tExtensibleAttributesDocumented' >\r\n        <xs:attribute name='namespace' type='xs:anyURI' use='required' />\r\n        <xs:attribute name='location' type='xs:anyURI' use='required' />\r\n      </xs:extension>\r\n    </xs:complexContent>\r\n  </xs:complexType>\r\n   \r\n  <xs:complexType name='tTypes' >\r\n    <xs:complexContent>   \r\n      <xs:extension base='wsdl:tExtensibleDocumented' />\r\n    </xs:complexContent>   \r\n  </xs:complexType>\r\n     \r\n  <xs:complexType name='tMessage' >\r\n    <xs:complexContent>   \r\n      <xs:extension base='wsdl:tExtensibleDocumented' >\r\n        <xs:sequence>\r\n          <xs:element name='part' type='wsdl:tPart' minOccurs='0' maxOccurs='unbounded' />\r\n        </xs:sequence>\r\n        <xs:attribute name='name' type='xs:NCName' use='required' />\r\n      </xs:extension>\r\n    </xs:complexContent>   \r\n  </xs:complexType>\r\n\r\n  <xs:complexType name='tPart' >\r\n    <xs:complexContent>   \r\n      <xs:extension base='wsdl:tExtensibleAttributesDocumented' >\r\n        <xs:attribute name='name' type='xs:NCName' use='required' />\r\n        <xs:attribute name='element' type='xs:QName' use='optional' />\r\n        <xs:attribute name='type' type='xs:QName' use='optional' />    \r\n      </xs:extension>\r\n    </xs:complexContent>   \r\n  </xs:complexType>\r\n\r\n  <xs:complexType name='tPortType' >\r\n    <xs:complexContent>   \r\n      <xs:extension base='wsdl:tExtensibleAttributesDocumented' >\r\n        <xs:sequence>\r\n          <xs:element name='operation' type='wsdl:tOperation' minOccurs='0' maxOccurs='unbounded' />\r\n        </xs:sequence>\r\n        <xs:attribute name='name' type='xs:NCName' use='required' />\r\n      </xs:extension>\r\n    </xs:complexContent>   \r\n  </xs:complexType>\r\n   \r\n  <xs:complexType name='tOperation' >\r\n    <xs:complexContent>   \r\n      <xs:extension base='wsdl:tExtensibleDocumented' >\r\n        <xs:sequence>\r\n          <xs:choice>\r\n            <xs:group ref='wsdl:request-response-or-one-way-operation' />\r\n            <xs:group ref='wsdl:solicit-response-or-notification-operation' />\r\n          </xs:choice>\r\n        </xs:sequence>\r\n        <xs:attribute name='name' type='xs:NCName' use='required' />\r\n        <xs:attribute name='parameterOrder' type='xs:NMTOKENS' use='optional' />\r\n      </xs:extension>\r\n    </xs:complexContent>   \r\n  </xs:complexType>\r\n    \r\n  <xs:group name='request-response-or-one-way-operation' >\r\n    <xs:sequence>\r\n      <xs:element name='input' type='wsdl:tParam' />\r\n      <xs:sequence minOccurs='0' >\r\n        <xs:element name='output' type='wsdl:tParam' />\r\n        <xs:element name='fault' type='wsdl:tFault' minOccurs='0' maxOccurs='unbounded' />\r\n      </xs:sequence>\r\n    </xs:sequence>\r\n  </xs:group>\r\n\r\n  <xs:group name='solicit-response-or-notification-operation' >\r\n    <xs:sequence>\r\n      <xs:element name='output' type='wsdl:tParam' />\r\n      <xs:sequence minOccurs='0' >\r\n        <xs:element name='input' type='wsdl:tParam' />\r\n        <xs:element name='fault' type='wsdl:tFault' minOccurs='0' maxOccurs='unbounded' />\r\n      </xs:sequence>\r\n    </xs:sequence>\r\n  </xs:group>\r\n        \r\n  <xs:complexType name='tParam' >\r\n    <xs:complexContent>\r\n      <xs:extension base='wsdl:tExtensibleAttributesDocumented' >\r\n        <xs:attribute name='name' type='xs:NCName' use='optional' />\r\n        <xs:attribute name='message' type='xs:QName' use='required' />\r\n      </xs:extension>\r\n    </xs:complexContent>\r\n  </xs:complexType>\r\n\r\n  <xs:complexType name='tFault' >\r\n    <xs:complexContent>\r\n      <xs:extension base='wsdl:tExtensibleAttributesDocumented' >\r\n        <xs:attribute name='name' type='xs:NCName'  use='required' />\r\n        <xs:attribute name='message' type='xs:QName' use='required' />\r\n      </xs:extension>\r\n    </xs:complexContent>\r\n  </xs:complexType>\r\n     \r\n  <xs:complexType name='tBinding' >\r\n    <xs:complexContent>\r\n      <xs:extension base='wsdl:tExtensibleDocumented' >\r\n        <xs:sequence>\r\n          <xs:element name='operation' type='wsdl:tBindingOperation' minOccurs='0' maxOccurs='unbounded' />\r\n        </xs:sequence>\r\n        <xs:attribute name='name' type='xs:NCName' use='required' />\r\n        <xs:attribute name='type' type='xs:QName' use='required' />\r\n      </xs:extension>\r\n    </xs:complexContent>\r\n  </xs:complexType>\r\n    \r\n  <xs:complexType name='tBindingOperationMessage' >\r\n    <xs:complexContent>\r\n      <xs:extension base='wsdl:tExtensibleDocumented' >\r\n        <xs:attribute name='name' type='xs:NCName' use='optional' />\r\n      </xs:extension>\r\n    </xs:complexContent>\r\n  </xs:complexType>\r\n  \r\n  <xs:complexType name='tBindingOperationFault' >\r\n    <xs:complexContent>\r\n      <xs:extension base='wsdl:tExtensibleDocumented' >\r\n        <xs:attribute name='name' type='xs:NCName' use='required' />\r\n      </xs:extension>\r\n    </xs:complexContent>\r\n  </xs:complexType>\r\n\r\n  <xs:complexType name='tBindingOperation' >\r\n    <xs:complexContent>\r\n      <xs:extension base='wsdl:tExtensibleDocumented' >\r\n        <xs:sequence>\r\n          <xs:element name='input' type='wsdl:tBindingOperationMessage' minOccurs='0' />\r\n          <xs:element name='output' type='wsdl:tBindingOperationMessage' minOccurs='0' />\r\n          <xs:element name='fault' type='wsdl:tBindingOperationFault' minOccurs='0' maxOccurs='unbounded' />\r\n        </xs:sequence>\r\n        <xs:attribute name='name' type='xs:NCName' use='required' />\r\n      </xs:extension>\r\n    </xs:complexContent>\r\n  </xs:complexType>\r\n     \r\n  <xs:complexType name='tService' >\r\n    <xs:complexContent>\r\n      <xs:extension base='wsdl:tExtensibleDocumented' >\r\n        <xs:sequence>\r\n          <xs:element name='port' type='wsdl:tPort' minOccurs='0' maxOccurs='unbounded' />\r\n        </xs:sequence>\r\n        <xs:attribute name='name' type='xs:NCName' use='required' />\r\n      </xs:extension>\r\n    </xs:complexContent>\r\n  </xs:complexType>\r\n     \r\n  <xs:complexType name='tPort' >\r\n    <xs:complexContent>\r\n      <xs:extension base='wsdl:tExtensibleDocumented' >\r\n        <xs:attribute name='name' type='xs:NCName' use='required' />\r\n        <xs:attribute name='binding' type='xs:QName' use='required' />\r\n      </xs:extension>\r\n    </xs:complexContent>\r\n  </xs:complexType>\r\n\r\n  <xs:attribute name='arrayType' type='xs:string' />\r\n  <xs:attribute name='required' type='xs:boolean' />\r\n  <xs:complexType name='tExtensibilityElement' abstract='true' >\r\n    <xs:attribute ref='wsdl:required' use='optional' />\r\n  </xs:complexType>\r\n\r\n</xs:schema>"), null);
            }
            return schema;
        }
    }

    internal static XmlSchema SoapEncodingSchema
    {
        get
        {
            if (soapEncodingSchema == null)
            {
                soapEncodingSchema = XmlSchema.Read(new StringReader("<?xml version='1.0' encoding='UTF-8' ?>\r\n<xs:schema xmlns:xs='http://www.w3.org/2001/XMLSchema'\r\n           xmlns:tns='http://schemas.xmlsoap.org/soap/encoding/'\r\n           targetNamespace='http://schemas.xmlsoap.org/soap/encoding/' >\r\n        \r\n <xs:attribute name='root' >\r\n   <xs:simpleType>\r\n     <xs:restriction base='xs:boolean'>\r\n       <xs:pattern value='0|1' />\r\n     </xs:restriction>\r\n   </xs:simpleType>\r\n </xs:attribute>\r\n\r\n  <xs:attributeGroup name='commonAttributes' >\r\n    <xs:attribute name='id' type='xs:ID' />\r\n    <xs:attribute name='href' type='xs:anyURI' />\r\n    <xs:anyAttribute namespace='##other' processContents='lax' />\r\n  </xs:attributeGroup>\r\n   \r\n  <xs:simpleType name='arrayCoordinate' >\r\n    <xs:restriction base='xs:string' />\r\n  </xs:simpleType>\r\n          \r\n  <xs:attribute name='arrayType' type='xs:string' />\r\n  <xs:attribute name='offset' type='tns:arrayCoordinate' />\r\n  \r\n  <xs:attributeGroup name='arrayAttributes' >\r\n    <xs:attribute ref='tns:arrayType' />\r\n    <xs:attribute ref='tns:offset' />\r\n  </xs:attributeGroup>    \r\n  \r\n  <xs:attribute name='position' type='tns:arrayCoordinate' /> \r\n  \r\n  <xs:attributeGroup name='arrayMemberAttributes' >\r\n    <xs:attribute ref='tns:position' />\r\n  </xs:attributeGroup>    \r\n\r\n  <xs:group name='Array' >\r\n    <xs:sequence>\r\n      <xs:any namespace='##any' minOccurs='0' maxOccurs='unbounded' processContents='lax' />\r\n    </xs:sequence>\r\n  </xs:group>\r\n\r\n  <xs:element name='Array' type='tns:Array' />\r\n  <xs:complexType name='Array' >\r\n    <xs:group ref='tns:Array' minOccurs='0' />\r\n    <xs:attributeGroup ref='tns:arrayAttributes' />\r\n    <xs:attributeGroup ref='tns:commonAttributes' />\r\n  </xs:complexType> \r\n  <xs:element name='Struct' type='tns:Struct' />\r\n  <xs:group name='Struct' >\r\n    <xs:sequence>\r\n      <xs:any namespace='##any' minOccurs='0' maxOccurs='unbounded' processContents='lax' />\r\n    </xs:sequence>\r\n  </xs:group>\r\n\r\n  <xs:complexType name='Struct' >\r\n    <xs:group ref='tns:Struct' minOccurs='0' />\r\n    <xs:attributeGroup ref='tns:commonAttributes'/>\r\n  </xs:complexType> \r\n  \r\n  <xs:simpleType name='base64' >\r\n    <xs:restriction base='xs:base64Binary' />\r\n  </xs:simpleType>\r\n\r\n  <xs:element name='duration' type='tns:duration' />\r\n  <xs:complexType name='duration' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:duration' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='dateTime' type='tns:dateTime' />\r\n  <xs:complexType name='dateTime' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:dateTime' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n\r\n\r\n  <xs:element name='NOTATION' type='tns:NOTATION' />\r\n  <xs:complexType name='NOTATION' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:QName' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n  \r\n\r\n  <xs:element name='time' type='tns:time' />\r\n  <xs:complexType name='time' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:time' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='date' type='tns:date' />\r\n  <xs:complexType name='date' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:date' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='gYearMonth' type='tns:gYearMonth' />\r\n  <xs:complexType name='gYearMonth' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:gYearMonth' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='gYear' type='tns:gYear' />\r\n  <xs:complexType name='gYear' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:gYear' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='gMonthDay' type='tns:gMonthDay' />\r\n  <xs:complexType name='gMonthDay' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:gMonthDay' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='gDay' type='tns:gDay' />\r\n  <xs:complexType name='gDay' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:gDay' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='gMonth' type='tns:gMonth' />\r\n  <xs:complexType name='gMonth' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:gMonth' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n  \r\n  <xs:element name='boolean' type='tns:boolean' />\r\n  <xs:complexType name='boolean' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:boolean' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='base64Binary' type='tns:base64Binary' />\r\n  <xs:complexType name='base64Binary' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:base64Binary' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='hexBinary' type='tns:hexBinary' />\r\n  <xs:complexType name='hexBinary' >\r\n    <xs:simpleContent>\r\n     <xs:extension base='xs:hexBinary' >\r\n       <xs:attributeGroup ref='tns:commonAttributes' />\r\n     </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='float' type='tns:float' />\r\n  <xs:complexType name='float' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:float' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='double' type='tns:double' />\r\n  <xs:complexType name='double' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:double' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='anyURI' type='tns:anyURI' />\r\n  <xs:complexType name='anyURI' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:anyURI' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='QName' type='tns:QName' />\r\n  <xs:complexType name='QName' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:QName' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  \r\n  <xs:element name='string' type='tns:string' />\r\n  <xs:complexType name='string' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:string' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='normalizedString' type='tns:normalizedString' />\r\n  <xs:complexType name='normalizedString' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:normalizedString' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='token' type='tns:token' />\r\n  <xs:complexType name='token' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:token' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='language' type='tns:language' />\r\n  <xs:complexType name='language' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:language' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='Name' type='tns:Name' />\r\n  <xs:complexType name='Name' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:Name' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='NMTOKEN' type='tns:NMTOKEN' />\r\n  <xs:complexType name='NMTOKEN' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:NMTOKEN' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='NCName' type='tns:NCName' />\r\n  <xs:complexType name='NCName' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:NCName' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='NMTOKENS' type='tns:NMTOKENS' />\r\n  <xs:complexType name='NMTOKENS' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:NMTOKENS' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='ID' type='tns:ID' />\r\n  <xs:complexType name='ID' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:ID' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='IDREF' type='tns:IDREF' />\r\n  <xs:complexType name='IDREF' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:IDREF' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='ENTITY' type='tns:ENTITY' />\r\n  <xs:complexType name='ENTITY' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:ENTITY' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='IDREFS' type='tns:IDREFS' />\r\n  <xs:complexType name='IDREFS' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:IDREFS' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='ENTITIES' type='tns:ENTITIES' />\r\n  <xs:complexType name='ENTITIES' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:ENTITIES' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='decimal' type='tns:decimal' />\r\n  <xs:complexType name='decimal' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:decimal' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='integer' type='tns:integer' />\r\n  <xs:complexType name='integer' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:integer' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='nonPositiveInteger' type='tns:nonPositiveInteger' />\r\n  <xs:complexType name='nonPositiveInteger' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:nonPositiveInteger' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='negativeInteger' type='tns:negativeInteger' />\r\n  <xs:complexType name='negativeInteger' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:negativeInteger' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='long' type='tns:long' />\r\n  <xs:complexType name='long' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:long' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='int' type='tns:int' />\r\n  <xs:complexType name='int' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:int' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='short' type='tns:short' />\r\n  <xs:complexType name='short' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:short' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='byte' type='tns:byte' />\r\n  <xs:complexType name='byte' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:byte' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='nonNegativeInteger' type='tns:nonNegativeInteger' />\r\n  <xs:complexType name='nonNegativeInteger' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:nonNegativeInteger' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='unsignedLong' type='tns:unsignedLong' />\r\n  <xs:complexType name='unsignedLong' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:unsignedLong' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='unsignedInt' type='tns:unsignedInt' />\r\n  <xs:complexType name='unsignedInt' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:unsignedInt' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='unsignedShort' type='tns:unsignedShort' />\r\n  <xs:complexType name='unsignedShort' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:unsignedShort' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='unsignedByte' type='tns:unsignedByte' />\r\n  <xs:complexType name='unsignedByte' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:unsignedByte' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='positiveInteger' type='tns:positiveInteger' />\r\n  <xs:complexType name='positiveInteger' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:positiveInteger' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='anyType' />\r\n</xs:schema>"), null);
            }
            return soapEncodingSchema;
        }
    }

    [XmlIgnore]
    public StringCollection ValidationWarnings
    {
        get
        {
            if (validationWarnings == null)
            {
                validationWarnings = new StringCollection();
            }
            return validationWarnings;
        }
    }

    [XmlIgnore]
    public static XmlSerializer Serializer
    {
        get
        {
            if (serializer == null)
            {
                WebServicesSection config = WebServicesSection.Current;
                XmlAttributeOverrides overrides = new XmlAttributeOverrides();
                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                ns.Add("s", "http://www.w3.org/2001/XMLSchema");
                WebServicesSection.LoadXmlFormatExtensions(config.GetAllFormatExtensionTypes(), overrides, ns);
                namespaces = ns;
                serializer = new ServiceDescriptionSerializer();
            }
            return serializer;
        }
    }

    internal string AppSettingBaseUrl
    {
        get
        {
            return appSettingBaseUrl;
        }
        set
        {
            appSettingBaseUrl = value;
        }
    }

    internal string AppSettingUrlKey
    {
        get
        {
            return appSettingUrlKey;
        }
        set
        {
            appSettingUrlKey = value;
        }
    }

    internal ServiceDescription Next
    {
        get
        {
            return next;
        }
        set
        {
            next = value;
        }
    }

    private static void InstanceValidation(object sender, ValidationEventArgs args)
    {
        StringCollection stringCollection = warnings;
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
        stringCollection.Add(ResWebServices.GetString(wsdlInstanceValidationDetails, obj));
    }

    internal void SetParent(ServiceDescriptionCollection parent)
    {
        this.parent = parent;
    }

    private bool ShouldSerializeTypes()
    {
        return Types.HasItems();
    }

    internal void SetWarnings(StringCollection warnings)
    {
        validationWarnings = warnings;
    }

    public static ServiceDescription Read(TextReader textReader)
    {
        return Read(textReader, false);
    }

    public static ServiceDescription Read(Stream stream)
    {
        return Read(stream, false);
    }

    public static ServiceDescription Read(XmlReader reader)
    {
        return Read(reader, false);
    }

    public static ServiceDescription Read(string fileName)
    {
        return Read(fileName, false);
    }

    public static ServiceDescription Read(TextReader textReader, bool validate)
    {
        XmlTextReader reader = new XmlTextReader(textReader);
        reader.WhitespaceHandling = WhitespaceHandling.Significant;
        reader.XmlResolver = null;
        reader.DtdProcessing = DtdProcessing.Prohibit;
        return Read(reader, validate);
    }

    public static ServiceDescription Read(Stream stream, bool validate)
    {
        XmlTextReader reader = new XmlTextReader(stream);
        reader.WhitespaceHandling = WhitespaceHandling.Significant;
        reader.XmlResolver = null;
        reader.DtdProcessing = DtdProcessing.Prohibit;
        return Read(reader, validate);
    }

    public static ServiceDescription Read(string fileName, bool validate)
    {
        StreamReader reader = new StreamReader(File.OpenRead(fileName), true);
        try
        {
            return Read(reader, validate);
        }
        finally
        {
            reader.Dispose();
        }
    }

    public static ServiceDescription Read(XmlReader reader, bool validate)
    {
        if (validate)
        {
            XmlReaderSettings readerSettings = new XmlReaderSettings();
            readerSettings.ValidationType = ValidationType.Schema;
            readerSettings.ValidationFlags = XmlSchemaValidationFlags.ProcessIdentityConstraints;
            readerSettings.Schemas.Add(Schema);
            readerSettings.Schemas.Add(SoapBinding.Schema);
            readerSettings.ValidationEventHandler += InstanceValidation;
            warnings.Clear();
            XmlReader validatingReader = XmlReader.Create(reader, readerSettings);
            if (reader.ReadState != 0)
            {
                validatingReader.Read();
            }
            ServiceDescription sd = (ServiceDescription)Serializer.Deserialize(validatingReader);
            sd.SetWarnings(warnings);
            return sd;
        }
        return (ServiceDescription)Serializer.Deserialize(reader);
    }

    public static bool CanRead(XmlReader reader)
    {
        return Serializer.CanDeserialize(reader);
    }

    public void Write(string fileName)
    {
        StreamWriter writer = new StreamWriter(File.OpenWrite(fileName));
        try
        {
            Write(writer);
        }
        finally
        {
            writer.Dispose();
        }
    }

    public void Write(TextWriter writer)
    {
        XmlTextWriter xmlWriter = new XmlTextWriter(writer);
        xmlWriter.Formatting = Formatting.Indented;
        xmlWriter.Indentation = 2;
        Write(xmlWriter);
    }

    public void Write(Stream stream)
    {
        TextWriter writer = new StreamWriter(stream);
        Write(writer);
        writer.Flush();
    }

    public void Write(XmlWriter writer)
    {
        XmlSerializer serializer = Serializer;
        XmlSerializerNamespaces ns;
        if (base.Namespaces == null || base.Namespaces.Count == 0)
        {
            ns = new XmlSerializerNamespaces(namespaces);
            ns.Add("wsdl", "http://schemas.xmlsoap.org/wsdl/");
            if (TargetNamespace != null && TargetNamespace.Length != 0)
            {
                ns.Add("tns", TargetNamespace);
            }
            for (int i = 0; i < Types.Schemas.Count; i++)
            {
                string tns = Types.Schemas[i].TargetNamespace;
                if (tns != null && tns.Length > 0 && tns != TargetNamespace && tns != "http://schemas.xmlsoap.org/wsdl/")
                {
                    ns.Add("s" + i.ToString(CultureInfo.InvariantCulture), tns);
                }
            }
            for (int j = 0; j < Imports.Count; j++)
            {
                Import import = Imports[j];
                if (import.Namespace.Length > 0)
                {
                    ns.Add("i" + j.ToString(CultureInfo.InvariantCulture), import.Namespace);
                }
            }
        }
        else
        {
            ns = base.Namespaces;
        }
        serializer.Serialize(writer, this, ns);
    }

    internal static WsiProfiles GetConformanceClaims(XmlElement documentation)
    {
        if (documentation == null)
        {
            return WsiProfiles.None;
        }
        WsiProfiles existingClaims = WsiProfiles.None;
        XmlNode sibling;
        for (XmlNode child = documentation.FirstChild; child != null; child = sibling)
        {
            sibling = child.NextSibling;
            if (child is XmlElement)
            {
                XmlElement element = (XmlElement)child;
                if (element.LocalName == "Claim" && element.NamespaceURI == "http://ws-i.org/schemas/conformanceClaim/" && "http://ws-i.org/profiles/basic/1.1" == element.GetAttribute("conformsTo"))
                {
                    existingClaims |= WsiProfiles.BasicProfile1_1;
                }
            }
        }
        return existingClaims;
    }

    internal static void AddConformanceClaims(XmlElement documentation, WsiProfiles claims)
    {
        claims &= WsiProfiles.BasicProfile1_1;
        if (claims != 0)
        {
            WsiProfiles existingClaims = GetConformanceClaims(documentation);
            claims &= ~existingClaims;
            if (claims != 0)
            {
                XmlDocument d = documentation.OwnerDocument;
                if ((claims & WsiProfiles.BasicProfile1_1) != 0)
                {
                    XmlElement claim = d.CreateElement("wsi", "Claim", "http://ws-i.org/schemas/conformanceClaim/");
                    claim.SetAttribute("conformsTo", "http://ws-i.org/profiles/basic/1.1");
                    documentation.InsertBefore(claim, null);
                }
            }
        }
    }
}
