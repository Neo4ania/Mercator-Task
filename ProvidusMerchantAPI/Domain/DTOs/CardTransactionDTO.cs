using ProvidusMerchantAPI.Domain.Enums;

namespace ProvidusMerchantAPI.Domain.DTOs
{
    public class CardTransactionDTO
    {
        public string CardName { get; set; }
        public string CardNumber { get; set; }
        public decimal CardBalance { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string InvoiceNumber { get; set; }
        public string Location { get; set; }
        public string RecepientName { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public CardStatus CardStatus { get; set; }
        public CardTransactionStatus CardTransactionStatus { get; set; }
    }
}
