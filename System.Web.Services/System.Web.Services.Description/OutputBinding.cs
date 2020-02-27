// System.Web.Services.Description.OutputBinding
using System.Xml.Serialization;

[XmlFormatExtensionPoint("Extensions")]
public sealed class OutputBinding : MessageBinding
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
