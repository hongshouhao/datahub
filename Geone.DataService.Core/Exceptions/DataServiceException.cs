using Geone.DataService.Core.Repository;
using System;

namespace Geone.DataService.Core.Exceptions
{
    public class DataServiceException : Exception
    {
        public DataServiceException(string message)
            : base(message)
        {
        }
    }
}
