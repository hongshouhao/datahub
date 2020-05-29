using Geone.IdentityServer4.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;

namespace Geone.DataHub.AspNetCore.Config
{
    public class AppSettings
    {
        public static AppSettings Value { get; private set; }
        public static AppSettings Read()
        {
            if (File.Exists("appsettings.json"))
            {
                Value = JsonConvert.DeserializeObject<AppSettings>(File.ReadAllText("appsettings.json"));
            }
            else
            {
                Value = new AppSettings()
                {
                    Server = new Server()
                };
            }
            return Value;
        }

        public MetadataDb MetadataDb { get; set; }
        public Consul Consul { get; set; }
        public Server Server { get; set; }
        public IdSConfig IdentityServer { get; set; }

        [OnDeserialized]
        internal void OnDeserializedMethod(StreamingContext context)
        {
            if (Server == null)
                Server = new Server();
            Server.Name = Server.Name?.Replace(" ", "");
        }
    }
}
