using System;
using System.Collections.Generic;
using System.Text;

namespace Geone.IdentityServer4.Client
{
    public class IdSException : Exception
    {
        public IdSException(string message, int status) : base(message)
        {
            Status = status;
        }

        public IdSException(string message, int status, Exception exception) : base(message, exception)
        {
            Status = status;
        }

        public int Status { get; private set; }
    }
}
