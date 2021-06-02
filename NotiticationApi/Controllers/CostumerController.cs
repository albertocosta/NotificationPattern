using Microsoft.AspNetCore.Mvc;
using NotiticationApi.Models;

namespace NotiticationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CostumerController : ControllerBase
    {
        [HttpPost("CustomerComException")]
        public void PostException(CustomerComException customer)
        {
            var c = new CustomerComException("", "");
        }

        [HttpPost("CustomerComNotification")]
        public IActionResult PostNotification(CustomerComNotification customer)
        {
            var c = new CustomerComNotification("", "");
            //TODO: Tratar os dados, talvez no ControllerBase
            if (c.Invalid)
            {
                var m = c.ValidationResult;
                return BadRequest(m.Errors);
            }

            return Ok(c);
        }
    }
}
