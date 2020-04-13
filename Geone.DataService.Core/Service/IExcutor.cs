using Geone.DataHub.Core.Metadata;
using System;
using System.Collections.Generic;
using System.Text;

namespace Geone.DataHub.Core.Service
{
    public interface IExcutor
    {
        object Excute(ServiceMeta service, object arguments);
    }
}
