using Geone.Privileges.Core;
using Geone.Privileges.Core.Services;
using Geone.Privileges.ResourceAuth.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Geone.AuthorisationFilter.ResourceAuth
{
    public class ApiAuthProlicyResourceAuthProvider : IApiProtectionProlicyProvider
    {
        private Dictionary<string, ProtectionScheme> DicKeyAndScheme = new Dictionary<string, ProtectionScheme>();
        public ApiAuthProlicyResourceAuthProvider(IConfiguration configuration)
        {
            var openauthSection = configuration.GetSection("OpenAuth");
            string host = openauthSection["Host"];
            string role = openauthSection["AdminRole"];
            string appKey = openauthSection["AppKey"];

            User user = new User()
            {
                Account = "",
                IsSuperAdmin = true,
                Roles = new[] { role }
            };

            if (string.IsNullOrWhiteSpace(host))
            {
                throw new Exception("配置错误: OpenAuth:Host");
            }

            if (string.IsNullOrWhiteSpace(appKey))
            {
                throw new Exception("配置错误: OpenAuth:AppKey");
            }

            List<ProtectionScheme> lstProtectionScheme = new List<ProtectionScheme>();

            ProtectionScheme defaultScheam = new ProtectionScheme();
            configuration.Bind("DefaultScheme", defaultScheam);
            if (!string.IsNullOrWhiteSpace(defaultScheam.Key))
            {
                lstProtectionScheme.Add(defaultScheam);
            }

            AppProtectionView[] appProtectionView = new AppProtectionLoader(host).LoadData(user, appKey);
            ProtectionScheme[] protectionSchemes = appProtectionView.Select(app =>
            {
                ProtectionScheme appProtectionScheme = JsonConvert.DeserializeObject<ProtectionScheme>(app.AppProtectionScheme);
                appProtectionScheme.Key = app.AppKeyName;

                ProtectionScheme serProtectionScheme = JsonConvert.DeserializeObject<ProtectionScheme>(app.ServiceScheme);
                appProtectionScheme.IpAllowedList = appProtectionScheme.IpAllowedList.Union(serProtectionScheme.IpAllowedList).ToArray();

                appProtectionScheme.ApiProtections = MergeApiProtectionProlicies(serProtectionScheme, appProtectionScheme).ToArray();

                return appProtectionScheme;

            }).ToArray();

            lstProtectionScheme.AddRange(protectionSchemes);
            DicKeyAndScheme = lstProtectionScheme.ToDictionary(k => k.Key, Scheme => Scheme);
        }

        public ApiProtectionProlicy GetProlicy(ActionContext actionContext)
        {
            string key = GetApiName(actionContext);
            string clientId = actionContext.HttpContext.User.Claims.FirstOrDefault(x => x.Type.ToLower() == "client_id")?.Value;
            if (string.IsNullOrWhiteSpace(clientId))
            {
                clientId = "default";
            }

            ProtectionScheme scheme = DicKeyAndScheme[clientId];
            if (scheme == null)
            {
                return new ApiProtectionProlicy()
                {
                    Enable = false,
                    Key = key
                };
            }
            else
            {
                ApiProtectionProlicy apiProtection = scheme.GetApiProtectionProlicy(key);
                if (apiProtection == null)
                {
                    return new ApiProtectionProlicy()
                    {
                        Enable = false,
                        IpAllowedList = scheme.IpAllowedList,
                        Key = key
                    };
                }
                return apiProtection;
            }
        }

        protected virtual string GetApiName(ActionContext actionContext)
        {
            //string controller = actionContext.RouteData.Values["Controller"].ToString();
            //string action = actionContext.RouteData.Values["Action"].ToString();
            //return $"{controller}/{action}";

            string action = actionContext.RouteData.Values["Action"].ToString();
            return action;
        }

        List<ApiProtectionProlicy> MergeApiProtectionProlicies(ProtectionScheme serProtectionScheme, ProtectionScheme appProtectionScheme)
        {
            List<ApiProtectionProlicy> lstApiProtectionProlicies = new List<ApiProtectionProlicy>();
            lstApiProtectionProlicies.AddRange(appProtectionScheme.ApiProtections);

            foreach (var serApiItem in serProtectionScheme.ApiProtections)
            {
                ApiProtectionProlicy api =  lstApiProtectionProlicies
                    .FirstOrDefault(s => string.Equals(s.Key, serApiItem.Key, StringComparison.CurrentCultureIgnoreCase));

                if (api == null)
                {
                    lstApiProtectionProlicies.Add(serApiItem);
                }
                else
                {
                    api.IpAllowedList = api.IpAllowedList.Union(serApiItem.IpAllowedList).ToArray();

                    List<RequiredClaims> lstRequiredClaims = new List<RequiredClaims>();
                    lstRequiredClaims.AddRange(api.RequiredClaims);

                    foreach (var serReq in serApiItem.RequiredClaims)
                    {
                        RequiredClaims req = lstRequiredClaims.FirstOrDefault(s => string.Equals(s.ClaimType, serReq.ClaimType, StringComparison.CurrentCultureIgnoreCase));
                        if (req == null)
                        {
                            lstRequiredClaims.Add(serReq);
                        }
                        else
                        {
                            if (serReq.RequireAll)
                            {
                                req.RequireAll = true;
                            }
                            req.ClaimValues = req.ClaimValues.Union(serReq.ClaimValues).ToArray();
                        }
                    }
                }
            }

            return lstApiProtectionProlicies;
        }
    }
}
