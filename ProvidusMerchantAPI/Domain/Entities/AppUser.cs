using Microsoft.AspNetCore.Identity;
using ProvidusMerchantAPI.Domain.Enums;
using System.Security.Cryptography.Xml;

namespace ProvidusMerchantAPI.Domain.Entities
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
        public string AccountId { get; set; }


        // Navigation Property
        public Account Account { get; set; }
    }
}

