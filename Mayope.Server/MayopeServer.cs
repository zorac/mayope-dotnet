using System.Collections.Generic;
using System.Linq;

using Microsoft.Extensions.Logging;

using Mayope.Api;
using Mayope.Api.Requests;
using Mayope.Api.Responses;
using Mayope.Api.Types;
using Mayope.Auth;
using Mayope.Core;
using Mayope.Data;
using Mayope.Meta;

namespace Mayope.Server
{
    public class MayopeServer : IMayopeService
    {
        private IDataService DataService { get; }
        private IMetaService MetaService { get; }
        private IAuthService AuthService { get; }
        private ILogger Logger { get; }

        public MayopeServer(
            IDataService dataService,
            IMetaService metaService,
            IAuthService authService,
            ILogger<MayopeServer> logger)
        {
            DataService = dataService;
            MetaService = metaService;
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
            var token = AuthService.GetToken(request.Token);
            IList<IForest> forests;

            if (request.Parent == null)
            {
                forests = MetaService.GetRootForests();
            }
            else
            {
                forests = MetaService.GetChildForests(request.Parent);
            }

            return new ListForestsResponse
            {
                Parent = request.Parent,
                Forests = forests.Select(f => new Forest()).ToList() // TODO!
            };
        }

        public ListTreesResponse ListTrees(ListTreesRequest request)
        {
            var token = AuthService.GetToken(request.Token);

            return new ListTreesResponse
            {
                Forest = request.Forest,
                Trees = MetaService.GetTrees(request.Forest)
                    .Select(t => new Tree()).ToList() // TODO!
            };
        }

        public ListBranchesResponse ListBranches(ListBranchesRequest request)
        {
            var token = AuthService.GetToken(request.Token);

            return new ListBranchesResponse
            {
                Tree = request.Tree,
                Branches = MetaService.GetBranches(request.Tree)
                    .Select(b => new Branch()).ToList() // TODO!
            };
        }
    }
}
