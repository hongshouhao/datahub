// System.Web.Services.Description.Import
using System.Xml.Serialization;

[XmlFormatExtensionPoint("Extensions")]
public sealed class Import : DocumentableItem
{
    private string ns;

    private string location;

    private ServiceDescription parent;

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

    public ServiceDescription ServiceDescription => parent;

    [XmlAttribute("namespace")]
    public string Namespace
    {
        get
        {
            if (ns != null)
            {
                return ns;
            }
            return string.Empty;
        }
        set
        {
            ns = value;
        }
    }

    [XmlAttribute("location")]
    public string Location
    {
        get
        {
            if (location != null)
            {
                return location;
            }
            return string.Empty;
        }
        set
        {
            location = value;
        }
    }

    internal void SetParent(ServiceDescription parent)
    {
        this.parent = parent;
    }
}
