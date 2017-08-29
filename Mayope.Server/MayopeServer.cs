using Microsoft.Extensions.Logging;

using Mayope.Api.Requests;
using Mayope.Api.Responses;
using Mayope.Auth;
using Mayope.Data;

namespace Mayope.Server
{
    public class MayopeServer : IServer
    {
        private IDataProvider DataProvider { get; }
        private IAuthProvider AuthProvider { get; }
        private ILogger Logger { get; }

        public MayopeServer(
            IDataProvider dataProvider,
            IAuthProvider authProvider,
            ILogger<MayopeServer> logger)
        {
            DataProvider = dataProvider;
            AuthProvider = authProvider;
            Logger = logger;
        }

        public LoginResponse handle(LoginRequest request)
        {
            var token = AuthProvider.Login(new UsernamePasswordCredentials
            {
                Username = request.Username,
                Password = request.Password
            });

            return new LoginResponse
            {
                Token = token.Id
            };
        }

        public LogoutResponse handle(LogoutRequest request, IAuth auth)
        {
            return new LogoutResponse
            {
                Success = AuthProvider.Logout(auth.Token)
            };
        }
    }
}
