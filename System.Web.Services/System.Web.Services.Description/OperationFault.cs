// System.Web.Services.Description.OperationFault
using System.Xml.Serialization;

[XmlFormatExtensionPoint("Extensions")]
public sealed class OperationFault : OperationMessage
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
