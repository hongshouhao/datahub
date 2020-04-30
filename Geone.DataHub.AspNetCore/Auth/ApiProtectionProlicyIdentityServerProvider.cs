using Geone.AuthorisationFilter;
using Geone.DataHub.AspNetCore.Config;
using Geone.IdentityServer4.Client;
using Geone.IdentityServer4.Client.Models;
using Microsoft.AspNetCore.Mvc;

namespace Geone.DataHub.AspNetCore.Auth
{
    public class ApiProtectionProlicyIdentityServerProvider : IApiProtectionProlicyProvider
    {
        private Root _root;
        private IApiProtectionProlicyProvider _prolicyProvider;

        public ApiProtectionProlicyIdentityServerProvider(Root root)
        {
            _root = root;
            Reload();
        }

        public ProtectionConfiguration GetConfiguration()
        {
            return _prolicyProvider.GetConfiguration();
        }

        public ApiProtectionProlicy GetProlicy(ActionContext actionContext)
        {
            string controller = actionContext.RouteData.Values["Controller"].ToString();
            string action = actionContext.RouteData.Values["Action"].ToString();

            if (controller == "Service" && action == "Post")
            {
                string apiKey = actionContext.RouteData.Values["name"].ToString();
                return _prolicyProvider.GetProlicy(apiKey, actionContext);
            }
            else
            {
                return new ApiProtectionProlicy() { Enable = false };
            }
        }

        public ApiProtectionProlicy GetProlicy(string apiKey, ActionContext actionContext)
        {
            return _prolicyProvider.GetProlicy(apiKey, actionContext);
        }

        public ProtectionConfiguration Reload()
        {
            IdSAdminClient client = new IdSAdminClient(_root.IdentityServer);
            ApiResourceRegistry apiResource = client.GetApiResource(_root.Server.Name, false);
            if (apiResource == null)
            {
                _prolicyProvider = new ApiProtectionProlicyProvider("{}");
            }
            else
            {
                apiResource.Properties.TryGetValue("AuthScheme", out string json);
                if (string.IsNullOrWhiteSpace(json)) json = "{}";
                _prolicyProvider = new ApiProtectionProlicyProvider(json);
            }

            return _prolicyProvider.Reload();
        }
    }
}
