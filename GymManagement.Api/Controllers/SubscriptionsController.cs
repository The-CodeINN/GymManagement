using GymManagement.Application.Subscriptions.Commands.CreateSubscription;
using GymManagement.Contracts.Subscriptions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GymManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class SubscriptionsController : ControllerBase
    {
        //private readonly IMediator _mediator;
        private readonly ISender _mediator;

        public SubscriptionsController(ISender mediator)
        {
            _mediator = mediator; 
        }

        [HttpPost]
        public async Task<IActionResult> CreateSubscription(CreateSubcriptionRequest request)
        {
            var command = new CreateSubcriptionCommand(
                request.SubscriptionType.ToString(), 
                request.AdminId);

            var createSubscriptionResult = await _mediator.Send(command);

            return createSubscriptionResult.MatchFirst(
                guid => Ok(new SubscriptionResponse(guid, request.SubscriptionType)), 
                error => Problem());

            //if (createSubscriptionResult.IsError)
            //{
            //    return Problem();
            //}

            //var response = new SubscriptionResponse(
            //    createSubscriptionResult.Value, 
            //    request.SubscriptionType);

            //return Ok(response);
        }
    }
}
