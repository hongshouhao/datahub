// System.Web.Services.Description.OperationBinding
using System.Xml.Serialization;

[XmlFormatExtensionPoint("Extensions")]
public sealed class OperationBinding : NamedItem
{
    private ServiceDescriptionFormatExtensionCollection extensions;

    private FaultBindingCollection faults;

    private InputBinding input;

    private OutputBinding output;

    private Binding parent;

    public Binding Binding => parent;

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

    [XmlElement("input")]
    public InputBinding Input
    {
        get
        {
            return input;
        }
        set
        {
            if (input != null)
            {
                input.SetParent(null);
            }
            input = value;
            if (input != null)
            {
                input.SetParent(this);
            }
        }
    }

    [XmlElement("output")]
    public OutputBinding Output
    {
        get
        {
            return output;
        }
        set
        {
            if (output != null)
            {
                output.SetParent(null);
            }
            output = value;
            if (output != null)
            {
                output.SetParent(this);
            }
        }
    }

    [XmlElement("fault")]
    public FaultBindingCollection Faults
    {
        get
        {
            if (faults == null)
            {
                faults = new FaultBindingCollection(this);
            }
            return faults;
        }
    }

    internal void SetParent(Binding parent)
    {
        this.parent = parent;
    }
}
