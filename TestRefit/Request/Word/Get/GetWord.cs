using MediatR;

namespace TestRefit.Request.Word.Get
{
    public class GetWord : IRequest<Entity.Word>
    {
        public int Id { get; set; }
    }
}
