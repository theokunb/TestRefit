using MediatR;
using TestWebApi.Entity;

namespace TestWebApi.Request.ObserverCommands.Get
{
    public class GetObserverHandler : IRequestHandler<GetObserver, Observer>
    {
        public Task<Observer> Handle(GetObserver request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
