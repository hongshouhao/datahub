// System.Web.Services.Description.Service
using System.Xml.Serialization;

[XmlFormatExtensionPoint("Extensions")]
public sealed class Service : NamedItem
{
    private ServiceDescriptionFormatExtensionCollection extensions;

    private PortCollection ports;

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

    [XmlElement("port")]
    public PortCollection Ports
    {
        get
        {
            if (ports == null)
            {
                ports = new PortCollection(this);
            }
            return ports;
        }
    }

    internal void SetParent(ServiceDescription parent)
    {
        this.parent = parent;
    }
}
