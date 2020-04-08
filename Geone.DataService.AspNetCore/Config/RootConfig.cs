using Geone.IdentityServer4.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;

namespace Geone.DataService.AspNetCore.Config
{
    public class RootConfig
    {
        public static RootConfig Value { get; private set; }
        public static RootConfig Read()
        {
            if (File.Exists("appsettings.json"))
            {
                Value = JsonConvert.DeserializeObject<RootConfig>(File.ReadAllText("appsettings.json"));
            }
            else
            {
                Value = new RootConfig()
                {
                    Server = new ServerConfig()
                    {
                        Host = "127.0.0.1",
                        Port = 9293,
                        Name = serviceName
                    }
                };
            }
            return Value;
        }

        public ConsulConfig Consul { get; set; }
        public ServerConfig Server { get; set; }
        public IdSAdminConfig IdSAdmin { get; set; }
        public IdSServerConfig IdSServer { get; set; }

        const string serviceName = "datahub";
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
                Server.Name = serviceName;
            }

            Server.Name = Server.Name?.Replace(" ", "");
        }
    }
}
