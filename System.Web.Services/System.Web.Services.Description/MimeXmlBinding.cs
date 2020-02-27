// System.Web.Services.Description.MimeXmlBinding
using System.Xml.Serialization;

[XmlFormatExtension("mimeXml", "http://schemas.xmlsoap.org/wsdl/mime/", typeof(MimePart), typeof(InputBinding), typeof(OutputBinding))]
public sealed class MimeXmlBinding : ServiceDescriptionFormatExtension
{
    private string part;

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
}
