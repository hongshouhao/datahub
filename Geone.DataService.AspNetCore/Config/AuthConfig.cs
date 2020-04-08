using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geone.DataService.AspNetCore.Config
{
    public class AuthConfig
    {
        public bool Enable { get; set; } = true;
        public string[] IpAllowedList { get; set; }
        public ServiceRolePolicy[] Services { get; set; }

        public ServiceRolePolicy TryGetService(string service)
        {
            return Services?.FirstOrDefault(x => x.Service.ToLower() == service.ToLower());
        }
    }

    public class ServiceRolePolicy
    {
        [JsonProperty("Name")]
        public string Service { get; set; }
        public bool RequireAll { get; set; }
        public string[] RequiredRoles { get; set; }
    }
}
