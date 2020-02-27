// System.Web.Services.Description.MessagePart
using System.Xml;
using System.Xml.Serialization;

[XmlFormatExtensionPoint("Extensions")]
public sealed class MessagePart : NamedItem
{
    private XmlQualifiedName type = XmlQualifiedName.Empty;

    private XmlQualifiedName element = XmlQualifiedName.Empty;

    private Message parent;

    private ServiceDescriptionFormatExtensionCollection extensions;

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

    public Message Message => parent;

    [XmlAttribute("element")]
    public XmlQualifiedName Element
    {
        get
        {
            return element;
        }
        set
        {
            element = value;
        }
    }

    [XmlAttribute("type")]
    public XmlQualifiedName Type
    {
        get
        {
            if ((object)type == null)
            {
                return XmlQualifiedName.Empty;
            }
            return type;
        }
        set
        {
            type = value;
        }
    }

    internal void SetParent(Message parent)
    {
        this.parent = parent;
    }
}
