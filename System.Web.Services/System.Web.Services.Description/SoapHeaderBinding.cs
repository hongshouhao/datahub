// System.Web.Services.Description.SoapHeaderBinding
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;


[XmlFormatExtension("header", "http://schemas.xmlsoap.org/wsdl/soap/", typeof(InputBinding), typeof(OutputBinding))]
public class SoapHeaderBinding : ServiceDescriptionFormatExtension
{
    private XmlQualifiedName message = XmlQualifiedName.Empty;

    private string part;

    private SoapBindingUse use;

    private string encoding;

    private string ns;

    private bool mapToProperty;

    private SoapHeaderFaultBinding fault;

    [XmlIgnore]
    public bool MapToProperty
    {
        get
        {
            return mapToProperty;
        }
        set
        {
            mapToProperty = value;
        }
    }

    [XmlAttribute("message")]
    public XmlQualifiedName Message
    {
        get
        {
            return message;
        }
        set
        {
            message = value;
        }
    }

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

    [XmlAttribute("use")]
    [DefaultValue(SoapBindingUse.Default)]
    public SoapBindingUse Use
    {
        get
        {
            return use;
        }
        set
        {
            use = value;
        }
    }

    [XmlAttribute("encodingStyle")]
    [DefaultValue("")]
    public string Encoding
    {
        get
        {
            if (encoding != null)
            {
                return encoding;
            }
            return string.Empty;
        }
        set
        {
            encoding = value;
        }
    }

    [XmlAttribute("namespace")]
    [DefaultValue("")]
    public string Namespace
    {
        get
        {
            if (ns != null)
            {
                return ns;
            }
            return string.Empty;
        }
        set
        {
            ns = value;
        }
    }

    [XmlElement("headerfault")]
    public SoapHeaderFaultBinding Fault
    {
        get
        {
            return fault;
        }
        set
        {
            fault = value;
        }
    }
}
