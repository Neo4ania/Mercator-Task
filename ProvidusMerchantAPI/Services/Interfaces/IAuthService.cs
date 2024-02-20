using ProvidusMerchantAPI.Domain.DTOs;
using ProvidusMerchantAPI.Domain.Generics;

namespace ProvidusMerchantAPI.Services.Interfaces
{
    public interface IAuthService
    {
        Task<Result<LoginResponseDTO>> Login(LoginRequestDTO loginRequestDTO);
        Task<Result<AppUserDTO>> Register(RegistrationRequestDTO requestDTO);
        Task<Result<bool>> AssignRole(string email, string roleName);
    }
}
