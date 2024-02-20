using Microsoft.AspNetCore.Mvc;
using ProvidusMerchantAPI.Domain.DTOs;
using ProvidusMerchantAPI.Services.Interfaces;


namespace ProvidusMerchantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly ICardService _cardService;

        public CardController(ICardService cardService)
        {
            _cardService = cardService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCards()
        {
            try
            {
                var cards = await _cardService.GetAllCardAsync();
                return Ok(cards);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost("search")]
        public async Task<IActionResult> SearchCardHistory([FromBody] SearchDTO searchDto)
        {
            try
            {
                var filteredCards = await _cardService.SearchCardListHistoryAsync(searchDto);
                return Ok(filteredCards);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
