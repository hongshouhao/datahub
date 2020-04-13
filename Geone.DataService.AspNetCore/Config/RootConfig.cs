using Geone.IdentityServer4.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;

namespace Geone.DataHub.AspNetCore.Config
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
                };
            }
            return Value;
        }

        public ConsulConfig Consul { get; set; }
        public ServerConfig Server { get; set; }
        public IdSAdminConfig IdSAdmin { get; set; }
        public IdSServerConfig IdSServer { get; set; }

        [OnDeserialized]
        internal void OnDeserializedMethod(StreamingContext context)
        {
            if (Server == null)
                Server = new ServerConfig();
            Server.Name = Server.Name?.Replace(" ", "");
        }
    }
}
