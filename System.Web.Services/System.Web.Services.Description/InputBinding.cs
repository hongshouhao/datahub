// System.Web.Services.Description.InputBinding
using System.Xml.Serialization;

[XmlFormatExtensionPoint("Extensions")]
public sealed class InputBinding : MessageBinding
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
