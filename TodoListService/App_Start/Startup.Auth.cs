using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using Microsoft.Owin.Security;
using Owin;
using System.IdentityModel.Tokens;
using TodoListService.App_Start;
using Microsoft.Owin.Security.Jwt;
using Microsoft.Owin.Security.OAuth;

namespace TodoListService
{
    public partial class Startup
    {
        private static string clientId = ConfigurationManager.AppSettings["ida:Audience"];

        public void ConfigureAuth(IAppBuilder app)
        {
            // TODO: Set up OWIN for OAuth authentication.
        }
    }
}
