// System.Web.Services.Description.ServiceDescriptionFormatExtension
using System.ComponentModel;
using System.Xml.Serialization;

public abstract class ServiceDescriptionFormatExtension
{
    private object parent;

    private bool required;

    private bool handled;

    public object Parent => parent;

    [XmlAttribute("required", Namespace = "http://schemas.xmlsoap.org/wsdl/")]
    [DefaultValue(false)]
    public bool Required
    {
        get
        {
            return required;
        }
        set
        {
            required = value;
        }
    }

    [XmlIgnore]
    public bool Handled
    {
        get
        {
            return handled;
        }
        set
        {
            handled = value;
        }
    }

    internal void SetParent(object parent)
    {
        this.parent = parent;
    }
}
