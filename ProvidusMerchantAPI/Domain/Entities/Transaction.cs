using ProvidusMerchantAPI.Domain.Enums;

namespace ProvidusMerchantAPI.Domain.Entities
{
    public class Transaction
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string InvoiceId { get; set; }
        public string CardId { get; set; }
        public DateTime Date { get; set; }
        public string Recipient { get; set; }
        public decimal Amount { get; set; }
        public TransactionType TransactionType { get; set; }
        public string Location { get; set; }
        public CardTransactionStatus CardTransactionStatus { get; set; }

        public Card Card { get; set; }
    }
}
