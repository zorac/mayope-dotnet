using System;

namespace Mayope.Auth.Mock
{
    public class MockUser : IUser
    {
        public string Username { get; set; }
        public string Name => this.Username;
        public string Email => this.Username;
    }
}
