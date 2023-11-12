using MediatR;
using Microsoft.EntityFrameworkCore;

namespace TestRefit.Request.Word.Delete
{
    public class DeleteWordHandler : IRequestHandler<DeleteWord, Task>
    {
        private readonly IWordDbContext _context;

        public DeleteWordHandler(IWordDbContext context)
        {
            _context = context;
        }

        public async Task<Task> Handle(DeleteWord request, CancellationToken cancellationToken)
        {
            var entity = await _context.Words.Where(element => element.Id == request.Id).FirstOrDefaultAsync();

            if (entity == null)
            {
                return Task.CompletedTask;
            }

            _context.Words.Remove(entity);
            await _context.SaveChangesAsync(cancellationToken);

            return Task.CompletedTask;
        }
    }
}
