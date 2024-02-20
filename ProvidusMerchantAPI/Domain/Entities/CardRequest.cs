using ProvidusMerchantAPI.Domain.Enums;

namespace ProvidusMerchantAPI.Domain.Entities
{
    public class CardRequest
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string BatchNumber { get; set; }
        public int Quantity { get; set; }
        public CardType CardTypes { get; set; }
        public CardScheme CardScheme { get; set; }
        public Currency Currency { get; set; }
        public DateTime DateOfRequest { get; set; }
        public DateTime DateOfDelivery { get; set; }
        public RequestStatus RequestStatus { get; set; }
        public string AccountId { get; set; }


        // Navigation Property
        public Account Account { get; set; }
    }
}
