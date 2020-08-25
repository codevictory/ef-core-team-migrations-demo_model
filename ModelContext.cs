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
    }
}