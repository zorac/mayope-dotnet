using System;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Mayope.Api;
using Mayope.Api.Requests;
using Mayope.Api.Responses;

namespace Mayope.Server.Http.Controllers
{
    public class AuthController : Controller
    {
        private IMayopeService Service { get; }
        private ILogger Logger { get; }

        public AuthController(
            IMayopeService service,
            ILogger<AuthController> logger)
        {
            Service = service;
            Logger = logger;
        }

        [HttpPost("Login")]
        public LoginResponse Login(
            [FromBody] LoginRequest request)
        {
            return Service.Login(request);
        }

        [HttpPost("Logout")]
        public LogoutResponse Logout(
            [FromBody] LogoutRequest request)
        {
            return Service.Logout(request);
        }
    }
}
