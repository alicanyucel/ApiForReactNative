using ApiForReactNative.Application.Features.Auth.Login;
using ApiForReactNative.Domain.Entities;

namespace ApiForReactNative.Application.Services
{
    public interface IJwtProvider
    {
        Task<LoginCommandResponse> CreateToken(AppUser user);
    }
}
