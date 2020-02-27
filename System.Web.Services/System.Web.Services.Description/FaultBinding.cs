// System.Web.Services.Description.FaultBinding
using System.Xml.Serialization;

[XmlFormatExtensionPoint("Extensions")]
public sealed class FaultBinding : MessageBinding
{
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
}
