// System.Web.Services.Description.SoapBodyBinding
using System.ComponentModel;
using System.Text;
using System.Xml.Serialization;


[XmlFormatExtension("body", "http://schemas.xmlsoap.org/wsdl/soap/", typeof(InputBinding), typeof(OutputBinding), typeof(MimePart))]
public class SoapBodyBinding : ServiceDescriptionFormatExtension
{
    private SoapBindingUse use;

    private string ns;

    private string encoding;

    private string[] parts;

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

    [XmlAttribute("parts")]
    public string PartsString
    {
        get
        {
            if (parts == null)
            {
                return null;
            }
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < parts.Length; i++)
            {
                if (i > 0)
                {
                    builder.Append(' ');
                }
                builder.Append(parts[i]);
            }
            return builder.ToString();
        }
        set
        {
            if (value == null)
            {
                parts = null;
            }
            else
            {
                parts = value.Split(new char[1]
                {
                    ' '
                });
            }
        }
    }

    [XmlIgnore]
    public string[] Parts
    {
        get
        {
            return parts;
        }
        set
        {
            parts = value;
        }
    }
}
