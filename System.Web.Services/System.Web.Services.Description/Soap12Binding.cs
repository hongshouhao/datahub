// System.Web.Services.Description.Soap12Binding

[XmlFormatExtension("binding", "http://schemas.xmlsoap.org/wsdl/soap12/", typeof(Binding))]
[XmlFormatExtensionPrefix("soap12", "http://schemas.xmlsoap.org/wsdl/soap12/")]
public sealed class Soap12Binding : SoapBinding
{
    public new const string Namespace = "http://schemas.xmlsoap.org/wsdl/soap12/";

    public new const string HttpTransport = "http://schemas.xmlsoap.org/soap/http";
}
