using Microsoft.EntityFrameworkCore;
using TestRefit.Entity;

namespace TestRefit
{
    public interface IWordDbContext
    {
        DbSet<Word> Words { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
