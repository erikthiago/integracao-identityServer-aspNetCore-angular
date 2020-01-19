using Microsoft.Extensions.Options;
using IdentityServerArtigo.Admin.Configuration.Interfaces;

namespace IdentityServerArtigo.Admin.Configuration
{
    public class RootConfiguration : IRootConfiguration
    {
        public IAdminConfiguration AdminConfiguration { get; set; }

        public RootConfiguration(IOptions<AdminConfiguration> adminConfiguration)
        {
            AdminConfiguration = adminConfiguration.Value;
        }
    }
}
