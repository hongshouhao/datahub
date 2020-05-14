namespace Geone.DataHub.AspNetCore.Config
{
    public class Server
    {
        public string Protocol { get; set; } = "http";
        public string Host { get; set; } = "127.0.0.1";
        public int Port { get; set; } = 9293;
        public string Name { get; set; } = "datahub";
        public string VirtualPath { get; set; }
        public string ApiSecret { get; set; }
        public string BaseUrl
        {
            get
            {
                string url = $"{Protocol}://{Host}:{Port}/";
                if (!string.IsNullOrWhiteSpace(VirtualPath))
                {
                    url += VirtualPath;
                }

                return url.TrimEnd('/');
            }
        }

        public string ApiProtectionProvider { get; set; }

        public override string ToString()
        {
            return $"http://{Host}:{Port};http://*:{Port};";
        }
    }
}
