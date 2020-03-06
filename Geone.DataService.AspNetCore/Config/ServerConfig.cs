namespace Geone.DataService.AspNetCore.Config
{
    public class ServerConfig
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"http://{Host}:{Port};http://*:{Port};";
        }
    }
}
