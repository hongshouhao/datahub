// System.Web.Services.Description.WebReferenceOptionsSerializationReader
using System.Collections;
using System.Collections.Specialized;
using System.Xml;
using System.Xml.Serialization;


internal class WebReferenceOptionsSerializationReader : XmlSerializationReader
{
    private Hashtable _CodeGenerationOptionsValues;

    private string id2_Item;

    private string id5_type;

    private string id4_schemaImporterExtensions;

    private string id3_codeGenerationOptions;

    private string id6_style;

    private string id7_verbose;

    private string id1_webReferenceOptions;

    internal Hashtable CodeGenerationOptionsValues
    {
        get
        {
            if (_CodeGenerationOptionsValues == null)
            {
                Hashtable h = new Hashtable();
                h.Add("properties", 1L);
                h.Add("newAsync", 2L);
                h.Add("oldAsync", 4L);
                h.Add("order", 8L);
                h.Add("enableDataBinding", 16L);
                _CodeGenerationOptionsValues = h;
            }
            return _CodeGenerationOptionsValues;
        }
    }

    private CodeGenerationOptions Read1_CodeGenerationOptions(string s)
    {
        return (CodeGenerationOptions)XmlSerializationReader.ToEnum(s, CodeGenerationOptionsValues, "System.Xml.Serialization.CodeGenerationOptions");
    }

    private ServiceDescriptionImportStyle Read2_ServiceDescriptionImportStyle(string s)
    {
        if (s != null)
        {
            if (!(s == "client"))
            {
                if (!(s == "server"))
                {
                    if (s == "serverInterface")
                    {
                        return ServiceDescriptionImportStyle.ServerInterface;
                    }
                    goto IL_0032;
                }
                return ServiceDescriptionImportStyle.Server;
            }
            return ServiceDescriptionImportStyle.Client;
        }
        goto IL_0032;
    IL_0032:
        throw CreateUnknownConstantException(s, typeof(ServiceDescriptionImportStyle));
    }

    private WebReferenceOptions Read4_WebReferenceOptions(bool isNullable, bool checkType)
    {
        XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
        bool isNull = false;
        if (isNullable)
        {
            isNull = ReadNull();
        }
        if (checkType && !(xsiType == (XmlQualifiedName)null) && ((object)xsiType.Name != id1_webReferenceOptions || (object)xsiType.Namespace != id2_Item))
        {
            throw CreateUnknownTypeException(xsiType);
        }
        if (isNull)
        {
            return null;
        }
        WebReferenceOptions o = new WebReferenceOptions();
        StringCollection a_ = o.SchemaImporterExtensions;
        bool[] paramsRead = new bool[4];
        while (base.Reader.MoveToNextAttribute())
        {
            if (!IsXmlnsAttribute(base.Reader.Name))
            {
                UnknownNode(o);
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
        int whileIterations0 = 0;
        int readerCount0 = base.ReaderCount;
        while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
        {
            if (base.Reader.NodeType == XmlNodeType.Element)
            {
                if (!paramsRead[0] && (object)base.Reader.LocalName == id3_codeGenerationOptions && (object)base.Reader.NamespaceURI == id2_Item)
                {
                    if (base.Reader.IsEmptyElement)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        o.CodeGenerationOptions = Read1_CodeGenerationOptions(base.Reader.ReadElementString());
                    }
                    paramsRead[0] = true;
                }
                else if ((object)base.Reader.LocalName == id4_schemaImporterExtensions && (object)base.Reader.NamespaceURI == id2_Item)
                {
                    if (!ReadNull())
                    {
                        StringCollection a_1_0 = o.SchemaImporterExtensions;
                        if (a_1_0 == null || base.Reader.IsEmptyElement)
                        {
                            base.Reader.Skip();
                        }
                        else
                        {
                            base.Reader.ReadStartElement();
                            base.Reader.MoveToContent();
                            int whileIterations = 0;
                            int readerCount = base.ReaderCount;
                            while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
                            {
                                if (base.Reader.NodeType == XmlNodeType.Element)
                                {
                                    if ((object)base.Reader.LocalName == id5_type && (object)base.Reader.NamespaceURI == id2_Item)
                                    {
                                        if (ReadNull())
                                        {
                                            a_1_0.Add(null);
                                        }
                                        else
                                        {
                                            a_1_0.Add(base.Reader.ReadElementString());
                                        }
                                    }
                                    else
                                    {
                                        UnknownNode(null, "http://microsoft.com/webReference/:type");
                                    }
                                }
                                else
                                {
                                    UnknownNode(null, "http://microsoft.com/webReference/:type");
                                }
                                base.Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations, ref readerCount);
                            }
                            ReadEndElement();
                        }
                    }
                }
                else if (!paramsRead[2] && (object)base.Reader.LocalName == id6_style && (object)base.Reader.NamespaceURI == id2_Item)
                {
                    if (base.Reader.IsEmptyElement)
                    {
                        base.Reader.Skip();
                    }
                    else
                    {
                        o.Style = Read2_ServiceDescriptionImportStyle(base.Reader.ReadElementString());
                    }
                    paramsRead[2] = true;
                }
                else if (!paramsRead[3] && (object)base.Reader.LocalName == id7_verbose && (object)base.Reader.NamespaceURI == id2_Item)
                {
                    o.Verbose = XmlConvert.ToBoolean(base.Reader.ReadElementString());
                    paramsRead[3] = true;
                }
                else
                {
                    UnknownNode(o, "http://microsoft.com/webReference/:codeGenerationOptions, http://microsoft.com/webReference/:schemaImporterExtensions, http://microsoft.com/webReference/:style, http://microsoft.com/webReference/:verbose");
                }
            }
            else
            {
                UnknownNode(o, "http://microsoft.com/webReference/:codeGenerationOptions, http://microsoft.com/webReference/:schemaImporterExtensions, http://microsoft.com/webReference/:style, http://microsoft.com/webReference/:verbose");
            }
            base.Reader.MoveToContent();
            CheckReaderCount(ref whileIterations0, ref readerCount0);
        }
        ReadEndElement();
        return o;
    }

    protected override void InitCallbacks()
    {
    }

    internal object Read5_webReferenceOptions()
    {
        object o = null;
        base.Reader.MoveToContent();
        if (base.Reader.NodeType == XmlNodeType.Element)
        {
            if ((object)base.Reader.LocalName == id1_webReferenceOptions && (object)base.Reader.NamespaceURI == id2_Item)
            {
                o = Read4_WebReferenceOptions(true, true);
                goto IL_0060;
            }
            throw CreateUnknownNodeException();
        }
        UnknownNode(null, "http://microsoft.com/webReference/:webReferenceOptions");
        goto IL_0060;
    IL_0060:
        return o;
    }

    protected override void InitIDs()
    {
        id2_Item = base.Reader.NameTable.Add("http://microsoft.com/webReference/");
        id5_type = base.Reader.NameTable.Add("type");
        id4_schemaImporterExtensions = base.Reader.NameTable.Add("schemaImporterExtensions");
        id3_codeGenerationOptions = base.Reader.NameTable.Add("codeGenerationOptions");
        id6_style = base.Reader.NameTable.Add("style");
        id7_verbose = base.Reader.NameTable.Add("verbose");
        id1_webReferenceOptions = base.Reader.NameTable.Add("webReferenceOptions");
    }
}
