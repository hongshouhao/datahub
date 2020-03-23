using System;
using System.Collections.Generic;
using System.Text;

namespace Geone.IdentityServer4.Client
{
    public class IdS4Exception : Exception
    {
        public IdS4Exception(string message, int status) : base(message)
        {
            Status = status;
        }

        public int Status { get; private set; }
    }
}
