using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
        public DbSet<Categories> Categories { get; set; }
    }
}
