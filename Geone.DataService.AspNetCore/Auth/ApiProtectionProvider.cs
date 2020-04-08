using Geone.AuthorisationFilter;
using Microsoft.AspNetCore.Mvc;

namespace Geone.DataService.AspNetCore.Auth
{
    public class ApiProtectionProvider : DefaultApiProtectionProlicyProvider, IApiProtectionProlicyProvider
    {
        //private readonly ApiAuthProlicyResourceAuthProvider provider = new ApiAuthProlicyResourceAuthProvider(configuration);

        public ApiProtectionProvider(string configFile) : base(configFile)
        {
        }

        public override ApiProtectionProlicy GetProlicy(ActionContext actionContext)
        {
            string controller = actionContext.RouteData.Values["Controller"].ToString();
            string action = actionContext.RouteData.Values["Action"].ToString();

            if (controller == "Service" && action == "Post")
            {
                return base.GetProlicy(actionContext);
            }
            else
            {
                return new ApiProtectionProlicy() { Enable = false };
            }
        }

        protected override string GetApiName(ActionContext actionContext)
        {
            return actionContext.RouteData.Values["name"].ToString();
        }
    }
}
