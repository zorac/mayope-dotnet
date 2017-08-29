using System;

namespace Mayope.Auth
{
    public class StandardAuth : IAuth
    {
        public IToken Token { get; set; }
        public IUser User => Token.User;
    }
}
