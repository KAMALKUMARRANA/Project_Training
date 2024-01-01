﻿using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using System.Security.Claims;

namespace BlazorServerAuthenticationAndAuthorization.Authentication
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly ProtectedSessionStorage sessionStorage;
        private ClaimsPrincipal _anonymous=new ClaimsPrincipal(new ClaimsIdentity() );

        public CustomAuthenticationStateProvider(ProtectedSessionStorage sessionStorage)
        {
            this.sessionStorage = sessionStorage;
        }
        public override async Task<AuthenticationState>  GetAuthenticationStateAsync()
        {
            try
            { 

                var userSessionStorageResult = await sessionStorage.GetAsync<UserSession>("UserSession");
                var userSession = userSessionStorageResult.Success ? userSessionStorageResult.Value : null;
                if (userSession == null)
                {
                    return await Task.FromResult(new AuthenticationState(_anonymous));
                }
                var claimsPrinciple = new ClaimsPrincipal(new ClaimsIdentity(new List<Claim>
            {
                new Claim(ClaimTypes.Name,userSession.UserName),
                new Claim(ClaimTypes.Role,userSession.Role)
            }, "CustomAuth"

                    ));
                return await Task.FromResult(new AuthenticationState(claimsPrinciple));
            }
            catch 
            {
                return await Task.FromResult(new AuthenticationState(_anonymous));
            }
        }

        public async Task UpdateAuthenticationState(UserSession userSession)
        {
            ClaimsPrincipal claimsPrincipal;
            if(userSession != null)
            {
                await sessionStorage.SetAsync("UserSession",userSession);
                claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new List<Claim>
            {
                new Claim(ClaimTypes.Name,userSession.UserName),
                new Claim(ClaimTypes.Role,userSession.Role)
            }));
            }
            else
            {
                await sessionStorage.DeleteAsync("UserSession");
                claimsPrincipal=_anonymous;
            }
        }
    }
}
