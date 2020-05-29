using Geone.AuthorisationFilter;
using Geone.DataHub.AspNetCore.Config;
using Geone.IdentityServer4.Client;
using Geone.IdentityServer4.Client.Models;
using Microsoft.AspNetCore.Mvc;

namespace Geone.DataHub.AspNetCore.Auth
{
    public class ApiProtectionProlicyIdentityServerProvider : IApiProtectionProlicyProvider
    {
        private AppSettings _root;
        private IApiProtectionProlicyProvider _prolicyProvider;

        public ApiProtectionProlicyIdentityServerProvider(AppSettings root)
        {
            _root = root;
            _prolicyProvider = new ApiProtectionProlicyProvider();
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

        public ProtectionConfiguration Load(string version)
        {
            IdSAdminClient client = new IdSAdminClient(_root.IdentityServer);
            ApiResourceRegistry apiResource = client.GetApiResource(_root.Server.Name, false);
            if (apiResource != null)
            {
                apiResource.Properties.TryGetValue(version, out string json);
                if (!string.IsNullOrWhiteSpace(json))
                    _prolicyProvider.Load(json);
            }

            return _prolicyProvider.GetConfiguration();
        }
    }
}
