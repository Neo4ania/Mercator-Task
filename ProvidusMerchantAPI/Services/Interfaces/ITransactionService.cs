using ProvidusMerchantAPI.Domain.DTOs;
using ProvidusMerchantAPI.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProvidusMerchantAPI.Services.Interfaces
{
    public interface ITransactionService
    {
        Task<(IEnumerable<AccountHistoryDTO>, int)> GetPaginatedAccountHistoryAsync(PaginationFilter paginationFilter);
        Task<IEnumerable<AccountHistoryDTO>> SearchAccountHistoryAsync(SearchDTO searchDto);
        Task<IEnumerable<AccountHistoryDTO>> FilterAccountHistoryAsync(FilterByTimeDTO filterByTimeDTO);
    }
}
