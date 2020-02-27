// System.Web.Services.Description.OperationMessage
using System.Xml;
using System.Xml.Serialization;

public abstract class OperationMessage : NamedItem
{
    private XmlQualifiedName message = XmlQualifiedName.Empty;

    private Operation parent;

    public Operation Operation => parent;

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

    internal void SetParent(Operation parent)
    {
        this.parent = parent;
    }
}
