namespace Geone.DataHub.AspNetCore.Config
{
    public class Server
    {
        public string Host { get; set; } = "127.0.0.1";
        public int Port { get; set; } = 9293;
        public string Name { get; set; } = "datahub";
        public string ApiSecret { get; set; }
        public string BaseUrl { get { return $"http://{Host}:{Port}"; } }

        public override string ToString()
        {
            return $"http://{Host}:{Port};http://*:{Port};";
        }
    }
}
