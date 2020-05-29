namespace Geone.IdentityServer4.Client
{
    public class IdSConfig
    {
        public string ApiBaseUrl { get; set; }
        public string Authority { get; set; }
        public string ClientId { get; set; } = "identity-client";
        public string ClientSecret { get; set; }
        public string GrantType { get; set; } = "password";
        public string UserName { get; set; } = "admin";
        public string Password { get; set; } = "Pa$$word123";
        public string Scopes { get; set; }
    }
}
