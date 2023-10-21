
namespace Api.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}