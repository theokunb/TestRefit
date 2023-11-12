using MediatR;

namespace TestRefit.Request.Word.Update
{
    public class UpdateWord : IRequest<Entity.Word>
    {
        public int Id { get; set; }
        public string Value { get; set; }
    }
}
