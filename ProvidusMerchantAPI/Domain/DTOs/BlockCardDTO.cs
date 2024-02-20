namespace ProvidusMerchantAPI.Domain.DTOs
{
    public class BlockCardDTO
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string AccountNumber { get; set; }
        public decimal ReasonForBlockingAccount { get; set; }
        public int Pin { get; set; }

    }
}
