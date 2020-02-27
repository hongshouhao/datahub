// System.Web.Services.Description.Soap12OperationBinding
using System.ComponentModel;
using System.Xml.Serialization;


[XmlFormatExtension("operation", "http://schemas.xmlsoap.org/wsdl/soap12/", typeof(OperationBinding))]
public sealed class Soap12OperationBinding : SoapOperationBinding
{
    private bool soapActionRequired;

    [XmlAttribute("soapActionRequired")]
    [DefaultValue(false)]
    public bool SoapActionRequired
    {
        get
        {
            return soapActionRequired;
        }
        set
        {
            soapActionRequired = value;
        }
    }
}
