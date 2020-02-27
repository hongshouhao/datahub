// System.Web.Services.Description.MimeContentBinding
using System.Xml.Serialization;

[XmlFormatExtension("content", "http://schemas.xmlsoap.org/wsdl/mime/", typeof(MimePart), typeof(InputBinding), typeof(OutputBinding))]
[XmlFormatExtensionPrefix("mime", "http://schemas.xmlsoap.org/wsdl/mime/")]
public sealed class MimeContentBinding : ServiceDescriptionFormatExtension
{
    private string type;

    private string part;

    public const string Namespace = "http://schemas.xmlsoap.org/wsdl/mime/";

    [XmlAttribute("part")]
    public string Part
    {
        get
        {
            return part;
        }
        set
        {
            part = value;
        }
    }

    [XmlAttribute("type")]
    public string Type
    {
        get
        {
            if (type != null)
            {
                return type;
            }
            return string.Empty;
        }
        set
        {
            type = value;
        }
    }
}
