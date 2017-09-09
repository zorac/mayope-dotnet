using System;

using Microsoft.Extensions.Logging;

using Mayope.Data;

namespace Mayope.Auth.Data
{
    public class DataAuthService : IAuthService
    {
        private IDataService DataService { get; }
        private ILogger Logger { get; }

        public DataAuthService(
            IDataService dataService,
            ILogger<DataAuthService> logger)
        {
            DataService = dataService;
            Logger = logger;
        }

        public IToken Login(ICredentials credentials)
        {
            return null; // TODO
        }

        public IToken GetToken(Guid id)
        {
            return null; // TODO
        }

        public bool Logout(IToken token)
        {
            return false; // TODO
        }
    }
}
