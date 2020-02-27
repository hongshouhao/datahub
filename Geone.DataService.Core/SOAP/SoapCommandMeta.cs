using System.Collections.Generic;

namespace Geone.DataService.Core.SOAP
{
    public class SoapCommandMeta : IServiceContent
    {
        public string Url { get; set; }
        public List<Parameter> Parameters { get; private set; } = new List<Parameter>();
    }
}
