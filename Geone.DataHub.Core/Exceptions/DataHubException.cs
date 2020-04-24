using System;

namespace Geone.DataHub.Core.Exceptions
{
    public class DataHubException : Exception
    {
        public DataHubException(string message, int status)
            : base(message)
        {
            Status = status;
        }

        public int Status { get; private set; }
    }
}
