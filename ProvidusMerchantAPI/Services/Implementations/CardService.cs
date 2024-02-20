using Microsoft.EntityFrameworkCore;
using ProvidusMerchantAPI.Data;
using ProvidusMerchantAPI.Domain.DTOs;
using ProvidusMerchantAPI.Services.Interfaces;


namespace ProvidusMerchantAPI.Services.Implementations
{
    public class CardService : ICardService
    {
        private readonly MerchantDBContext _context;

        public CardService(MerchantDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CardListDTO>> GetAllCardAsync()
        {
            try
            {
                var cards = await _context.Cards.ToListAsync();

                // Map Card entities to DTOs
                var cardListDTOs = cards.Select(card => new CardListDTO
                {
                    Id = card.Id,
                    CardName = card.CardHolderName,
                    CardNumber = card.CardNumber,
                    AccountNumber = card.Account?.AccountNumber, 
                    CardExpiryDate = card.CardExpiryDate
                });

                return cardListDTOs;
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public async Task<IEnumerable<CardListDTO>> SearchCardListHistoryAsync(SearchDTO searchDto)
        {
            try
            {
                var query = _context.Cards.AsQueryable();

                // Apply filtering conditions based on the searchDto properties
                if (!string.IsNullOrEmpty(searchDto.SearchString))
                {
                    query = query.Where(card => card.CardHolderName.Contains(searchDto.SearchString));
                }

                var filteredCards = await query.ToListAsync();

                // Map the filtered cards to CardListDTOs
                var cardListDTOs = filteredCards.Select(card => new CardListDTO
                {
                    Id = card.Id,
                    CardName = card.CardHolderName,
                    CardNumber = card.CardNumber,
                    AccountNumber = card.Account?.AccountNumber, 
                    CardExpiryDate = card.CardExpiryDate
                });

                return cardListDTOs;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
