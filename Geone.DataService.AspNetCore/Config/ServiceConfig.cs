namespace Geone.DataHub.AspNetCore.Config
{
    public class ServerConfig
    {
        public string Host { get; set; } = "127.0.0.1";
        public int Port { get; set; } = 9293;
        public string Name { get; set; } = "datahub";
        public string BaseUrl { get { return $"http://{Host}:{Port}"; } }

        public override string ToString()
        {
            return $"http://{Host}:{Port};http://*:{Port};";
        }
    }
}
