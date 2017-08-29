using System;

namespace Mayope.Api.Responses
{
    public class LoginResponse : IResponse
    {
        public Guid Token { get; set; }
    }
}
