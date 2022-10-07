using Duende.IdentityServer.Models;

namespace Twitter.DuendeServer.Configuration;

public static class DuendeConfig
{
    public static IEnumerable<ApiScope> Scopes = new[]
    {
        new ApiScope("Api", "My api")
    };

    public static IEnumerable<IdentityResource> Resources = new IdentityResource[]
    {
        new IdentityResources.OpenId(),
        new IdentityResources.Profile(),
    };

    public static IEnumerable<Client> Clients = new[]
    {
        new Client()
        {
            ClientId = "swagger",
            ClientSecrets = {new Secret("secret".Sha256())},
            AllowedGrantTypes = GrantTypes.ClientCredentials,
            AllowedScopes = {"Api"}
        }
    };


}