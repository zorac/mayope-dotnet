using Mayope.Api.Requests;
using Mayope.Api.Responses;
using Mayope.Auth;

namespace Mayope.Server
{
    public interface IServer
    {
        LoginResponse handle(LoginRequest request);

        LogoutResponse handle(LogoutRequest request, IAuth auth);
    }
}
