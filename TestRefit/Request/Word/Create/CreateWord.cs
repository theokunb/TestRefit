using MediatR;

namespace TestRefit.Request.Word.Create
{
    public class CreateWord : IRequest<Entity.Word>
    {
        public string Value { get; set; }
    }
}
