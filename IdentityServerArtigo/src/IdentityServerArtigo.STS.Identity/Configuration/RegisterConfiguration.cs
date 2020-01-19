using IdentityServerArtigo.STS.Identity.Configuration.Intefaces;

namespace IdentityServerArtigo.STS.Identity.Configuration
{
    public class RegisterConfiguration : IRegisterConfiguration
    {
        public bool Enabled { get; set; } = true;
    }
}
