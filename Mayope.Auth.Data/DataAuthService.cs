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
            throw new NotImplementedException();
        }

        public IToken GetToken(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Logout(IToken token)
        {
            throw new NotImplementedException();
        }
    }
}
