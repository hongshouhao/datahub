// System.Web.Services.Description.Binding
using System.Xml;
using System.Xml.Serialization;

[XmlFormatExtensionPoint("Extensions")]
public sealed class Binding : NamedItem
{
    private ServiceDescriptionFormatExtensionCollection extensions;

    private OperationBindingCollection operations;

    private XmlQualifiedName type = XmlQualifiedName.Empty;

    private ServiceDescription parent;

    public ServiceDescription ServiceDescription => parent;

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

    [XmlElement("operation")]
    public OperationBindingCollection Operations
    {
        get
        {
            if (operations == null)
            {
                operations = new OperationBindingCollection(this);
            }
            return operations;
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

    internal void SetParent(ServiceDescription parent)
    {
        this.parent = parent;
    }
}
