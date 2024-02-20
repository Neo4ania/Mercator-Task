namespace ProvidusMerchantAPI.Domain.DTOs
{
    public class FundCardDTO
    {
        public string Id { get; set; } = Guid.NewGuid().ToString(); 
        public string AccountNumber { get; set; }
        public decimal Amount { get; set; }
        public int Pin { get; set; }
    }
}
