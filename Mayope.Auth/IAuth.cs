namespace Mayope.Auth
{
    public interface IAuth
    {
        IToken Token { get; }
        IUser User { get; }
    }
}
