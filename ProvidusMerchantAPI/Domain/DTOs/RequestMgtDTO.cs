using ProvidusMerchantAPI.Domain.Entities;
using ProvidusMerchantAPI.Domain.Enums;

namespace ProvidusMerchantAPI.Domain.DTOs
{
    public class RequestMgtDTO
    {
        public string BatchNumber { get; set; }
        public int Quantity { get; set; }
        public CardType CardTypes { get; set; }
        public CardScheme CardScheme { get; set; }
        public Currency Currency { get; set; }
        public DateTime DateOfRequest { get; set; }
        public DateTime DateOfDelivery { get; set; }
        public RequestStatus RequestStatus { get; set; }

    }
}
