using ProvidusMerchantAPI.Domain.DTOs;
using ProvidusMerchantAPI.Domain.Entities;


namespace ProvidusMerchantAPI.Services.Interfaces
{
    public interface ICardService
    {
        Task<IEnumerable<CardListDTO>> GetAllCardAsync();
        Task<IEnumerable<CardListDTO>> SearchCardListHistoryAsync(SearchDTO searchDto);
    }
}
