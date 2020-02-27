// System.Web.Services.Description.ServiceDescriptionImportStyle
using System.Xml.Serialization;

public enum ServiceDescriptionImportStyle
{
    [XmlEnum("client")]
    Client,
    [XmlEnum("server")]
    Server,
    [XmlEnum("serverInterface")]
    ServerInterface
}
