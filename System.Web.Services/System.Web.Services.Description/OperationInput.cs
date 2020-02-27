// System.Web.Services.Description.OperationInput
using System.Xml.Serialization;

[XmlFormatExtensionPoint("Extensions")]
public sealed class OperationInput : OperationMessage
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
