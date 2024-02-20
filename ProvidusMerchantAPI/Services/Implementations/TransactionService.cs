using Microsoft.EntityFrameworkCore;
using ProvidusMerchantAPI.Data;
using ProvidusMerchantAPI.Domain.DTOs;
using ProvidusMerchantAPI.Domain.Entities;
using ProvidusMerchantAPI.Domain.Enums;
using ProvidusMerchantAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ProvidusMerchantAPI.Services.Implementations
{
    public class TransactionService : ITransactionService
    {
        private readonly MerchantDBContext _dbContext;

        public TransactionService(MerchantDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<(IEnumerable<AccountHistoryDTO>, int)> GetPaginatedAccountHistoryAsync(PaginationFilter paginationFilter)
        {
            try
            {
                var query = _dbContext.AccountHistories.Include(a => a.Account).AsQueryable();

                // Calculate total count for pagination
                var totalCount = await query.CountAsync();

                // Apply pagination
                var skipAmount = (paginationFilter.CurrentPage - 1) * paginationFilter.PerPage;
                query = query.Skip(skipAmount).Take(paginationFilter.PerPage);

                var accountHistoryDTOs = await query.Select(a => new AccountHistoryDTO
                {
                    id = a.Id,
                    ReferenceNumber = a.ReferenceNumber,
                    Name = a.Account.AppUser.Name,
                    AccountNumber = a.AccountNumber,
                    Amount = a.Amount,
                    Narration = a.Narration,
                    AccountBalance = a.Account.AccountBalance,
                    TransactionDate = a.Date,
                    TransactionTime = a.Time,
                    TransactionType = a.TransactionType,
                    Bank = a.Bank,
                    Recepient = a.Recepient
                }).ToListAsync();

                return (accountHistoryDTOs, totalCount);
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                throw;
            }
        }

        public async Task<IEnumerable<AccountHistoryDTO>> SearchAccountHistoryAsync(SearchDTO searchDto)
        {
            try
            {
                var query = _dbContext.AccountHistories.Include(a => a.Account).AsQueryable();

                // Apply search criteria
                if (!string.IsNullOrEmpty(searchDto.SearchString))
                {
                    query = query.Where(a =>
                        a.ReferenceNumber.Contains(searchDto.SearchString) ||
                        a.Account.AppUser.Name.Contains(searchDto.SearchString) ||
                        a.AccountNumber.Contains(searchDto.SearchString) ||
                        a.Narration.Contains(searchDto.SearchString) ||
                        a.Bank.Contains(searchDto.SearchString) ||
                        a.Recepient.Contains(searchDto.SearchString));
                }  

                // Execute the query and project the results to DTOs
                var result = await query.Select(a => new AccountHistoryDTO
                {
                    // Populate DTO properties here
                    id = a.Id,
                    ReferenceNumber = a.ReferenceNumber,
                    Name = a.Account.AppUser.Name,
                    AccountNumber = a.AccountNumber,
                    Amount = a.Amount,
                    Narration = a.Narration,
                    AccountBalance = a.Account.AccountBalance,
                    TransactionDate = a.Date,
                    TransactionTime = a.Time,
                    TransactionType = a.TransactionType,
                    Bank = a.Bank,
                    Recepient = a.Recepient
                }).ToListAsync();

                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<IEnumerable<AccountHistoryDTO>> FilterAccountHistoryAsync(FilterByTimeDTO filterByTimeDTO)
        {
            try
            {
                var query = _dbContext.AccountHistories.Include(a => a.Account).AsQueryable();

                // Apply filter criteria
                if (filterByTimeDTO.Date != default)
                {
                    query = query.Where(a => a.Date.Date == filterByTimeDTO.Date.Date);
                }
                else if (filterByTimeDTO.Week != default)
                {
                    query = query.Where(a => CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(a.Date, CultureInfo.CurrentCulture.DateTimeFormat.CalendarWeekRule, CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek) == filterByTimeDTO.Week);
                }
                else if (filterByTimeDTO.Month != default)
                {
                    query = query.Where(a => a.Date.Month == filterByTimeDTO.Month);
                }
                else if (filterByTimeDTO.Year != default)
                {
                    query = query.Where(a => a.Date.Year == filterByTimeDTO.Year);
                }
                else
                {
                    throw new ArgumentException("Invalid filter criteria provided.");
                }

                // Execute the query and project the results to DTOs
                var result = await query.Select(a => new AccountHistoryDTO
                {
                    // Populate DTO properties here
                    id = a.Id,
                    ReferenceNumber = a.ReferenceNumber,
                    Name = a.Account.AppUser.Name,
                    AccountNumber = a.AccountNumber,
                    Amount = a.Amount,
                    Narration = a.Narration,
                    AccountBalance = a.Account.AccountBalance,
                    TransactionDate = a.Date,
                    TransactionTime = a.Time,
                    TransactionType = a.TransactionType,
                    Bank = a.Bank,
                    Recepient = a.Recepient
                }).ToListAsync();

                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
