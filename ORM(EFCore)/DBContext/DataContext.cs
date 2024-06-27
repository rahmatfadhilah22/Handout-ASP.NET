using Microsoft.EntityFrameworkCore;
using ORM_EFCore_.Models;

namespace ORM_EFCore_.DBContext
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options) { }
		public DbSet<Categories> Categories { get; set; }
	}
}
