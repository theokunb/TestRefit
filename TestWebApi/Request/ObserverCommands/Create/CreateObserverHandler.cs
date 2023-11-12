using MediatR;
using TestWebApi.Entity;
using TestWebApi.Request.ObserveCommands.Create;

namespace TestWebApi.Request.ObserverCommands.Create
{
    public class CreateObserverHandler : IRequestHandler<CreateObserver, Observer>
    {
        public Task<Observer> Handle(CreateObserver request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
