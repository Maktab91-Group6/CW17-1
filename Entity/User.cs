using System.ComponentModel.DataAnnotations;

namespace CW17_1.Entity
{
	public class User
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }

		public bool IsDeleted { get; set; }

		public Address? Address { get; set; }
		public Guid? AddressId { get; set; }



		public User()
		{
			IsDeleted=false;
		}
	}
}
