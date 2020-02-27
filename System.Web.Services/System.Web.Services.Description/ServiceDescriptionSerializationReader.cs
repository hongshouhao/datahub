// System.Web.Services.Description.ServiceDescriptionSerializationReader
using System.Collections;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

internal class ServiceDescriptionSerializationReader : XmlSerializationReader
{
    private Hashtable _XmlSchemaDerivationMethodValues;

    private string id133_XmlSchemaSimpleTypeUnion;

    private string id143_maxInclusive;

    private string id46_body;

    private string id190_any;

    private string id88_OperationOutput;

    private string id6_targetNamespace;

    private string id158_XmlSchemaMaxLengthFacet;

    private string id11_portType;

    private string id182_mixed;

    private string id172_keyref;

    private string id187_all;

    private string id162_itemType;

    private string id68_InputBinding;

    private string id25_HttpAddressBinding;

    private string id82_HttpBinding;

    private string id17_address;

    private string id3_ServiceDescription;

    private string id38_SoapFaultBinding;

    private string id123_ref;

    private string id198_XmlSchemaComplexContent;

    private string id53_parts;

    private string id35_use;

    private string id157_XmlSchemaLengthFacet;

    private string id207_XmlSchemaImport;

    private string id44_text;

    private string id117_XmlSchemaAppInfo;

    private string id203_public;

    private string id69_urlEncoded;

    private string id7_documentation;

    private string id19_Item;

    private string id129_final;

    private string id163_XmlSchemaElement;

    private string id60_capture;

    private string id37_encodingStyle;

    private string id185_sequence;

    private string id166_abstract;

    private string id23_location;

    private string id111_XmlSchemaAttributeGroup;

    private string id192_XmlSchemaSequence;

    private string id33_FaultBinding;

    private string id153_XmlSchemaMaxInclusiveFacet;

    private string id201_XmlSchemaGroup;

    private string id43_multipartRelated;

    private string id168_nillable;

    private string id149_value;

    private string id64_MimeMultipartRelatedBinding;

    private string id193_XmlSchemaAny;

    private string id191_XmlSchemaGroupRef;

    private string id74_soapAction;

    private string id63_ignoreCase;

    private string id101_version;

    private string id47_header;

    private string id195_extension;

    private string id48_Soap12HeaderBinding;

    private string id134_memberTypes;

    private string id121_Item;

    private string id146_minExclusive;

    private string id84_PortType;

    private string id42_mimeXml;

    private string id138_minInclusive;

    private string id118_source;

    private string id73_Soap12OperationBinding;

    private string id131_restriction;

    private string id152_XmlSchemaMaxExclusiveFacet;

    private string id135_XmlSchemaSimpleTypeRestriction;

    private string id188_XmlSchemaAll;

    private string id116_appinfo;

    private string id86_parameterOrder;

    private string id147_minLength;

    private string id78_HttpOperationBinding;

    private string id161_XmlSchemaSimpleTypeList;

    private string id205_XmlSchemaRedefine;

    private string id194_XmlSchemaSimpleContent;

    private string id91_MessagePart;

    private string id92_element;

    private string id114_processContents;

    private string id18_Item;

    private string id50_headerfault;

    private string id154_XmlSchemaEnumerationFacet;

    private string id96_XmlSchema;

    private string id127_form;

    private string id176_field;

    private string id49_part;

    private string id5_Item;

    private string id57_match;

    private string id52_Soap12BodyBinding;

    private string id104_redefine;

    private string id20_Item;

    private string id21_Soap12AddressBinding;

    private string id142_enumeration;

    private string id24_SoapAddressBinding;

    private string id103_include;

    private string id139_maxLength;

    private string id165_maxOccurs;

    private string id65_MimePart;

    private string id102_id;

    private string id196_Item;

    private string id140_length;

    private string id27_type;

    private string id106_complexType;

    private string id31_output;

    private string id1_definitions;

    private string id4_name;

    private string id132_union;

    private string id29_OperationBinding;

    private string id170_key;

    private string id45_Item;

    private string id95_Item;

    private string id169_substitutionGroup;

    private string id178_xpath;

    private string id9_types;

    private string id97_attributeFormDefault;

    private string id62_pattern;

    private string id58_MimeTextMatch;

    private string id180_XmlSchemaKey;

    private string id10_message;

    private string id8_import;

    private string id148_XmlSchemaMinLengthFacet;

    private string id105_simpleType;

    private string id181_XmlSchemaComplexType;

    private string id164_minOccurs;

    private string id144_maxExclusive;

    private string id160_XmlSchemaFractionDigitsFacet;

    private string id124_XmlSchemaAttribute;

    private string id209_Import;

    private string id206_schemaLocation;

    private string id179_XmlSchemaUnique;

    private string id75_style;

    private string id119_XmlSchemaDocumentation;

    private string id136_base;

    private string id66_MimeXmlBinding;

    private string id30_input;

    private string id40_content;

    private string id93_Types;

    private string id94_schema;

    private string id200_Item;

    private string id67_MimeContentBinding;

    private string id59_group;

    private string id32_fault;

    private string id80_transport;

    private string id98_blockDefault;

    private string id13_service;

    private string id54_SoapHeaderBinding;

    private string id204_system;

    private string id16_Port;

    private string id108_notation;

    private string id186_choice;

    private string id110_attributeGroup;

    private string id79_Soap12Binding;

    private string id77_SoapOperationBinding;

    private string id115_XmlSchemaAnnotation;

    private string id83_verb;

    private string id72_HttpUrlEncodedBinding;

    private string id39_OutputBinding;

    private string id183_complexContent;

    private string id202_XmlSchemaNotation;

    private string id81_SoapBinding;

    private string id199_Item;

    private string id28_operation;

    private string id122_XmlSchemaAttributeGroupRef;

    private string id155_XmlSchemaPatternFacet;

    private string id76_soapActionRequired;

    private string id90_Message;

    private string id159_XmlSchemaMinInclusiveFacet;

    private string id208_XmlSchemaInclude;

    private string id85_Operation;

    private string id130_list;

    private string id14_Service;

    private string id22_required;

    private string id174_refer;

    private string id71_HttpUrlReplacementBinding;

    private string id56_MimeTextBinding;

    private string id87_OperationFault;

    private string id125_default;

    private string id15_port;

    private string id51_SoapHeaderFaultBinding;

    private string id128_XmlSchemaSimpleType;

    private string id36_namespace;

    private string id175_selector;

    private string id150_XmlSchemaMinExclusiveFacet;

    private string id100_elementFormDefault;

    private string id26_Binding;

    private string id197_Item;

    private string id126_fixed;

    private string id107_annotation;

    private string id99_finalDefault;

    private string id137_fractionDigits;

    private string id70_urlReplacement;

    private string id189_XmlSchemaChoice;

    private string id2_Item;

    private string id112_anyAttribute;

    private string id89_OperationInput;

    private string id141_totalDigits;

    private string id61_repeats;

    private string id184_simpleContent;

    private string id55_SoapBodyBinding;

    private string id145_whiteSpace;

    private string id167_block;

    private string id151_XmlSchemaWhiteSpaceFacet;

    private string id12_binding;

    private string id109_attribute;

    private string id171_unique;

    private string id120_lang;

    private string id173_XmlSchemaKeyref;

    private string id177_XmlSchemaXPath;

    private string id34_Soap12FaultBinding;

    private string id41_Item;

    private string id156_XmlSchemaTotalDigitsFacet;

    private string id113_XmlSchemaAnyAttribute;

    internal Hashtable XmlSchemaDerivationMethodValues
    {
        get
        {
            if (_XmlSchemaDerivationMethodValues == null)
            {
                Hashtable h = new Hashtable();
                h.Add("", 0L);
                h.Add("substitution", 1L);
                h.Add("extension", 2L);
                h.Add("restriction", 4L);
                h.Add("list", 8L);
                h.Add("union", 16L);
                h.Add("#all", 255L);
                _XmlSchemaDerivationMethodValues = h;
            }
            return _XmlSchemaDerivationMethodValues;
        }
    }

    public object Read125_definitions()
    {
        object o = null;
        base.Reader.MoveToContent();
        if (base.Reader.NodeType == XmlNodeType.Element)
        {
            if ((object)base.Reader.LocalName == id1_definitions && (object)base.Reader.NamespaceURI == id2_Item)
            {
                o = Read124_ServiceDescription(true, true);
                goto IL_0060;
            }
            throw CreateUnknownNodeException();
        }
        UnknownNode(null, "http://schemas.xmlsoap.org/wsdl/:definitions");
        goto IL_0060;
    IL_0060:
        return o;
    }

