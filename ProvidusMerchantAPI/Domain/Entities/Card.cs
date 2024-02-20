using ProvidusMerchantAPI.Domain.Enums;

namespace ProvidusMerchantAPI.Domain.Entities
{
    public class Card
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string CardHolderName { get; set; }
        public string CardNumber { get; set; }
        public string Cvv { get; set; }
        public decimal CardBalance { get; set; }
        public DateTime CardExpiryDate { get; set; }
        public CardType CardTypes { get; set; }
        public CardStatus CardStatus { get; set; }
        public string AccountId { get; set; }

        // Navigation Property
        public Account Account { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }
}
