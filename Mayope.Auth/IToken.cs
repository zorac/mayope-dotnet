using System;

namespace Mayope.Auth
{
    public interface IToken
    {
        Guid Id { get; }
        IUser User { get; }
    }
}
