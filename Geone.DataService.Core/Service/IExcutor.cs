using Geone.DataService.Core.Metadata;
using System;
using System.Collections.Generic;
using System.Text;

namespace Geone.DataService.Core.Service
{
    public interface IExcutor
    {
        object Excute(ServiceMeta service, object arguments);
    }
}
