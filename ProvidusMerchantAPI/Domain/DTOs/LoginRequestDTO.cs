using System.ComponentModel.DataAnnotations;

namespace ProvidusMerchantAPI.Domain.DTOs
{
    public class LoginRequestDTO
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
