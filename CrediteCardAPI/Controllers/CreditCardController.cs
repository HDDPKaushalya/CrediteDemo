using CrediteCardAPI.Helpers;
using Microsoft.AspNetCore.Mvc;
using CrediteCardAPI.Models;

namespace CrediteCardAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CreditCardController : Controller
    {
        [HttpPost("Validate")]
        public IActionResult ValidateCard(CreditCard creditCard)
        {
            if (!CreditCardValidator.IsValidCardNumber(creditCard.CardNumber))
            {
                return BadRequest(new { message = "Invalid card number." });
            }

            string cardType = CreditCardValidator.GetCardType(creditCard.CardNumber);

            return Ok(new
            {
                message = "Card is valid.",
                cardType = cardType
            });
        }

    }
}

