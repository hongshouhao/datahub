// System.Web.Services.Description.HttpAddressBinding
using System.Xml.Serialization;

[XmlFormatExtension("address", "http://schemas.xmlsoap.org/wsdl/http/", typeof(Port))]
public sealed class HttpAddressBinding : ServiceDescriptionFormatExtension
{
    private string location;

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
}
