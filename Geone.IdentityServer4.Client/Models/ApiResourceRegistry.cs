using System;
using System.Collections.Generic;
using System.Text;

namespace Geone.IdentityServer4.Client.Models
{
    public class ApiResourceRegistry
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public bool Enabled { get; set; } = true;

        public List<string> UserClaims { get; set; } = new List<string>();
        public List<ApiScopeRegistry> Scopes { get; set; } = new List<ApiScopeRegistry>();
        public Dictionary<string, string> Properties { get; set; } = new Dictionary<string, string>();

        public void Check()
        {
            if (string.IsNullOrWhiteSpace(Name))
                throw new ArgumentException($"{nameof(Name)}不能为空");
            if (string.IsNullOrWhiteSpace(DisplayName))
                throw new ArgumentException($"{nameof(DisplayName)}不能为空");

            foreach (var item in Scopes)
            {
                if (string.IsNullOrWhiteSpace(item.Name))
                    throw new ArgumentException($"{nameof(ApiScopeRegistry.Name)}不能为空");
                //if (string.IsNullOrWhiteSpace(item.DisplayName))
                //    throw new ArgumentException($"{nameof(ApiScopeRegistry.DisplayName)}不能为空");
            }
        }
    }
}
