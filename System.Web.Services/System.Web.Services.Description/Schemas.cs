// System.Web.Services.Description.Schemas

internal class Schemas
{
    internal const string Wsdl = "<?xml version='1.0' encoding='UTF-8' ?> \r\n<xs:schema xmlns:xs='http://www.w3.org/2001/XMLSchema'\r\n           xmlns:wsdl='http://schemas.xmlsoap.org/wsdl/'\r\n           targetNamespace='http://schemas.xmlsoap.org/wsdl/'\r\n           elementFormDefault='qualified' >\r\n   \r\n  <xs:complexType mixed='true' name='tDocumentation' >\r\n    <xs:sequence>\r\n      <xs:any minOccurs='0' maxOccurs='unbounded' processContents='lax' />\r\n    </xs:sequence>\r\n  </xs:complexType>\r\n\r\n  <xs:complexType name='tDocumented' >\r\n    <xs:annotation>\r\n      <xs:documentation>\r\n      This type is extended by  component types to allow them to be documented\r\n      </xs:documentation>\r\n    </xs:annotation>\r\n    <xs:sequence>\r\n      <xs:element name='documentation' type='wsdl:tDocumentation' minOccurs='0' />\r\n    </xs:sequence>\r\n  </xs:complexType>\r\n <!-- allow extensibility via elements and attributes on all elements swa124 -->\r\n <xs:complexType name='tExtensibleAttributesDocumented' abstract='true' >\r\n    <xs:complexContent>\r\n      <xs:extension base='wsdl:tDocumented' >\r\n        <xs:annotation>\r\n          <xs:documentation>\r\n          This type is extended by component types to allow attributes from other namespaces to be added.\r\n          </xs:documentation>\r\n        </xs:annotation>\r\n        <xs:sequence>\r\n          <xs:any namespace='##other' minOccurs='0' maxOccurs='unbounded' processContents='lax' />\r\n        </xs:sequence>\r\n        <xs:anyAttribute namespace='##other' processContents='lax' />   \r\n      </xs:extension>\r\n    </xs:complexContent>\r\n  </xs:complexType>\r\n  <xs:complexType name='tExtensibleDocumented' abstract='true' >\r\n    <xs:complexContent>\r\n      <xs:extension base='wsdl:tDocumented' >\r\n        <xs:annotation>\r\n          <xs:documentation>\r\n          This type is extended by component types to allow elements from other namespaces to be added.\r\n          </xs:documentation>\r\n        </xs:annotation>\r\n        <xs:sequence>\r\n          <xs:any namespace='##other' minOccurs='0' maxOccurs='unbounded' processContents='lax' />\r\n        </xs:sequence>\r\n        <xs:anyAttribute namespace='##other' processContents='lax' />   \r\n      </xs:extension>\r\n    </xs:complexContent>\r\n  </xs:complexType>\r\n  <!-- original wsdl removed as part of swa124 resolution\r\n  <xs:complexType name='tExtensibleAttributesDocumented' abstract='true' >\r\n    <xs:complexContent>\r\n      <xs:extension base='wsdl:tDocumented' >\r\n        <xs:annotation>\r\n          <xs:documentation>\r\n          This type is extended by component types to allow attributes from other namespaces to be added.\r\n          </xs:documentation>\r\n        </xs:annotation>\r\n        <xs:anyAttribute namespace='##other' processContents='lax' />    \r\n      </xs:extension>\r\n    </xs:complexContent>\r\n  </xs:complexType>\r\n\r\n  <xs:complexType name='tExtensibleDocumented' abstract='true' >\r\n    <xs:complexContent>\r\n      <xs:extension base='wsdl:tDocumented' >\r\n        <xs:annotation>\r\n          <xs:documentation>\r\n          This type is extended by component types to allow elements from other namespaces to be added.\r\n          </xs:documentation>\r\n        </xs:annotation>\r\n        <xs:sequence>\r\n          <xs:any namespace='##other' minOccurs='0' maxOccurs='unbounded' processContents='lax' />\r\n        </xs:sequence>\r\n      </xs:extension>\r\n    </xs:complexContent>\r\n  </xs:complexType>\r\n -->\r\n  <xs:element name='definitions' type='wsdl:tDefinitions' >\r\n    <xs:key name='message' >\r\n      <xs:selector xpath='wsdl:message' />\r\n      <xs:field xpath='@name' />\r\n    </xs:key>\r\n    <xs:key name='portType' >\r\n      <xs:selector xpath='wsdl:portType' />\r\n      <xs:field xpath='@name' />\r\n    </xs:key>\r\n    <xs:key name='binding' >\r\n      <xs:selector xpath='wsdl:binding' />\r\n      <xs:field xpath='@name' />\r\n    </xs:key>\r\n    <xs:key name='service' >\r\n      <xs:selector xpath='wsdl:service' />\r\n      <xs:field xpath='@name' />\r\n    </xs:key>\r\n    <xs:key name='import' >\r\n      <xs:selector xpath='wsdl:import' />\r\n      <xs:field xpath='@namespace' />\r\n    </xs:key>\r\n  </xs:element>\r\n\r\n  <xs:group name='anyTopLevelOptionalElement' >\r\n    <xs:annotation>\r\n      <xs:documentation>\r\n      Any top level optional element allowed to appear more then once - any child of definitions element except wsdl:types. Any extensibility element is allowed in any place.\r\n      </xs:documentation>\r\n    </xs:annotation>\r\n    <xs:choice>\r\n      <xs:element name='import' type='wsdl:tImport' />\r\n      <xs:element name='types' type='wsdl:tTypes' />                     \r\n      <xs:element name='message'  type='wsdl:tMessage' >\r\n        <xs:unique name='part' >\r\n          <xs:selector xpath='wsdl:part' />\r\n          <xs:field xpath='@name' />\r\n        </xs:unique>\r\n      </xs:element>\r\n      <xs:element name='portType' type='wsdl:tPortType' />\r\n      <xs:element name='binding'  type='wsdl:tBinding' />\r\n      <xs:element name='service'  type='wsdl:tService' >\r\n        <xs:unique name='port' >\r\n          <xs:selector xpath='wsdl:port' />\r\n          <xs:field xpath='@name' />\r\n        </xs:unique>\r\n      </xs:element>\r\n    </xs:choice>\r\n  </xs:group>\r\n\r\n  <xs:complexType name='tDefinitions' >\r\n    <xs:complexContent>\r\n      <xs:extension base='wsdl:tExtensibleDocumented' >\r\n        <xs:sequence>\r\n          <xs:group ref='wsdl:anyTopLevelOptionalElement'  minOccurs='0'   maxOccurs='unbounded' />\r\n        </xs:sequence>\r\n        <xs:attribute name='targetNamespace' type='xs:anyURI' use='optional' />\r\n        <xs:attribute name='name' type='xs:NCName' use='optional' />\r\n      </xs:extension>\r\n    </xs:complexContent>\r\n  </xs:complexType>\r\n   \r\n  <xs:complexType name='tImport' >\r\n    <xs:complexContent>\r\n      <xs:extension base='wsdl:tExtensibleAttributesDocumented' >\r\n        <xs:attribute name='namespace' type='xs:anyURI' use='required' />\r\n        <xs:attribute name='location' type='xs:anyURI' use='required' />\r\n      </xs:extension>\r\n    </xs:complexContent>\r\n  </xs:complexType>\r\n   \r\n  <xs:complexType name='tTypes' >\r\n    <xs:complexContent>   \r\n      <xs:extension base='wsdl:tExtensibleDocumented' />\r\n    </xs:complexContent>   \r\n  </xs:complexType>\r\n     \r\n  <xs:complexType name='tMessage' >\r\n    <xs:complexContent>   \r\n      <xs:extension base='wsdl:tExtensibleDocumented' >\r\n        <xs:sequence>\r\n          <xs:element name='part' type='wsdl:tPart' minOccurs='0' maxOccurs='unbounded' />\r\n        </xs:sequence>\r\n        <xs:attribute name='name' type='xs:NCName' use='required' />\r\n      </xs:extension>\r\n    </xs:complexContent>   \r\n  </xs:complexType>\r\n\r\n  <xs:complexType name='tPart' >\r\n    <xs:complexContent>   \r\n      <xs:extension base='wsdl:tExtensibleAttributesDocumented' >\r\n        <xs:attribute name='name' type='xs:NCName' use='required' />\r\n        <xs:attribute name='element' type='xs:QName' use='optional' />\r\n        <xs:attribute name='type' type='xs:QName' use='optional' />    \r\n      </xs:extension>\r\n    </xs:complexContent>   \r\n  </xs:complexType>\r\n\r\n  <xs:complexType name='tPortType' >\r\n    <xs:complexContent>   \r\n      <xs:extension base='wsdl:tExtensibleAttributesDocumented' >\r\n        <xs:sequence>\r\n          <xs:element name='operation' type='wsdl:tOperation' minOccurs='0' maxOccurs='unbounded' />\r\n        </xs:sequence>\r\n        <xs:attribute name='name' type='xs:NCName' use='required' />\r\n      </xs:extension>\r\n    </xs:complexContent>   \r\n  </xs:complexType>\r\n   \r\n  <xs:complexType name='tOperation' >\r\n    <xs:complexContent>   \r\n      <xs:extension base='wsdl:tExtensibleDocumented' >\r\n        <xs:sequence>\r\n          <xs:choice>\r\n            <xs:group ref='wsdl:request-response-or-one-way-operation' />\r\n            <xs:group ref='wsdl:solicit-response-or-notification-operation' />\r\n          </xs:choice>\r\n        </xs:sequence>\r\n        <xs:attribute name='name' type='xs:NCName' use='required' />\r\n        <xs:attribute name='parameterOrder' type='xs:NMTOKENS' use='optional' />\r\n      </xs:extension>\r\n    </xs:complexContent>   \r\n  </xs:complexType>\r\n    \r\n  <xs:group name='request-response-or-one-way-operation' >\r\n    <xs:sequence>\r\n      <xs:element name='input' type='wsdl:tParam' />\r\n      <xs:sequence minOccurs='0' >\r\n        <xs:element name='output' type='wsdl:tParam' />\r\n        <xs:element name='fault' type='wsdl:tFault' minOccurs='0' maxOccurs='unbounded' />\r\n      </xs:sequence>\r\n    </xs:sequence>\r\n  </xs:group>\r\n\r\n  <xs:group name='solicit-response-or-notification-operation' >\r\n    <xs:sequence>\r\n      <xs:element name='output' type='wsdl:tParam' />\r\n      <xs:sequence minOccurs='0' >\r\n        <xs:element name='input' type='wsdl:tParam' />\r\n        <xs:element name='fault' type='wsdl:tFault' minOccurs='0' maxOccurs='unbounded' />\r\n      </xs:sequence>\r\n    </xs:sequence>\r\n  </xs:group>\r\n        \r\n  <xs:complexType name='tParam' >\r\n    <xs:complexContent>\r\n      <xs:extension base='wsdl:tExtensibleAttributesDocumented' >\r\n        <xs:attribute name='name' type='xs:NCName' use='optional' />\r\n        <xs:attribute name='message' type='xs:QName' use='required' />\r\n      </xs:extension>\r\n    </xs:complexContent>\r\n  </xs:complexType>\r\n\r\n  <xs:complexType name='tFault' >\r\n    <xs:complexContent>\r\n      <xs:extension base='wsdl:tExtensibleAttributesDocumented' >\r\n        <xs:attribute name='name' type='xs:NCName'  use='required' />\r\n        <xs:attribute name='message' type='xs:QName' use='required' />\r\n      </xs:extension>\r\n    </xs:complexContent>\r\n  </xs:complexType>\r\n     \r\n  <xs:complexType name='tBinding' >\r\n    <xs:complexContent>\r\n      <xs:extension base='wsdl:tExtensibleDocumented' >\r\n        <xs:sequence>\r\n          <xs:element name='operation' type='wsdl:tBindingOperation' minOccurs='0' maxOccurs='unbounded' />\r\n        </xs:sequence>\r\n        <xs:attribute name='name' type='xs:NCName' use='required' />\r\n        <xs:attribute name='type' type='xs:QName' use='required' />\r\n      </xs:extension>\r\n    </xs:complexContent>\r\n  </xs:complexType>\r\n    \r\n  <xs:complexType name='tBindingOperationMessage' >\r\n    <xs:complexContent>\r\n      <xs:extension base='wsdl:tExtensibleDocumented' >\r\n        <xs:attribute name='name' type='xs:NCName' use='optional' />\r\n      </xs:extension>\r\n    </xs:complexContent>\r\n  </xs:complexType>\r\n  \r\n  <xs:complexType name='tBindingOperationFault' >\r\n    <xs:complexContent>\r\n      <xs:extension base='wsdl:tExtensibleDocumented' >\r\n        <xs:attribute name='name' type='xs:NCName' use='required' />\r\n      </xs:extension>\r\n    </xs:complexContent>\r\n  </xs:complexType>\r\n\r\n  <xs:complexType name='tBindingOperation' >\r\n    <xs:complexContent>\r\n      <xs:extension base='wsdl:tExtensibleDocumented' >\r\n        <xs:sequence>\r\n          <xs:element name='input' type='wsdl:tBindingOperationMessage' minOccurs='0' />\r\n          <xs:element name='output' type='wsdl:tBindingOperationMessage' minOccurs='0' />\r\n          <xs:element name='fault' type='wsdl:tBindingOperationFault' minOccurs='0' maxOccurs='unbounded' />\r\n        </xs:sequence>\r\n        <xs:attribute name='name' type='xs:NCName' use='required' />\r\n      </xs:extension>\r\n    </xs:complexContent>\r\n  </xs:complexType>\r\n     \r\n  <xs:complexType name='tService' >\r\n    <xs:complexContent>\r\n      <xs:extension base='wsdl:tExtensibleDocumented' >\r\n        <xs:sequence>\r\n          <xs:element name='port' type='wsdl:tPort' minOccurs='0' maxOccurs='unbounded' />\r\n        </xs:sequence>\r\n        <xs:attribute name='name' type='xs:NCName' use='required' />\r\n      </xs:extension>\r\n    </xs:complexContent>\r\n  </xs:complexType>\r\n     \r\n  <xs:complexType name='tPort' >\r\n    <xs:complexContent>\r\n      <xs:extension base='wsdl:tExtensibleDocumented' >\r\n        <xs:attribute name='name' type='xs:NCName' use='required' />\r\n        <xs:attribute name='binding' type='xs:QName' use='required' />\r\n      </xs:extension>\r\n    </xs:complexContent>\r\n  </xs:complexType>\r\n\r\n  <xs:attribute name='arrayType' type='xs:string' />\r\n  <xs:attribute name='required' type='xs:boolean' />\r\n  <xs:complexType name='tExtensibilityElement' abstract='true' >\r\n    <xs:attribute ref='wsdl:required' use='optional' />\r\n  </xs:complexType>\r\n\r\n</xs:schema>";

