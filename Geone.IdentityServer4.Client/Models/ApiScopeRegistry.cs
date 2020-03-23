using System;
using System.Collections.Generic;
using System.Text;

namespace Geone.IdentityServer4.Client.Models
{
    public class ApiScopeRegistry
    {
        public ApiScopeRegistry()
        {
            UserClaims = new List<string>();
        }

        public bool ShowInDiscoveryDocument { get; set; } = true;
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public bool Required { get; set; }
        public bool Emphasize { get; set; }
        public List<string> UserClaims { get; set; }
    }
}
