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
        public string AllowedGrantType { get; set; }
        public string RedirectUri { get; set; }
        public bool AllowOfflineAccess { get; set; }
        public bool AllowAccessTokensViaBrowser { get; set; }
        public List<string> AllowedScopes { get; set; }

        public void Check()
        {
            if (string.IsNullOrWhiteSpace(ClientId))
                throw new ArgumentException($"{nameof(ClientId)}不能为空");
            if (string.IsNullOrWhiteSpace(ClientName))
                throw new ArgumentException($"{nameof(ClientId)}不能为空");
            if (string.IsNullOrWhiteSpace(AllowedGrantType))
                throw new ArgumentException($"{nameof(AllowedGrantType)}不能为空");

            if (string.IsNullOrWhiteSpace(BaseURL) && !string.IsNullOrWhiteSpace(RedirectUri))
            {
                throw new ArgumentException($"{nameof(BaseURL)}和{nameof(RedirectUri)}只能都为空或都不为空");
            }

            if (!string.IsNullOrWhiteSpace(BaseURL) && string.IsNullOrWhiteSpace(RedirectUri))
            {
                throw new ArgumentException($"{nameof(BaseURL)}和{nameof(RedirectUri)}只能都为空或都不为空");
            }
        }
    }
}
