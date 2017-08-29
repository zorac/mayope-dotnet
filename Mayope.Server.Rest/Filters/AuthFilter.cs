using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

using Mayope.Api.Requests;
using Mayope.Auth;

namespace Mayope.Server.Rest.Filters
{
    public class AuthFilter : IActionFilter
    {
        private IAuthProvider AuthProvider { get; }
        private IAuth Auth { get; }
        private ILogger Logger { get; }

        public AuthFilter(
            IAuthProvider authProvider,
            IAuth auth,
            ILogger<AuthFilter> logger)
        {
            AuthProvider = authProvider;
            Auth = auth;
            Logger = logger;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var request = context.ActionArguments["request"];

            if (request is AuthRequest)
            {
                var standardAuth = Auth as StandardAuth;
                var authRequest = request as AuthRequest;
                var token = AuthProvider.GetToken(authRequest.Token);

                if (token == null)
                {
                    throw new AuthorizationException("Not authenticated");
                }
                else
                {
                    standardAuth.Token = token;
                }
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            // do nothing
        }
    }
}
