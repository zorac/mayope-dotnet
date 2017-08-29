using System;

using Microsoft.Extensions.Logging;

using Mayope.Data;

namespace Mayope.Auth.Data
{
    public class DataAuthProvider : IAuthProvider
    {
        private IDataProvider DataProvider { get; }
        private ILogger Logger { get; }

        public DataAuthProvider(
            IDataProvider dataProvider,
            ILogger<DataAuthProvider> logger)
        {
            DataProvider = dataProvider;
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
