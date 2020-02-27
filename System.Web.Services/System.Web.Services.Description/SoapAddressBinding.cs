// System.Web.Services.Description.SoapAddressBinding
using System.Xml.Serialization;


[XmlFormatExtension("address", "http://schemas.xmlsoap.org/wsdl/soap/", typeof(Port))]
public class SoapAddressBinding : ServiceDescriptionFormatExtension
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
