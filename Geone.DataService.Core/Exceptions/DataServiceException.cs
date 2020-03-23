using System;

namespace Geone.DataService.Core.Exceptions
{
    public class DataServiceException : Exception
    {
        public DataServiceException(string message, int status)
            : base(message)
        {
            Status = status;
        }

        public int Status { get; private set; }
    }
}
