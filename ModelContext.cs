using Microsoft.EntityFrameworkCore;

namespace ef_core_team_migrations_demo_model
{
    public class ModelContext : DbContext
    {
        public ModelContext(DbContextOptions options)
            : base(options) { }

        public DbSet<Pharaoh> Pharaohs { get; set; }
    }
}
