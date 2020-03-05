using Geone.DataService.Core.Repository;
using System;

namespace Geone.DataService.Core.Exceptions
{
    public class BizException : Exception
    {
        public BizException(string message)
            : base(message)
        {
        }
    }
}
