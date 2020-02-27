// System.Web.Services.Description.SoapOperationBinding
using System.ComponentModel;
using System.Xml.Serialization;


[XmlFormatExtension("operation", "http://schemas.xmlsoap.org/wsdl/soap/", typeof(OperationBinding))]
public class SoapOperationBinding : ServiceDescriptionFormatExtension
{
    private string soapAction;

    private SoapBindingStyle style;

    [XmlAttribute("soapAction")]
    public string SoapAction
    {
        get
        {
            if (soapAction != null)
            {
                return soapAction;
            }
            return string.Empty;
        }
        set
        {
            soapAction = value;
        }
    }

    [XmlAttribute("style")]
    [DefaultValue(SoapBindingStyle.Default)]
    public SoapBindingStyle Style
    {
        get
        {
            return style;
        }
        set
        {
            style = value;
        }
    }
}
