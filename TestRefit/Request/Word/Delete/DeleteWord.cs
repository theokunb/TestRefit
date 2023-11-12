using MediatR;

namespace TestRefit.Request.Word.Delete
{
    public class DeleteWord : IRequest<Task>
    {
        public int Id { get; set; }
    }
}
