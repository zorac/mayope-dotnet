using System;
using System.Collections.Generic;

using Microsoft.Extensions.Logging;

namespace Mayope.Auth.Mock
{
    public class MockAuthProvider : IAuthProvider
    {
        private ILogger Logger { get; }
        private IDictionary<Guid,MockToken> Tokens { get; }

        public MockAuthProvider(ILogger<MockAuthProvider> logger)
        {
            Logger = logger;
            Tokens = new Dictionary<Guid,MockToken>();
        }

        public IToken Login(ICredentials credentials)
        {
            if (credentials is UsernamePasswordCredentials)
            {
                var userPass = credentials as UsernamePasswordCredentials;
                var id = Guid.NewGuid();
                var user = new MockUser
                {
                    Username = userPass.Username
                };
                var token = new MockToken
                {
                    Id = id,
                    User = user
                };

                Tokens[id] = token;

                return token;
            }
            else
            {
                return null; // TODO throw exception?
            }
        }

        public IToken GetToken(Guid id)
        {
            MockToken token;

            if (Tokens.TryGetValue(id, out token))
            {
                return token;
            }
            else
            {
                return null;
            }
        }

        public bool Logout(IToken token)
        {
            if (token is MockToken)
            {
                return Tokens.Remove(token.Id);
            }
            else
            {
                return false;
            }
        }
    }
}
