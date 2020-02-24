using System;
using System.Collections.Generic;
using System.Text;

namespace Geone.DataService.Core.Repository
{
    public interface IAudit
    {
        DateTime CreatedDate { get; set; }
        DateTime ModifiedDate { get; set; }
    }
}
