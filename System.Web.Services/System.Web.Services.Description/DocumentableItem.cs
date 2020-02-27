// System.Web.Services.Description.DocumentableItem
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Xml;
using System.Xml.Serialization;

public abstract class DocumentableItem
{
    private XmlDocument parent;

    private string documentation;

    private XmlElement documentationElement;

    private XmlAttribute[] anyAttribute;

    private XmlSerializerNamespaces namespaces;

    [XmlIgnore]
    public string Documentation
    {
        get
        {
            if (documentation != null)
            {
                return documentation;
            }
            if (documentationElement == null)
            {
                return string.Empty;
            }
            return documentationElement.InnerXml;
        }
        set
        {
            documentation = value;
            StringWriter writer = new StringWriter(CultureInfo.InvariantCulture);
            XmlTextWriter xmlWriter = new XmlTextWriter(writer);
            xmlWriter.WriteElementString("wsdl", "documentation", "http://schemas.xmlsoap.org/wsdl/", value);
            Parent.LoadXml(writer.ToString());
            documentationElement = parent.DocumentElement;
            xmlWriter.Close();
        }
    }

    [XmlAnyElement("documentation", Namespace = "http://schemas.xmlsoap.org/wsdl/")]
    [ComVisible(false)]
    public XmlElement DocumentationElement
    {
        get
        {
            return documentationElement;
        }
        set
        {
            documentationElement = value;
            documentation = null;
        }
    }

    [XmlAnyAttribute]
    public XmlAttribute[] ExtensibleAttributes
    {
        get
        {
            return anyAttribute;
        }
        set
        {
            anyAttribute = value;
        }
    }

    [XmlNamespaceDeclarations]
    public XmlSerializerNamespaces Namespaces
    {
        get
        {
            if (namespaces == null)
            {
                namespaces = new XmlSerializerNamespaces();
            }
            return namespaces;
        }
        set
        {
            namespaces = value;
        }
    }

    [XmlIgnore]
    public abstract ServiceDescriptionFormatExtensionCollection Extensions
    {
        get;
    }

    internal XmlDocument Parent
    {
        get
        {
            if (parent == null)
            {
                parent = new XmlDocument();
            }
            return parent;
        }
    }

    internal XmlElement GetDocumentationElement()
    {
        if (documentationElement == null)
        {
            documentationElement = Parent.CreateElement("wsdl", "documentation", "http://schemas.xmlsoap.org/wsdl/");
            Parent.InsertBefore(documentationElement, null);
        }
        return documentationElement;
    }
}
