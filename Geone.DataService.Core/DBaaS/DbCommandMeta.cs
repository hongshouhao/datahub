using System.Collections.Generic;

namespace Geone.DataService.Core.DBaaS
{
    public class DbCommandMeta : IServiceContent
    {
        public DbCommandMeta()
        {
        }

        public string Database { get; set; }
        public string CommandText { get; set; }
        public int CommandTimeout { get; set; }

        public List<Parameter> Parameters { get; private set; } = new List<Parameter>();
    }
}
