using Microsoft.EntityFrameworkCore;

namespace Model
{
    public class ModelContext : DbContext
    {
        public ModelContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Pharaoh> Pharaohs
        {
            get;
            set;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("data source=localhost;initial catalog=MigrationTest;Integrated Security=SSPI;MultipleActiveResultSets=True;App=EntityFramework");
            }
        }
    }
}