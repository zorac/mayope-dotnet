using System;

namespace Mayope.Auth
{
    public interface IAuthService
    {
        IToken Login(ICredentials credentials);
        IToken GetToken(Guid id);
        bool Logout(IToken token);
    }
}
