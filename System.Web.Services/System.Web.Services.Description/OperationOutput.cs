// System.Web.Services.Description.OperationOutput
using System.Xml.Serialization;

[XmlFormatExtensionPoint("Extensions")]
public sealed class OperationOutput : OperationMessage
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
