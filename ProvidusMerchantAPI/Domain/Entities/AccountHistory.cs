using ProvidusMerchantAPI.Domain.Enums;

namespace ProvidusMerchantAPI.Domain.Entities
{
    public class AccountHistory
    {
        public int Id { get; set; }
        public string ReferenceNumber { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public int Amount { get; set; }
        public string Recepient { get; set; }
        public string Narration { get; set; }
        public DateTime Date { get; set; } = DateTime.Now.Date;
        public TimeSpan Time { get; set; } = DateTime.Now.TimeOfDay;
        public TransactionType TransactionType { get; set; }
        public string Bank { get; set; }
        public string AccountId { get; set; }


        // Navigation Properties
        public Account Account { get; set; } // An Account has a one-to-one relationship with User/
    }
}