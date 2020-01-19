using IdentityServerArtigo.STS.Identity.Configuration.Intefaces;

namespace IdentityServerArtigo.STS.Identity.Configuration
{
    public class AdminConfiguration : IAdminConfiguration
    {
        public string IdentityAdminBaseUrl { get; set; } = "http://localhost:9000";
    }
}