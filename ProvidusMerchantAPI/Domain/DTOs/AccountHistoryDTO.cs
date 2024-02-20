using ProvidusMerchantAPI.Domain.Enums;

namespace ProvidusMerchantAPI.Domain.DTOs
{
    public class AccountHistoryDTO
    {
        public int id { get; set; }
        public string ReferenceNumber { get; set; }
        public string Name { get; set; }
        public string AccountNumber { get; set; }
        public decimal Amount { get; set; }
        public string Narration { get; set; }
        public decimal AccountBalance { get; set; }
        public DateTime TransactionDate { get; set; } = DateTime.Now;
        public TimeSpan TransactionTime { get; set; } = DateTime.Now.TimeOfDay;
        public TransactionType TransactionType { get; set; }
        public string Bank { get; set; }
        public string Recepient { get; set; }

    }
}
