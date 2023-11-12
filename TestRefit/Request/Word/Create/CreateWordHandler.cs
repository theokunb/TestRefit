using AutoMapper;
using MediatR;

namespace TestRefit.Request.Word.Create
{
    public class CreateWordHandler : IRequestHandler<CreateWord, Entity.Word>
    {
        private readonly IWordDbContext _context;
        private readonly IMapper _mapper;

        public CreateWordHandler(IWordDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Entity.Word> Handle(CreateWord request, CancellationToken cancellationToken)
        {
            var word = _mapper.Map<CreateWord, Entity.Word>(request);

            var res = await _context.Words.AddAsync(word);
            await _context.SaveChangesAsync(cancellationToken);

            return res.Entity;
        }
    }
}
