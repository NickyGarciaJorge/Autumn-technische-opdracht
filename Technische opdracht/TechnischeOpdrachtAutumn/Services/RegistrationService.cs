using Microsoft.AspNetCore.Mvc;
using TechnischeOpdrachtAutumn.Models;

namespace TechnischeOpdrachtAutumn.Services
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegistrationService : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult> RegisterAsync([FromBody] UserRegistrationModel model)
        {
            //var httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:5001/") };
            //var response = await httpClient.PostAsJsonAsync("api/register", model);

            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            //if (response.IsSuccessStatusCode)
            //{
            //    var result = await response.Content.ReadAsStringAsync();
            //    return Ok(new { message = $"Registratie gebruiker: {model.Username} successvol."});
            //}
            //else
            //{
            //    return Conflict(new { message = $"Registratie gebruiker: {model.Username} mislukt." });
            //}

            return Ok(new { message = $"Registratie gebruiker: {model.Username} succesvol." });
        }
    }
}
