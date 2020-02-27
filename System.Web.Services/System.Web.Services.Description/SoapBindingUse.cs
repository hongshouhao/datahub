// System.Web.Services.Description.SoapBindingUse
using System.Xml.Serialization;

public enum SoapBindingUse
{
    [XmlIgnore]
    Default,
    [XmlEnum("encoded")]
    Encoded,
    [XmlEnum("literal")]
    Literal
}
