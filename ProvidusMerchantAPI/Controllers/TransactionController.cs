using Microsoft.AspNetCore.Mvc;
using ProvidusMerchantAPI.Domain.DTOs;
using ProvidusMerchantAPI.Services.Interfaces;


namespace ProvidusMerchantAPI.Controllers
{
    [ApiController]
    [Route("api")]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService _transactionService;

        public TransactionController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpGet("account-history")]
        public async Task<IActionResult> GetPaginatedAccountHistoryAsync([FromQuery] PaginationFilter paginationFilter)
        {
            try
            {
                // Fetch account history data based on pagination
                var (accountHistory, totalCount) = await _transactionService.GetPaginatedAccountHistoryAsync(paginationFilter);

                // Construct pagination response
                var paginationResponse = new PaginationDTO<AccountHistoryDTO>(
                    totalCount,
                    paginationFilter.PerPage,
                    paginationFilter.CurrentPage,
                    accountHistory.ToList()
                );

                return Ok(paginationResponse);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("search-account-history")]
        public async Task<IActionResult> SearchAccountHistory([FromQuery] SearchDTO searchDto)
        {
            try
            {
                // Search account history data based on search criteria
                var searchResults = await _transactionService.SearchAccountHistoryAsync(searchDto);

                return Ok(searchResults);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("filter-account-history")]
        public async Task<IActionResult> FilterAccountHistory([FromQuery] FilterByTimeDTO filterByTimeDTO)
        {
            try
            {
                // Filter account history data based on filter criteria
                var filteredResults = await _transactionService.FilterAccountHistoryAsync(filterByTimeDTO);

                return Ok(filteredResults);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}

//try
//{
//    var searchResults = await _transactionService.SearchAccountHistoryAsync(searchDto);

//    
//    // var paginatedResults = searchResults.Skip((paginationFilter.CurrentPage - 1) * paginationFilter.PerPage).Take(paginationFilter.PerPage);

//    return Ok(searchResults);
//}
//catch (Exception ex)
//{
//    return StatusCode(500, ex.Message);
//}