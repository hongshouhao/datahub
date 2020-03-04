using System.Collections.Generic;

namespace Geone.DataService.Core.Aggregate
{
    public class AggregateMeta : IServiceContent
    {
        public AggregateMeta()
        {
        }

        public string AggregateJson { get; set; }
        public List<Parameter> Parameters { get; private set; } = new List<Parameter>();
    }
}
