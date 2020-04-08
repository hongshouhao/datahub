namespace Geone.DataService.AspNetCore.Config
{
    public class ServerConfig
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public string Name { get; set; }
        public string BaseUrl { get { return $"http://{Host}:{Port}"; } }

        public override string ToString()
        {
            return $"http://{Host}:{Port};http://*:{Port};";
        }
    }
}
