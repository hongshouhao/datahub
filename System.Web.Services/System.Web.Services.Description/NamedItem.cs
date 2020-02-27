// System.Web.Services.Description.NamedItem
using System.Xml.Serialization;

public abstract class NamedItem : DocumentableItem
{
    private string name;

    [XmlAttribute("name")]
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
}
