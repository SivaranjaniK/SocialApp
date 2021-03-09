using SocialApi.Models;

namespace SocialApi.Interface
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}