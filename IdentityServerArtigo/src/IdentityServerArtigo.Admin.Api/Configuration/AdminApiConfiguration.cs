using IdentityServerArtigo.Admin.Api.Configuration.Constants;

namespace IdentityServerArtigo.Admin.Api.Configuration
{
    public class AdminApiConfiguration
    {
        public string IdentityServerBaseUrl { get; set; } = AuthorizationConsts.IdentityServerBaseUrl;

        public string OidcSwaggerUIClientId { get; set; } = AuthorizationConsts.OidcSwaggerUIClientId;

        public string OidcApiName { get; set; } = AuthorizationConsts.OidcApiName;
    }
}