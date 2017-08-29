using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Mayope.Api.Requests;
using Mayope.Api.Responses;
using Mayope.Auth;

namespace Mayope.Server.Rest.Controllers
{
    [Route("auth")]
    public class AuthController : Controller
    {
        private IServer Server;
        private ILogger Logger;

        public AuthController(
            IServer server,
            ILogger<AuthController> logger)
        {
            Server = server;
            Logger = logger;
        }

        [HttpPost("login")]
        public LoginResponse Login(
            [FromBody] LoginRequest request)
        {
            return Server.handle(request);
        }

        [HttpPost("logout")]
        public LogoutResponse Logout(
            [FromBody] LogoutRequest request,
            [FromServices] IAuth auth)
        {
            return Server.handle(request, auth);
        }
    }
}