    internal const string Soap = "<?xml version='1.0' encoding='UTF-8' ?> \r\n<xs:schema xmlns:soap='http://schemas.xmlsoap.org/wsdl/soap/' xmlns:wsdl='http://schemas.xmlsoap.org/wsdl/' targetNamespace='http://schemas.xmlsoap.org/wsdl/soap/' xmlns:xs='http://www.w3.org/2001/XMLSchema'>\r\n  <xs:import namespace='http://schemas.xmlsoap.org/wsdl/' />\r\n  <xs:simpleType name='encodingStyle'>\r\n    <xs:annotation>\r\n      <xs:documentation>\r\n      'encodingStyle' indicates any canonicalization conventions followed in the contents of the containing element.  For example, the value 'http://schemas.xmlsoap.org/soap/encoding/' indicates the pattern described in SOAP specification\r\n      </xs:documentation>\r\n    </xs:annotation>\r\n    <xs:list itemType='xs:anyURI' />\r\n  </xs:simpleType>\r\n  <xs:element name='binding' type='soap:tBinding' />\r\n  <xs:complexType name='tBinding'>\r\n    <xs:complexContent mixed='false'>\r\n      <xs:extension base='wsdl:tExtensibilityElement'>\r\n        <xs:attribute name='transport' type='xs:anyURI' use='required' />\r\n        <xs:attribute name='style' type='soap:tStyleChoice' use='optional' />\r\n      </xs:extension>\r\n    </xs:complexContent>\r\n  </xs:complexType>\r\n  <xs:simpleType name='tStyleChoice'>\r\n    <xs:restriction base='xs:string'>\r\n      <xs:enumeration value='rpc' />\r\n      <xs:enumeration value='document' />\r\n    </xs:restriction>\r\n  </xs:simpleType>\r\n  <xs:element name='operation' type='soap:tOperation' />\r\n  <xs:complexType name='tOperation'>\r\n    <xs:complexContent mixed='false'>\r\n      <xs:extension base='wsdl:tExtensibilityElement'>\r\n        <xs:attribute name='soapAction' type='xs:anyURI' use='optional' />\r\n        <xs:attribute name='style' type='soap:tStyleChoice' use='optional' />\r\n      </xs:extension>\r\n    </xs:complexContent>\r\n  </xs:complexType>\r\n  <xs:element name='body' type='soap:tBody' />\r\n  <xs:attributeGroup name='tBodyAttributes'>\r\n    <xs:attribute name='encodingStyle' type='soap:encodingStyle' use='optional' />\r\n    <xs:attribute name='use' type='soap:useChoice' use='optional' />\r\n    <xs:attribute name='namespace' type='xs:anyURI' use='optional' />\r\n  </xs:attributeGroup>\r\n  <xs:complexType name='tBody'>\r\n    <xs:complexContent mixed='false'>\r\n      <xs:extension base='wsdl:tExtensibilityElement'>\r\n        <xs:attribute name='parts' type='xs:NMTOKENS' use='optional' />\r\n        <xs:attributeGroup ref='soap:tBodyAttributes' />\r\n      </xs:extension>\r\n    </xs:complexContent>\r\n  </xs:complexType>\r\n  <xs:simpleType name='useChoice'>\r\n    <xs:restriction base='xs:string'>\r\n      <xs:enumeration value='literal' />\r\n      <xs:enumeration value='encoded' />\r\n    </xs:restriction>\r\n  </xs:simpleType>\r\n  <xs:element name='fault' type='soap:tFault' />\r\n  <xs:complexType name='tFaultRes' abstract='true'>\r\n    <xs:complexContent mixed='false'>\r\n      <xs:restriction base='soap:tBody'>\r\n        <xs:attribute ref='wsdl:required' use='optional' />\r\n        <xs:attribute name='parts' type='xs:NMTOKENS' use='prohibited' />\r\n        <xs:attributeGroup ref='soap:tBodyAttributes' />\r\n      </xs:restriction>\r\n    </xs:complexContent>\r\n  </xs:complexType>\r\n  <xs:complexType name='tFault'>\r\n    <xs:complexContent mixed='false'>\r\n      <xs:extension base='soap:tFaultRes'>\r\n        <xs:attribute name='name' type='xs:NCName' use='required' />\r\n      </xs:extension>\r\n    </xs:complexContent>\r\n  </xs:complexType>\r\n  <xs:element name='header' type='soap:tHeader' />\r\n  <xs:attributeGroup name='tHeaderAttributes'>\r\n    <xs:attribute name='message' type='xs:QName' use='required' />\r\n    <xs:attribute name='part' type='xs:NMTOKEN' use='required' />\r\n    <xs:attribute name='use' type='soap:useChoice' use='required' />\r\n    <xs:attribute name='encodingStyle' type='soap:encodingStyle' use='optional' />\r\n    <xs:attribute name='namespace' type='xs:anyURI' use='optional' />\r\n  </xs:attributeGroup>\r\n  <xs:complexType name='tHeader'>\r\n    <xs:complexContent mixed='false'>\r\n      <xs:extension base='wsdl:tExtensibilityElement'>\r\n        <xs:sequence>\r\n          <xs:element minOccurs='0' maxOccurs='unbounded' ref='soap:headerfault' />\r\n        </xs:sequence>\r\n        <xs:attributeGroup ref='soap:tHeaderAttributes' />\r\n      </xs:extension>\r\n    </xs:complexContent>\r\n  </xs:complexType>\r\n  <xs:element name='headerfault' type='soap:tHeaderFault' />\r\n  <xs:complexType name='tHeaderFault'>\r\n    <xs:attributeGroup ref='soap:tHeaderAttributes' />\r\n  </xs:complexType>\r\n  <xs:element name='address' type='soap:tAddress' />\r\n  <xs:complexType name='tAddress'>\r\n    <xs:complexContent mixed='false'>\r\n      <xs:extension base='wsdl:tExtensibilityElement'>\r\n        <xs:attribute name='location' type='xs:anyURI' use='required' />\r\n      </xs:extension>\r\n    </xs:complexContent>\r\n  </xs:complexType>\r\n</xs:schema>";

