using System;

namespace Mayope.Auth.Mock
{
    public class MockToken : IToken
    {
        public Guid Id { get; set; }
        public IUser User { get; set; }
    }
}
