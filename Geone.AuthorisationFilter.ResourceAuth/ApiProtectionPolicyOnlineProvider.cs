using Geone.Privileges.Core.Services;
using Geone.Privileges.ResourceAuth.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Concurrent;
using System.Linq;

namespace Geone.AuthorisationFilter.ResourceAuth
{
    public class ApiProtectionPolicyOnlineProvider : IApiProtectionProlicyProvider
    {
        private ConcurrentDictionary<string, ProtectionScheme> _dicKeyAndScheme
            = new ConcurrentDictionary<string, ProtectionScheme>(StringComparer.OrdinalIgnoreCase);

        private ProtectionScheme _global = null;
        private string _resAuthBaseUrl;
        private string _serviceName;

        public ApiProtectionPolicyOnlineProvider(string resAuthBaseUrl, string serviceName)
        {
            _resAuthBaseUrl = resAuthBaseUrl;
            _serviceName = serviceName;

            Reload();
        }

        public void Reload()
        {
            ApiAuthScheme[] schemes = new ApiAuthSchemeLoader(_resAuthBaseUrl).LoadData(_serviceName);
            foreach (var item in schemes)
            {
                ProtectionScheme appScheme = null;
                if (_global == null)
                {
                    if (item.GlobalScheme is JObject)
                    {
                        _global = ((JObject)item.GlobalScheme).ToObject<ProtectionScheme>();
                    }
                    else
                    {
                        _global = new ProtectionScheme() { Enable = true };
                    }
                }

                if (item.Scheme is JObject)
                {
                    appScheme = ((JObject)item.Scheme).ToObject<ProtectionScheme>();
                }

                if (appScheme != null)
                {
                    _global.MergeTo(appScheme);
                    _dicKeyAndScheme.TryAdd(item.AppName, appScheme);
                }
                else
                {
                    ProtectionScheme copy = ((JObject)item.GlobalScheme).ToObject<ProtectionScheme>();
                    copy.Key = item.AppName;

                    _dicKeyAndScheme.TryAdd(item.AppName, copy);
                }
            }
        }

        public virtual ApiProtectionProlicy GetProlicy(ActionContext actionContext)
        {
            string apiKey = GetApiName(actionContext);
            return GetProlicy(apiKey, actionContext);
        }

        public virtual ApiProtectionProlicy GetProlicy(string apiKey, ActionContext actionContext)
        {
            string clientId = actionContext.HttpContext.User.Claims.FirstOrDefault(x => x.Type.ToLower() == "client_id")?.Value;

            if (string.IsNullOrWhiteSpace(clientId))
            {
                return GetDefaultApiPolicy(apiKey);
            }

            if (_dicKeyAndScheme.TryGetValue(clientId, out ProtectionScheme scheme))
            {
                ApiProtectionProlicy prolicy = scheme.GetApiProtectionProlicy(clientId);
                if (prolicy == null)
                {
                    return new ApiProtectionProlicy()
                    {
                        Key = apiKey,
                        Enable = scheme.Enable,
                        IpAllowedList = scheme.IpAllowedList,
                        RequiredClaims = scheme.RequiredClaims
                    };
                }
                else
                {
                    return prolicy;
                }
            }
            else
            {
                return GetDefaultApiPolicy(apiKey);
            }
        }

        private ApiProtectionProlicy GetDefaultApiPolicy(string key)
        {
            ApiProtectionProlicy targ = _global.GetApiProtectionProlicy(key);
            if (targ == null)
            {
                return new ApiProtectionProlicy()
                {
                    Key = key,
                    Enable = _global.Enable,
                    IpAllowedList = _global.IpAllowedList,
                    RequiredClaims = _global.RequiredClaims
                };
            }
            else
            {
                return targ;
            }
        }

        protected virtual string GetApiName(ActionContext actionContext)
        {
            string controller = actionContext.RouteData.Values["Controller"].ToString();
            string action = actionContext.RouteData.Values["Action"].ToString();
            return $"{controller}/{action}";
        }
    }
}
