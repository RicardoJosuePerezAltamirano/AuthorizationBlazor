using Microsoft.AspNetCore.Components.Authorization;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BlazorDemoAuthClient
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        public override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var identity = new ClaimsIdentity(new[]
        {
            new Claim(ClaimTypes.Name, "Rik"),
            new Claim("Departament","Recursos Humanoss")
        },
        Microsoft.IdentityModel.Claims.AuthenticationTypes.Basic);
            
            var user = new ClaimsPrincipal(identity);

            return Task.FromResult(new AuthenticationState(user));
        }
    }
}
