using MediatR;
using Microsoft.EntityFrameworkCore;

namespace TestRefit.Request.Word.Get
{
    public class GetWordHandler : IRequestHandler<GetWord, Entity.Word>
    {
        private readonly IWordDbContext _context;

        public GetWordHandler(IWordDbContext context)
        {
            _context = context;
        }

        public async Task<Entity.Word> Handle(GetWord request, CancellationToken cancellationToken)
        {
            var res = await _context.Words.Where(element => element.Id == request.Id).FirstOrDefaultAsync();

            return res;
        }
    }
}
