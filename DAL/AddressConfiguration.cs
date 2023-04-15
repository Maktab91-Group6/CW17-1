using CW17_1.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CW17_1.DAL;

public class AddressConfiguration : IEntityTypeConfiguration<Address>
{
	public void Configure(EntityTypeBuilder<Address> builder)
	{
		builder.HasKey(o => o.Id);
		builder.Property(e => e.Id).ValueGeneratedOnAdd().HasDefaultValueSql("newid()");

	}
}