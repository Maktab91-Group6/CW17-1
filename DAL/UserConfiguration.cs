using CW17_1.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CW17_1.DAL;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
	public void Configure(EntityTypeBuilder<User> builder)
	{
		builder.HasKey(o => o.Id);
		builder.ToTable("Users");
		builder.HasOne(user => user.Address).WithOne().HasForeignKey<User>(user => user.AddressId);

	}
}