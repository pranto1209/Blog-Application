using Microsoft.AspNetCore.Identity;

namespace BlogApplicationAPI.Repositories.Interface
{
    public interface ITokenRepository
    {
        string CreateJwtToken(IdentityUser user, List<string> roles);
    }
}
