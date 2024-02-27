using GymManagement.Contracts.Subscriptions;
using Microsoft.AspNetCore.Mvc;

namespace GymManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscriptionsController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateSubscription(CreateSubcriptionRequest request)
        {
            return Ok(request);
        }
    }
}
