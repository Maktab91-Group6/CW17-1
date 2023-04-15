using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CW17_1.Entity
{
	public class Address
	{
		
		public Guid Id { get; set; }
		public string Title { get; set; }

		public string Description { get; set; }

		//public User User { get; set; }
		//public int UserId { get; set; }



	}
}
