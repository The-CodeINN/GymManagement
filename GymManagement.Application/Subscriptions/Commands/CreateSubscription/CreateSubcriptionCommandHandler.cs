using MediatR;
using ErrorOr;


namespace GymManagement.Application.Subscriptions.Commands.CreateSubscription;

public class CreateSubcriptionCommandHandler : IRequestHandler<CreateSubcriptionCommand, ErrorOr<Guid>>
{
    public async Task<ErrorOr<Guid>> Handle(CreateSubcriptionCommand request, CancellationToken cancellationToken)
    {
        return Guid.NewGuid();
    }
}
