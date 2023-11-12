using MediatR;
using Microsoft.EntityFrameworkCore;

namespace TestRefit.Request.Word.Update
{
    public class UpdateWordHandler : IRequestHandler<UpdateWord, Entity.Word>
    {
        private readonly IWordDbContext _context;

        public UpdateWordHandler(IWordDbContext context)
        {
            _context = context;
        }

        public async Task<Entity.Word> Handle(UpdateWord request, CancellationToken cancellationToken)
        {
            var entity = await _context.Words.Where(elenet => elenet.Id == request.Id).FirstOrDefaultAsync();

            if (entity == null)
            {
                return null;
            }

            entity.Value = request.Value;
            await _context.SaveChangesAsync(cancellationToken);

            return entity;
        }
    }
}
