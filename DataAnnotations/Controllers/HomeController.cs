using DataAnnotations.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DataAnnotations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        [HttpPost("length")]
        public IActionResult Length([FromBody] Length length)
        {
            if (!ModelState.IsValid) {  return BadRequest(); }
            return Ok(length);
        }

        [HttpPost("base64")]
        public IActionResult Base64String([FromBody] Base64String baseString)
        {
            if (!ModelState.IsValid) { return BadRequest(); }
            return Ok(baseString);
        }

        [HttpPost("allowedValues")]
        public IActionResult AllowedValues([FromBody] AllowedValues allowedValues)
        {
            if (!ModelState.IsValid) { return BadRequest(); }
            return Ok(allowedValues);
        }

        [HttpPost("DeniedValues")]
        public IActionResult DeniedValues([FromBody] DeniedValues deniedValues)
        {
            if (!ModelState.IsValid) { return BadRequest(); }
            return Ok(deniedValues);
        }

        [HttpPost("Range")]
        public IActionResult Range([FromBody] ExemploRange range)
        {
            if (!ModelState.IsValid) { return BadRequest(); }
            return Ok(range);
        }

        [HttpPost("Validation")]
        public IActionResult LetraMaiscula([FromBody] Pessoa pessoa)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return Ok(pessoa);
        }

    }
}
