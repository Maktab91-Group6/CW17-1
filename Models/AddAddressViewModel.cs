using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Cors;

namespace CW17_1.Models
{
	public class AddAddressViewModel
	{
		
		public int UserId { get; set; }
		[Display(Name = "عنوان")]
		public string Title { get; set; }
		[Display(Name = "جزئیات")]
		public string Description { get; set; }
	}
}
