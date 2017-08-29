using System;

namespace Mayope.Auth
{
    public interface IUser
    {
        string Username { get; }
        string Name { get; }
        string Email { get; }
    }
}
