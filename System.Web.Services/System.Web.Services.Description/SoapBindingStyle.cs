// System.Web.Services.Description.SoapBindingStyle
using System.Xml.Serialization;

public enum SoapBindingStyle
{
    [XmlIgnore]
    Default,
    [XmlEnum("document")]
    Document,
    [XmlEnum("rpc")]
    Rpc
}
