using CW17_1.Entity;
using Microsoft.EntityFrameworkCore;

namespace CW17_1.DAL
{
	public class AppDbContext:DbContext
	{
		//protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		//{
		//	base.OnConfiguring(optionsBuilder);
		//	optionsBuilder.UseSqlServer(
		//		@"Server=.;Initial Catalog=CW17 ;TrustServerCertificate=True;integrated security=True");

		//}

		public AppDbContext(DbContextOptions options)
			: base(options)
		{
		}

		public DbSet<User> Members { get; set; }




	}
}
