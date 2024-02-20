using ProvidusMerchantAPI.Domain.Enums;


namespace ProvidusMerchantAPI.Domain.Entities
{
    public class Account
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string AccountNumber { get; set; }
        public decimal AccountBalance { get; set; }
        public string AccountType { get; set; }
        public int Pin {  get; set; }
        public string AppUserId { get; set; }
        public string AccountHistoryId { get; set; }



        // Navigation Properties
        public AppUser AppUser { get; set; } // An Account has a one-to-one relationship with User
        public ICollection<Transaction> Transactions { get; set; } // An Account has a one-to-many relationship with Transaction
        public ICollection<Card> Cards { get; set; } // An Account has a one-to-many relationship with Card
        public ICollection<CardRequest> CardRequests { get; set; } // An Account has a one-to-many relationship with Request
        public ICollection<AccountHistory> AccountHistories { get; set; }
    }
}
