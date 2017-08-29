using System;

namespace Mayope.Auth
{
    public class AuthorizationException : Exception
    {
        public AuthorizationException(string message) : base(message)
        {
        }
    }
}
