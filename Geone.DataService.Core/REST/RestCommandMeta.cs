using System.Collections.Generic;

namespace Geone.DataService.Core.REST
{
    public class RestCommandMeta : IServiceContent
    {
        public string Curl { get; set; }

        public List<Parameter> Parameters { get; private set; } = new List<Parameter>();
    }
}
