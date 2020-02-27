using System;

namespace Geone.DataService.Core.Repository
{
    public interface IAudit
    {
        DateTime CreatedDate { get; set; }
        DateTime ModifiedDate { get; set; }
    }
}
