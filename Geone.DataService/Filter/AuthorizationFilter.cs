using Geone.DataService.AspNetCore.Config;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Linq;

namespace Geone.DataService.Authorize
{
    public class AuthorizationFilter : IAuthorizationFilter
    {
        private readonly ConfigRoot _configRoot;

        public AuthorizationFilter(ConfigRoot configRoot)
        {
            _configRoot = configRoot;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var request = context.HttpContext.Request;
            if (request.RouteValues.TryGetValue("Action", out object action)
                && request.RouteValues.TryGetValue("Controller", out object controller))
            {
                string actionName = action == null ? "" : action.ToString();
                string controllerName = controller == null ? "" : controller.ToString();
                if (string.Equals("Service", controllerName, StringComparison.CurrentCultureIgnoreCase)
                    && string.Equals("Post", actionName, StringComparison.CurrentCultureIgnoreCase))
                {
                    string requestIP = request.Host.Host;

                    if (_configRoot.IPSafeList.Contains(requestIP))
                    {
                        string serviceName = request.RouteValues["name"].ToString();

                        if (_configRoot.ActionRoles.TryGetValue(serviceName, out string[] needRoles))
                        {
                            if (needRoles != null || needRoles.Length > 0)
                            {
                                string[] userRoles = context.HttpContext.User.Claims
                                    .Where(s => s.Type.ToLower() == "role").Select(s => s.Value).ToArray();

                                if (userRoles.Length == 0)
                                {
                                    context.Result = new UnauthorizedResult();
                                }
                                else
                                {
                                    bool hasAuthorization = needRoles.All(r =>
                                        userRoles.Any(s => string.Equals(s, r, StringComparison.CurrentCultureIgnoreCase)));

                                    if (!hasAuthorization)
                                    {
                                        context.Result = new UnauthorizedResult();
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        context.Result = new UnauthorizedResult();
                    }
                }
            }
        }
    }
}