    internal const string WebRef = "<?xml version='1.0' encoding='UTF-8' ?>\r\n<xs:schema xmlns:tns='http://microsoft.com/webReference/' elementFormDefault='qualified' targetNamespace='http://microsoft.com/webReference/' xmlns:xs='http://www.w3.org/2001/XMLSchema'>\r\n  <xs:simpleType name='options'>\r\n    <xs:list>\r\n      <xs:simpleType>\r\n        <xs:restriction base='xs:string'>\r\n          <xs:enumeration value='properties' />\r\n          <xs:enumeration value='newAsync' />\r\n          <xs:enumeration value='oldAsync' />\r\n          <xs:enumeration value='order' />\r\n          <xs:enumeration value='enableDataBinding' />\r\n        </xs:restriction>\r\n      </xs:simpleType>\r\n    </xs:list>\r\n  </xs:simpleType>\r\n  <xs:simpleType name='style'>\r\n    <xs:restriction base='xs:string'>\r\n      <xs:enumeration value='client' />\r\n      <xs:enumeration value='server' />\r\n      <xs:enumeration value='serverInterface' />\r\n    </xs:restriction>\r\n  </xs:simpleType>\r\n  <xs:complexType name='webReferenceOptions'>\r\n    <xs:all>\r\n      <xs:element minOccurs='0' default='oldAsync' name='codeGenerationOptions' type='tns:options' />\r\n      <xs:element minOccurs='0' default='client' name='style' type='tns:style' />\r\n      <xs:element minOccurs='0' default='false' name='verbose' type='xs:boolean' />\r\n      <xs:element minOccurs='0' name='schemaImporterExtensions'>\r\n        <xs:complexType>\r\n          <xs:sequence>\r\n            <xs:element minOccurs='0' maxOccurs='unbounded' name='type' type='xs:string' />\r\n          </xs:sequence>\r\n        </xs:complexType>\r\n      </xs:element>\r\n    </xs:all>\r\n  </xs:complexType>\r\n  <xs:element name='webReferenceOptions' type='tns:webReferenceOptions' />\r\n  <xs:complexType name='wsdlParameters'>\r\n    <xs:all>\r\n      <xs:element minOccurs='0' name='appSettingBaseUrl' type='xs:string' />\r\n      <xs:element minOccurs='0' name='appSettingUrlKey' type='xs:string' />\r\n      <xs:element minOccurs='0' name='domain' type='xs:string' />\r\n      <xs:element minOccurs='0' name='out' type='xs:string' />\r\n      <xs:element minOccurs='0' name='password' type='xs:string' />\r\n      <xs:element minOccurs='0' name='proxy' type='xs:string' />\r\n      <xs:element minOccurs='0' name='proxydomain' type='xs:string' />\r\n      <xs:element minOccurs='0' name='proxypassword' type='xs:string' />\r\n      <xs:element minOccurs='0' name='proxyusername' type='xs:string' />\r\n      <xs:element minOccurs='0' name='username' type='xs:string' />\r\n      <xs:element minOccurs='0' name='namespace' type='xs:string' />\r\n      <xs:element minOccurs='0' name='language' type='xs:string' />\r\n      <xs:element minOccurs='0' name='protocol' type='xs:string' />\r\n      <xs:element minOccurs='0' name='nologo' type='xs:boolean' />\r\n      <xs:element minOccurs='0' name='parsableerrors' type='xs:boolean' />\r\n      <xs:element minOccurs='0' name='sharetypes' type='xs:boolean' />\r\n      <xs:element minOccurs='0' name='webReferenceOptions' type='tns:webReferenceOptions' />\r\n      <xs:element minOccurs='0' name='documents'>\r\n        <xs:complexType>\r\n          <xs:sequence>\r\n            <xs:element minOccurs='0' maxOccurs='unbounded' name='document' type='xs:string' />\r\n          </xs:sequence>\r\n        </xs:complexType>\r\n      </xs:element>\r\n    </xs:all>\r\n  </xs:complexType>\r\n  <xs:element name='wsdlParameters' type='tns:wsdlParameters' />\r\n</xs:schema>";

