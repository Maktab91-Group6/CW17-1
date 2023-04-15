using CW17_1.Entity;
using Microsoft.EntityFrameworkCore;

namespace CW17_1.DAL
{
	public class AppDbContext:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
			//optionsBuilder.UseSqlServer(
			//	@"Server=.;Initial Catalog=CW17 ;TrustServerCertificate=True;integrated security=True");
			optionsBuilder.LogTo(Console.WriteLine);

		}





		public AppDbContext(DbContextOptions options)
			: base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new UserConfiguration());
			modelBuilder.ApplyConfiguration(new AddressConfiguration());

			//modelBuilder.Entity<User>().Property(c=>c.Name).IsRequired();
		}




		public DbSet<User> Members { get; set; }
		public DbSet<Address> Addresses { get;set; }



	}
}
