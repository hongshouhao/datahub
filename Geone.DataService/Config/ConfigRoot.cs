using Newtonsoft.Json;
using System.IO;
using System.Runtime.Serialization;

namespace Geone.DataService.Config
{
    public class ConfigRoot
    {
        public static ConfigRoot Read(string jsonFile)
        {
            return JsonConvert.DeserializeObject<ConfigRoot>(File.ReadAllText(jsonFile));
        }

        public ConsulConfig Consul { get; set; }
        public ServerConfig Server { get; set; }

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
                Server.Name = "Data Service Center";
            }
        }
    }
}
