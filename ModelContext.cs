using Microsoft.EntityFrameworkCore;

namespace Model
{
    public partial class ModelContext : DbContext
    {
        public ModelContext() { }
        public ModelContext(DbContextOptions options) : base(options) { }

        public DbSet<Pharaoh> Pharaohs { get; set; }
        public DbSet<Sargophagus> Sargophagi { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("data source=localhost;initial catalog=MigrationTest;Integrated Security=SSPI;MultipleActiveResultSets=True;App=EntityFramework");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) { }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}