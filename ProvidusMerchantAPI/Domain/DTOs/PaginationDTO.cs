namespace ProvidusMerchantAPI.Domain.DTOs
{
    public class PaginationDTO<T>
    {
        public int count { get; set; }
        public int perPage { get; set; }
        public int CurrentPage { get; set; }
        public IEnumerable<T> entity { get; set; }

        public PaginationDTO(int count, int perPage, int CurrentPage, IEnumerable<T> entity)
        {
            this.count = count;
            this.perPage = perPage;
            this.CurrentPage = CurrentPage;
            this.entity = entity;
        }

    }
}
