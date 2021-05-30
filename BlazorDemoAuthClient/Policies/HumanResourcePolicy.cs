using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemoAuthClient.Policies
{
    public static class HumanResourcePolicy
    {
        public const string CanUserForHumanResource = "CanUserForHumanResource";
        public static AuthorizationPolicy IsHumanResourceEmployee()
        {
            return new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .RequireClaim("Departament", "Recursos Humanos")
                .Build();
                
        }
    }
}
