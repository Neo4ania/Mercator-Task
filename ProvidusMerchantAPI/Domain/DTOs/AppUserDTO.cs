namespace ProvidusMerchantAPI.Domain.DTOs
{
    public class AppUserDTO
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public IList<string> RoleName { get; set; }
    }
}
