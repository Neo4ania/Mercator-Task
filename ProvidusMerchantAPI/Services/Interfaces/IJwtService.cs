using ProvidusMerchantAPI.Domain.Entities;

namespace ProvidusMerchantAPI.Services.Interfaces
{
    public interface IJwtService
    {
        string GenerateToken(AppUser appUser, IEnumerable<string> roles);
    }
}
