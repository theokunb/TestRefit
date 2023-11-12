using Microsoft.EntityFrameworkCore;
using TestRefit.Entity;

namespace TestRefit
{
    public class WordDbContext : DbContext, IWordDbContext
    {
        public WordDbContext(DbContextOptions<WordDbContext> options): base(options) { }

        public DbSet<Word> Words { get; set; }
    }

    public class DbInitializer
    {
        public static void Initialize(DbContext dbContext)
        {
            dbContext.Database.Migrate();
        }
    }
}
