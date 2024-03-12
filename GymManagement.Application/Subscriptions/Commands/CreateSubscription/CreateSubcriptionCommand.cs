using MediatR;
using ErrorOr;


namespace GymManagement.Application.Subscriptions.Commands.CreateSubscription
{
    public record CreateSubcriptionCommand(string SubscriptionType, Guid AdminId) : IRequest<ErrorOr<Guid>>;
    
}
