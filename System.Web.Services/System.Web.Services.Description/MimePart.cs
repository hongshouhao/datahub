// System.Web.Services.Description.MimePart
using System.Xml.Serialization;

[XmlFormatExtensionPoint("Extensions")]
public sealed class MimePart : ServiceDescriptionFormatExtension
{
    private ServiceDescriptionFormatExtensionCollection extensions;

    [XmlIgnore]
    public ServiceDescriptionFormatExtensionCollection Extensions
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
}
