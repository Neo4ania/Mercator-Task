namespace ProvidusMerchantAPI.Domain.DTOs
{
    public class CardListDTO
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string CardName { get; set; }
        public string CardNumber { get; set; } = Guid.NewGuid().ToString();
        public string AccountNumber { get; set; }
        public decimal CardBalance { get; set; }
        public DateTime CardExpiryDate { get; set; }
    }
}
