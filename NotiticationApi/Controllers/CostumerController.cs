using Microsoft.AspNetCore.Mvc;
using NotiticationApi.Models;
using NotiticationApi.Notification;

namespace NotiticationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CostumerController : ControllerBase
    {
        private readonly NotificationContext _notificationContext;
        public CostumerController(NotificationContext notificationContext)
        {
            _notificationContext = notificationContext;
        }

        [HttpPost("CustomerComException")]
        public void PostException(CustomerComException customer)
        {
            var c = new CustomerComException("", "");
        }

        [HttpPost("CustomerComNotification")]
        public IActionResult PostNotification(CustomerComNotification customer)
        {
            var c = new CustomerComNotification("", "");
            if (c.Invalid)
            {
                _notificationContext.AddNotifications(c.ValidationResult);
            }

            return Ok(c);
        }
    }
}
