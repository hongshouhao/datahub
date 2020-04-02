using Geone.IdentityServer4.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;

namespace Geone.DataService.AspNetCore.Config
{
    public class ConfigRoot
    {
        public static ConfigRoot Read(string jsonFile)
        {
            return JsonConvert.DeserializeObject<ConfigRoot>(File.ReadAllText(jsonFile));
        }

        public ConsulConfig Consul { get; set; }
        public ServerConfig Server { get; set; }
        public IdS4Config IdentityServer { get; set; }
        public string[] IPSafeList { get; set; }
        public Dictionary<string,string[]> ActionRoles { get; set; }

        [OnDeserialized]
        internal void OnDeserializedMethod(StreamingContext context)
        {
            if (Server == null)
                Server = new ServerConfig();

            if (Server.Port == 0)
            {
                Server.Port = 9293;
            }

            if (string.IsNullOrWhiteSpace(Server.Host))
            {
                Server.Host = "127.0.0.1";
            }

            if (string.IsNullOrWhiteSpace(Server.Name))
            {
                Server.Name = "DataHub";
            }

            Server.Name = Server.Name?.Replace(" ", "");
        }
    }
}
