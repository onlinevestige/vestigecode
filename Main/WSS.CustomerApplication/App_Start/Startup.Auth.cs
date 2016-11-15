﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System;
using WSS.Identity;

namespace WSS.CustomerApplication
{
    public partial class Startup
	{
	    public void ConfigureAuth(IAppBuilder app)
	    {
            // Configure the db context, user manager and signin manager to use a single instance per request
            app.CreatePerOwinContext(WssIdentityContext.Create);
            app.CreatePerOwinContext<WssIdentityUserManager>(WssIdentityUserManager.Create);
            app.CreatePerOwinContext<WssIdentitySignInManager>(WssIdentitySignInManager.Create);

            // Enable the application to use a cookie to store information for the signed in user
            // and to use a cookie to temporarily store information about a user logging in with a third party login provider
            // Configure the sign in cookie
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Login"),
                Provider = new CookieAuthenticationProvider
                {
                    // Enables the application to validate the security stamp when the user logs in.
                    // This is a security feature which is used when you change a password or add an external login to your account.  
                    OnValidateIdentity = SecurityStampValidator.OnValidateIdentity<WssIdentityUserManager, WssIdentityUser>(
                        validateInterval: TimeSpan.FromMinutes(30),
                        regenerateIdentity: (manager, user) => user.GenerateUserIdentityAsync(manager))
                }
            });
        }
    }
}