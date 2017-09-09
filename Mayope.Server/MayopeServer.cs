using Microsoft.Extensions.Logging;

using Mayope.Api;
using Mayope.Api.Requests;
using Mayope.Api.Responses;
using Mayope.Auth;
using Mayope.Data;

namespace Mayope.Server
{
    public class MayopeServer : IMayopeService
    {
        private IDataService DataService { get; }
        private IAuthService AuthService { get; }
        private ILogger Logger { get; }

        public MayopeServer(
            IDataService dataService,
            IAuthService authService,
            ILogger<MayopeServer> logger)
        {
            DataService = dataService;
            AuthService = authService;
            Logger = logger;
        }

        public LoginResponse Login(LoginRequest request)
        {
            var token = AuthService.Login(new UsernamePasswordCredentials
            {
                Username = request.Username,
                Password = request.Password
            });

            return new LoginResponse
            {
                Token = token.Id
            };
        }

        public LogoutResponse Logout(LogoutRequest request)
        {
            var token = AuthService.GetToken(request.Token);

            return new LogoutResponse
            {
                Success = AuthService.Logout(token)
            };
        }

        public ListForestsResponse ListForests(ListForestsRequest request)
        {
            throw new System.NotImplementedException();
        }

        public ListTreesResponse ListTrees(ListTreesRequest request)
        {
            throw new System.NotImplementedException();
        }

        public ListBranchesResponse ListBranches(ListBranchesRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}