    internal const string SoapEncoding = "<?xml version='1.0' encoding='UTF-8' ?>\r\n<xs:schema xmlns:xs='http://www.w3.org/2001/XMLSchema'\r\n           xmlns:tns='http://schemas.xmlsoap.org/soap/encoding/'\r\n           targetNamespace='http://schemas.xmlsoap.org/soap/encoding/' >\r\n        \r\n <xs:attribute name='root' >\r\n   <xs:simpleType>\r\n     <xs:restriction base='xs:boolean'>\r\n       <xs:pattern value='0|1' />\r\n     </xs:restriction>\r\n   </xs:simpleType>\r\n </xs:attribute>\r\n\r\n  <xs:attributeGroup name='commonAttributes' >\r\n    <xs:attribute name='id' type='xs:ID' />\r\n    <xs:attribute name='href' type='xs:anyURI' />\r\n    <xs:anyAttribute namespace='##other' processContents='lax' />\r\n  </xs:attributeGroup>\r\n   \r\n  <xs:simpleType name='arrayCoordinate' >\r\n    <xs:restriction base='xs:string' />\r\n  </xs:simpleType>\r\n          \r\n  <xs:attribute name='arrayType' type='xs:string' />\r\n  <xs:attribute name='offset' type='tns:arrayCoordinate' />\r\n  \r\n  <xs:attributeGroup name='arrayAttributes' >\r\n    <xs:attribute ref='tns:arrayType' />\r\n    <xs:attribute ref='tns:offset' />\r\n  </xs:attributeGroup>    \r\n  \r\n  <xs:attribute name='position' type='tns:arrayCoordinate' /> \r\n  \r\n  <xs:attributeGroup name='arrayMemberAttributes' >\r\n    <xs:attribute ref='tns:position' />\r\n  </xs:attributeGroup>    \r\n\r\n  <xs:group name='Array' >\r\n    <xs:sequence>\r\n      <xs:any namespace='##any' minOccurs='0' maxOccurs='unbounded' processContents='lax' />\r\n    </xs:sequence>\r\n  </xs:group>\r\n\r\n  <xs:element name='Array' type='tns:Array' />\r\n  <xs:complexType name='Array' >\r\n    <xs:group ref='tns:Array' minOccurs='0' />\r\n    <xs:attributeGroup ref='tns:arrayAttributes' />\r\n    <xs:attributeGroup ref='tns:commonAttributes' />\r\n  </xs:complexType> \r\n  <xs:element name='Struct' type='tns:Struct' />\r\n  <xs:group name='Struct' >\r\n    <xs:sequence>\r\n      <xs:any namespace='##any' minOccurs='0' maxOccurs='unbounded' processContents='lax' />\r\n    </xs:sequence>\r\n  </xs:group>\r\n\r\n  <xs:complexType name='Struct' >\r\n    <xs:group ref='tns:Struct' minOccurs='0' />\r\n    <xs:attributeGroup ref='tns:commonAttributes'/>\r\n  </xs:complexType> \r\n  \r\n  <xs:simpleType name='base64' >\r\n    <xs:restriction base='xs:base64Binary' />\r\n  </xs:simpleType>\r\n\r\n  <xs:element name='duration' type='tns:duration' />\r\n  <xs:complexType name='duration' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:duration' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='dateTime' type='tns:dateTime' />\r\n  <xs:complexType name='dateTime' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:dateTime' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n\r\n\r\n  <xs:element name='NOTATION' type='tns:NOTATION' />\r\n  <xs:complexType name='NOTATION' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:QName' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n  \r\n\r\n  <xs:element name='time' type='tns:time' />\r\n  <xs:complexType name='time' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:time' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='date' type='tns:date' />\r\n  <xs:complexType name='date' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:date' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='gYearMonth' type='tns:gYearMonth' />\r\n  <xs:complexType name='gYearMonth' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:gYearMonth' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='gYear' type='tns:gYear' />\r\n  <xs:complexType name='gYear' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:gYear' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='gMonthDay' type='tns:gMonthDay' />\r\n  <xs:complexType name='gMonthDay' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:gMonthDay' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='gDay' type='tns:gDay' />\r\n  <xs:complexType name='gDay' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:gDay' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='gMonth' type='tns:gMonth' />\r\n  <xs:complexType name='gMonth' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:gMonth' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n  \r\n  <xs:element name='boolean' type='tns:boolean' />\r\n  <xs:complexType name='boolean' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:boolean' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='base64Binary' type='tns:base64Binary' />\r\n  <xs:complexType name='base64Binary' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:base64Binary' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='hexBinary' type='tns:hexBinary' />\r\n  <xs:complexType name='hexBinary' >\r\n    <xs:simpleContent>\r\n     <xs:extension base='xs:hexBinary' >\r\n       <xs:attributeGroup ref='tns:commonAttributes' />\r\n     </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='float' type='tns:float' />\r\n  <xs:complexType name='float' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:float' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='double' type='tns:double' />\r\n  <xs:complexType name='double' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:double' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='anyURI' type='tns:anyURI' />\r\n  <xs:complexType name='anyURI' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:anyURI' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='QName' type='tns:QName' />\r\n  <xs:complexType name='QName' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:QName' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  \r\n  <xs:element name='string' type='tns:string' />\r\n  <xs:complexType name='string' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:string' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='normalizedString' type='tns:normalizedString' />\r\n  <xs:complexType name='normalizedString' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:normalizedString' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='token' type='tns:token' />\r\n  <xs:complexType name='token' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:token' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='language' type='tns:language' />\r\n  <xs:complexType name='language' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:language' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='Name' type='tns:Name' />\r\n  <xs:complexType name='Name' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:Name' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='NMTOKEN' type='tns:NMTOKEN' />\r\n  <xs:complexType name='NMTOKEN' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:NMTOKEN' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='NCName' type='tns:NCName' />\r\n  <xs:complexType name='NCName' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:NCName' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='NMTOKENS' type='tns:NMTOKENS' />\r\n  <xs:complexType name='NMTOKENS' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:NMTOKENS' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='ID' type='tns:ID' />\r\n  <xs:complexType name='ID' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:ID' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='IDREF' type='tns:IDREF' />\r\n  <xs:complexType name='IDREF' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:IDREF' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='ENTITY' type='tns:ENTITY' />\r\n  <xs:complexType name='ENTITY' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:ENTITY' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='IDREFS' type='tns:IDREFS' />\r\n  <xs:complexType name='IDREFS' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:IDREFS' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='ENTITIES' type='tns:ENTITIES' />\r\n  <xs:complexType name='ENTITIES' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:ENTITIES' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='decimal' type='tns:decimal' />\r\n  <xs:complexType name='decimal' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:decimal' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='integer' type='tns:integer' />\r\n  <xs:complexType name='integer' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:integer' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='nonPositiveInteger' type='tns:nonPositiveInteger' />\r\n  <xs:complexType name='nonPositiveInteger' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:nonPositiveInteger' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='negativeInteger' type='tns:negativeInteger' />\r\n  <xs:complexType name='negativeInteger' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:negativeInteger' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='long' type='tns:long' />\r\n  <xs:complexType name='long' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:long' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='int' type='tns:int' />\r\n  <xs:complexType name='int' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:int' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='short' type='tns:short' />\r\n  <xs:complexType name='short' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:short' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='byte' type='tns:byte' />\r\n  <xs:complexType name='byte' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:byte' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='nonNegativeInteger' type='tns:nonNegativeInteger' />\r\n  <xs:complexType name='nonNegativeInteger' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:nonNegativeInteger' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='unsignedLong' type='tns:unsignedLong' />\r\n  <xs:complexType name='unsignedLong' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:unsignedLong' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='unsignedInt' type='tns:unsignedInt' />\r\n  <xs:complexType name='unsignedInt' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:unsignedInt' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='unsignedShort' type='tns:unsignedShort' />\r\n  <xs:complexType name='unsignedShort' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:unsignedShort' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='unsignedByte' type='tns:unsignedByte' />\r\n  <xs:complexType name='unsignedByte' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:unsignedByte' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='positiveInteger' type='tns:positiveInteger' />\r\n  <xs:complexType name='positiveInteger' >\r\n    <xs:simpleContent>\r\n      <xs:extension base='xs:positiveInteger' >\r\n        <xs:attributeGroup ref='tns:commonAttributes' />\r\n      </xs:extension>\r\n    </xs:simpleContent>\r\n  </xs:complexType>\r\n\r\n  <xs:element name='anyType' />\r\n</xs:schema>";

    private Schemas()
    {
    }
}
