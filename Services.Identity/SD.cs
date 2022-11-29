using Duende.IdentityServer;
using Duende.IdentityServer.Models;
using System.Collections.Generic;

namespace FinalP.Services.Identity
{
    public static class SD
    {
        public const string Admin = "Admin";
        public const string Etudiant = "Etudiant";

        public static IEnumerable<IdentityResource> identityResources => new List<IdentityResource>
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Email(),
            new IdentityResources.Profile()

        };

        public static IEnumerable<IdentityResource> IdentityResources { get; internal set; }

        public static IEnumerable<ApiScope> ApiScopes => new List<ApiScope> { new ApiScope("FinalP", "FinalP Server"),
            new ApiScope(name:"read", displayName:"Read your data"),
            new ApiScope(name:"write", displayName:"Write your data"),
            new ApiScope(name:"delete", displayName:"Delete your data"),
        };
        public static IEnumerable<Client> Clients =>
            new List<Client>
            {
                new Client
                {
                    ClientId = "Client",
                    ClientSecrets = { new Secret("sercret".Sha256()) },
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    AllowedScopes = { "read", "write", "profile" }
                },
                new Client
                {
                    ClientId = "Client",
                    ClientSecrets = { new Secret("sercret".Sha256()) },
                    AllowedGrantTypes = GrantTypes.Code,
                    RedirectUris = { "http://localhost:44353/signin-oidc" },
                    PostLogoutRedirectUris = { "http://localhost:44353/singout-callback-oidc" },
                    AllowedScopes = new List<string>
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        IdentityServerConstants.StandardScopes.Email,
                        "FinalP"
                    }

                },
            };
    }
}