    private ServiceDescription Read124_ServiceDescription(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id3_ServiceDescription || (object)xsiType.Namespace != id2_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        ServiceDescription o = new ServiceDescription();
        XmlAttribute[] a_16 = null;
        int ca_ = 0;
        ServiceDescriptionFormatExtensionCollection a_15 = o.Extensions;
        ImportCollection a_14 = o.Imports;
        MessageCollection a_13 = o.Messages;
        PortTypeCollection a_12 = o.PortTypes;
        BindingCollection a_11 = o.Bindings;
        ServiceCollection a_10 = o.Services;
        bool[] paramsRead = new bool[12];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[3] && (object)base.Reader.LocalName == id4_name && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Name = base.Reader.Value;
                paramsRead[3] = true;
            }
            else if (!paramsRead[11] && (object)base.Reader.LocalName == id6_targetNamespace && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.TargetNamespace = base.Reader.Value;
                paramsRead[11] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_16 = (XmlAttribute[])EnsureArrayIndex(a_16, ca_, typeof(XmlAttribute));
                a_16[ca_++] = attr;
            }
        }
        o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_16, ca_, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_16, ca_, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations0 = 0;
        int readerCount0 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[0] && (object)base.Reader.LocalName == id7_documentation && (object)base.Reader.NamespaceURI == id2_Item)
                {
                    o.DocumentationElement = (XmlElement)ReadXmlNode(false);
                    paramsRead[0] = true;
                }
                else if ((object)base.Reader.LocalName == id8_import && (object)base.Reader.NamespaceURI == id2_Item)
                {
                    if (a_14 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_14.Add(Read4_Import(false, true));
                    }
                }
                else if (!paramsRead[6] && (object)base.Reader.LocalName == id9_types && (object)base.Reader.NamespaceURI == id2_Item)
                {
                    o.Types = Read67_Types(false, true);
                    paramsRead[6] = true;
                }
                else if ((object)base.Reader.LocalName == id10_message && (object)base.Reader.NamespaceURI == id2_Item)
                {
                    if (a_13 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_13.Add(Read69_Message(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id11_portType && (object)base.Reader.NamespaceURI == id2_Item)
                {
                    if (a_12 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_12.Add(Read75_PortType(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id12_binding && (object)base.Reader.NamespaceURI == id2_Item)
                {
                    if (a_11 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_11.Add(Read117_Binding(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id13_service && (object)base.Reader.NamespaceURI == id2_Item)
                {
                    if (a_10 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_10.Add(Read123_Service(false, true));
                    }
                }
                else
                {
                    a_15.Add((XmlElement)ReadXmlNode(false));
                }
            }
            else
            {
                UnknownNode(o, "http://schemas.xmlsoap.org/wsdl/:documentation, http://schemas.xmlsoap.org/wsdl/:import, http://schemas.xmlsoap.org/wsdl/:types, http://schemas.xmlsoap.org/wsdl/:message, http://schemas.xmlsoap.org/wsdl/:portType, http://schemas.xmlsoap.org/wsdl/:binding, http://schemas.xmlsoap.org/wsdl/:service");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations0, ref readerCount0);
        }
        o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_16, ca_, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private Service Read123_Service(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id14_Service || (object)xsiType.Namespace != id2_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        Service o = new Service();
        XmlAttribute[] a_7 = null;
        int ca_ = 0;
        ServiceDescriptionFormatExtensionCollection a_6 = o.Extensions;
        PortCollection a_5 = o.Ports;
        bool[] paramsRead = new bool[6];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[3] && (object)base.Reader.LocalName == id4_name && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Name = base.Reader.Value;
                paramsRead[3] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_7 = (XmlAttribute[])EnsureArrayIndex(a_7, ca_, typeof(XmlAttribute));
                a_7[ca_++] = attr;
            }
        }
        o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_7, ca_, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_7, ca_, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations = 0;
        int readerCount = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[0] && (object)base.Reader.LocalName == id7_documentation && (object)base.Reader.NamespaceURI == id2_Item)
                {
                    o.DocumentationElement = (XmlElement)ReadXmlNode(false);
                    paramsRead[0] = true;
                }
                else if ((object)base.Reader.LocalName == id15_port && (object)base.Reader.NamespaceURI == id2_Item)
                {
                    if (a_5 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_5.Add(Read122_Port(false, true));
                    }
                }
                else
                {
                    a_6.Add((XmlElement)ReadXmlNode(false));
                }
            }
            else
            {
                UnknownNode(o, "http://schemas.xmlsoap.org/wsdl/:documentation, http://schemas.xmlsoap.org/wsdl/:port");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations, ref readerCount);
        }
        o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_7, ca_, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private Port Read122_Port(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id16_Port || (object)xsiType.Namespace != id2_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        Port o = new Port();
        XmlAttribute[] a_5 = null;
        int ca_ = 0;
        ServiceDescriptionFormatExtensionCollection a_4 = o.Extensions;
        bool[] paramsRead = new bool[6];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[3] && (object)base.Reader.LocalName == id4_name && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Name = base.Reader.Value;
                paramsRead[3] = true;
            }
            else if (!paramsRead[5] && (object)base.Reader.LocalName == id12_binding && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Binding = ToXmlQualifiedName(base.Reader.Value);
                paramsRead[5] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_5 = (XmlAttribute[])EnsureArrayIndex(a_5, ca_, typeof(XmlAttribute));
                a_5[ca_++] = attr;
            }
        }
        o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_5, ca_, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_5, ca_, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations2 = 0;
        int readerCount2 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[0] && (object)base.Reader.LocalName == id7_documentation && (object)base.Reader.NamespaceURI == id2_Item)
                {
                    o.DocumentationElement = (XmlElement)ReadXmlNode(false);
                    paramsRead[0] = true;
                }
                else if ((object)base.Reader.LocalName == id17_address && (object)base.Reader.NamespaceURI == id18_Item)
                {
                    if (a_4 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_4.Add(Read118_HttpAddressBinding(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id17_address && (object)base.Reader.NamespaceURI == id19_Item)
                {
                    if (a_4 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_4.Add(Read119_SoapAddressBinding(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id17_address && (object)base.Reader.NamespaceURI == id20_Item)
                {
                    if (a_4 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_4.Add(Read121_Soap12AddressBinding(false, true));
                    }
                }
                else
                {
                    a_4.Add((XmlElement)ReadXmlNode(false));
                }
            }
            else
            {
                UnknownNode(o, "http://schemas.xmlsoap.org/wsdl/:documentation, http://schemas.xmlsoap.org/wsdl/http/:address, http://schemas.xmlsoap.org/wsdl/soap/:address, http://schemas.xmlsoap.org/wsdl/soap12/:address");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations2, ref readerCount2);
        }
        o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_5, ca_, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private Soap12AddressBinding Read121_Soap12AddressBinding(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id21_Soap12AddressBinding || (object)xsiType.Namespace != id20_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        Soap12AddressBinding o = new Soap12AddressBinding();
        bool[] paramsRead = new bool[2];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[0] && (object)base.Reader.LocalName == id22_required && (object)base.Reader.NamespaceURI == id2_Item)
            {
                o.Required = XmlConvert.ToBoolean(base.Reader.Value);
                paramsRead[0] = true;
            }
            else if (!paramsRead[1] && (object)base.Reader.LocalName == id23_location && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Location = base.Reader.Value;
                paramsRead[1] = true;
            }
            else if (!IsXmlnsAttribute(base.Reader.Name))
            {
                UnknownNode(o, "http://schemas.xmlsoap.org/wsdl/:required, :location");
            }
        }
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations3 = 0;
        int readerCount3 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                UnknownNode(o, "");
            }
            else
            {
                UnknownNode(o, "");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations3, ref readerCount3);
        }
        ReadEndElement();
        return o;
    }

    private SoapAddressBinding Read119_SoapAddressBinding(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id24_SoapAddressBinding || (object)xsiType.Namespace != id19_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        SoapAddressBinding o = new SoapAddressBinding();
        bool[] paramsRead = new bool[2];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[0] && (object)base.Reader.LocalName == id22_required && (object)base.Reader.NamespaceURI == id2_Item)
            {
                o.Required = XmlConvert.ToBoolean(base.Reader.Value);
                paramsRead[0] = true;
            }
            else if (!paramsRead[1] && (object)base.Reader.LocalName == id23_location && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Location = base.Reader.Value;
                paramsRead[1] = true;
            }
            else if (!IsXmlnsAttribute(base.Reader.Name))
            {
                UnknownNode(o, "http://schemas.xmlsoap.org/wsdl/:required, :location");
            }
        }
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations4 = 0;
        int readerCount4 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                UnknownNode(o, "");
            }
            else
            {
                UnknownNode(o, "");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations4, ref readerCount4);
        }
        ReadEndElement();
        return o;
    }

    private HttpAddressBinding Read118_HttpAddressBinding(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id25_HttpAddressBinding || (object)xsiType.Namespace != id18_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        HttpAddressBinding o = new HttpAddressBinding();
        bool[] paramsRead = new bool[2];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[0] && (object)base.Reader.LocalName == id22_required && (object)base.Reader.NamespaceURI == id2_Item)
            {
                o.Required = XmlConvert.ToBoolean(base.Reader.Value);
                paramsRead[0] = true;
            }
            else if (!paramsRead[1] && (object)base.Reader.LocalName == id23_location && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Location = base.Reader.Value;
                paramsRead[1] = true;
            }
            else if (!IsXmlnsAttribute(base.Reader.Name))
            {
                UnknownNode(o, "http://schemas.xmlsoap.org/wsdl/:required, :location");
            }
        }
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations5 = 0;
        int readerCount5 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                UnknownNode(o, "");
            }
            else
            {
                UnknownNode(o, "");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations5, ref readerCount5);
        }
        ReadEndElement();
        return o;
    }

    private Binding Read117_Binding(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id26_Binding || (object)xsiType.Namespace != id2_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        Binding o = new Binding();
        XmlAttribute[] a_7 = null;
        int ca_ = 0;
        ServiceDescriptionFormatExtensionCollection a_6 = o.Extensions;
        OperationBindingCollection a_5 = o.Operations;
        bool[] paramsRead = new bool[7];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[3] && (object)base.Reader.LocalName == id4_name && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Name = base.Reader.Value;
                paramsRead[3] = true;
            }
            else if (!paramsRead[6] && (object)base.Reader.LocalName == id27_type && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Type = ToXmlQualifiedName(base.Reader.Value);
                paramsRead[6] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_7 = (XmlAttribute[])EnsureArrayIndex(a_7, ca_, typeof(XmlAttribute));
                a_7[ca_++] = attr;
            }
        }
        o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_7, ca_, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_7, ca_, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations6 = 0;
        int readerCount6 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[0] && (object)base.Reader.LocalName == id7_documentation && (object)base.Reader.NamespaceURI == id2_Item)
                {
                    o.DocumentationElement = (XmlElement)ReadXmlNode(false);
                    paramsRead[0] = true;
                }
                else if ((object)base.Reader.LocalName == id12_binding && (object)base.Reader.NamespaceURI == id18_Item)
                {
                    if (a_6 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_6.Add(Read77_HttpBinding(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id12_binding && (object)base.Reader.NamespaceURI == id19_Item)
                {
                    if (a_6 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_6.Add(Read80_SoapBinding(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id12_binding && (object)base.Reader.NamespaceURI == id20_Item)
                {
                    if (a_6 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_6.Add(Read84_Soap12Binding(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id28_operation && (object)base.Reader.NamespaceURI == id2_Item)
                {
                    if (a_5 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_5.Add(Read116_OperationBinding(false, true));
                    }
                }
                else
                {
                    a_6.Add((XmlElement)ReadXmlNode(false));
                }
            }
            else
            {
                UnknownNode(o, "http://schemas.xmlsoap.org/wsdl/:documentation, http://schemas.xmlsoap.org/wsdl/http/:binding, http://schemas.xmlsoap.org/wsdl/soap/:binding, http://schemas.xmlsoap.org/wsdl/soap12/:binding, http://schemas.xmlsoap.org/wsdl/:operation");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations6, ref readerCount6);
        }
        o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_7, ca_, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private OperationBinding Read116_OperationBinding(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id29_OperationBinding || (object)xsiType.Namespace != id2_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        OperationBinding o = new OperationBinding();
        XmlAttribute[] a_9 = null;
        int ca_ = 0;
        ServiceDescriptionFormatExtensionCollection a_8 = o.Extensions;
        FaultBindingCollection a_7 = o.Faults;
        bool[] paramsRead = new bool[8];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[3] && (object)base.Reader.LocalName == id4_name && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Name = base.Reader.Value;
                paramsRead[3] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_9 = (XmlAttribute[])EnsureArrayIndex(a_9, ca_, typeof(XmlAttribute));
                a_9[ca_++] = attr;
            }
        }
        o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_9, ca_, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_9, ca_, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations7 = 0;
        int readerCount7 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[0] && (object)base.Reader.LocalName == id7_documentation && (object)base.Reader.NamespaceURI == id2_Item)
                {
                    o.DocumentationElement = (XmlElement)ReadXmlNode(false);
                    paramsRead[0] = true;
                }
                else if ((object)base.Reader.LocalName == id28_operation && (object)base.Reader.NamespaceURI == id18_Item)
                {
                    if (a_8 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_8.Add(Read85_HttpOperationBinding(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id28_operation && (object)base.Reader.NamespaceURI == id19_Item)
                {
                    if (a_8 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_8.Add(Read86_SoapOperationBinding(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id28_operation && (object)base.Reader.NamespaceURI == id20_Item)
                {
                    if (a_8 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_8.Add(Read88_Soap12OperationBinding(false, true));
                    }
                }
                else if (!paramsRead[5] && (object)base.Reader.LocalName == id30_input && (object)base.Reader.NamespaceURI == id2_Item)
                {
                    o.Input = Read110_InputBinding(false, true);
                    paramsRead[5] = true;
                }
                else if (!paramsRead[6] && (object)base.Reader.LocalName == id31_output && (object)base.Reader.NamespaceURI == id2_Item)
                {
                    o.Output = Read111_OutputBinding(false, true);
                    paramsRead[6] = true;
                }
                else if ((object)base.Reader.LocalName == id32_fault && (object)base.Reader.NamespaceURI == id2_Item)
                {
                    if (a_7 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_7.Add(Read115_FaultBinding(false, true));
                    }
                }
                else
                {
                    a_8.Add((XmlElement)ReadXmlNode(false));
                }
            }
            else
            {
                UnknownNode(o, "http://schemas.xmlsoap.org/wsdl/:documentation, http://schemas.xmlsoap.org/wsdl/http/:operation, http://schemas.xmlsoap.org/wsdl/soap/:operation, http://schemas.xmlsoap.org/wsdl/soap12/:operation, http://schemas.xmlsoap.org/wsdl/:input, http://schemas.xmlsoap.org/wsdl/:output, http://schemas.xmlsoap.org/wsdl/:fault");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations7, ref readerCount7);
        }
        o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_9, ca_, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private FaultBinding Read115_FaultBinding(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id33_FaultBinding || (object)xsiType.Namespace != id2_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        FaultBinding o = new FaultBinding();
        XmlAttribute[] a_5 = null;
        int ca_ = 0;
        ServiceDescriptionFormatExtensionCollection a_4 = o.Extensions;
        bool[] paramsRead = new bool[5];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[3] && (object)base.Reader.LocalName == id4_name && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Name = base.Reader.Value;
                paramsRead[3] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_5 = (XmlAttribute[])EnsureArrayIndex(a_5, ca_, typeof(XmlAttribute));
                a_5[ca_++] = attr;
            }
        }
        o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_5, ca_, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_5, ca_, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations8 = 0;
        int readerCount8 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[0] && (object)base.Reader.LocalName == id7_documentation && (object)base.Reader.NamespaceURI == id2_Item)
                {
                    o.DocumentationElement = (XmlElement)ReadXmlNode(false);
                    paramsRead[0] = true;
                }
                else if ((object)base.Reader.LocalName == id32_fault && (object)base.Reader.NamespaceURI == id19_Item)
                {
                    if (a_4 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_4.Add(Read112_SoapFaultBinding(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id32_fault && (object)base.Reader.NamespaceURI == id20_Item)
                {
                    if (a_4 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_4.Add(Read114_Soap12FaultBinding(false, true));
                    }
                }
                else
                {
                    a_4.Add((XmlElement)ReadXmlNode(false));
                }
            }
            else
            {
                UnknownNode(o, "http://schemas.xmlsoap.org/wsdl/:documentation, http://schemas.xmlsoap.org/wsdl/soap/:fault, http://schemas.xmlsoap.org/wsdl/soap12/:fault");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations8, ref readerCount8);
        }
        o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_5, ca_, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private Soap12FaultBinding Read114_Soap12FaultBinding(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id34_Soap12FaultBinding || (object)xsiType.Namespace != id20_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        Soap12FaultBinding o = new Soap12FaultBinding();
        bool[] paramsRead = new bool[5];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[0] && (object)base.Reader.LocalName == id22_required && (object)base.Reader.NamespaceURI == id2_Item)
            {
                o.Required = XmlConvert.ToBoolean(base.Reader.Value);
                paramsRead[0] = true;
            }
            else if (!paramsRead[1] && (object)base.Reader.LocalName == id35_use && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Use = Read100_SoapBindingUse(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[2] && (object)base.Reader.LocalName == id4_name && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Name = base.Reader.Value;
                paramsRead[2] = true;
            }
            else if (!paramsRead[3] && (object)base.Reader.LocalName == id36_namespace && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Namespace = base.Reader.Value;
                paramsRead[3] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id37_encodingStyle && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Encoding = base.Reader.Value;
                paramsRead[4] = true;
            }
            else if (!IsXmlnsAttribute(base.Reader.Name))
            {
                UnknownNode(o, "http://schemas.xmlsoap.org/wsdl/:required, :use, :name, :namespace, :encodingStyle");
            }
        }
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations9 = 0;
        int readerCount9 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                UnknownNode(o, "");
            }
            else
            {
                UnknownNode(o, "");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations9, ref readerCount9);
        }
        ReadEndElement();
        return o;
    }

    private SoapBindingUse Read100_SoapBindingUse(string s)
    {
        if (s != null)
        {
            if (s == "encoded")
            {
                return SoapBindingUse.Encoded;
            }
            if (s == "literal")
            {
                return SoapBindingUse.Literal;
            }
        }
        throw CreateUnknownConstantException(s, typeof(SoapBindingUse));
    }

    private SoapFaultBinding Read112_SoapFaultBinding(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id38_SoapFaultBinding || (object)xsiType.Namespace != id19_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        SoapFaultBinding o = new SoapFaultBinding();
        bool[] paramsRead = new bool[5];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[0] && (object)base.Reader.LocalName == id22_required && (object)base.Reader.NamespaceURI == id2_Item)
            {
                o.Required = XmlConvert.ToBoolean(base.Reader.Value);
                paramsRead[0] = true;
            }
            else if (!paramsRead[1] && (object)base.Reader.LocalName == id35_use && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Use = Read98_SoapBindingUse(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[2] && (object)base.Reader.LocalName == id4_name && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Name = base.Reader.Value;
                paramsRead[2] = true;
            }
            else if (!paramsRead[3] && (object)base.Reader.LocalName == id36_namespace && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Namespace = base.Reader.Value;
                paramsRead[3] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id37_encodingStyle && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Encoding = base.Reader.Value;
                paramsRead[4] = true;
            }
            else if (!IsXmlnsAttribute(base.Reader.Name))
            {
                UnknownNode(o, "http://schemas.xmlsoap.org/wsdl/:required, :use, :name, :namespace, :encodingStyle");
            }
        }
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations10 = 0;
        int readerCount10 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                UnknownNode(o, "");
            }
            else
            {
                UnknownNode(o, "");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations10, ref readerCount10);
        }
        ReadEndElement();
        return o;
    }

    private SoapBindingUse Read98_SoapBindingUse(string s)
    {
        if (s != null)
        {
            if (s == "encoded")
            {
                return SoapBindingUse.Encoded;
            }
            if (s == "literal")
            {
                return SoapBindingUse.Literal;
            }
        }
        throw CreateUnknownConstantException(s, typeof(SoapBindingUse));
    }

    private OutputBinding Read111_OutputBinding(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id39_OutputBinding || (object)xsiType.Namespace != id2_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        OutputBinding o = new OutputBinding();
        XmlAttribute[] a_5 = null;
        int ca_ = 0;
        ServiceDescriptionFormatExtensionCollection a_4 = o.Extensions;
        bool[] paramsRead = new bool[5];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[3] && (object)base.Reader.LocalName == id4_name && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Name = base.Reader.Value;
                paramsRead[3] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_5 = (XmlAttribute[])EnsureArrayIndex(a_5, ca_, typeof(XmlAttribute));
                a_5[ca_++] = attr;
            }
        }
        o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_5, ca_, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_5, ca_, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations11 = 0;
        int readerCount11 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[0] && (object)base.Reader.LocalName == id7_documentation && (object)base.Reader.NamespaceURI == id2_Item)
                {
                    o.DocumentationElement = (XmlElement)ReadXmlNode(false);
                    paramsRead[0] = true;
                }
                else if ((object)base.Reader.LocalName == id40_content && (object)base.Reader.NamespaceURI == id41_Item)
                {
                    if (a_4 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_4.Add(Read93_MimeContentBinding(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id42_mimeXml && (object)base.Reader.NamespaceURI == id41_Item)
                {
                    if (a_4 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_4.Add(Read94_MimeXmlBinding(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id43_multipartRelated && (object)base.Reader.NamespaceURI == id41_Item)
                {
                    if (a_4 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_4.Add(Read104_MimeMultipartRelatedBinding(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id44_text && (object)base.Reader.NamespaceURI == id45_Item)
                {
                    if (a_4 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_4.Add(Read97_MimeTextBinding(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id46_body && (object)base.Reader.NamespaceURI == id19_Item)
                {
                    if (a_4 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_4.Add(Read99_SoapBodyBinding(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id47_header && (object)base.Reader.NamespaceURI == id19_Item)
                {
                    if (a_4 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_4.Add(Read106_SoapHeaderBinding(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id46_body && (object)base.Reader.NamespaceURI == id20_Item)
                {
                    if (a_4 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_4.Add(Read102_Soap12BodyBinding(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id47_header && (object)base.Reader.NamespaceURI == id20_Item)
                {
                    if (a_4 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_4.Add(Read109_Soap12HeaderBinding(false, true));
                    }
                }
                else
                {
                    a_4.Add((XmlElement)ReadXmlNode(false));
                }
            }
            else
            {
                UnknownNode(o, "http://schemas.xmlsoap.org/wsdl/:documentation, http://schemas.xmlsoap.org/wsdl/mime/:content, http://schemas.xmlsoap.org/wsdl/mime/:mimeXml, http://schemas.xmlsoap.org/wsdl/mime/:multipartRelated, http://microsoft.com/wsdl/mime/textMatching/:text, http://schemas.xmlsoap.org/wsdl/soap/:body, http://schemas.xmlsoap.org/wsdl/soap/:header, http://schemas.xmlsoap.org/wsdl/soap12/:body, http://schemas.xmlsoap.org/wsdl/soap12/:header");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations11, ref readerCount11);
        }
        o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_5, ca_, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private Soap12HeaderBinding Read109_Soap12HeaderBinding(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id48_Soap12HeaderBinding || (object)xsiType.Namespace != id20_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        Soap12HeaderBinding o = new Soap12HeaderBinding();
        bool[] paramsRead = new bool[7];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[0] && (object)base.Reader.LocalName == id22_required && (object)base.Reader.NamespaceURI == id2_Item)
            {
                o.Required = XmlConvert.ToBoolean(base.Reader.Value);
                paramsRead[0] = true;
            }
            else if (!paramsRead[1] && (object)base.Reader.LocalName == id10_message && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Message = ToXmlQualifiedName(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[2] && (object)base.Reader.LocalName == id49_part && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Part = base.Reader.Value;
                paramsRead[2] = true;
            }
            else if (!paramsRead[3] && (object)base.Reader.LocalName == id35_use && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Use = Read100_SoapBindingUse(base.Reader.Value);
                paramsRead[3] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id37_encodingStyle && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Encoding = base.Reader.Value;
                paramsRead[4] = true;
            }
            else if (!paramsRead[5] && (object)base.Reader.LocalName == id36_namespace && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Namespace = base.Reader.Value;
                paramsRead[5] = true;
            }
            else if (!IsXmlnsAttribute(base.Reader.Name))
            {
                UnknownNode(o, "http://schemas.xmlsoap.org/wsdl/:required, :message, :part, :use, :encodingStyle, :namespace");
            }
        }
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations12 = 0;
        int readerCount12 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[6] && (object)base.Reader.LocalName == id50_headerfault && (object)base.Reader.NamespaceURI == id20_Item)
                {
                    o.Fault = Read107_SoapHeaderFaultBinding(false, true);
                    paramsRead[6] = true;
                }
                else
                {
                    UnknownNode(o, "http://schemas.xmlsoap.org/wsdl/soap12/:headerfault");
                }
            }
            else
            {
                UnknownNode(o, "http://schemas.xmlsoap.org/wsdl/soap12/:headerfault");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations12, ref readerCount12);
        }
        ReadEndElement();
        return o;
    }

    private SoapHeaderFaultBinding Read107_SoapHeaderFaultBinding(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id51_SoapHeaderFaultBinding || (object)xsiType.Namespace != id20_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        SoapHeaderFaultBinding o = new SoapHeaderFaultBinding();
        bool[] paramsRead = new bool[6];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[0] && (object)base.Reader.LocalName == id22_required && (object)base.Reader.NamespaceURI == id2_Item)
            {
                o.Required = XmlConvert.ToBoolean(base.Reader.Value);
                paramsRead[0] = true;
            }
            else if (!paramsRead[1] && (object)base.Reader.LocalName == id10_message && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Message = ToXmlQualifiedName(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[2] && (object)base.Reader.LocalName == id49_part && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Part = base.Reader.Value;
                paramsRead[2] = true;
            }
            else if (!paramsRead[3] && (object)base.Reader.LocalName == id35_use && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Use = Read100_SoapBindingUse(base.Reader.Value);
                paramsRead[3] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id37_encodingStyle && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Encoding = base.Reader.Value;
                paramsRead[4] = true;
            }
            else if (!paramsRead[5] && (object)base.Reader.LocalName == id36_namespace && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Namespace = base.Reader.Value;
                paramsRead[5] = true;
            }
            else if (!IsXmlnsAttribute(base.Reader.Name))
            {
                UnknownNode(o, "http://schemas.xmlsoap.org/wsdl/:required, :message, :part, :use, :encodingStyle, :namespace");
            }
        }
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations13 = 0;
        int readerCount13 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                UnknownNode(o, "");
            }
            else
            {
                UnknownNode(o, "");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations13, ref readerCount13);
        }
        ReadEndElement();
        return o;
    }

    private Soap12BodyBinding Read102_Soap12BodyBinding(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id52_Soap12BodyBinding || (object)xsiType.Namespace != id20_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        Soap12BodyBinding o = new Soap12BodyBinding();
        bool[] paramsRead = new bool[5];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[0] && (object)base.Reader.LocalName == id22_required && (object)base.Reader.NamespaceURI == id2_Item)
            {
                o.Required = XmlConvert.ToBoolean(base.Reader.Value);
                paramsRead[0] = true;
            }
            else if (!paramsRead[1] && (object)base.Reader.LocalName == id35_use && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Use = Read100_SoapBindingUse(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[2] && (object)base.Reader.LocalName == id36_namespace && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Namespace = base.Reader.Value;
                paramsRead[2] = true;
            }
            else if (!paramsRead[3] && (object)base.Reader.LocalName == id37_encodingStyle && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Encoding = base.Reader.Value;
                paramsRead[3] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id53_parts && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.PartsString = base.Reader.Value;
                paramsRead[4] = true;
            }
            else if (!IsXmlnsAttribute(base.Reader.Name))
            {
                UnknownNode(o, "http://schemas.xmlsoap.org/wsdl/:required, :use, :namespace, :encodingStyle, :parts");
            }
        }
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations14 = 0;
        int readerCount14 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                UnknownNode(o, "");
            }
            else
            {
                UnknownNode(o, "");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations14, ref readerCount14);
        }
        ReadEndElement();
        return o;
    }

    private SoapHeaderBinding Read106_SoapHeaderBinding(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id54_SoapHeaderBinding || (object)xsiType.Namespace != id19_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        SoapHeaderBinding o = new SoapHeaderBinding();
        bool[] paramsRead = new bool[7];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[0] && (object)base.Reader.LocalName == id22_required && (object)base.Reader.NamespaceURI == id2_Item)
            {
                o.Required = XmlConvert.ToBoolean(base.Reader.Value);
                paramsRead[0] = true;
            }
            else if (!paramsRead[1] && (object)base.Reader.LocalName == id10_message && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Message = ToXmlQualifiedName(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[2] && (object)base.Reader.LocalName == id49_part && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Part = base.Reader.Value;
                paramsRead[2] = true;
            }
            else if (!paramsRead[3] && (object)base.Reader.LocalName == id35_use && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Use = Read98_SoapBindingUse(base.Reader.Value);
                paramsRead[3] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id37_encodingStyle && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Encoding = base.Reader.Value;
                paramsRead[4] = true;
            }
            else if (!paramsRead[5] && (object)base.Reader.LocalName == id36_namespace && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Namespace = base.Reader.Value;
                paramsRead[5] = true;
            }
            else if (!IsXmlnsAttribute(base.Reader.Name))
            {
                UnknownNode(o, "http://schemas.xmlsoap.org/wsdl/:required, :message, :part, :use, :encodingStyle, :namespace");
            }
        }
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations15 = 0;
        int readerCount15 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[6] && (object)base.Reader.LocalName == id50_headerfault && (object)base.Reader.NamespaceURI == id19_Item)
                {
                    o.Fault = Read105_SoapHeaderFaultBinding(false, true);
                    paramsRead[6] = true;
                }
                else
                {
                    UnknownNode(o, "http://schemas.xmlsoap.org/wsdl/soap/:headerfault");
                }
            }
            else
            {
                UnknownNode(o, "http://schemas.xmlsoap.org/wsdl/soap/:headerfault");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations15, ref readerCount15);
        }
        ReadEndElement();
        return o;
    }

    private SoapHeaderFaultBinding Read105_SoapHeaderFaultBinding(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id51_SoapHeaderFaultBinding || (object)xsiType.Namespace != id19_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        SoapHeaderFaultBinding o = new SoapHeaderFaultBinding();
        bool[] paramsRead = new bool[6];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[0] && (object)base.Reader.LocalName == id22_required && (object)base.Reader.NamespaceURI == id2_Item)
            {
                o.Required = XmlConvert.ToBoolean(base.Reader.Value);
                paramsRead[0] = true;
            }
            else if (!paramsRead[1] && (object)base.Reader.LocalName == id10_message && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Message = ToXmlQualifiedName(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[2] && (object)base.Reader.LocalName == id49_part && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Part = base.Reader.Value;
                paramsRead[2] = true;
            }
            else if (!paramsRead[3] && (object)base.Reader.LocalName == id35_use && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Use = Read98_SoapBindingUse(base.Reader.Value);
                paramsRead[3] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id37_encodingStyle && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Encoding = base.Reader.Value;
                paramsRead[4] = true;
            }
            else if (!paramsRead[5] && (object)base.Reader.LocalName == id36_namespace && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Namespace = base.Reader.Value;
                paramsRead[5] = true;
            }
            else if (!IsXmlnsAttribute(base.Reader.Name))
            {
                UnknownNode(o, "http://schemas.xmlsoap.org/wsdl/:required, :message, :part, :use, :encodingStyle, :namespace");
            }
        }
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations16 = 0;
        int readerCount16 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                UnknownNode(o, "");
            }
            else
            {
                UnknownNode(o, "");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations16, ref readerCount16);
        }
        ReadEndElement();
        return o;
    }

    private SoapBodyBinding Read99_SoapBodyBinding(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id55_SoapBodyBinding || (object)xsiType.Namespace != id19_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        SoapBodyBinding o = new SoapBodyBinding();
        bool[] paramsRead = new bool[5];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[0] && (object)base.Reader.LocalName == id22_required && (object)base.Reader.NamespaceURI == id2_Item)
            {
                o.Required = XmlConvert.ToBoolean(base.Reader.Value);
                paramsRead[0] = true;
            }
            else if (!paramsRead[1] && (object)base.Reader.LocalName == id35_use && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Use = Read98_SoapBindingUse(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[2] && (object)base.Reader.LocalName == id36_namespace && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Namespace = base.Reader.Value;
                paramsRead[2] = true;
            }
            else if (!paramsRead[3] && (object)base.Reader.LocalName == id37_encodingStyle && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Encoding = base.Reader.Value;
                paramsRead[3] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id53_parts && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.PartsString = base.Reader.Value;
                paramsRead[4] = true;
            }
            else if (!IsXmlnsAttribute(base.Reader.Name))
            {
                UnknownNode(o, "http://schemas.xmlsoap.org/wsdl/:required, :use, :namespace, :encodingStyle, :parts");
            }
        }
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations17 = 0;
        int readerCount17 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                UnknownNode(o, "");
            }
            else
            {
                UnknownNode(o, "");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations17, ref readerCount17);
        }
        ReadEndElement();
        return o;
    }

    private MimeTextBinding Read97_MimeTextBinding(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id56_MimeTextBinding || (object)xsiType.Namespace != id45_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        MimeTextBinding o = new MimeTextBinding();
        MimeTextMatchCollection a_ = o.Matches;
        bool[] paramsRead = new bool[2];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[0] && (object)base.Reader.LocalName == id22_required && (object)base.Reader.NamespaceURI == id2_Item)
            {
                o.Required = XmlConvert.ToBoolean(base.Reader.Value);
                paramsRead[0] = true;
            }
            else if (!IsXmlnsAttribute(base.Reader.Name))
            {
                UnknownNode(o, "http://schemas.xmlsoap.org/wsdl/:required");
            }
        }
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations18 = 0;
        int readerCount18 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if ((object)base.Reader.LocalName == id57_match && (object)base.Reader.NamespaceURI == id45_Item)
                {
                    if (a_ == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_.Add(Read96_MimeTextMatch(false, true));
                    }
                }
                else
                {
                    UnknownNode(o, "http://microsoft.com/wsdl/mime/textMatching/:match");
                }
            }
            else
            {
                UnknownNode(o, "http://microsoft.com/wsdl/mime/textMatching/:match");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations18, ref readerCount18);
        }
        ReadEndElement();
        return o;
    }

    private MimeTextMatch Read96_MimeTextMatch(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id58_MimeTextMatch || (object)xsiType.Namespace != id45_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        MimeTextMatch o = new MimeTextMatch();
        MimeTextMatchCollection a_7 = o.Matches;
        bool[] paramsRead = new bool[8];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[0] && (object)base.Reader.LocalName == id4_name && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Name = base.Reader.Value;
                paramsRead[0] = true;
            }
            else if (!paramsRead[1] && (object)base.Reader.LocalName == id27_type && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Type = base.Reader.Value;
                paramsRead[1] = true;
            }
            else if (!paramsRead[2] && (object)base.Reader.LocalName == id59_group && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Group = XmlConvert.ToInt32(base.Reader.Value);
                paramsRead[2] = true;
            }
            else if (!paramsRead[3] && (object)base.Reader.LocalName == id60_capture && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Capture = XmlConvert.ToInt32(base.Reader.Value);
                paramsRead[3] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id61_repeats && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.RepeatsString = base.Reader.Value;
                paramsRead[4] = true;
            }
            else if (!paramsRead[5] && (object)base.Reader.LocalName == id62_pattern && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Pattern = base.Reader.Value;
                paramsRead[5] = true;
            }
            else if (!paramsRead[6] && (object)base.Reader.LocalName == id63_ignoreCase && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.IgnoreCase = XmlConvert.ToBoolean(base.Reader.Value);
                paramsRead[6] = true;
            }
            else if (!IsXmlnsAttribute(base.Reader.Name))
            {
                UnknownNode(o, ":name, :type, :group, :capture, :repeats, :pattern, :ignoreCase");
            }
        }
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations19 = 0;
        int readerCount19 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if ((object)base.Reader.LocalName == id57_match && (object)base.Reader.NamespaceURI == id45_Item)
                {
                    if (a_7 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_7.Add(Read96_MimeTextMatch(false, true));
                    }
                }
                else
                {
                    UnknownNode(o, "http://microsoft.com/wsdl/mime/textMatching/:match");
                }
            }
            else
            {
                UnknownNode(o, "http://microsoft.com/wsdl/mime/textMatching/:match");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations19, ref readerCount19);
        }
        ReadEndElement();
        return o;
    }

    private MimeMultipartRelatedBinding Read104_MimeMultipartRelatedBinding(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id64_MimeMultipartRelatedBinding || (object)xsiType.Namespace != id41_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        MimeMultipartRelatedBinding o = new MimeMultipartRelatedBinding();
        MimePartCollection a_ = o.Parts;
        bool[] paramsRead = new bool[2];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[0] && (object)base.Reader.LocalName == id22_required && (object)base.Reader.NamespaceURI == id2_Item)
            {
                o.Required = XmlConvert.ToBoolean(base.Reader.Value);
                paramsRead[0] = true;
            }
            else if (!IsXmlnsAttribute(base.Reader.Name))
            {
                UnknownNode(o, "http://schemas.xmlsoap.org/wsdl/:required");
            }
        }
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations20 = 0;
        int readerCount20 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if ((object)base.Reader.LocalName == id49_part && (object)base.Reader.NamespaceURI == id41_Item)
                {
                    if (a_ == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_.Add(Read103_MimePart(false, true));
                    }
                }
                else
                {
                    UnknownNode(o, "http://schemas.xmlsoap.org/wsdl/mime/:part");
                }
            }
            else
            {
                UnknownNode(o, "http://schemas.xmlsoap.org/wsdl/mime/:part");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations20, ref readerCount20);
        }
        ReadEndElement();
        return o;
    }

    private MimePart Read103_MimePart(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id65_MimePart || (object)xsiType.Namespace != id41_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        MimePart o = new MimePart();
        ServiceDescriptionFormatExtensionCollection a_ = o.Extensions;
        bool[] paramsRead = new bool[2];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[0] && (object)base.Reader.LocalName == id22_required && (object)base.Reader.NamespaceURI == id2_Item)
            {
                o.Required = XmlConvert.ToBoolean(base.Reader.Value);
                paramsRead[0] = true;
            }
            else if (!IsXmlnsAttribute(base.Reader.Name))
            {
                UnknownNode(o, "http://schemas.xmlsoap.org/wsdl/:required");
            }
        }
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations21 = 0;
        int readerCount21 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if ((object)base.Reader.LocalName == id40_content && (object)base.Reader.NamespaceURI == id41_Item)
                {
                    if (a_ == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_.Add(Read93_MimeContentBinding(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id42_mimeXml && (object)base.Reader.NamespaceURI == id41_Item)
                {
                    if (a_ == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_.Add(Read94_MimeXmlBinding(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id44_text && (object)base.Reader.NamespaceURI == id45_Item)
                {
                    if (a_ == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_.Add(Read97_MimeTextBinding(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id46_body && (object)base.Reader.NamespaceURI == id19_Item)
                {
                    if (a_ == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_.Add(Read99_SoapBodyBinding(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id46_body && (object)base.Reader.NamespaceURI == id20_Item)
                {
                    if (a_ == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_.Add(Read102_Soap12BodyBinding(false, true));
                    }
                }
                else
                {
                    a_.Add((XmlElement)ReadXmlNode(false));
                }
            }
            else
            {
                UnknownNode(o, "http://schemas.xmlsoap.org/wsdl/mime/:content, http://schemas.xmlsoap.org/wsdl/mime/:mimeXml, http://microsoft.com/wsdl/mime/textMatching/:text, http://schemas.xmlsoap.org/wsdl/soap/:body, http://schemas.xmlsoap.org/wsdl/soap12/:body");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations21, ref readerCount21);
        }
        ReadEndElement();
        return o;
    }

    private MimeXmlBinding Read94_MimeXmlBinding(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id66_MimeXmlBinding || (object)xsiType.Namespace != id41_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        MimeXmlBinding o = new MimeXmlBinding();
        bool[] paramsRead = new bool[2];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[0] && (object)base.Reader.LocalName == id22_required && (object)base.Reader.NamespaceURI == id2_Item)
            {
                o.Required = XmlConvert.ToBoolean(base.Reader.Value);
                paramsRead[0] = true;
            }
            else if (!paramsRead[1] && (object)base.Reader.LocalName == id49_part && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Part = base.Reader.Value;
                paramsRead[1] = true;
            }
            else if (!IsXmlnsAttribute(base.Reader.Name))
            {
                UnknownNode(o, "http://schemas.xmlsoap.org/wsdl/:required, :part");
            }
        }
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations22 = 0;
        int readerCount22 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                UnknownNode(o, "");
            }
            else
            {
                UnknownNode(o, "");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations22, ref readerCount22);
        }
        ReadEndElement();
        return o;
    }

    private MimeContentBinding Read93_MimeContentBinding(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id67_MimeContentBinding || (object)xsiType.Namespace != id41_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        MimeContentBinding o = new MimeContentBinding();
        bool[] paramsRead = new bool[3];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[0] && (object)base.Reader.LocalName == id22_required && (object)base.Reader.NamespaceURI == id2_Item)
            {
                o.Required = XmlConvert.ToBoolean(base.Reader.Value);
                paramsRead[0] = true;
            }
            else if (!paramsRead[1] && (object)base.Reader.LocalName == id49_part && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Part = base.Reader.Value;
                paramsRead[1] = true;
            }
            else if (!paramsRead[2] && (object)base.Reader.LocalName == id27_type && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Type = base.Reader.Value;
                paramsRead[2] = true;
            }
            else if (!IsXmlnsAttribute(base.Reader.Name))
            {
                UnknownNode(o, "http://schemas.xmlsoap.org/wsdl/:required, :part, :type");
            }
        }
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations23 = 0;
        int readerCount23 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                UnknownNode(o, "");
            }
            else
            {
                UnknownNode(o, "");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations23, ref readerCount23);
        }
        ReadEndElement();
        return o;
    }

    private InputBinding Read110_InputBinding(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id68_InputBinding || (object)xsiType.Namespace != id2_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        InputBinding o = new InputBinding();
        XmlAttribute[] a_5 = null;
        int ca_ = 0;
        ServiceDescriptionFormatExtensionCollection a_4 = o.Extensions;
        bool[] paramsRead = new bool[5];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[3] && (object)base.Reader.LocalName == id4_name && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Name = base.Reader.Value;
                paramsRead[3] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_5 = (XmlAttribute[])EnsureArrayIndex(a_5, ca_, typeof(XmlAttribute));
                a_5[ca_++] = attr;
            }
        }
        o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_5, ca_, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_5, ca_, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations24 = 0;
        int readerCount24 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[0] && (object)base.Reader.LocalName == id7_documentation && (object)base.Reader.NamespaceURI == id2_Item)
                {
                    o.DocumentationElement = (XmlElement)ReadXmlNode(false);
                    paramsRead[0] = true;
                }
                else if ((object)base.Reader.LocalName == id69_urlEncoded && (object)base.Reader.NamespaceURI == id18_Item)
                {
                    if (a_4 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_4.Add(Read90_HttpUrlEncodedBinding(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id70_urlReplacement && (object)base.Reader.NamespaceURI == id18_Item)
                {
                    if (a_4 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_4.Add(Read91_HttpUrlReplacementBinding(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id40_content && (object)base.Reader.NamespaceURI == id41_Item)
                {
                    if (a_4 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_4.Add(Read93_MimeContentBinding(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id42_mimeXml && (object)base.Reader.NamespaceURI == id41_Item)
                {
                    if (a_4 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_4.Add(Read94_MimeXmlBinding(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id43_multipartRelated && (object)base.Reader.NamespaceURI == id41_Item)
                {
                    if (a_4 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_4.Add(Read104_MimeMultipartRelatedBinding(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id44_text && (object)base.Reader.NamespaceURI == id45_Item)
                {
                    if (a_4 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_4.Add(Read97_MimeTextBinding(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id46_body && (object)base.Reader.NamespaceURI == id19_Item)
                {
                    if (a_4 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_4.Add(Read99_SoapBodyBinding(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id47_header && (object)base.Reader.NamespaceURI == id19_Item)
                {
                    if (a_4 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_4.Add(Read106_SoapHeaderBinding(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id46_body && (object)base.Reader.NamespaceURI == id20_Item)
                {
                    if (a_4 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_4.Add(Read102_Soap12BodyBinding(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id47_header && (object)base.Reader.NamespaceURI == id20_Item)
                {
                    if (a_4 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_4.Add(Read109_Soap12HeaderBinding(false, true));
                    }
                }
                else
                {
                    a_4.Add((XmlElement)ReadXmlNode(false));
                }
            }
            else
            {
                UnknownNode(o, "http://schemas.xmlsoap.org/wsdl/:documentation, http://schemas.xmlsoap.org/wsdl/http/:urlEncoded, http://schemas.xmlsoap.org/wsdl/http/:urlReplacement, http://schemas.xmlsoap.org/wsdl/mime/:content, http://schemas.xmlsoap.org/wsdl/mime/:mimeXml, http://schemas.xmlsoap.org/wsdl/mime/:multipartRelated, http://microsoft.com/wsdl/mime/textMatching/:text, http://schemas.xmlsoap.org/wsdl/soap/:body, http://schemas.xmlsoap.org/wsdl/soap/:header, http://schemas.xmlsoap.org/wsdl/soap12/:body, http://schemas.xmlsoap.org/wsdl/soap12/:header");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations24, ref readerCount24);
        }
        o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_5, ca_, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private HttpUrlReplacementBinding Read91_HttpUrlReplacementBinding(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id71_HttpUrlReplacementBinding || (object)xsiType.Namespace != id18_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        HttpUrlReplacementBinding o = new HttpUrlReplacementBinding();
        bool[] paramsRead = new bool[1];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[0] && (object)base.Reader.LocalName == id22_required && (object)base.Reader.NamespaceURI == id2_Item)
            {
                o.Required = XmlConvert.ToBoolean(base.Reader.Value);
                paramsRead[0] = true;
            }
            else if (!IsXmlnsAttribute(base.Reader.Name))
            {
                UnknownNode(o, "http://schemas.xmlsoap.org/wsdl/:required");
            }
        }
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations25 = 0;
        int readerCount25 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                UnknownNode(o, "");
            }
            else
            {
                UnknownNode(o, "");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations25, ref readerCount25);
        }
        ReadEndElement();
        return o;
    }

    private HttpUrlEncodedBinding Read90_HttpUrlEncodedBinding(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id72_HttpUrlEncodedBinding || (object)xsiType.Namespace != id18_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        HttpUrlEncodedBinding o = new HttpUrlEncodedBinding();
        bool[] paramsRead = new bool[1];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[0] && (object)base.Reader.LocalName == id22_required && (object)base.Reader.NamespaceURI == id2_Item)
            {
                o.Required = XmlConvert.ToBoolean(base.Reader.Value);
                paramsRead[0] = true;
            }
            else if (!IsXmlnsAttribute(base.Reader.Name))
            {
                UnknownNode(o, "http://schemas.xmlsoap.org/wsdl/:required");
            }
        }
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations26 = 0;
        int readerCount26 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                UnknownNode(o, "");
            }
            else
            {
                UnknownNode(o, "");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations26, ref readerCount26);
        }
        ReadEndElement();
        return o;
    }

    private Soap12OperationBinding Read88_Soap12OperationBinding(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id73_Soap12OperationBinding || (object)xsiType.Namespace != id20_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        Soap12OperationBinding o = new Soap12OperationBinding();
        bool[] paramsRead = new bool[4];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[0] && (object)base.Reader.LocalName == id22_required && (object)base.Reader.NamespaceURI == id2_Item)
            {
                o.Required = XmlConvert.ToBoolean(base.Reader.Value);
                paramsRead[0] = true;
            }
            else if (!paramsRead[1] && (object)base.Reader.LocalName == id74_soapAction && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.SoapAction = base.Reader.Value;
                paramsRead[1] = true;
            }
            else if (!paramsRead[2] && (object)base.Reader.LocalName == id75_style && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Style = Read82_SoapBindingStyle(base.Reader.Value);
                paramsRead[2] = true;
            }
            else if (!paramsRead[3] && (object)base.Reader.LocalName == id76_soapActionRequired && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.SoapActionRequired = XmlConvert.ToBoolean(base.Reader.Value);
                paramsRead[3] = true;
            }
            else if (!IsXmlnsAttribute(base.Reader.Name))
            {
                UnknownNode(o, "http://schemas.xmlsoap.org/wsdl/:required, :soapAction, :style, :soapActionRequired");
            }
        }
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations27 = 0;
        int readerCount27 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                UnknownNode(o, "");
            }
            else
            {
                UnknownNode(o, "");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations27, ref readerCount27);
        }
        ReadEndElement();
        return o;
    }

    private SoapBindingStyle Read82_SoapBindingStyle(string s)
    {
        if (s != null)
        {
            if (s == "document")
            {
                return SoapBindingStyle.Document;
            }
            if (s == "rpc")
            {
                return SoapBindingStyle.Rpc;
            }
        }
        throw CreateUnknownConstantException(s, typeof(SoapBindingStyle));
    }

    private SoapOperationBinding Read86_SoapOperationBinding(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id77_SoapOperationBinding || (object)xsiType.Namespace != id19_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        SoapOperationBinding o = new SoapOperationBinding();
        bool[] paramsRead = new bool[3];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[0] && (object)base.Reader.LocalName == id22_required && (object)base.Reader.NamespaceURI == id2_Item)
            {
                o.Required = XmlConvert.ToBoolean(base.Reader.Value);
                paramsRead[0] = true;
            }
            else if (!paramsRead[1] && (object)base.Reader.LocalName == id74_soapAction && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.SoapAction = base.Reader.Value;
                paramsRead[1] = true;
            }
            else if (!paramsRead[2] && (object)base.Reader.LocalName == id75_style && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Style = Read79_SoapBindingStyle(base.Reader.Value);
                paramsRead[2] = true;
            }
            else if (!IsXmlnsAttribute(base.Reader.Name))
            {
                UnknownNode(o, "http://schemas.xmlsoap.org/wsdl/:required, :soapAction, :style");
            }
        }
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations28 = 0;
        int readerCount28 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                UnknownNode(o, "");
            }
            else
            {
                UnknownNode(o, "");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations28, ref readerCount28);
        }
        ReadEndElement();
        return o;
    }

    private SoapBindingStyle Read79_SoapBindingStyle(string s)
    {
        if (s != null)
        {
            if (s == "document")
            {
                return SoapBindingStyle.Document;
            }
            if (s == "rpc")
            {
                return SoapBindingStyle.Rpc;
            }
        }
        throw CreateUnknownConstantException(s, typeof(SoapBindingStyle));
    }

    private HttpOperationBinding Read85_HttpOperationBinding(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id78_HttpOperationBinding || (object)xsiType.Namespace != id18_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        HttpOperationBinding o = new HttpOperationBinding();
        bool[] paramsRead = new bool[2];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[0] && (object)base.Reader.LocalName == id22_required && (object)base.Reader.NamespaceURI == id2_Item)
            {
                o.Required = XmlConvert.ToBoolean(base.Reader.Value);
                paramsRead[0] = true;
            }
            else if (!paramsRead[1] && (object)base.Reader.LocalName == id23_location && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Location = base.Reader.Value;
                paramsRead[1] = true;
            }
            else if (!IsXmlnsAttribute(base.Reader.Name))
            {
                UnknownNode(o, "http://schemas.xmlsoap.org/wsdl/:required, :location");
            }
        }
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations29 = 0;
        int readerCount29 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                UnknownNode(o, "");
            }
            else
            {
                UnknownNode(o, "");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations29, ref readerCount29);
        }
        ReadEndElement();
        return o;
    }

    private Soap12Binding Read84_Soap12Binding(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id79_Soap12Binding || (object)xsiType.Namespace != id20_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        Soap12Binding o = new Soap12Binding();
        bool[] paramsRead = new bool[3];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[0] && (object)base.Reader.LocalName == id22_required && (object)base.Reader.NamespaceURI == id2_Item)
            {
                o.Required = XmlConvert.ToBoolean(base.Reader.Value);
                paramsRead[0] = true;
            }
            else if (!paramsRead[1] && (object)base.Reader.LocalName == id80_transport && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Transport = base.Reader.Value;
                paramsRead[1] = true;
            }
            else if (!paramsRead[2] && (object)base.Reader.LocalName == id75_style && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Style = Read82_SoapBindingStyle(base.Reader.Value);
                paramsRead[2] = true;
            }
            else if (!IsXmlnsAttribute(base.Reader.Name))
            {
                UnknownNode(o, "http://schemas.xmlsoap.org/wsdl/:required, :transport, :style");
            }
        }
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations30 = 0;
        int readerCount30 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                UnknownNode(o, "");
            }
            else
            {
                UnknownNode(o, "");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations30, ref readerCount30);
        }
        ReadEndElement();
        return o;
    }

    private SoapBinding Read80_SoapBinding(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id81_SoapBinding || (object)xsiType.Namespace != id19_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        SoapBinding o = new SoapBinding();
        bool[] paramsRead = new bool[3];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[0] && (object)base.Reader.LocalName == id22_required && (object)base.Reader.NamespaceURI == id2_Item)
            {
                o.Required = XmlConvert.ToBoolean(base.Reader.Value);
                paramsRead[0] = true;
            }
            else if (!paramsRead[1] && (object)base.Reader.LocalName == id80_transport && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Transport = base.Reader.Value;
                paramsRead[1] = true;
            }
            else if (!paramsRead[2] && (object)base.Reader.LocalName == id75_style && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Style = Read79_SoapBindingStyle(base.Reader.Value);
                paramsRead[2] = true;
            }
            else if (!IsXmlnsAttribute(base.Reader.Name))
            {
                UnknownNode(o, "http://schemas.xmlsoap.org/wsdl/:required, :transport, :style");
            }
        }
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations31 = 0;
        int readerCount31 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                UnknownNode(o, "");
            }
            else
            {
                UnknownNode(o, "");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations31, ref readerCount31);
        }
        ReadEndElement();
        return o;
    }

    private HttpBinding Read77_HttpBinding(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id82_HttpBinding || (object)xsiType.Namespace != id18_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        HttpBinding o = new HttpBinding();
        bool[] paramsRead = new bool[2];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[0] && (object)base.Reader.LocalName == id22_required && (object)base.Reader.NamespaceURI == id2_Item)
            {
                o.Required = XmlConvert.ToBoolean(base.Reader.Value);
                paramsRead[0] = true;
            }
            else if (!paramsRead[1] && (object)base.Reader.LocalName == id83_verb && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Verb = base.Reader.Value;
                paramsRead[1] = true;
            }
            else if (!IsXmlnsAttribute(base.Reader.Name))
            {
                UnknownNode(o, "http://schemas.xmlsoap.org/wsdl/:required, :verb");
            }
        }
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations32 = 0;
        int readerCount32 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                UnknownNode(o, "");
            }
            else
            {
                UnknownNode(o, "");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations32, ref readerCount32);
        }
        ReadEndElement();
        return o;
    }

    private PortType Read75_PortType(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id84_PortType || (object)xsiType.Namespace != id2_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        PortType o = new PortType();
        XmlAttribute[] a_7 = null;
        int ca_ = 0;
        ServiceDescriptionFormatExtensionCollection a_6 = o.Extensions;
        OperationCollection a_5 = o.Operations;
        bool[] paramsRead = new bool[6];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[3] && (object)base.Reader.LocalName == id4_name && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Name = base.Reader.Value;
                paramsRead[3] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_7 = (XmlAttribute[])EnsureArrayIndex(a_7, ca_, typeof(XmlAttribute));
                a_7[ca_++] = attr;
            }
        }
        o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_7, ca_, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_7, ca_, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations33 = 0;
        int readerCount33 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[0] && (object)base.Reader.LocalName == id7_documentation && (object)base.Reader.NamespaceURI == id2_Item)
                {
                    o.DocumentationElement = (XmlElement)ReadXmlNode(false);
                    paramsRead[0] = true;
                }
                else if ((object)base.Reader.LocalName == id28_operation && (object)base.Reader.NamespaceURI == id2_Item)
                {
                    if (a_5 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_5.Add(Read74_Operation(false, true));
                    }
                }
                else
                {
                    a_6.Add((XmlElement)ReadXmlNode(false));
                }
            }
            else
            {
                UnknownNode(o, "http://schemas.xmlsoap.org/wsdl/:documentation, http://schemas.xmlsoap.org/wsdl/:operation");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations33, ref readerCount33);
        }
        o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_7, ca_, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private Operation Read74_Operation(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id85_Operation || (object)xsiType.Namespace != id2_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        Operation o = new Operation();
        XmlAttribute[] a_10 = null;
        int ca_ = 0;
        ServiceDescriptionFormatExtensionCollection a_9 = o.Extensions;
        OperationMessageCollection a_8 = o.Messages;
        OperationFaultCollection a_7 = o.Faults;
        bool[] paramsRead = new bool[8];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[3] && (object)base.Reader.LocalName == id4_name && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Name = base.Reader.Value;
                paramsRead[3] = true;
            }
            else if (!paramsRead[5] && (object)base.Reader.LocalName == id86_parameterOrder && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.ParameterOrderString = base.Reader.Value;
                paramsRead[5] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_10 = (XmlAttribute[])EnsureArrayIndex(a_10, ca_, typeof(XmlAttribute));
                a_10[ca_++] = attr;
            }
        }
        o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_10, ca_, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_10, ca_, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations34 = 0;
        int readerCount34 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[0] && (object)base.Reader.LocalName == id7_documentation && (object)base.Reader.NamespaceURI == id2_Item)
                {
                    o.DocumentationElement = (XmlElement)ReadXmlNode(false);
                    paramsRead[0] = true;
                }
                else if ((object)base.Reader.LocalName == id30_input && (object)base.Reader.NamespaceURI == id2_Item)
                {
                    if (a_8 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_8.Add(Read71_OperationInput(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id31_output && (object)base.Reader.NamespaceURI == id2_Item)
                {
                    if (a_8 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_8.Add(Read72_OperationOutput(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id32_fault && (object)base.Reader.NamespaceURI == id2_Item)
                {
                    if (a_7 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_7.Add(Read73_OperationFault(false, true));
                    }
                }
                else
                {
                    a_9.Add((XmlElement)ReadXmlNode(false));
                }
            }
            else
            {
                UnknownNode(o, "http://schemas.xmlsoap.org/wsdl/:documentation, http://schemas.xmlsoap.org/wsdl/:input, http://schemas.xmlsoap.org/wsdl/:output, http://schemas.xmlsoap.org/wsdl/:fault");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations34, ref readerCount34);
        }
        o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_10, ca_, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private OperationFault Read73_OperationFault(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id87_OperationFault || (object)xsiType.Namespace != id2_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        OperationFault o = new OperationFault();
        XmlAttribute[] a_6 = null;
        int ca_ = 0;
        ServiceDescriptionFormatExtensionCollection a_5 = o.Extensions;
        bool[] paramsRead = new bool[6];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[3] && (object)base.Reader.LocalName == id4_name && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Name = base.Reader.Value;
                paramsRead[3] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id10_message && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Message = ToXmlQualifiedName(base.Reader.Value);
                paramsRead[4] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_6 = (XmlAttribute[])EnsureArrayIndex(a_6, ca_, typeof(XmlAttribute));
                a_6[ca_++] = attr;
            }
        }
        o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_6, ca_, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_6, ca_, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations35 = 0;
        int readerCount35 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[0] && (object)base.Reader.LocalName == id7_documentation && (object)base.Reader.NamespaceURI == id2_Item)
                {
                    o.DocumentationElement = (XmlElement)ReadXmlNode(false);
                    paramsRead[0] = true;
                }
                else
                {
                    a_5.Add((XmlElement)ReadXmlNode(false));
                }
            }
            else
            {
                UnknownNode(o, "http://schemas.xmlsoap.org/wsdl/:documentation");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations35, ref readerCount35);
        }
        o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_6, ca_, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private OperationOutput Read72_OperationOutput(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id88_OperationOutput || (object)xsiType.Namespace != id2_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        OperationOutput o = new OperationOutput();
        XmlAttribute[] a_6 = null;
        int ca_ = 0;
        ServiceDescriptionFormatExtensionCollection a_5 = o.Extensions;
        bool[] paramsRead = new bool[6];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[3] && (object)base.Reader.LocalName == id4_name && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Name = base.Reader.Value;
                paramsRead[3] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id10_message && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Message = ToXmlQualifiedName(base.Reader.Value);
                paramsRead[4] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_6 = (XmlAttribute[])EnsureArrayIndex(a_6, ca_, typeof(XmlAttribute));
                a_6[ca_++] = attr;
            }
        }
        o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_6, ca_, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_6, ca_, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations36 = 0;
        int readerCount36 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[0] && (object)base.Reader.LocalName == id7_documentation && (object)base.Reader.NamespaceURI == id2_Item)
                {
                    o.DocumentationElement = (XmlElement)ReadXmlNode(false);
                    paramsRead[0] = true;
                }
                else
                {
                    a_5.Add((XmlElement)ReadXmlNode(false));
                }
            }
            else
            {
                UnknownNode(o, "http://schemas.xmlsoap.org/wsdl/:documentation");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations36, ref readerCount36);
        }
        o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_6, ca_, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private OperationInput Read71_OperationInput(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id89_OperationInput || (object)xsiType.Namespace != id2_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        OperationInput o = new OperationInput();
        XmlAttribute[] a_6 = null;
        int ca_ = 0;
        ServiceDescriptionFormatExtensionCollection a_5 = o.Extensions;
        bool[] paramsRead = new bool[6];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[3] && (object)base.Reader.LocalName == id4_name && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Name = base.Reader.Value;
                paramsRead[3] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id10_message && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Message = ToXmlQualifiedName(base.Reader.Value);
                paramsRead[4] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_6 = (XmlAttribute[])EnsureArrayIndex(a_6, ca_, typeof(XmlAttribute));
                a_6[ca_++] = attr;
            }
        }
        o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_6, ca_, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_6, ca_, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations37 = 0;
        int readerCount37 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[0] && (object)base.Reader.LocalName == id7_documentation && (object)base.Reader.NamespaceURI == id2_Item)
                {
                    o.DocumentationElement = (XmlElement)ReadXmlNode(false);
                    paramsRead[0] = true;
                }
                else
                {
                    a_5.Add((XmlElement)ReadXmlNode(false));
                }
            }
            else
            {
                UnknownNode(o, "http://schemas.xmlsoap.org/wsdl/:documentation");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations37, ref readerCount37);
        }
        o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_6, ca_, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private Message Read69_Message(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id90_Message || (object)xsiType.Namespace != id2_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        Message o = new Message();
        XmlAttribute[] a_7 = null;
        int ca_ = 0;
        ServiceDescriptionFormatExtensionCollection a_6 = o.Extensions;
        MessagePartCollection a_5 = o.Parts;
        bool[] paramsRead = new bool[6];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[3] && (object)base.Reader.LocalName == id4_name && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Name = base.Reader.Value;
                paramsRead[3] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_7 = (XmlAttribute[])EnsureArrayIndex(a_7, ca_, typeof(XmlAttribute));
                a_7[ca_++] = attr;
            }
        }
        o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_7, ca_, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_7, ca_, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations38 = 0;
        int readerCount38 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[0] && (object)base.Reader.LocalName == id7_documentation && (object)base.Reader.NamespaceURI == id2_Item)
                {
                    o.DocumentationElement = (XmlElement)ReadXmlNode(false);
                    paramsRead[0] = true;
                }
                else if ((object)base.Reader.LocalName == id49_part && (object)base.Reader.NamespaceURI == id2_Item)
                {
                    if (a_5 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_5.Add(Read68_MessagePart(false, true));
                    }
                }
                else
                {
                    a_6.Add((XmlElement)ReadXmlNode(false));
                }
            }
            else
            {
                UnknownNode(o, "http://schemas.xmlsoap.org/wsdl/:documentation, http://schemas.xmlsoap.org/wsdl/:part");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations38, ref readerCount38);
        }
        o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_7, ca_, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private MessagePart Read68_MessagePart(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id91_MessagePart || (object)xsiType.Namespace != id2_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        MessagePart o = new MessagePart();
        XmlAttribute[] a_5 = null;
        int ca_ = 0;
        ServiceDescriptionFormatExtensionCollection a_4 = o.Extensions;
        bool[] paramsRead = new bool[7];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[3] && (object)base.Reader.LocalName == id4_name && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Name = base.Reader.Value;
                paramsRead[3] = true;
            }
            else if (!paramsRead[5] && (object)base.Reader.LocalName == id92_element && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Element = ToXmlQualifiedName(base.Reader.Value);
                paramsRead[5] = true;
            }
            else if (!paramsRead[6] && (object)base.Reader.LocalName == id27_type && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Type = ToXmlQualifiedName(base.Reader.Value);
                paramsRead[6] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_5 = (XmlAttribute[])EnsureArrayIndex(a_5, ca_, typeof(XmlAttribute));
                a_5[ca_++] = attr;
            }
        }
        o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_5, ca_, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_5, ca_, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations39 = 0;
        int readerCount39 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[0] && (object)base.Reader.LocalName == id7_documentation && (object)base.Reader.NamespaceURI == id2_Item)
                {
                    o.DocumentationElement = (XmlElement)ReadXmlNode(false);
                    paramsRead[0] = true;
                }
                else
                {
                    a_4.Add((XmlElement)ReadXmlNode(false));
                }
            }
            else
            {
                UnknownNode(o, "http://schemas.xmlsoap.org/wsdl/:documentation");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations39, ref readerCount39);
        }
        o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_5, ca_, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private Types Read67_Types(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id93_Types || (object)xsiType.Namespace != id2_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        Types o = new Types();
        XmlAttribute[] a_6 = null;
        int ca_ = 0;
        ServiceDescriptionFormatExtensionCollection a_5 = o.Extensions;
        XmlSchemas a_4 = o.Schemas;
        bool[] paramsRead = new bool[5];
        while (base.Reader.MoveToNextAttribute())
        {
            if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_6 = (XmlAttribute[])EnsureArrayIndex(a_6, ca_, typeof(XmlAttribute));
                a_6[ca_++] = attr;
            }
        }
        o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_6, ca_, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_6, ca_, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations40 = 0;
        int readerCount40 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[0] && (object)base.Reader.LocalName == id7_documentation && (object)base.Reader.NamespaceURI == id2_Item)
                {
                    o.DocumentationElement = (XmlElement)ReadXmlNode(false);
                    paramsRead[0] = true;
                }
                else if ((object)base.Reader.LocalName == id94_schema && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_4 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_4.Add(Read66_XmlSchema(false, true));
                    }
                }
                else
                {
                    a_5.Add((XmlElement)ReadXmlNode(false));
                }
            }
            else
            {
                UnknownNode(o, "http://schemas.xmlsoap.org/wsdl/:documentation, http://www.w3.org/2001/XMLSchema:schema");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations40, ref readerCount40);
        }
        o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_6, ca_, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private XmlSchema Read66_XmlSchema(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id96_XmlSchema || (object)xsiType.Namespace != id95_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        base.DecodeName = false;
        XmlSchema o = new XmlSchema();
        XmlSchemaObjectCollection a_12 = o.Includes;
        XmlSchemaObjectCollection a_11 = o.Items;
        XmlAttribute[] a_10 = null;
        int ca_10 = 0;
        bool[] paramsRead = new bool[11];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[1] && (object)base.Reader.LocalName == id97_attributeFormDefault && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.AttributeFormDefault = Read6_XmlSchemaForm(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[2] && (object)base.Reader.LocalName == id98_blockDefault && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.BlockDefault = Read7_XmlSchemaDerivationMethod(base.Reader.Value);
                paramsRead[2] = true;
            }
            else if (!paramsRead[3] && (object)base.Reader.LocalName == id99_finalDefault && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.FinalDefault = Read7_XmlSchemaDerivationMethod(base.Reader.Value);
                paramsRead[3] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id100_elementFormDefault && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.ElementFormDefault = Read6_XmlSchemaForm(base.Reader.Value);
                paramsRead[4] = true;
            }
            else if (!paramsRead[5] && (object)base.Reader.LocalName == id6_targetNamespace && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.TargetNamespace = CollapseWhitespace(base.Reader.Value);
                paramsRead[5] = true;
            }
            else if (!paramsRead[6] && (object)base.Reader.LocalName == id101_version && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Version = CollapseWhitespace(base.Reader.Value);
                paramsRead[6] = true;
            }
            else if (!paramsRead[9] && (object)base.Reader.LocalName == id102_id && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Id = CollapseWhitespace(base.Reader.Value);
                paramsRead[9] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_10 = (XmlAttribute[])EnsureArrayIndex(a_10, ca_10, typeof(XmlAttribute));
                a_10[ca_10++] = attr;
            }
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_10, ca_10, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_10, ca_10, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations41 = 0;
        int readerCount41 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if ((object)base.Reader.LocalName == id103_include && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_12 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_12.Add(Read12_XmlSchemaInclude(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id8_import && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_12 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_12.Add(Read13_XmlSchemaImport(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id104_redefine && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_12 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_12.Add(Read64_XmlSchemaRedefine(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id105_simpleType && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_11 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_11.Add(Read34_XmlSchemaSimpleType(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id106_complexType && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_11 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_11.Add(Read62_XmlSchemaComplexType(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id107_annotation && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_11 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_11.Add(Read11_XmlSchemaAnnotation(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id108_notation && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_11 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_11.Add(Read65_XmlSchemaNotation(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id59_group && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_11 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_11.Add(Read63_XmlSchemaGroup(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id92_element && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_11 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_11.Add(Read52_XmlSchemaElement(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id109_attribute && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_11 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_11.Add(Read36_XmlSchemaAttribute(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id110_attributeGroup && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_11 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_11.Add(Read40_XmlSchemaAttributeGroup(false, true));
                    }
                }
                else
                {
                    UnknownNode(o, "http://www.w3.org/2001/XMLSchema:include, http://www.w3.org/2001/XMLSchema:import, http://www.w3.org/2001/XMLSchema:redefine, http://www.w3.org/2001/XMLSchema:simpleType, http://www.w3.org/2001/XMLSchema:complexType, http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:notation, http://www.w3.org/2001/XMLSchema:group, http://www.w3.org/2001/XMLSchema:element, http://www.w3.org/2001/XMLSchema:attribute, http://www.w3.org/2001/XMLSchema:attributeGroup");
                }
            }
            else
            {
                UnknownNode(o, "http://www.w3.org/2001/XMLSchema:include, http://www.w3.org/2001/XMLSchema:import, http://www.w3.org/2001/XMLSchema:redefine, http://www.w3.org/2001/XMLSchema:simpleType, http://www.w3.org/2001/XMLSchema:complexType, http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:notation, http://www.w3.org/2001/XMLSchema:group, http://www.w3.org/2001/XMLSchema:element, http://www.w3.org/2001/XMLSchema:attribute, http://www.w3.org/2001/XMLSchema:attributeGroup");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations41, ref readerCount41);
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_10, ca_10, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private XmlSchemaAttributeGroup Read40_XmlSchemaAttributeGroup(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id111_XmlSchemaAttributeGroup || (object)xsiType.Namespace != id95_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        base.DecodeName = false;
        XmlSchemaAttributeGroup o = new XmlSchemaAttributeGroup();
        XmlAttribute[] a_6 = null;
        int ca_3 = 0;
        XmlSchemaObjectCollection a_5 = o.Attributes;
        bool[] paramsRead = new bool[7];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[1] && (object)base.Reader.LocalName == id102_id && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Id = CollapseWhitespace(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id4_name && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Name = base.Reader.Value;
                paramsRead[4] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_6 = (XmlAttribute[])EnsureArrayIndex(a_6, ca_3, typeof(XmlAttribute));
                a_6[ca_3++] = attr;
            }
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_6, ca_3, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_6, ca_3, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations42 = 0;
        int readerCount42 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[2] && (object)base.Reader.LocalName == id107_annotation && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Annotation = Read11_XmlSchemaAnnotation(false, true);
                    paramsRead[2] = true;
                }
                else if ((object)base.Reader.LocalName == id109_attribute && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_5 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_5.Add(Read36_XmlSchemaAttribute(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id110_attributeGroup && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_5 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_5.Add(Read37_XmlSchemaAttributeGroupRef(false, true));
                    }
                }
                else if (!paramsRead[6] && (object)base.Reader.LocalName == id112_anyAttribute && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.AnyAttribute = Read39_XmlSchemaAnyAttribute(false, true);
                    paramsRead[6] = true;
                }
                else
                {
                    UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:attribute, http://www.w3.org/2001/XMLSchema:attributeGroup, http://www.w3.org/2001/XMLSchema:anyAttribute");
                }
            }
            else
            {
                UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:attribute, http://www.w3.org/2001/XMLSchema:attributeGroup, http://www.w3.org/2001/XMLSchema:anyAttribute");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations42, ref readerCount42);
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_6, ca_3, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private XmlSchemaAnyAttribute Read39_XmlSchemaAnyAttribute(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id113_XmlSchemaAnyAttribute || (object)xsiType.Namespace != id95_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        base.DecodeName = false;
        XmlSchemaAnyAttribute o = new XmlSchemaAnyAttribute();
        XmlAttribute[] a_3 = null;
        int ca_3 = 0;
        bool[] paramsRead = new bool[6];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[1] && (object)base.Reader.LocalName == id102_id && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Id = CollapseWhitespace(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id36_namespace && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Namespace = base.Reader.Value;
                paramsRead[4] = true;
            }
            else if (!paramsRead[5] && (object)base.Reader.LocalName == id114_processContents && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.ProcessContents = Read38_XmlSchemaContentProcessing(base.Reader.Value);
                paramsRead[5] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_3 = (XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(XmlAttribute));
                a_3[ca_3++] = attr;
            }
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations43 = 0;
        int readerCount43 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[2] && (object)base.Reader.LocalName == id107_annotation && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Annotation = Read11_XmlSchemaAnnotation(false, true);
                    paramsRead[2] = true;
                }
                else
                {
                    UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation");
                }
            }
            else
            {
                UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations43, ref readerCount43);
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private XmlSchemaAnnotation Read11_XmlSchemaAnnotation(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id115_XmlSchemaAnnotation || (object)xsiType.Namespace != id95_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        base.DecodeName = false;
        XmlSchemaAnnotation o = new XmlSchemaAnnotation();
        XmlSchemaObjectCollection a_4 = o.Items;
        XmlAttribute[] a_3 = null;
        int ca_3 = 0;
        bool[] paramsRead = new bool[4];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[1] && (object)base.Reader.LocalName == id102_id && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Id = CollapseWhitespace(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_3 = (XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(XmlAttribute));
                a_3[ca_3++] = attr;
            }
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations44 = 0;
        int readerCount44 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if ((object)base.Reader.LocalName == id7_documentation && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_4 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_4.Add(Read9_XmlSchemaDocumentation(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id116_appinfo && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_4 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_4.Add(Read10_XmlSchemaAppInfo(false, true));
                    }
                }
                else
                {
                    UnknownNode(o, "http://www.w3.org/2001/XMLSchema:documentation, http://www.w3.org/2001/XMLSchema:appinfo");
                }
            }
            else
            {
                UnknownNode(o, "http://www.w3.org/2001/XMLSchema:documentation, http://www.w3.org/2001/XMLSchema:appinfo");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations44, ref readerCount44);
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private XmlSchemaAppInfo Read10_XmlSchemaAppInfo(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id117_XmlSchemaAppInfo || (object)xsiType.Namespace != id95_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        base.DecodeName = false;
        XmlSchemaAppInfo o = new XmlSchemaAppInfo();
        XmlNode[] a_2 = null;
        int ca_2 = 0;
        bool[] paramsRead = new bool[3];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[1] && (object)base.Reader.LocalName == id118_source && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Source = CollapseWhitespace(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                UnknownNode(o, ":source");
            }
        }
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.Markup = (XmlNode[])ShrinkArray(a_2, ca_2, typeof(XmlNode), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations45 = 0;
        int readerCount45 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                a_2 = (XmlNode[])EnsureArrayIndex(a_2, ca_2, typeof(XmlNode));
                a_2[ca_2++] = ReadXmlNode(false);
            }
            else if (base.Reader.NodeType == XmlNodeType.Text || base.Reader.NodeType == XmlNodeType.CDATA || base.Reader.NodeType == XmlNodeType.Whitespace || base.Reader.NodeType == XmlNodeType.SignificantWhitespace)
            {
                a_2 = (XmlNode[])EnsureArrayIndex(a_2, ca_2, typeof(XmlNode));
                a_2[ca_2++] = base.Document.CreateTextNode(base.Reader.ReadString());
            }
            else
            {
                UnknownNode(o, "");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations45, ref readerCount45);
        }
        o.Markup = (XmlNode[])ShrinkArray(a_2, ca_2, typeof(XmlNode), true);
        ReadEndElement();
        return o;
    }

    private XmlSchemaDocumentation Read9_XmlSchemaDocumentation(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id119_XmlSchemaDocumentation || (object)xsiType.Namespace != id95_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        base.DecodeName = false;
        XmlSchemaDocumentation o = new XmlSchemaDocumentation();
        XmlNode[] a_3 = null;
        int ca_3 = 0;
        bool[] paramsRead = new bool[4];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[1] && (object)base.Reader.LocalName == id118_source && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Source = CollapseWhitespace(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[2] && (object)base.Reader.LocalName == id120_lang && (object)base.Reader.NamespaceURI == id121_Item)
            {
                o.Language = base.Reader.Value;
                paramsRead[2] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                UnknownNode(o, ":source, http://www.w3.org/XML/1998/namespace");
            }
        }
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.Markup = (XmlNode[])ShrinkArray(a_3, ca_3, typeof(XmlNode), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations46 = 0;
        int readerCount46 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                a_3 = (XmlNode[])EnsureArrayIndex(a_3, ca_3, typeof(XmlNode));
                a_3[ca_3++] = ReadXmlNode(false);
            }
            else if (base.Reader.NodeType == XmlNodeType.Text || base.Reader.NodeType == XmlNodeType.CDATA || base.Reader.NodeType == XmlNodeType.Whitespace || base.Reader.NodeType == XmlNodeType.SignificantWhitespace)
            {
                a_3 = (XmlNode[])EnsureArrayIndex(a_3, ca_3, typeof(XmlNode));
                a_3[ca_3++] = base.Document.CreateTextNode(base.Reader.ReadString());
            }
            else
            {
                UnknownNode(o, "");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations46, ref readerCount46);
        }
        o.Markup = (XmlNode[])ShrinkArray(a_3, ca_3, typeof(XmlNode), true);
        ReadEndElement();
        return o;
    }

    private XmlSchemaContentProcessing Read38_XmlSchemaContentProcessing(string s)
    {
        if (s != null)
        {
            if (!(s == "skip"))
            {
                if (!(s == "lax"))
                {
                    if (s == "strict")
                    {
                        return XmlSchemaContentProcessing.Strict;
                    }
                    goto IL_0032;
                }
                return XmlSchemaContentProcessing.Lax;
            }
            return XmlSchemaContentProcessing.Skip;
        }
        goto IL_0032;
    IL_0032:
        throw CreateUnknownConstantException(s, typeof(XmlSchemaContentProcessing));
    }

    private XmlSchemaAttributeGroupRef Read37_XmlSchemaAttributeGroupRef(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id122_XmlSchemaAttributeGroupRef || (object)xsiType.Namespace != id95_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        base.DecodeName = false;
        XmlSchemaAttributeGroupRef o = new XmlSchemaAttributeGroupRef();
        XmlAttribute[] a_3 = null;
        int ca_3 = 0;
        bool[] paramsRead = new bool[5];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[1] && (object)base.Reader.LocalName == id102_id && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Id = CollapseWhitespace(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id123_ref && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.RefName = ToXmlQualifiedName(base.Reader.Value);
                paramsRead[4] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_3 = (XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(XmlAttribute));
                a_3[ca_3++] = attr;
            }
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations47 = 0;
        int readerCount47 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[2] && (object)base.Reader.LocalName == id107_annotation && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Annotation = Read11_XmlSchemaAnnotation(false, true);
                    paramsRead[2] = true;
                }
                else
                {
                    UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation");
                }
            }
            else
            {
                UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations47, ref readerCount47);
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private XmlSchemaAttribute Read36_XmlSchemaAttribute(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id124_XmlSchemaAttribute || (object)xsiType.Namespace != id95_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        base.DecodeName = false;
        XmlSchemaAttribute o = new XmlSchemaAttribute();
        XmlAttribute[] a_3 = null;
        int ca_3 = 0;
        bool[] paramsRead = new bool[12];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[1] && (object)base.Reader.LocalName == id102_id && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Id = CollapseWhitespace(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id125_default && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.DefaultValue = base.Reader.Value;
                paramsRead[4] = true;
            }
            else if (!paramsRead[5] && (object)base.Reader.LocalName == id126_fixed && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.FixedValue = base.Reader.Value;
                paramsRead[5] = true;
            }
            else if (!paramsRead[6] && (object)base.Reader.LocalName == id127_form && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Form = Read6_XmlSchemaForm(base.Reader.Value);
                paramsRead[6] = true;
            }
            else if (!paramsRead[7] && (object)base.Reader.LocalName == id4_name && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Name = base.Reader.Value;
                paramsRead[7] = true;
            }
            else if (!paramsRead[8] && (object)base.Reader.LocalName == id123_ref && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.RefName = ToXmlQualifiedName(base.Reader.Value);
                paramsRead[8] = true;
            }
            else if (!paramsRead[9] && (object)base.Reader.LocalName == id27_type && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.SchemaTypeName = ToXmlQualifiedName(base.Reader.Value);
                paramsRead[9] = true;
            }
            else if (!paramsRead[11] && (object)base.Reader.LocalName == id35_use && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Use = Read35_XmlSchemaUse(base.Reader.Value);
                paramsRead[11] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_3 = (XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(XmlAttribute));
                a_3[ca_3++] = attr;
            }
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations48 = 0;
        int readerCount48 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[2] && (object)base.Reader.LocalName == id107_annotation && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Annotation = Read11_XmlSchemaAnnotation(false, true);
                    paramsRead[2] = true;
                }
                else if (!paramsRead[10] && (object)base.Reader.LocalName == id105_simpleType && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.SchemaType = Read34_XmlSchemaSimpleType(false, true);
                    paramsRead[10] = true;
                }
                else
                {
                    UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:simpleType");
                }
            }
            else
            {
                UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:simpleType");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations48, ref readerCount48);
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private XmlSchemaSimpleType Read34_XmlSchemaSimpleType(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id128_XmlSchemaSimpleType || (object)xsiType.Namespace != id95_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        base.DecodeName = false;
        XmlSchemaSimpleType o = new XmlSchemaSimpleType();
        XmlAttribute[] a_3 = null;
        int ca_3 = 0;
        bool[] paramsRead = new bool[7];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[1] && (object)base.Reader.LocalName == id102_id && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Id = CollapseWhitespace(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id4_name && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Name = base.Reader.Value;
                paramsRead[4] = true;
            }
            else if (!paramsRead[5] && (object)base.Reader.LocalName == id129_final && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Final = Read7_XmlSchemaDerivationMethod(base.Reader.Value);
                paramsRead[5] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_3 = (XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(XmlAttribute));
                a_3[ca_3++] = attr;
            }
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations49 = 0;
        int readerCount49 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[2] && (object)base.Reader.LocalName == id107_annotation && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Annotation = Read11_XmlSchemaAnnotation(false, true);
                    paramsRead[2] = true;
                }
                else if (!paramsRead[6] && (object)base.Reader.LocalName == id130_list && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Content = Read17_XmlSchemaSimpleTypeList(false, true);
                    paramsRead[6] = true;
                }
                else if (!paramsRead[6] && (object)base.Reader.LocalName == id131_restriction && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Content = Read32_XmlSchemaSimpleTypeRestriction(false, true);
                    paramsRead[6] = true;
                }
                else if (!paramsRead[6] && (object)base.Reader.LocalName == id132_union && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Content = Read33_XmlSchemaSimpleTypeUnion(false, true);
                    paramsRead[6] = true;
                }
                else
                {
                    UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:list, http://www.w3.org/2001/XMLSchema:restriction, http://www.w3.org/2001/XMLSchema:union");
                }
            }
            else
            {
                UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:list, http://www.w3.org/2001/XMLSchema:restriction, http://www.w3.org/2001/XMLSchema:union");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations49, ref readerCount49);
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private XmlSchemaSimpleTypeUnion Read33_XmlSchemaSimpleTypeUnion(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id133_XmlSchemaSimpleTypeUnion || (object)xsiType.Namespace != id95_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        base.DecodeName = false;
        XmlSchemaSimpleTypeUnion o = new XmlSchemaSimpleTypeUnion();
        XmlAttribute[] a_7 = null;
        int ca_6 = 0;
        XmlSchemaObjectCollection a_6 = o.BaseTypes;
        XmlQualifiedName[] a_5 = null;
        int ca_5 = 0;
        bool[] paramsRead = new bool[6];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[1] && (object)base.Reader.LocalName == id102_id && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Id = CollapseWhitespace(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if ((object)base.Reader.LocalName == id134_memberTypes && (object)base.Reader.NamespaceURI == id5_Item)
            {
                string listValues = base.Reader.Value;
                string[] vals = listValues.Split((char[])null);
                for (int i = 0; i < vals.Length; i++)
                {
                    a_5 = (XmlQualifiedName[])EnsureArrayIndex(a_5, ca_5, typeof(XmlQualifiedName));
                    a_5[ca_5++] = ToXmlQualifiedName(vals[i]);
                }
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_7 = (XmlAttribute[])EnsureArrayIndex(a_7, ca_6, typeof(XmlAttribute));
                a_7[ca_6++] = attr;
            }
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_7, ca_6, typeof(XmlAttribute), true);
        o.MemberTypes = (XmlQualifiedName[])ShrinkArray(a_5, ca_5, typeof(XmlQualifiedName), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_7, ca_6, typeof(XmlAttribute), true);
            o.MemberTypes = (XmlQualifiedName[])ShrinkArray(a_5, ca_5, typeof(XmlQualifiedName), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations50 = 0;
        int readerCount50 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[2] && (object)base.Reader.LocalName == id107_annotation && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Annotation = Read11_XmlSchemaAnnotation(false, true);
                    paramsRead[2] = true;
                }
                else if ((object)base.Reader.LocalName == id105_simpleType && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_6 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_6.Add(Read34_XmlSchemaSimpleType(false, true));
                    }
                }
                else
                {
                    UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:simpleType");
                }
            }
            else
            {
                UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:simpleType");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations50, ref readerCount50);
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_7, ca_6, typeof(XmlAttribute), true);
        o.MemberTypes = (XmlQualifiedName[])ShrinkArray(a_5, ca_5, typeof(XmlQualifiedName), true);
        ReadEndElement();
        return o;
    }

    private XmlSchemaSimpleTypeRestriction Read32_XmlSchemaSimpleTypeRestriction(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id135_XmlSchemaSimpleTypeRestriction || (object)xsiType.Namespace != id95_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        base.DecodeName = false;
        XmlSchemaSimpleTypeRestriction o = new XmlSchemaSimpleTypeRestriction();
        XmlAttribute[] a_7 = null;
        int ca_3 = 0;
        XmlSchemaObjectCollection a_6 = o.Facets;
        bool[] paramsRead = new bool[7];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[1] && (object)base.Reader.LocalName == id102_id && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Id = CollapseWhitespace(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id136_base && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.BaseTypeName = ToXmlQualifiedName(base.Reader.Value);
                paramsRead[4] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_7 = (XmlAttribute[])EnsureArrayIndex(a_7, ca_3, typeof(XmlAttribute));
                a_7[ca_3++] = attr;
            }
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_7, ca_3, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_7, ca_3, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations51 = 0;
        int readerCount51 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[2] && (object)base.Reader.LocalName == id107_annotation && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Annotation = Read11_XmlSchemaAnnotation(false, true);
                    paramsRead[2] = true;
                }
                else if (!paramsRead[5] && (object)base.Reader.LocalName == id105_simpleType && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.BaseType = Read34_XmlSchemaSimpleType(false, true);
                    paramsRead[5] = true;
                }
                else if ((object)base.Reader.LocalName == id137_fractionDigits && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_6 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_6.Add(Read20_XmlSchemaFractionDigitsFacet(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id138_minInclusive && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_6 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_6.Add(Read21_XmlSchemaMinInclusiveFacet(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id139_maxLength && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_6 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_6.Add(Read22_XmlSchemaMaxLengthFacet(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id140_length && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_6 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_6.Add(Read23_XmlSchemaLengthFacet(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id141_totalDigits && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_6 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_6.Add(Read24_XmlSchemaTotalDigitsFacet(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id62_pattern && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_6 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_6.Add(Read25_XmlSchemaPatternFacet(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id142_enumeration && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_6 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_6.Add(Read26_XmlSchemaEnumerationFacet(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id143_maxInclusive && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_6 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_6.Add(Read27_XmlSchemaMaxInclusiveFacet(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id144_maxExclusive && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_6 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_6.Add(Read28_XmlSchemaMaxExclusiveFacet(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id145_whiteSpace && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_6 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_6.Add(Read29_XmlSchemaWhiteSpaceFacet(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id146_minExclusive && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_6 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_6.Add(Read30_XmlSchemaMinExclusiveFacet(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id147_minLength && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_6 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_6.Add(Read31_XmlSchemaMinLengthFacet(false, true));
                    }
                }
                else
                {
                    UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:simpleType, http://www.w3.org/2001/XMLSchema:fractionDigits, http://www.w3.org/2001/XMLSchema:minInclusive, http://www.w3.org/2001/XMLSchema:maxLength, http://www.w3.org/2001/XMLSchema:length, http://www.w3.org/2001/XMLSchema:totalDigits, http://www.w3.org/2001/XMLSchema:pattern, http://www.w3.org/2001/XMLSchema:enumeration, http://www.w3.org/2001/XMLSchema:maxInclusive, http://www.w3.org/2001/XMLSchema:maxExclusive, http://www.w3.org/2001/XMLSchema:whiteSpace, http://www.w3.org/2001/XMLSchema:minExclusive, http://www.w3.org/2001/XMLSchema:minLength");
                }
            }
            else
            {
                UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:simpleType, http://www.w3.org/2001/XMLSchema:fractionDigits, http://www.w3.org/2001/XMLSchema:minInclusive, http://www.w3.org/2001/XMLSchema:maxLength, http://www.w3.org/2001/XMLSchema:length, http://www.w3.org/2001/XMLSchema:totalDigits, http://www.w3.org/2001/XMLSchema:pattern, http://www.w3.org/2001/XMLSchema:enumeration, http://www.w3.org/2001/XMLSchema:maxInclusive, http://www.w3.org/2001/XMLSchema:maxExclusive, http://www.w3.org/2001/XMLSchema:whiteSpace, http://www.w3.org/2001/XMLSchema:minExclusive, http://www.w3.org/2001/XMLSchema:minLength");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations51, ref readerCount51);
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_7, ca_3, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private XmlSchemaMinLengthFacet Read31_XmlSchemaMinLengthFacet(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id148_XmlSchemaMinLengthFacet || (object)xsiType.Namespace != id95_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        base.DecodeName = false;
        XmlSchemaMinLengthFacet o = new XmlSchemaMinLengthFacet();
        XmlAttribute[] a_3 = null;
        int ca_3 = 0;
        bool[] paramsRead = new bool[6];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[1] && (object)base.Reader.LocalName == id102_id && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Id = CollapseWhitespace(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id149_value && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Value = base.Reader.Value;
                paramsRead[4] = true;
            }
            else if (!paramsRead[5] && (object)base.Reader.LocalName == id126_fixed && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.IsFixed = XmlConvert.ToBoolean(base.Reader.Value);
                paramsRead[5] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_3 = (XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(XmlAttribute));
                a_3[ca_3++] = attr;
            }
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations52 = 0;
        int readerCount52 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[2] && (object)base.Reader.LocalName == id107_annotation && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Annotation = Read11_XmlSchemaAnnotation(false, true);
                    paramsRead[2] = true;
                }
                else
                {
                    UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation");
                }
            }
            else
            {
                UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations52, ref readerCount52);
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private XmlSchemaMinExclusiveFacet Read30_XmlSchemaMinExclusiveFacet(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id150_XmlSchemaMinExclusiveFacet || (object)xsiType.Namespace != id95_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        base.DecodeName = false;
        XmlSchemaMinExclusiveFacet o = new XmlSchemaMinExclusiveFacet();
        XmlAttribute[] a_3 = null;
        int ca_3 = 0;
        bool[] paramsRead = new bool[6];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[1] && (object)base.Reader.LocalName == id102_id && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Id = CollapseWhitespace(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id149_value && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Value = base.Reader.Value;
                paramsRead[4] = true;
            }
            else if (!paramsRead[5] && (object)base.Reader.LocalName == id126_fixed && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.IsFixed = XmlConvert.ToBoolean(base.Reader.Value);
                paramsRead[5] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_3 = (XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(XmlAttribute));
                a_3[ca_3++] = attr;
            }
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations53 = 0;
        int readerCount53 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[2] && (object)base.Reader.LocalName == id107_annotation && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Annotation = Read11_XmlSchemaAnnotation(false, true);
                    paramsRead[2] = true;
                }
                else
                {
                    UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation");
                }
            }
            else
            {
                UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations53, ref readerCount53);
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private XmlSchemaWhiteSpaceFacet Read29_XmlSchemaWhiteSpaceFacet(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id151_XmlSchemaWhiteSpaceFacet || (object)xsiType.Namespace != id95_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        base.DecodeName = false;
        XmlSchemaWhiteSpaceFacet o = new XmlSchemaWhiteSpaceFacet();
        XmlAttribute[] a_3 = null;
        int ca_3 = 0;
        bool[] paramsRead = new bool[6];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[1] && (object)base.Reader.LocalName == id102_id && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Id = CollapseWhitespace(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id149_value && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Value = base.Reader.Value;
                paramsRead[4] = true;
            }
            else if (!paramsRead[5] && (object)base.Reader.LocalName == id126_fixed && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.IsFixed = XmlConvert.ToBoolean(base.Reader.Value);
                paramsRead[5] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_3 = (XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(XmlAttribute));
                a_3[ca_3++] = attr;
            }
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations54 = 0;
        int readerCount54 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[2] && (object)base.Reader.LocalName == id107_annotation && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Annotation = Read11_XmlSchemaAnnotation(false, true);
                    paramsRead[2] = true;
                }
                else
                {
                    UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation");
                }
            }
            else
            {
                UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations54, ref readerCount54);
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private XmlSchemaMaxExclusiveFacet Read28_XmlSchemaMaxExclusiveFacet(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id152_XmlSchemaMaxExclusiveFacet || (object)xsiType.Namespace != id95_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        base.DecodeName = false;
        XmlSchemaMaxExclusiveFacet o = new XmlSchemaMaxExclusiveFacet();
        XmlAttribute[] a_3 = null;
        int ca_3 = 0;
        bool[] paramsRead = new bool[6];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[1] && (object)base.Reader.LocalName == id102_id && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Id = CollapseWhitespace(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id149_value && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Value = base.Reader.Value;
                paramsRead[4] = true;
            }
            else if (!paramsRead[5] && (object)base.Reader.LocalName == id126_fixed && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.IsFixed = XmlConvert.ToBoolean(base.Reader.Value);
                paramsRead[5] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_3 = (XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(XmlAttribute));
                a_3[ca_3++] = attr;
            }
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations55 = 0;
        int readerCount55 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[2] && (object)base.Reader.LocalName == id107_annotation && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Annotation = Read11_XmlSchemaAnnotation(false, true);
                    paramsRead[2] = true;
                }
                else
                {
                    UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation");
                }
            }
            else
            {
                UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations55, ref readerCount55);
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private XmlSchemaMaxInclusiveFacet Read27_XmlSchemaMaxInclusiveFacet(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id153_XmlSchemaMaxInclusiveFacet || (object)xsiType.Namespace != id95_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        base.DecodeName = false;
        XmlSchemaMaxInclusiveFacet o = new XmlSchemaMaxInclusiveFacet();
        XmlAttribute[] a_3 = null;
        int ca_3 = 0;
        bool[] paramsRead = new bool[6];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[1] && (object)base.Reader.LocalName == id102_id && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Id = CollapseWhitespace(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id149_value && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Value = base.Reader.Value;
                paramsRead[4] = true;
            }
            else if (!paramsRead[5] && (object)base.Reader.LocalName == id126_fixed && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.IsFixed = XmlConvert.ToBoolean(base.Reader.Value);
                paramsRead[5] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_3 = (XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(XmlAttribute));
                a_3[ca_3++] = attr;
            }
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations56 = 0;
        int readerCount56 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[2] && (object)base.Reader.LocalName == id107_annotation && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Annotation = Read11_XmlSchemaAnnotation(false, true);
                    paramsRead[2] = true;
                }
                else
                {
                    UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation");
                }
            }
            else
            {
                UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations56, ref readerCount56);
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private XmlSchemaEnumerationFacet Read26_XmlSchemaEnumerationFacet(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id154_XmlSchemaEnumerationFacet || (object)xsiType.Namespace != id95_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        base.DecodeName = false;
        XmlSchemaEnumerationFacet o = new XmlSchemaEnumerationFacet();
        XmlAttribute[] a_3 = null;
        int ca_3 = 0;
        bool[] paramsRead = new bool[6];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[1] && (object)base.Reader.LocalName == id102_id && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Id = CollapseWhitespace(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id149_value && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Value = base.Reader.Value;
                paramsRead[4] = true;
            }
            else if (!paramsRead[5] && (object)base.Reader.LocalName == id126_fixed && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.IsFixed = XmlConvert.ToBoolean(base.Reader.Value);
                paramsRead[5] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_3 = (XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(XmlAttribute));
                a_3[ca_3++] = attr;
            }
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations57 = 0;
        int readerCount57 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[2] && (object)base.Reader.LocalName == id107_annotation && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Annotation = Read11_XmlSchemaAnnotation(false, true);
                    paramsRead[2] = true;
                }
                else
                {
                    UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation");
                }
            }
            else
            {
                UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations57, ref readerCount57);
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private XmlSchemaPatternFacet Read25_XmlSchemaPatternFacet(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id155_XmlSchemaPatternFacet || (object)xsiType.Namespace != id95_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        base.DecodeName = false;
        XmlSchemaPatternFacet o = new XmlSchemaPatternFacet();
        XmlAttribute[] a_3 = null;
        int ca_3 = 0;
        bool[] paramsRead = new bool[6];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[1] && (object)base.Reader.LocalName == id102_id && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Id = CollapseWhitespace(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id149_value && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Value = base.Reader.Value;
                paramsRead[4] = true;
            }
            else if (!paramsRead[5] && (object)base.Reader.LocalName == id126_fixed && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.IsFixed = XmlConvert.ToBoolean(base.Reader.Value);
                paramsRead[5] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_3 = (XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(XmlAttribute));
                a_3[ca_3++] = attr;
            }
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations58 = 0;
        int readerCount58 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[2] && (object)base.Reader.LocalName == id107_annotation && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Annotation = Read11_XmlSchemaAnnotation(false, true);
                    paramsRead[2] = true;
                }
                else
                {
                    UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation");
                }
            }
            else
            {
                UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations58, ref readerCount58);
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private XmlSchemaTotalDigitsFacet Read24_XmlSchemaTotalDigitsFacet(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id156_XmlSchemaTotalDigitsFacet || (object)xsiType.Namespace != id95_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        base.DecodeName = false;
        XmlSchemaTotalDigitsFacet o = new XmlSchemaTotalDigitsFacet();
        XmlAttribute[] a_3 = null;
        int ca_3 = 0;
        bool[] paramsRead = new bool[6];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[1] && (object)base.Reader.LocalName == id102_id && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Id = CollapseWhitespace(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id149_value && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Value = base.Reader.Value;
                paramsRead[4] = true;
            }
            else if (!paramsRead[5] && (object)base.Reader.LocalName == id126_fixed && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.IsFixed = XmlConvert.ToBoolean(base.Reader.Value);
                paramsRead[5] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_3 = (XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(XmlAttribute));
                a_3[ca_3++] = attr;
            }
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations59 = 0;
        int readerCount59 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[2] && (object)base.Reader.LocalName == id107_annotation && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Annotation = Read11_XmlSchemaAnnotation(false, true);
                    paramsRead[2] = true;
                }
                else
                {
                    UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation");
                }
            }
            else
            {
                UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations59, ref readerCount59);
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private XmlSchemaLengthFacet Read23_XmlSchemaLengthFacet(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id157_XmlSchemaLengthFacet || (object)xsiType.Namespace != id95_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        base.DecodeName = false;
        XmlSchemaLengthFacet o = new XmlSchemaLengthFacet();
        XmlAttribute[] a_3 = null;
        int ca_3 = 0;
        bool[] paramsRead = new bool[6];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[1] && (object)base.Reader.LocalName == id102_id && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Id = CollapseWhitespace(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id149_value && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Value = base.Reader.Value;
                paramsRead[4] = true;
            }
            else if (!paramsRead[5] && (object)base.Reader.LocalName == id126_fixed && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.IsFixed = XmlConvert.ToBoolean(base.Reader.Value);
                paramsRead[5] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_3 = (XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(XmlAttribute));
                a_3[ca_3++] = attr;
            }
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations60 = 0;
        int readerCount60 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[2] && (object)base.Reader.LocalName == id107_annotation && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Annotation = Read11_XmlSchemaAnnotation(false, true);
                    paramsRead[2] = true;
                }
                else
                {
                    UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation");
                }
            }
            else
            {
                UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations60, ref readerCount60);
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private XmlSchemaMaxLengthFacet Read22_XmlSchemaMaxLengthFacet(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id158_XmlSchemaMaxLengthFacet || (object)xsiType.Namespace != id95_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        base.DecodeName = false;
        XmlSchemaMaxLengthFacet o = new XmlSchemaMaxLengthFacet();
        XmlAttribute[] a_3 = null;
        int ca_3 = 0;
        bool[] paramsRead = new bool[6];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[1] && (object)base.Reader.LocalName == id102_id && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Id = CollapseWhitespace(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id149_value && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Value = base.Reader.Value;
                paramsRead[4] = true;
            }
            else if (!paramsRead[5] && (object)base.Reader.LocalName == id126_fixed && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.IsFixed = XmlConvert.ToBoolean(base.Reader.Value);
                paramsRead[5] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_3 = (XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(XmlAttribute));
                a_3[ca_3++] = attr;
            }
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations61 = 0;
        int readerCount61 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[2] && (object)base.Reader.LocalName == id107_annotation && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Annotation = Read11_XmlSchemaAnnotation(false, true);
                    paramsRead[2] = true;
                }
                else
                {
                    UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation");
                }
            }
            else
            {
                UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations61, ref readerCount61);
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private XmlSchemaMinInclusiveFacet Read21_XmlSchemaMinInclusiveFacet(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id159_XmlSchemaMinInclusiveFacet || (object)xsiType.Namespace != id95_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        base.DecodeName = false;
        XmlSchemaMinInclusiveFacet o = new XmlSchemaMinInclusiveFacet();
        XmlAttribute[] a_3 = null;
        int ca_3 = 0;
        bool[] paramsRead = new bool[6];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[1] && (object)base.Reader.LocalName == id102_id && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Id = CollapseWhitespace(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id149_value && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Value = base.Reader.Value;
                paramsRead[4] = true;
            }
            else if (!paramsRead[5] && (object)base.Reader.LocalName == id126_fixed && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.IsFixed = XmlConvert.ToBoolean(base.Reader.Value);
                paramsRead[5] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_3 = (XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(XmlAttribute));
                a_3[ca_3++] = attr;
            }
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations62 = 0;
        int readerCount62 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[2] && (object)base.Reader.LocalName == id107_annotation && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Annotation = Read11_XmlSchemaAnnotation(false, true);
                    paramsRead[2] = true;
                }
                else
                {
                    UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation");
                }
            }
            else
            {
                UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations62, ref readerCount62);
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private XmlSchemaFractionDigitsFacet Read20_XmlSchemaFractionDigitsFacet(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id160_XmlSchemaFractionDigitsFacet || (object)xsiType.Namespace != id95_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        base.DecodeName = false;
        XmlSchemaFractionDigitsFacet o = new XmlSchemaFractionDigitsFacet();
        XmlAttribute[] a_3 = null;
        int ca_3 = 0;
        bool[] paramsRead = new bool[6];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[1] && (object)base.Reader.LocalName == id102_id && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Id = CollapseWhitespace(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id149_value && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Value = base.Reader.Value;
                paramsRead[4] = true;
            }
            else if (!paramsRead[5] && (object)base.Reader.LocalName == id126_fixed && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.IsFixed = XmlConvert.ToBoolean(base.Reader.Value);
                paramsRead[5] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_3 = (XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(XmlAttribute));
                a_3[ca_3++] = attr;
            }
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations63 = 0;
        int readerCount63 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[2] && (object)base.Reader.LocalName == id107_annotation && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Annotation = Read11_XmlSchemaAnnotation(false, true);
                    paramsRead[2] = true;
                }
                else
                {
                    UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation");
                }
            }
            else
            {
                UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations63, ref readerCount63);
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private XmlSchemaSimpleTypeList Read17_XmlSchemaSimpleTypeList(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id161_XmlSchemaSimpleTypeList || (object)xsiType.Namespace != id95_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        base.DecodeName = false;
        XmlSchemaSimpleTypeList o = new XmlSchemaSimpleTypeList();
        XmlAttribute[] a_3 = null;
        int ca_3 = 0;
        bool[] paramsRead = new bool[6];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[1] && (object)base.Reader.LocalName == id102_id && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Id = CollapseWhitespace(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id162_itemType && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.ItemTypeName = ToXmlQualifiedName(base.Reader.Value);
                paramsRead[4] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_3 = (XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(XmlAttribute));
                a_3[ca_3++] = attr;
            }
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations64 = 0;
        int readerCount64 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[2] && (object)base.Reader.LocalName == id107_annotation && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Annotation = Read11_XmlSchemaAnnotation(false, true);
                    paramsRead[2] = true;
                }
                else if (!paramsRead[5] && (object)base.Reader.LocalName == id105_simpleType && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.ItemType = Read34_XmlSchemaSimpleType(false, true);
                    paramsRead[5] = true;
                }
                else
                {
                    UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:simpleType");
                }
            }
            else
            {
                UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:simpleType");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations64, ref readerCount64);
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private XmlSchemaDerivationMethod Read7_XmlSchemaDerivationMethod(string s)
    {
        return (XmlSchemaDerivationMethod)XmlSerializationReader.ToEnum(s, XmlSchemaDerivationMethodValues, "System.Xml.Schema.XmlSchemaDerivationMethod");
    }

    private XmlSchemaUse Read35_XmlSchemaUse(string s)
    {
        if (s != null)
        {
            if (!(s == "optional"))
            {
                if (!(s == "prohibited"))
                {
                    if (s == "required")
                    {
                        return XmlSchemaUse.Required;
                    }
                    goto IL_0032;
                }
                return XmlSchemaUse.Prohibited;
            }
            return XmlSchemaUse.Optional;
        }
        goto IL_0032;
    IL_0032:
        throw CreateUnknownConstantException(s, typeof(XmlSchemaUse));
    }

    private XmlSchemaForm Read6_XmlSchemaForm(string s)
    {
        if (s != null)
        {
            if (s == "qualified")
            {
                return XmlSchemaForm.Qualified;
            }
            if (s == "unqualified")
            {
                return XmlSchemaForm.Unqualified;
            }
        }
        throw CreateUnknownConstantException(s, typeof(XmlSchemaForm));
    }

    private XmlSchemaElement Read52_XmlSchemaElement(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id163_XmlSchemaElement || (object)xsiType.Namespace != id95_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        base.DecodeName = false;
        XmlSchemaElement o = new XmlSchemaElement();
        XmlAttribute[] a_19 = null;
        int ca_3 = 0;
        XmlSchemaObjectCollection a_18 = o.Constraints;
        bool[] paramsRead = new bool[19];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[1] && (object)base.Reader.LocalName == id102_id && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Id = CollapseWhitespace(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id164_minOccurs && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.MinOccursString = base.Reader.Value;
                paramsRead[4] = true;
            }
            else if (!paramsRead[5] && (object)base.Reader.LocalName == id165_maxOccurs && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.MaxOccursString = base.Reader.Value;
                paramsRead[5] = true;
            }
            else if (!paramsRead[6] && (object)base.Reader.LocalName == id166_abstract && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.IsAbstract = XmlConvert.ToBoolean(base.Reader.Value);
                paramsRead[6] = true;
            }
            else if (!paramsRead[7] && (object)base.Reader.LocalName == id167_block && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Block = Read7_XmlSchemaDerivationMethod(base.Reader.Value);
                paramsRead[7] = true;
            }
            else if (!paramsRead[8] && (object)base.Reader.LocalName == id125_default && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.DefaultValue = base.Reader.Value;
                paramsRead[8] = true;
            }
            else if (!paramsRead[9] && (object)base.Reader.LocalName == id129_final && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Final = Read7_XmlSchemaDerivationMethod(base.Reader.Value);
                paramsRead[9] = true;
            }
            else if (!paramsRead[10] && (object)base.Reader.LocalName == id126_fixed && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.FixedValue = base.Reader.Value;
                paramsRead[10] = true;
            }
            else if (!paramsRead[11] && (object)base.Reader.LocalName == id127_form && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Form = Read6_XmlSchemaForm(base.Reader.Value);
                paramsRead[11] = true;
            }
            else if (!paramsRead[12] && (object)base.Reader.LocalName == id4_name && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Name = base.Reader.Value;
                paramsRead[12] = true;
            }
            else if (!paramsRead[13] && (object)base.Reader.LocalName == id168_nillable && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.IsNillable = XmlConvert.ToBoolean(base.Reader.Value);
                paramsRead[13] = true;
            }
            else if (!paramsRead[14] && (object)base.Reader.LocalName == id123_ref && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.RefName = ToXmlQualifiedName(base.Reader.Value);
                paramsRead[14] = true;
            }
            else if (!paramsRead[15] && (object)base.Reader.LocalName == id169_substitutionGroup && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.SubstitutionGroup = ToXmlQualifiedName(base.Reader.Value);
                paramsRead[15] = true;
            }
            else if (!paramsRead[16] && (object)base.Reader.LocalName == id27_type && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.SchemaTypeName = ToXmlQualifiedName(base.Reader.Value);
                paramsRead[16] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_19 = (XmlAttribute[])EnsureArrayIndex(a_19, ca_3, typeof(XmlAttribute));
                a_19[ca_3++] = attr;
            }
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_19, ca_3, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_19, ca_3, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations65 = 0;
        int readerCount65 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[2] && (object)base.Reader.LocalName == id107_annotation && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Annotation = Read11_XmlSchemaAnnotation(false, true);
                    paramsRead[2] = true;
                }
                else if (!paramsRead[17] && (object)base.Reader.LocalName == id105_simpleType && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.SchemaType = Read34_XmlSchemaSimpleType(false, true);
                    paramsRead[17] = true;
                }
                else if (!paramsRead[17] && (object)base.Reader.LocalName == id106_complexType && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.SchemaType = Read62_XmlSchemaComplexType(false, true);
                    paramsRead[17] = true;
                }
                else if ((object)base.Reader.LocalName == id170_key && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_18 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_18.Add(Read49_XmlSchemaKey(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id171_unique && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_18 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_18.Add(Read50_XmlSchemaUnique(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id172_keyref && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_18 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_18.Add(Read51_XmlSchemaKeyref(false, true));
                    }
                }
                else
                {
                    UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:simpleType, http://www.w3.org/2001/XMLSchema:complexType, http://www.w3.org/2001/XMLSchema:key, http://www.w3.org/2001/XMLSchema:unique, http://www.w3.org/2001/XMLSchema:keyref");
                }
            }
            else
            {
                UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:simpleType, http://www.w3.org/2001/XMLSchema:complexType, http://www.w3.org/2001/XMLSchema:key, http://www.w3.org/2001/XMLSchema:unique, http://www.w3.org/2001/XMLSchema:keyref");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations65, ref readerCount65);
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_19, ca_3, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private XmlSchemaKeyref Read51_XmlSchemaKeyref(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id173_XmlSchemaKeyref || (object)xsiType.Namespace != id95_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        base.DecodeName = false;
        XmlSchemaKeyref o = new XmlSchemaKeyref();
        XmlAttribute[] a_7 = null;
        int ca_3 = 0;
        XmlSchemaObjectCollection a_6 = o.Fields;
        bool[] paramsRead = new bool[8];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[1] && (object)base.Reader.LocalName == id102_id && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Id = CollapseWhitespace(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id4_name && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Name = base.Reader.Value;
                paramsRead[4] = true;
            }
            else if (!paramsRead[7] && (object)base.Reader.LocalName == id174_refer && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Refer = ToXmlQualifiedName(base.Reader.Value);
                paramsRead[7] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_7 = (XmlAttribute[])EnsureArrayIndex(a_7, ca_3, typeof(XmlAttribute));
                a_7[ca_3++] = attr;
            }
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_7, ca_3, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_7, ca_3, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations66 = 0;
        int readerCount66 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[2] && (object)base.Reader.LocalName == id107_annotation && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Annotation = Read11_XmlSchemaAnnotation(false, true);
                    paramsRead[2] = true;
                }
                else if (!paramsRead[5] && (object)base.Reader.LocalName == id175_selector && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Selector = Read47_XmlSchemaXPath(false, true);
                    paramsRead[5] = true;
                }
                else if ((object)base.Reader.LocalName == id176_field && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_6 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_6.Add(Read47_XmlSchemaXPath(false, true));
                    }
                }
                else
                {
                    UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:selector, http://www.w3.org/2001/XMLSchema:field");
                }
            }
            else
            {
                UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:selector, http://www.w3.org/2001/XMLSchema:field");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations66, ref readerCount66);
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_7, ca_3, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private XmlSchemaXPath Read47_XmlSchemaXPath(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id177_XmlSchemaXPath || (object)xsiType.Namespace != id95_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        base.DecodeName = false;
        XmlSchemaXPath o = new XmlSchemaXPath();
        XmlAttribute[] a_3 = null;
        int ca_3 = 0;
        bool[] paramsRead = new bool[5];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[1] && (object)base.Reader.LocalName == id102_id && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Id = CollapseWhitespace(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id178_xpath && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.XPath = base.Reader.Value;
                paramsRead[4] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_3 = (XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(XmlAttribute));
                a_3[ca_3++] = attr;
            }
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations67 = 0;
        int readerCount67 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[2] && (object)base.Reader.LocalName == id107_annotation && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Annotation = Read11_XmlSchemaAnnotation(false, true);
                    paramsRead[2] = true;
                }
                else
                {
                    UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation");
                }
            }
            else
            {
                UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations67, ref readerCount67);
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private XmlSchemaUnique Read50_XmlSchemaUnique(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id179_XmlSchemaUnique || (object)xsiType.Namespace != id95_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        base.DecodeName = false;
        XmlSchemaUnique o = new XmlSchemaUnique();
        XmlAttribute[] a_7 = null;
        int ca_3 = 0;
        XmlSchemaObjectCollection a_6 = o.Fields;
        bool[] paramsRead = new bool[7];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[1] && (object)base.Reader.LocalName == id102_id && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Id = CollapseWhitespace(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id4_name && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Name = base.Reader.Value;
                paramsRead[4] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_7 = (XmlAttribute[])EnsureArrayIndex(a_7, ca_3, typeof(XmlAttribute));
                a_7[ca_3++] = attr;
            }
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_7, ca_3, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_7, ca_3, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations68 = 0;
        int readerCount68 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[2] && (object)base.Reader.LocalName == id107_annotation && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Annotation = Read11_XmlSchemaAnnotation(false, true);
                    paramsRead[2] = true;
                }
                else if (!paramsRead[5] && (object)base.Reader.LocalName == id175_selector && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Selector = Read47_XmlSchemaXPath(false, true);
                    paramsRead[5] = true;
                }
                else if ((object)base.Reader.LocalName == id176_field && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_6 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_6.Add(Read47_XmlSchemaXPath(false, true));
                    }
                }
                else
                {
                    UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:selector, http://www.w3.org/2001/XMLSchema:field");
                }
            }
            else
            {
                UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:selector, http://www.w3.org/2001/XMLSchema:field");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations68, ref readerCount68);
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_7, ca_3, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private XmlSchemaKey Read49_XmlSchemaKey(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id180_XmlSchemaKey || (object)xsiType.Namespace != id95_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        base.DecodeName = false;
        XmlSchemaKey o = new XmlSchemaKey();
        XmlAttribute[] a_7 = null;
        int ca_3 = 0;
        XmlSchemaObjectCollection a_6 = o.Fields;
        bool[] paramsRead = new bool[7];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[1] && (object)base.Reader.LocalName == id102_id && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Id = CollapseWhitespace(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id4_name && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Name = base.Reader.Value;
                paramsRead[4] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_7 = (XmlAttribute[])EnsureArrayIndex(a_7, ca_3, typeof(XmlAttribute));
                a_7[ca_3++] = attr;
            }
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_7, ca_3, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_7, ca_3, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations69 = 0;
        int readerCount69 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[2] && (object)base.Reader.LocalName == id107_annotation && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Annotation = Read11_XmlSchemaAnnotation(false, true);
                    paramsRead[2] = true;
                }
                else if (!paramsRead[5] && (object)base.Reader.LocalName == id175_selector && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Selector = Read47_XmlSchemaXPath(false, true);
                    paramsRead[5] = true;
                }
                else if ((object)base.Reader.LocalName == id176_field && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_6 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_6.Add(Read47_XmlSchemaXPath(false, true));
                    }
                }
                else
                {
                    UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:selector, http://www.w3.org/2001/XMLSchema:field");
                }
            }
            else
            {
                UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:selector, http://www.w3.org/2001/XMLSchema:field");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations69, ref readerCount69);
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_7, ca_3, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private XmlSchemaComplexType Read62_XmlSchemaComplexType(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id181_XmlSchemaComplexType || (object)xsiType.Namespace != id95_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        base.DecodeName = false;
        XmlSchemaComplexType o = new XmlSchemaComplexType();
        XmlAttribute[] a_12 = null;
        int ca_3 = 0;
        XmlSchemaObjectCollection a_11 = o.Attributes;
        bool[] paramsRead = new bool[13];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[1] && (object)base.Reader.LocalName == id102_id && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Id = CollapseWhitespace(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id4_name && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Name = base.Reader.Value;
                paramsRead[4] = true;
            }
            else if (!paramsRead[5] && (object)base.Reader.LocalName == id129_final && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Final = Read7_XmlSchemaDerivationMethod(base.Reader.Value);
                paramsRead[5] = true;
            }
            else if (!paramsRead[6] && (object)base.Reader.LocalName == id166_abstract && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.IsAbstract = XmlConvert.ToBoolean(base.Reader.Value);
                paramsRead[6] = true;
            }
            else if (!paramsRead[7] && (object)base.Reader.LocalName == id167_block && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Block = Read7_XmlSchemaDerivationMethod(base.Reader.Value);
                paramsRead[7] = true;
            }
            else if (!paramsRead[8] && (object)base.Reader.LocalName == id182_mixed && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.IsMixed = XmlConvert.ToBoolean(base.Reader.Value);
                paramsRead[8] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_12 = (XmlAttribute[])EnsureArrayIndex(a_12, ca_3, typeof(XmlAttribute));
                a_12[ca_3++] = attr;
            }
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_12, ca_3, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_12, ca_3, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations70 = 0;
        int readerCount70 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[2] && (object)base.Reader.LocalName == id107_annotation && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Annotation = Read11_XmlSchemaAnnotation(false, true);
                    paramsRead[2] = true;
                }
                else if (!paramsRead[9] && (object)base.Reader.LocalName == id183_complexContent && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.ContentModel = Read58_XmlSchemaComplexContent(false, true);
                    paramsRead[9] = true;
                }
                else if (!paramsRead[9] && (object)base.Reader.LocalName == id184_simpleContent && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.ContentModel = Read61_XmlSchemaSimpleContent(false, true);
                    paramsRead[9] = true;
                }
                else if (!paramsRead[10] && (object)base.Reader.LocalName == id59_group && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Particle = Read44_XmlSchemaGroupRef(false, true);
                    paramsRead[10] = true;
                }
                else if (!paramsRead[10] && (object)base.Reader.LocalName == id185_sequence && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Particle = Read53_XmlSchemaSequence(false, true);
                    paramsRead[10] = true;
                }
                else if (!paramsRead[10] && (object)base.Reader.LocalName == id186_choice && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Particle = Read54_XmlSchemaChoice(false, true);
                    paramsRead[10] = true;
                }
                else if (!paramsRead[10] && (object)base.Reader.LocalName == id187_all && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Particle = Read55_XmlSchemaAll(false, true);
                    paramsRead[10] = true;
                }
                else if ((object)base.Reader.LocalName == id109_attribute && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_11 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_11.Add(Read36_XmlSchemaAttribute(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id110_attributeGroup && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_11 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_11.Add(Read37_XmlSchemaAttributeGroupRef(false, true));
                    }
                }
                else if (!paramsRead[12] && (object)base.Reader.LocalName == id112_anyAttribute && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.AnyAttribute = Read39_XmlSchemaAnyAttribute(false, true);
                    paramsRead[12] = true;
                }
                else
                {
                    UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:complexContent, http://www.w3.org/2001/XMLSchema:simpleContent, http://www.w3.org/2001/XMLSchema:group, http://www.w3.org/2001/XMLSchema:sequence, http://www.w3.org/2001/XMLSchema:choice, http://www.w3.org/2001/XMLSchema:all, http://www.w3.org/2001/XMLSchema:attribute, http://www.w3.org/2001/XMLSchema:attributeGroup, http://www.w3.org/2001/XMLSchema:anyAttribute");
                }
            }
            else
            {
                UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:complexContent, http://www.w3.org/2001/XMLSchema:simpleContent, http://www.w3.org/2001/XMLSchema:group, http://www.w3.org/2001/XMLSchema:sequence, http://www.w3.org/2001/XMLSchema:choice, http://www.w3.org/2001/XMLSchema:all, http://www.w3.org/2001/XMLSchema:attribute, http://www.w3.org/2001/XMLSchema:attributeGroup, http://www.w3.org/2001/XMLSchema:anyAttribute");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations70, ref readerCount70);
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_12, ca_3, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private XmlSchemaAll Read55_XmlSchemaAll(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id188_XmlSchemaAll || (object)xsiType.Namespace != id95_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        base.DecodeName = false;
        XmlSchemaAll o = new XmlSchemaAll();
        XmlAttribute[] a_7 = null;
        int ca_3 = 0;
        XmlSchemaObjectCollection a_6 = o.Items;
        bool[] paramsRead = new bool[7];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[1] && (object)base.Reader.LocalName == id102_id && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Id = CollapseWhitespace(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id164_minOccurs && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.MinOccursString = base.Reader.Value;
                paramsRead[4] = true;
            }
            else if (!paramsRead[5] && (object)base.Reader.LocalName == id165_maxOccurs && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.MaxOccursString = base.Reader.Value;
                paramsRead[5] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_7 = (XmlAttribute[])EnsureArrayIndex(a_7, ca_3, typeof(XmlAttribute));
                a_7[ca_3++] = attr;
            }
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_7, ca_3, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_7, ca_3, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations71 = 0;
        int readerCount71 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[2] && (object)base.Reader.LocalName == id107_annotation && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Annotation = Read11_XmlSchemaAnnotation(false, true);
                    paramsRead[2] = true;
                }
                else if ((object)base.Reader.LocalName == id92_element && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_6 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_6.Add(Read52_XmlSchemaElement(false, true));
                    }
                }
                else
                {
                    UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:element");
                }
            }
            else
            {
                UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:element");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations71, ref readerCount71);
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_7, ca_3, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private XmlSchemaChoice Read54_XmlSchemaChoice(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id189_XmlSchemaChoice || (object)xsiType.Namespace != id95_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        base.DecodeName = false;
        XmlSchemaChoice o = new XmlSchemaChoice();
        XmlAttribute[] a_7 = null;
        int ca_3 = 0;
        XmlSchemaObjectCollection a_6 = o.Items;
        bool[] paramsRead = new bool[7];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[1] && (object)base.Reader.LocalName == id102_id && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Id = CollapseWhitespace(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id164_minOccurs && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.MinOccursString = base.Reader.Value;
                paramsRead[4] = true;
            }
            else if (!paramsRead[5] && (object)base.Reader.LocalName == id165_maxOccurs && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.MaxOccursString = base.Reader.Value;
                paramsRead[5] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_7 = (XmlAttribute[])EnsureArrayIndex(a_7, ca_3, typeof(XmlAttribute));
                a_7[ca_3++] = attr;
            }
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_7, ca_3, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_7, ca_3, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations72 = 0;
        int readerCount72 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[2] && (object)base.Reader.LocalName == id107_annotation && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Annotation = Read11_XmlSchemaAnnotation(false, true);
                    paramsRead[2] = true;
                }
                else if ((object)base.Reader.LocalName == id190_any && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_6 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_6.Add(Read46_XmlSchemaAny(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id186_choice && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_6 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_6.Add(Read54_XmlSchemaChoice(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id185_sequence && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_6 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_6.Add(Read53_XmlSchemaSequence(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id92_element && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_6 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_6.Add(Read52_XmlSchemaElement(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id59_group && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_6 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_6.Add(Read44_XmlSchemaGroupRef(false, true));
                    }
                }
                else
                {
                    UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:any, http://www.w3.org/2001/XMLSchema:choice, http://www.w3.org/2001/XMLSchema:sequence, http://www.w3.org/2001/XMLSchema:element, http://www.w3.org/2001/XMLSchema:group");
                }
            }
            else
            {
                UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:any, http://www.w3.org/2001/XMLSchema:choice, http://www.w3.org/2001/XMLSchema:sequence, http://www.w3.org/2001/XMLSchema:element, http://www.w3.org/2001/XMLSchema:group");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations72, ref readerCount72);
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_7, ca_3, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private XmlSchemaGroupRef Read44_XmlSchemaGroupRef(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id191_XmlSchemaGroupRef || (object)xsiType.Namespace != id95_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        base.DecodeName = false;
        XmlSchemaGroupRef o = new XmlSchemaGroupRef();
        XmlAttribute[] a_3 = null;
        int ca_3 = 0;
        bool[] paramsRead = new bool[7];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[1] && (object)base.Reader.LocalName == id102_id && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Id = CollapseWhitespace(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id164_minOccurs && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.MinOccursString = base.Reader.Value;
                paramsRead[4] = true;
            }
            else if (!paramsRead[5] && (object)base.Reader.LocalName == id165_maxOccurs && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.MaxOccursString = base.Reader.Value;
                paramsRead[5] = true;
            }
            else if (!paramsRead[6] && (object)base.Reader.LocalName == id123_ref && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.RefName = ToXmlQualifiedName(base.Reader.Value);
                paramsRead[6] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_3 = (XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(XmlAttribute));
                a_3[ca_3++] = attr;
            }
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations73 = 0;
        int readerCount73 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[2] && (object)base.Reader.LocalName == id107_annotation && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Annotation = Read11_XmlSchemaAnnotation(false, true);
                    paramsRead[2] = true;
                }
                else
                {
                    UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation");
                }
            }
            else
            {
                UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations73, ref readerCount73);
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private XmlSchemaSequence Read53_XmlSchemaSequence(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id192_XmlSchemaSequence || (object)xsiType.Namespace != id95_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        base.DecodeName = false;
        XmlSchemaSequence o = new XmlSchemaSequence();
        XmlAttribute[] a_7 = null;
        int ca_3 = 0;
        XmlSchemaObjectCollection a_6 = o.Items;
        bool[] paramsRead = new bool[7];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[1] && (object)base.Reader.LocalName == id102_id && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Id = CollapseWhitespace(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id164_minOccurs && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.MinOccursString = base.Reader.Value;
                paramsRead[4] = true;
            }
            else if (!paramsRead[5] && (object)base.Reader.LocalName == id165_maxOccurs && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.MaxOccursString = base.Reader.Value;
                paramsRead[5] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_7 = (XmlAttribute[])EnsureArrayIndex(a_7, ca_3, typeof(XmlAttribute));
                a_7[ca_3++] = attr;
            }
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_7, ca_3, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_7, ca_3, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations74 = 0;
        int readerCount74 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[2] && (object)base.Reader.LocalName == id107_annotation && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Annotation = Read11_XmlSchemaAnnotation(false, true);
                    paramsRead[2] = true;
                }
                else if ((object)base.Reader.LocalName == id92_element && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_6 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_6.Add(Read52_XmlSchemaElement(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id185_sequence && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_6 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_6.Add(Read53_XmlSchemaSequence(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id190_any && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_6 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_6.Add(Read46_XmlSchemaAny(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id186_choice && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_6 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_6.Add(Read54_XmlSchemaChoice(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id59_group && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_6 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_6.Add(Read44_XmlSchemaGroupRef(false, true));
                    }
                }
                else
                {
                    UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:element, http://www.w3.org/2001/XMLSchema:sequence, http://www.w3.org/2001/XMLSchema:any, http://www.w3.org/2001/XMLSchema:choice, http://www.w3.org/2001/XMLSchema:group");
                }
            }
            else
            {
                UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:element, http://www.w3.org/2001/XMLSchema:sequence, http://www.w3.org/2001/XMLSchema:any, http://www.w3.org/2001/XMLSchema:choice, http://www.w3.org/2001/XMLSchema:group");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations74, ref readerCount74);
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_7, ca_3, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private XmlSchemaAny Read46_XmlSchemaAny(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id193_XmlSchemaAny || (object)xsiType.Namespace != id95_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        base.DecodeName = false;
        XmlSchemaAny o = new XmlSchemaAny();
        XmlAttribute[] a_3 = null;
        int ca_3 = 0;
        bool[] paramsRead = new bool[8];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[1] && (object)base.Reader.LocalName == id102_id && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Id = CollapseWhitespace(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id164_minOccurs && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.MinOccursString = base.Reader.Value;
                paramsRead[4] = true;
            }
            else if (!paramsRead[5] && (object)base.Reader.LocalName == id165_maxOccurs && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.MaxOccursString = base.Reader.Value;
                paramsRead[5] = true;
            }
            else if (!paramsRead[6] && (object)base.Reader.LocalName == id36_namespace && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Namespace = base.Reader.Value;
                paramsRead[6] = true;
            }
            else if (!paramsRead[7] && (object)base.Reader.LocalName == id114_processContents && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.ProcessContents = Read38_XmlSchemaContentProcessing(base.Reader.Value);
                paramsRead[7] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_3 = (XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(XmlAttribute));
                a_3[ca_3++] = attr;
            }
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations75 = 0;
        int readerCount75 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[2] && (object)base.Reader.LocalName == id107_annotation && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Annotation = Read11_XmlSchemaAnnotation(false, true);
                    paramsRead[2] = true;
                }
                else
                {
                    UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation");
                }
            }
            else
            {
                UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations75, ref readerCount75);
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private XmlSchemaSimpleContent Read61_XmlSchemaSimpleContent(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id194_XmlSchemaSimpleContent || (object)xsiType.Namespace != id95_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        base.DecodeName = false;
        XmlSchemaSimpleContent o = new XmlSchemaSimpleContent();
        XmlAttribute[] a_3 = null;
        int ca_3 = 0;
        bool[] paramsRead = new bool[5];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[1] && (object)base.Reader.LocalName == id102_id && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Id = CollapseWhitespace(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_3 = (XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(XmlAttribute));
                a_3[ca_3++] = attr;
            }
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations76 = 0;
        int readerCount76 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[2] && (object)base.Reader.LocalName == id107_annotation && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Annotation = Read11_XmlSchemaAnnotation(false, true);
                    paramsRead[2] = true;
                }
                else if (!paramsRead[4] && (object)base.Reader.LocalName == id131_restriction && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Content = Read59_Item(false, true);
                    paramsRead[4] = true;
                }
                else if (!paramsRead[4] && (object)base.Reader.LocalName == id195_extension && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Content = Read60_Item(false, true);
                    paramsRead[4] = true;
                }
                else
                {
                    UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:restriction, http://www.w3.org/2001/XMLSchema:extension");
                }
            }
            else
            {
                UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:restriction, http://www.w3.org/2001/XMLSchema:extension");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations76, ref readerCount76);
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private XmlSchemaSimpleContentExtension Read60_Item(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id196_Item || (object)xsiType.Namespace != id95_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        base.DecodeName = false;
        XmlSchemaSimpleContentExtension o = new XmlSchemaSimpleContentExtension();
        XmlAttribute[] a_6 = null;
        int ca_3 = 0;
        XmlSchemaObjectCollection a_5 = o.Attributes;
        bool[] paramsRead = new bool[7];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[1] && (object)base.Reader.LocalName == id102_id && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Id = CollapseWhitespace(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id136_base && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.BaseTypeName = ToXmlQualifiedName(base.Reader.Value);
                paramsRead[4] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_6 = (XmlAttribute[])EnsureArrayIndex(a_6, ca_3, typeof(XmlAttribute));
                a_6[ca_3++] = attr;
            }
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_6, ca_3, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_6, ca_3, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations77 = 0;
        int readerCount77 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[2] && (object)base.Reader.LocalName == id107_annotation && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Annotation = Read11_XmlSchemaAnnotation(false, true);
                    paramsRead[2] = true;
                }
                else if ((object)base.Reader.LocalName == id110_attributeGroup && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_5 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_5.Add(Read37_XmlSchemaAttributeGroupRef(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id109_attribute && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_5 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_5.Add(Read36_XmlSchemaAttribute(false, true));
                    }
                }
                else if (!paramsRead[6] && (object)base.Reader.LocalName == id112_anyAttribute && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.AnyAttribute = Read39_XmlSchemaAnyAttribute(false, true);
                    paramsRead[6] = true;
                }
                else
                {
                    UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:attributeGroup, http://www.w3.org/2001/XMLSchema:attribute, http://www.w3.org/2001/XMLSchema:anyAttribute");
                }
            }
            else
            {
                UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:attributeGroup, http://www.w3.org/2001/XMLSchema:attribute, http://www.w3.org/2001/XMLSchema:anyAttribute");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations77, ref readerCount77);
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_6, ca_3, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private XmlSchemaSimpleContentRestriction Read59_Item(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id197_Item || (object)xsiType.Namespace != id95_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        base.DecodeName = false;
        XmlSchemaSimpleContentRestriction o = new XmlSchemaSimpleContentRestriction();
        XmlAttribute[] a_9 = null;
        int ca_3 = 0;
        XmlSchemaObjectCollection a_8 = o.Facets;
        XmlSchemaObjectCollection a_7 = o.Attributes;
        bool[] paramsRead = new bool[9];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[1] && (object)base.Reader.LocalName == id102_id && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Id = CollapseWhitespace(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id136_base && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.BaseTypeName = ToXmlQualifiedName(base.Reader.Value);
                paramsRead[4] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_9 = (XmlAttribute[])EnsureArrayIndex(a_9, ca_3, typeof(XmlAttribute));
                a_9[ca_3++] = attr;
            }
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_9, ca_3, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_9, ca_3, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations78 = 0;
        int readerCount78 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[2] && (object)base.Reader.LocalName == id107_annotation && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Annotation = Read11_XmlSchemaAnnotation(false, true);
                    paramsRead[2] = true;
                }
                else if (!paramsRead[5] && (object)base.Reader.LocalName == id105_simpleType && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.BaseType = Read34_XmlSchemaSimpleType(false, true);
                    paramsRead[5] = true;
                }
                else if ((object)base.Reader.LocalName == id138_minInclusive && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_8 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_8.Add(Read21_XmlSchemaMinInclusiveFacet(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id144_maxExclusive && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_8 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_8.Add(Read28_XmlSchemaMaxExclusiveFacet(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id145_whiteSpace && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_8 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_8.Add(Read29_XmlSchemaWhiteSpaceFacet(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id147_minLength && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_8 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_8.Add(Read31_XmlSchemaMinLengthFacet(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id62_pattern && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_8 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_8.Add(Read25_XmlSchemaPatternFacet(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id142_enumeration && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_8 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_8.Add(Read26_XmlSchemaEnumerationFacet(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id143_maxInclusive && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_8 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_8.Add(Read27_XmlSchemaMaxInclusiveFacet(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id140_length && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_8 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_8.Add(Read23_XmlSchemaLengthFacet(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id139_maxLength && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_8 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_8.Add(Read22_XmlSchemaMaxLengthFacet(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id146_minExclusive && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_8 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_8.Add(Read30_XmlSchemaMinExclusiveFacet(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id141_totalDigits && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_8 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_8.Add(Read24_XmlSchemaTotalDigitsFacet(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id137_fractionDigits && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_8 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_8.Add(Read20_XmlSchemaFractionDigitsFacet(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id110_attributeGroup && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_7 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_7.Add(Read37_XmlSchemaAttributeGroupRef(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id109_attribute && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_7 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_7.Add(Read36_XmlSchemaAttribute(false, true));
                    }
                }
                else if (!paramsRead[8] && (object)base.Reader.LocalName == id112_anyAttribute && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.AnyAttribute = Read39_XmlSchemaAnyAttribute(false, true);
                    paramsRead[8] = true;
                }
                else
                {
                    UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:simpleType, http://www.w3.org/2001/XMLSchema:minInclusive, http://www.w3.org/2001/XMLSchema:maxExclusive, http://www.w3.org/2001/XMLSchema:whiteSpace, http://www.w3.org/2001/XMLSchema:minLength, http://www.w3.org/2001/XMLSchema:pattern, http://www.w3.org/2001/XMLSchema:enumeration, http://www.w3.org/2001/XMLSchema:maxInclusive, http://www.w3.org/2001/XMLSchema:length, http://www.w3.org/2001/XMLSchema:maxLength, http://www.w3.org/2001/XMLSchema:minExclusive, http://www.w3.org/2001/XMLSchema:totalDigits, http://www.w3.org/2001/XMLSchema:fractionDigits, http://www.w3.org/2001/XMLSchema:attributeGroup, http://www.w3.org/2001/XMLSchema:attribute, http://www.w3.org/2001/XMLSchema:anyAttribute");
                }
            }
            else
            {
                UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:simpleType, http://www.w3.org/2001/XMLSchema:minInclusive, http://www.w3.org/2001/XMLSchema:maxExclusive, http://www.w3.org/2001/XMLSchema:whiteSpace, http://www.w3.org/2001/XMLSchema:minLength, http://www.w3.org/2001/XMLSchema:pattern, http://www.w3.org/2001/XMLSchema:enumeration, http://www.w3.org/2001/XMLSchema:maxInclusive, http://www.w3.org/2001/XMLSchema:length, http://www.w3.org/2001/XMLSchema:maxLength, http://www.w3.org/2001/XMLSchema:minExclusive, http://www.w3.org/2001/XMLSchema:totalDigits, http://www.w3.org/2001/XMLSchema:fractionDigits, http://www.w3.org/2001/XMLSchema:attributeGroup, http://www.w3.org/2001/XMLSchema:attribute, http://www.w3.org/2001/XMLSchema:anyAttribute");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations78, ref readerCount78);
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_9, ca_3, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private XmlSchemaComplexContent Read58_XmlSchemaComplexContent(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id198_XmlSchemaComplexContent || (object)xsiType.Namespace != id95_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        base.DecodeName = false;
        XmlSchemaComplexContent o = new XmlSchemaComplexContent();
        XmlAttribute[] a_3 = null;
        int ca_3 = 0;
        bool[] paramsRead = new bool[6];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[1] && (object)base.Reader.LocalName == id102_id && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Id = CollapseWhitespace(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id182_mixed && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.IsMixed = XmlConvert.ToBoolean(base.Reader.Value);
                paramsRead[4] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_3 = (XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(XmlAttribute));
                a_3[ca_3++] = attr;
            }
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations79 = 0;
        int readerCount79 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[2] && (object)base.Reader.LocalName == id107_annotation && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Annotation = Read11_XmlSchemaAnnotation(false, true);
                    paramsRead[2] = true;
                }
                else if (!paramsRead[5] && (object)base.Reader.LocalName == id195_extension && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Content = Read56_Item(false, true);
                    paramsRead[5] = true;
                }
                else if (!paramsRead[5] && (object)base.Reader.LocalName == id131_restriction && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Content = Read57_Item(false, true);
                    paramsRead[5] = true;
                }
                else
                {
                    UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:extension, http://www.w3.org/2001/XMLSchema:restriction");
                }
            }
            else
            {
                UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:extension, http://www.w3.org/2001/XMLSchema:restriction");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations79, ref readerCount79);
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private XmlSchemaComplexContentRestriction Read57_Item(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id199_Item || (object)xsiType.Namespace != id95_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        base.DecodeName = false;
        XmlSchemaComplexContentRestriction o = new XmlSchemaComplexContentRestriction();
        XmlAttribute[] a_7 = null;
        int ca_3 = 0;
        XmlSchemaObjectCollection a_6 = o.Attributes;
        bool[] paramsRead = new bool[8];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[1] && (object)base.Reader.LocalName == id102_id && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Id = CollapseWhitespace(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id136_base && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.BaseTypeName = ToXmlQualifiedName(base.Reader.Value);
                paramsRead[4] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_7 = (XmlAttribute[])EnsureArrayIndex(a_7, ca_3, typeof(XmlAttribute));
                a_7[ca_3++] = attr;
            }
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_7, ca_3, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_7, ca_3, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations80 = 0;
        int readerCount80 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[2] && (object)base.Reader.LocalName == id107_annotation && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Annotation = Read11_XmlSchemaAnnotation(false, true);
                    paramsRead[2] = true;
                }
                else if (!paramsRead[5] && (object)base.Reader.LocalName == id186_choice && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Particle = Read54_XmlSchemaChoice(false, true);
                    paramsRead[5] = true;
                }
                else if (!paramsRead[5] && (object)base.Reader.LocalName == id59_group && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Particle = Read44_XmlSchemaGroupRef(false, true);
                    paramsRead[5] = true;
                }
                else if (!paramsRead[5] && (object)base.Reader.LocalName == id187_all && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Particle = Read55_XmlSchemaAll(false, true);
                    paramsRead[5] = true;
                }
                else if (!paramsRead[5] && (object)base.Reader.LocalName == id185_sequence && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Particle = Read53_XmlSchemaSequence(false, true);
                    paramsRead[5] = true;
                }
                else if ((object)base.Reader.LocalName == id110_attributeGroup && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_6 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_6.Add(Read37_XmlSchemaAttributeGroupRef(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id109_attribute && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_6 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_6.Add(Read36_XmlSchemaAttribute(false, true));
                    }
                }
                else if (!paramsRead[7] && (object)base.Reader.LocalName == id112_anyAttribute && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.AnyAttribute = Read39_XmlSchemaAnyAttribute(false, true);
                    paramsRead[7] = true;
                }
                else
                {
                    UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:choice, http://www.w3.org/2001/XMLSchema:group, http://www.w3.org/2001/XMLSchema:all, http://www.w3.org/2001/XMLSchema:sequence, http://www.w3.org/2001/XMLSchema:attributeGroup, http://www.w3.org/2001/XMLSchema:attribute, http://www.w3.org/2001/XMLSchema:anyAttribute");
                }
            }
            else
            {
                UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:choice, http://www.w3.org/2001/XMLSchema:group, http://www.w3.org/2001/XMLSchema:all, http://www.w3.org/2001/XMLSchema:sequence, http://www.w3.org/2001/XMLSchema:attributeGroup, http://www.w3.org/2001/XMLSchema:attribute, http://www.w3.org/2001/XMLSchema:anyAttribute");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations80, ref readerCount80);
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_7, ca_3, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private XmlSchemaComplexContentExtension Read56_Item(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id200_Item || (object)xsiType.Namespace != id95_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        base.DecodeName = false;
        XmlSchemaComplexContentExtension o = new XmlSchemaComplexContentExtension();
        XmlAttribute[] a_7 = null;
        int ca_3 = 0;
        XmlSchemaObjectCollection a_6 = o.Attributes;
        bool[] paramsRead = new bool[8];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[1] && (object)base.Reader.LocalName == id102_id && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Id = CollapseWhitespace(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id136_base && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.BaseTypeName = ToXmlQualifiedName(base.Reader.Value);
                paramsRead[4] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_7 = (XmlAttribute[])EnsureArrayIndex(a_7, ca_3, typeof(XmlAttribute));
                a_7[ca_3++] = attr;
            }
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_7, ca_3, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_7, ca_3, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations81 = 0;
        int readerCount81 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[2] && (object)base.Reader.LocalName == id107_annotation && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Annotation = Read11_XmlSchemaAnnotation(false, true);
                    paramsRead[2] = true;
                }
                else if (!paramsRead[5] && (object)base.Reader.LocalName == id59_group && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Particle = Read44_XmlSchemaGroupRef(false, true);
                    paramsRead[5] = true;
                }
                else if (!paramsRead[5] && (object)base.Reader.LocalName == id186_choice && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Particle = Read54_XmlSchemaChoice(false, true);
                    paramsRead[5] = true;
                }
                else if (!paramsRead[5] && (object)base.Reader.LocalName == id187_all && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Particle = Read55_XmlSchemaAll(false, true);
                    paramsRead[5] = true;
                }
                else if (!paramsRead[5] && (object)base.Reader.LocalName == id185_sequence && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Particle = Read53_XmlSchemaSequence(false, true);
                    paramsRead[5] = true;
                }
                else if ((object)base.Reader.LocalName == id110_attributeGroup && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_6 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_6.Add(Read37_XmlSchemaAttributeGroupRef(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id109_attribute && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_6 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_6.Add(Read36_XmlSchemaAttribute(false, true));
                    }
                }
                else if (!paramsRead[7] && (object)base.Reader.LocalName == id112_anyAttribute && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.AnyAttribute = Read39_XmlSchemaAnyAttribute(false, true);
                    paramsRead[7] = true;
                }
                else
                {
                    UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:group, http://www.w3.org/2001/XMLSchema:choice, http://www.w3.org/2001/XMLSchema:all, http://www.w3.org/2001/XMLSchema:sequence, http://www.w3.org/2001/XMLSchema:attributeGroup, http://www.w3.org/2001/XMLSchema:attribute, http://www.w3.org/2001/XMLSchema:anyAttribute");
                }
            }
            else
            {
                UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:group, http://www.w3.org/2001/XMLSchema:choice, http://www.w3.org/2001/XMLSchema:all, http://www.w3.org/2001/XMLSchema:sequence, http://www.w3.org/2001/XMLSchema:attributeGroup, http://www.w3.org/2001/XMLSchema:attribute, http://www.w3.org/2001/XMLSchema:anyAttribute");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations81, ref readerCount81);
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_7, ca_3, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private XmlSchemaGroup Read63_XmlSchemaGroup(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id201_XmlSchemaGroup || (object)xsiType.Namespace != id95_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        base.DecodeName = false;
        XmlSchemaGroup o = new XmlSchemaGroup();
        XmlAttribute[] a_3 = null;
        int ca_3 = 0;
        bool[] paramsRead = new bool[6];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[1] && (object)base.Reader.LocalName == id102_id && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Id = CollapseWhitespace(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id4_name && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Name = base.Reader.Value;
                paramsRead[4] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_3 = (XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(XmlAttribute));
                a_3[ca_3++] = attr;
            }
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations82 = 0;
        int readerCount82 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[2] && (object)base.Reader.LocalName == id107_annotation && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Annotation = Read11_XmlSchemaAnnotation(false, true);
                    paramsRead[2] = true;
                }
                else if (!paramsRead[5] && (object)base.Reader.LocalName == id185_sequence && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Particle = Read53_XmlSchemaSequence(false, true);
                    paramsRead[5] = true;
                }
                else if (!paramsRead[5] && (object)base.Reader.LocalName == id186_choice && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Particle = Read54_XmlSchemaChoice(false, true);
                    paramsRead[5] = true;
                }
                else if (!paramsRead[5] && (object)base.Reader.LocalName == id187_all && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Particle = Read55_XmlSchemaAll(false, true);
                    paramsRead[5] = true;
                }
                else
                {
                    UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:sequence, http://www.w3.org/2001/XMLSchema:choice, http://www.w3.org/2001/XMLSchema:all");
                }
            }
            else
            {
                UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:sequence, http://www.w3.org/2001/XMLSchema:choice, http://www.w3.org/2001/XMLSchema:all");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations82, ref readerCount82);
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private XmlSchemaNotation Read65_XmlSchemaNotation(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id202_XmlSchemaNotation || (object)xsiType.Namespace != id95_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        base.DecodeName = false;
        XmlSchemaNotation o = new XmlSchemaNotation();
        XmlAttribute[] a_3 = null;
        int ca_3 = 0;
        bool[] paramsRead = new bool[7];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[1] && (object)base.Reader.LocalName == id102_id && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Id = CollapseWhitespace(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id4_name && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Name = base.Reader.Value;
                paramsRead[4] = true;
            }
            else if (!paramsRead[5] && (object)base.Reader.LocalName == id203_public && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Public = base.Reader.Value;
                paramsRead[5] = true;
            }
            else if (!paramsRead[6] && (object)base.Reader.LocalName == id204_system && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.System = base.Reader.Value;
                paramsRead[6] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_3 = (XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(XmlAttribute));
                a_3[ca_3++] = attr;
            }
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations83 = 0;
        int readerCount83 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[2] && (object)base.Reader.LocalName == id107_annotation && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Annotation = Read11_XmlSchemaAnnotation(false, true);
                    paramsRead[2] = true;
                }
                else
                {
                    UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation");
                }
            }
            else
            {
                UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations83, ref readerCount83);
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private XmlSchemaRedefine Read64_XmlSchemaRedefine(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id205_XmlSchemaRedefine || (object)xsiType.Namespace != id95_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        base.DecodeName = false;
        XmlSchemaRedefine o = new XmlSchemaRedefine();
        XmlAttribute[] a_5 = null;
        int ca_3 = 0;
        XmlSchemaObjectCollection a_4 = o.Items;
        bool[] paramsRead = new bool[5];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[1] && (object)base.Reader.LocalName == id206_schemaLocation && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.SchemaLocation = CollapseWhitespace(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[2] && (object)base.Reader.LocalName == id102_id && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Id = CollapseWhitespace(base.Reader.Value);
                paramsRead[2] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_5 = (XmlAttribute[])EnsureArrayIndex(a_5, ca_3, typeof(XmlAttribute));
                a_5[ca_3++] = attr;
            }
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_5, ca_3, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_5, ca_3, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations84 = 0;
        int readerCount84 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if ((object)base.Reader.LocalName == id110_attributeGroup && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_4 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_4.Add(Read40_XmlSchemaAttributeGroup(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id106_complexType && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_4 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_4.Add(Read62_XmlSchemaComplexType(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id105_simpleType && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_4 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_4.Add(Read34_XmlSchemaSimpleType(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id107_annotation && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_4 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_4.Add(Read11_XmlSchemaAnnotation(false, true));
                    }
                }
                else if ((object)base.Reader.LocalName == id59_group && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    if (a_4 == null)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        a_4.Add(Read63_XmlSchemaGroup(false, true));
                    }
                }
                else
                {
                    UnknownNode(o, "http://www.w3.org/2001/XMLSchema:attributeGroup, http://www.w3.org/2001/XMLSchema:complexType, http://www.w3.org/2001/XMLSchema:simpleType, http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:group");
                }
            }
            else
            {
                UnknownNode(o, "http://www.w3.org/2001/XMLSchema:attributeGroup, http://www.w3.org/2001/XMLSchema:complexType, http://www.w3.org/2001/XMLSchema:simpleType, http://www.w3.org/2001/XMLSchema:annotation, http://www.w3.org/2001/XMLSchema:group");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations84, ref readerCount84);
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_5, ca_3, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private XmlSchemaImport Read13_XmlSchemaImport(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id207_XmlSchemaImport || (object)xsiType.Namespace != id95_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        base.DecodeName = false;
        XmlSchemaImport o = new XmlSchemaImport();
        XmlAttribute[] a_3 = null;
        int ca_3 = 0;
        bool[] paramsRead = new bool[6];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[1] && (object)base.Reader.LocalName == id206_schemaLocation && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.SchemaLocation = CollapseWhitespace(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[2] && (object)base.Reader.LocalName == id102_id && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Id = CollapseWhitespace(base.Reader.Value);
                paramsRead[2] = true;
            }
            else if (!paramsRead[4] && (object)base.Reader.LocalName == id36_namespace && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Namespace = CollapseWhitespace(base.Reader.Value);
                paramsRead[4] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_3 = (XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(XmlAttribute));
                a_3[ca_3++] = attr;
            }
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations85 = 0;
        int readerCount85 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[5] && (object)base.Reader.LocalName == id107_annotation && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Annotation = Read11_XmlSchemaAnnotation(false, true);
                    paramsRead[5] = true;
                }
                else
                {
                    UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation");
                }
            }
            else
            {
                UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations85, ref readerCount85);
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private XmlSchemaInclude Read12_XmlSchemaInclude(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id208_XmlSchemaInclude || (object)xsiType.Namespace != id95_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        base.DecodeName = false;
        XmlSchemaInclude o = new XmlSchemaInclude();
        XmlAttribute[] a_3 = null;
        int ca_3 = 0;
        bool[] paramsRead = new bool[5];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[1] && (object)base.Reader.LocalName == id206_schemaLocation && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.SchemaLocation = CollapseWhitespace(base.Reader.Value);
                paramsRead[1] = true;
            }
            else if (!paramsRead[2] && (object)base.Reader.LocalName == id102_id && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Id = CollapseWhitespace(base.Reader.Value);
                paramsRead[2] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_3 = (XmlAttribute[])EnsureArrayIndex(a_3, ca_3, typeof(XmlAttribute));
                a_3[ca_3++] = attr;
            }
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations86 = 0;
        int readerCount86 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[4] && (object)base.Reader.LocalName == id107_annotation && (object)base.Reader.NamespaceURI == id95_Item)
                {
                    o.Annotation = Read11_XmlSchemaAnnotation(false, true);
                    paramsRead[4] = true;
                }
                else
                {
                    UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation");
                }
            }
            else
            {
                UnknownNode(o, "http://www.w3.org/2001/XMLSchema:annotation");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations86, ref readerCount86);
        }
        o.UnhandledAttributes = (XmlAttribute[])ShrinkArray(a_3, ca_3, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    private Import Read4_Import(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id209_Import || (object)xsiType.Namespace != id2_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        Import o = new Import();
        XmlAttribute[] a_4 = null;
        int ca_ = 0;
        ServiceDescriptionFormatExtensionCollection a_3 = o.Extensions;
        bool[] paramsRead = new bool[6];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!paramsRead[4] && (object)base.Reader.LocalName == id36_namespace && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Namespace = base.Reader.Value;
                paramsRead[4] = true;
            }
            else if (!paramsRead[5] && (object)base.Reader.LocalName == id23_location && (object)base.Reader.NamespaceURI == id5_Item)
            {
                o.Location = base.Reader.Value;
                paramsRead[5] = true;
            }
            else if (IsXmlnsAttribute(base.Reader.Name))
            {
                if (o.Namespaces == null)
                {
                    o.Namespaces = new XmlSerializerNamespaces();
                }
                o.Namespaces.Add((base.Reader.Name.Length == 5) ? "" : base.Reader.LocalName, base.Reader.Value);
            }
            else
            {
                XmlAttribute attr = (XmlAttribute)base.Document.ReadNode(base.Reader);
                ParseWsdlArrayType(attr);
                a_4 = (XmlAttribute[])EnsureArrayIndex(a_4, ca_, typeof(XmlAttribute));
                a_4[ca_++] = attr;
            }
        }
        o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_4, ca_, typeof(XmlAttribute), true);
        base.Reader.MoveToElement();
        if (base.Reader.IsEmptyElement)
        {
            base.Reader.Skip();
            o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_4, ca_, typeof(XmlAttribute), true);
            return o;
        }
        base.Reader.ReadStartElement();
        base.Reader.MoveToContent();
        int whileIterations87 = 0;
        int readerCount87 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[0] && (object)base.Reader.LocalName == id7_documentation && (object)base.Reader.NamespaceURI == id2_Item)
                {
                    o.DocumentationElement = (XmlElement)ReadXmlNode(false);
                    paramsRead[0] = true;
                }
                else
                {
                    a_3.Add((XmlElement)ReadXmlNode(false));
                }
            }
            else
            {
                UnknownNode(o, "http://schemas.xmlsoap.org/wsdl/:documentation");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations87, ref readerCount87);
        }
        o.ExtensibleAttributes = (XmlAttribute[])ShrinkArray(a_4, ca_, typeof(XmlAttribute), true);
        ReadEndElement();
        return o;
    }

    protected override void InitCallbacks()
    {
    }

    protected override void InitIDs()
    {
        id133_XmlSchemaSimpleTypeUnion = base.Reader.NameTable.Add("XmlSchemaSimpleTypeUnion");
        id143_maxInclusive = base.Reader.NameTable.Add("maxInclusive");
        id46_body = base.Reader.NameTable.Add("body");
        id190_any = base.Reader.NameTable.Add("any");
        id88_OperationOutput = base.Reader.NameTable.Add("OperationOutput");
        id6_targetNamespace = base.Reader.NameTable.Add("targetNamespace");
        id158_XmlSchemaMaxLengthFacet = base.Reader.NameTable.Add("XmlSchemaMaxLengthFacet");
        id11_portType = base.Reader.NameTable.Add("portType");
        id182_mixed = base.Reader.NameTable.Add("mixed");
        id172_keyref = base.Reader.NameTable.Add("keyref");
        id187_all = base.Reader.NameTable.Add("all");
        id162_itemType = base.Reader.NameTable.Add("itemType");
        id68_InputBinding = base.Reader.NameTable.Add("InputBinding");
        id25_HttpAddressBinding = base.Reader.NameTable.Add("HttpAddressBinding");
        id82_HttpBinding = base.Reader.NameTable.Add("HttpBinding");
        id17_address = base.Reader.NameTable.Add("address");
        id3_ServiceDescription = base.Reader.NameTable.Add("ServiceDescription");
        id38_SoapFaultBinding = base.Reader.NameTable.Add("SoapFaultBinding");
        id123_ref = base.Reader.NameTable.Add("ref");
        id198_XmlSchemaComplexContent = base.Reader.NameTable.Add("XmlSchemaComplexContent");
        id53_parts = base.Reader.NameTable.Add("parts");
        id35_use = base.Reader.NameTable.Add("use");
        id157_XmlSchemaLengthFacet = base.Reader.NameTable.Add("XmlSchemaLengthFacet");
        id207_XmlSchemaImport = base.Reader.NameTable.Add("XmlSchemaImport");
        id44_text = base.Reader.NameTable.Add("text");
        id117_XmlSchemaAppInfo = base.Reader.NameTable.Add("XmlSchemaAppInfo");
        id203_public = base.Reader.NameTable.Add("public");
        id69_urlEncoded = base.Reader.NameTable.Add("urlEncoded");
        id7_documentation = base.Reader.NameTable.Add("documentation");
        id19_Item = base.Reader.NameTable.Add("http://schemas.xmlsoap.org/wsdl/soap/");
        id129_final = base.Reader.NameTable.Add("final");
        id163_XmlSchemaElement = base.Reader.NameTable.Add("XmlSchemaElement");
        id60_capture = base.Reader.NameTable.Add("capture");
        id37_encodingStyle = base.Reader.NameTable.Add("encodingStyle");
        id185_sequence = base.Reader.NameTable.Add("sequence");
        id166_abstract = base.Reader.NameTable.Add("abstract");
        id23_location = base.Reader.NameTable.Add("location");
        id111_XmlSchemaAttributeGroup = base.Reader.NameTable.Add("XmlSchemaAttributeGroup");
        id192_XmlSchemaSequence = base.Reader.NameTable.Add("XmlSchemaSequence");
        id33_FaultBinding = base.Reader.NameTable.Add("FaultBinding");
        id153_XmlSchemaMaxInclusiveFacet = base.Reader.NameTable.Add("XmlSchemaMaxInclusiveFacet");
        id201_XmlSchemaGroup = base.Reader.NameTable.Add("XmlSchemaGroup");
        id43_multipartRelated = base.Reader.NameTable.Add("multipartRelated");
        id168_nillable = base.Reader.NameTable.Add("nillable");
        id149_value = base.Reader.NameTable.Add("value");
        id64_MimeMultipartRelatedBinding = base.Reader.NameTable.Add("MimeMultipartRelatedBinding");
        id193_XmlSchemaAny = base.Reader.NameTable.Add("XmlSchemaAny");
        id191_XmlSchemaGroupRef = base.Reader.NameTable.Add("XmlSchemaGroupRef");
        id74_soapAction = base.Reader.NameTable.Add("soapAction");
        id63_ignoreCase = base.Reader.NameTable.Add("ignoreCase");
        id101_version = base.Reader.NameTable.Add("version");
        id47_header = base.Reader.NameTable.Add("header");
        id195_extension = base.Reader.NameTable.Add("extension");
        id48_Soap12HeaderBinding = base.Reader.NameTable.Add("Soap12HeaderBinding");
        id134_memberTypes = base.Reader.NameTable.Add("memberTypes");
        id121_Item = base.Reader.NameTable.Add("http://www.w3.org/XML/1998/namespace");
        id146_minExclusive = base.Reader.NameTable.Add("minExclusive");
        id84_PortType = base.Reader.NameTable.Add("PortType");
        id42_mimeXml = base.Reader.NameTable.Add("mimeXml");
        id138_minInclusive = base.Reader.NameTable.Add("minInclusive");
        id118_source = base.Reader.NameTable.Add("source");
        id73_Soap12OperationBinding = base.Reader.NameTable.Add("Soap12OperationBinding");
        id131_restriction = base.Reader.NameTable.Add("restriction");
        id152_XmlSchemaMaxExclusiveFacet = base.Reader.NameTable.Add("XmlSchemaMaxExclusiveFacet");
        id135_XmlSchemaSimpleTypeRestriction = base.Reader.NameTable.Add("XmlSchemaSimpleTypeRestriction");
        id188_XmlSchemaAll = base.Reader.NameTable.Add("XmlSchemaAll");
        id116_appinfo = base.Reader.NameTable.Add("appinfo");
        id86_parameterOrder = base.Reader.NameTable.Add("parameterOrder");
        id147_minLength = base.Reader.NameTable.Add("minLength");
        id78_HttpOperationBinding = base.Reader.NameTable.Add("HttpOperationBinding");
        id161_XmlSchemaSimpleTypeList = base.Reader.NameTable.Add("XmlSchemaSimpleTypeList");
        id205_XmlSchemaRedefine = base.Reader.NameTable.Add("XmlSchemaRedefine");
        id194_XmlSchemaSimpleContent = base.Reader.NameTable.Add("XmlSchemaSimpleContent");
        id91_MessagePart = base.Reader.NameTable.Add("MessagePart");
        id92_element = base.Reader.NameTable.Add("element");
        id114_processContents = base.Reader.NameTable.Add("processContents");
        id18_Item = base.Reader.NameTable.Add("http://schemas.xmlsoap.org/wsdl/http/");
        id50_headerfault = base.Reader.NameTable.Add("headerfault");
        id154_XmlSchemaEnumerationFacet = base.Reader.NameTable.Add("XmlSchemaEnumerationFacet");
        id96_XmlSchema = base.Reader.NameTable.Add("XmlSchema");
        id127_form = base.Reader.NameTable.Add("form");
        id176_field = base.Reader.NameTable.Add("field");
        id49_part = base.Reader.NameTable.Add("part");
        id5_Item = base.Reader.NameTable.Add("");
        id57_match = base.Reader.NameTable.Add("match");
        id52_Soap12BodyBinding = base.Reader.NameTable.Add("Soap12BodyBinding");
        id104_redefine = base.Reader.NameTable.Add("redefine");
        id20_Item = base.Reader.NameTable.Add("http://schemas.xmlsoap.org/wsdl/soap12/");
        id21_Soap12AddressBinding = base.Reader.NameTable.Add("Soap12AddressBinding");
        id142_enumeration = base.Reader.NameTable.Add("enumeration");
        id24_SoapAddressBinding = base.Reader.NameTable.Add("SoapAddressBinding");
        id103_include = base.Reader.NameTable.Add("include");
        id139_maxLength = base.Reader.NameTable.Add("maxLength");
        id165_maxOccurs = base.Reader.NameTable.Add("maxOccurs");
        id65_MimePart = base.Reader.NameTable.Add("MimePart");
        id102_id = base.Reader.NameTable.Add("id");
        id196_Item = base.Reader.NameTable.Add("XmlSchemaSimpleContentExtension");
        id140_length = base.Reader.NameTable.Add("length");
        id27_type = base.Reader.NameTable.Add("type");
        id106_complexType = base.Reader.NameTable.Add("complexType");
        id31_output = base.Reader.NameTable.Add("output");
        id1_definitions = base.Reader.NameTable.Add("definitions");
        id4_name = base.Reader.NameTable.Add("name");
        id132_union = base.Reader.NameTable.Add("union");
        id29_OperationBinding = base.Reader.NameTable.Add("OperationBinding");
        id170_key = base.Reader.NameTable.Add("key");
        id45_Item = base.Reader.NameTable.Add("http://microsoft.com/wsdl/mime/textMatching/");
        id95_Item = base.Reader.NameTable.Add("http://www.w3.org/2001/XMLSchema");
        id169_substitutionGroup = base.Reader.NameTable.Add("substitutionGroup");
        id178_xpath = base.Reader.NameTable.Add("xpath");
        id9_types = base.Reader.NameTable.Add("types");
        id97_attributeFormDefault = base.Reader.NameTable.Add("attributeFormDefault");
        id62_pattern = base.Reader.NameTable.Add("pattern");
        id58_MimeTextMatch = base.Reader.NameTable.Add("MimeTextMatch");
        id180_XmlSchemaKey = base.Reader.NameTable.Add("XmlSchemaKey");
        id10_message = base.Reader.NameTable.Add("message");
        id8_import = base.Reader.NameTable.Add("import");
        id148_XmlSchemaMinLengthFacet = base.Reader.NameTable.Add("XmlSchemaMinLengthFacet");
        id105_simpleType = base.Reader.NameTable.Add("simpleType");
        id181_XmlSchemaComplexType = base.Reader.NameTable.Add("XmlSchemaComplexType");
        id164_minOccurs = base.Reader.NameTable.Add("minOccurs");
        id144_maxExclusive = base.Reader.NameTable.Add("maxExclusive");
        id160_XmlSchemaFractionDigitsFacet = base.Reader.NameTable.Add("XmlSchemaFractionDigitsFacet");
        id124_XmlSchemaAttribute = base.Reader.NameTable.Add("XmlSchemaAttribute");
        id209_Import = base.Reader.NameTable.Add("Import");
        id206_schemaLocation = base.Reader.NameTable.Add("schemaLocation");
        id179_XmlSchemaUnique = base.Reader.NameTable.Add("XmlSchemaUnique");
        id75_style = base.Reader.NameTable.Add("style");
        id119_XmlSchemaDocumentation = base.Reader.NameTable.Add("XmlSchemaDocumentation");
        id136_base = base.Reader.NameTable.Add("base");
        id66_MimeXmlBinding = base.Reader.NameTable.Add("MimeXmlBinding");
        id30_input = base.Reader.NameTable.Add("input");
        id40_content = base.Reader.NameTable.Add("content");
        id93_Types = base.Reader.NameTable.Add("Types");
        id94_schema = base.Reader.NameTable.Add("schema");
        id200_Item = base.Reader.NameTable.Add("XmlSchemaComplexContentExtension");
        id67_MimeContentBinding = base.Reader.NameTable.Add("MimeContentBinding");
        id59_group = base.Reader.NameTable.Add("group");
        id32_fault = base.Reader.NameTable.Add("fault");
        id80_transport = base.Reader.NameTable.Add("transport");
        id98_blockDefault = base.Reader.NameTable.Add("blockDefault");
        id13_service = base.Reader.NameTable.Add("service");
        id54_SoapHeaderBinding = base.Reader.NameTable.Add("SoapHeaderBinding");
        id204_system = base.Reader.NameTable.Add("system");
        id16_Port = base.Reader.NameTable.Add("Port");
        id108_notation = base.Reader.NameTable.Add("notation");
        id186_choice = base.Reader.NameTable.Add("choice");
        id110_attributeGroup = base.Reader.NameTable.Add("attributeGroup");
        id79_Soap12Binding = base.Reader.NameTable.Add("Soap12Binding");
        id77_SoapOperationBinding = base.Reader.NameTable.Add("SoapOperationBinding");
        id115_XmlSchemaAnnotation = base.Reader.NameTable.Add("XmlSchemaAnnotation");
        id83_verb = base.Reader.NameTable.Add("verb");
        id72_HttpUrlEncodedBinding = base.Reader.NameTable.Add("HttpUrlEncodedBinding");
        id39_OutputBinding = base.Reader.NameTable.Add("OutputBinding");
        id183_complexContent = base.Reader.NameTable.Add("complexContent");
        id202_XmlSchemaNotation = base.Reader.NameTable.Add("XmlSchemaNotation");
        id81_SoapBinding = base.Reader.NameTable.Add("SoapBinding");
        id199_Item = base.Reader.NameTable.Add("XmlSchemaComplexContentRestriction");
        id28_operation = base.Reader.NameTable.Add("operation");
        id122_XmlSchemaAttributeGroupRef = base.Reader.NameTable.Add("XmlSchemaAttributeGroupRef");
        id155_XmlSchemaPatternFacet = base.Reader.NameTable.Add("XmlSchemaPatternFacet");
        id76_soapActionRequired = base.Reader.NameTable.Add("soapActionRequired");
        id90_Message = base.Reader.NameTable.Add("Message");
        id159_XmlSchemaMinInclusiveFacet = base.Reader.NameTable.Add("XmlSchemaMinInclusiveFacet");
        id208_XmlSchemaInclude = base.Reader.NameTable.Add("XmlSchemaInclude");
        id85_Operation = base.Reader.NameTable.Add("Operation");
        id130_list = base.Reader.NameTable.Add("list");
        id14_Service = base.Reader.NameTable.Add("Service");
        id22_required = base.Reader.NameTable.Add("required");
        id174_refer = base.Reader.NameTable.Add("refer");
        id71_HttpUrlReplacementBinding = base.Reader.NameTable.Add("HttpUrlReplacementBinding");
        id56_MimeTextBinding = base.Reader.NameTable.Add("MimeTextBinding");
        id87_OperationFault = base.Reader.NameTable.Add("OperationFault");
        id125_default = base.Reader.NameTable.Add("default");
        id15_port = base.Reader.NameTable.Add("port");
        id51_SoapHeaderFaultBinding = base.Reader.NameTable.Add("SoapHeaderFaultBinding");
        id128_XmlSchemaSimpleType = base.Reader.NameTable.Add("XmlSchemaSimpleType");
        id36_namespace = base.Reader.NameTable.Add("namespace");
        id175_selector = base.Reader.NameTable.Add("selector");
        id150_XmlSchemaMinExclusiveFacet = base.Reader.NameTable.Add("XmlSchemaMinExclusiveFacet");
        id100_elementFormDefault = base.Reader.NameTable.Add("elementFormDefault");
        id26_Binding = base.Reader.NameTable.Add("Binding");
        id197_Item = base.Reader.NameTable.Add("XmlSchemaSimpleContentRestriction");
        id126_fixed = base.Reader.NameTable.Add("fixed");
        id107_annotation = base.Reader.NameTable.Add("annotation");
        id99_finalDefault = base.Reader.NameTable.Add("finalDefault");
        id137_fractionDigits = base.Reader.NameTable.Add("fractionDigits");
        id70_urlReplacement = base.Reader.NameTable.Add("urlReplacement");
        id189_XmlSchemaChoice = base.Reader.NameTable.Add("XmlSchemaChoice");
        id2_Item = base.Reader.NameTable.Add("http://schemas.xmlsoap.org/wsdl/");
        id112_anyAttribute = base.Reader.NameTable.Add("anyAttribute");
        id89_OperationInput = base.Reader.NameTable.Add("OperationInput");
        id141_totalDigits = base.Reader.NameTable.Add("totalDigits");
        id61_repeats = base.Reader.NameTable.Add("repeats");
        id184_simpleContent = base.Reader.NameTable.Add("simpleContent");
        id55_SoapBodyBinding = base.Reader.NameTable.Add("SoapBodyBinding");
        id145_whiteSpace = base.Reader.NameTable.Add("whiteSpace");
        id167_block = base.Reader.NameTable.Add("block");
        id151_XmlSchemaWhiteSpaceFacet = base.Reader.NameTable.Add("XmlSchemaWhiteSpaceFacet");
        id12_binding = base.Reader.NameTable.Add("binding");
        id109_attribute = base.Reader.NameTable.Add("attribute");
        id171_unique = base.Reader.NameTable.Add("unique");
        id120_lang = base.Reader.NameTable.Add("lang");
        id173_XmlSchemaKeyref = base.Reader.NameTable.Add("XmlSchemaKeyref");
        id177_XmlSchemaXPath = base.Reader.NameTable.Add("XmlSchemaXPath");
        id34_Soap12FaultBinding = base.Reader.NameTable.Add("Soap12FaultBinding");
        id41_Item = base.Reader.NameTable.Add("http://schemas.xmlsoap.org/wsdl/mime/");
        id156_XmlSchemaTotalDigitsFacet = base.Reader.NameTable.Add("XmlSchemaTotalDigitsFacet");
        id113_XmlSchemaAnyAttribute = base.Reader.NameTable.Add("XmlSchemaAnyAttribute");
    }
}
