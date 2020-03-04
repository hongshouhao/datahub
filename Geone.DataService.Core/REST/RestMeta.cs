using System.Collections.Generic;

namespace Geone.DataService.Core.REST
{
    public class RestMeta : IServiceContent
    {
        public string Curl { get; set; }

        public List<Parameter> Parameters { get; private set; } = new List<Parameter>();
    }
}
