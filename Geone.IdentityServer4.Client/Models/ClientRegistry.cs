using System;
using System.Collections.Generic;

namespace Geone.IdentityServer4.Client.Models
{
    public class ClientRegistry
    {
        public string ClientId { get; set; }
        public string ClientName { get; set; }
        public string ClientSecret { get; set; }
        public string Description { get; set; }
        public string BaseURL { get; set; }
        public string ClientUri { get; set; }
        public List<string> AllowedGrantTypes { get; set; } = new List<string>();
        public List<string> RedirectUris { get; set; } = new List<string>();
        public bool AllowOfflineAccess { get; set; }
        public bool AllowAccessTokensViaBrowser { get; set; }
        public bool RequireClientSecret { get; set; }
        public List<string> AllowedScopes { get; set; } = new List<string>();
        public Dictionary<string, string> Properties { get; set; } = new Dictionary<string, string>();

        public void Check()
        {
            if (string.IsNullOrWhiteSpace(ClientId))
                throw new ArgumentException($"{nameof(ClientId)}不能为空");
            if (string.IsNullOrWhiteSpace(ClientName))
                throw new ArgumentException($"{nameof(ClientId)}不能为空");
            if (AllowedGrantTypes.Count == 0)
                throw new ArgumentException($"{nameof(AllowedGrantTypes)}不能为空");
        }
    }
}
