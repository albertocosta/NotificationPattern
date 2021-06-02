using Microsoft.AspNetCore.Mvc;
using NotiticationApi.Models;

namespace NotiticationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CostumerController : ControllerBase
    {
        [HttpPost]
        public void Post(Customer customer)
        {
            var c = new Customer("", "");
        }
    }
}
