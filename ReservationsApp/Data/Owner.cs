using System.ComponentModel.DataAnnotations;
using MudBlazor;

namespace ReservationsApp.Data
{
	public class Owner
	{
		[Required]
		public string FirstName { get; set; }
		[Required]
		public string LastName { get; set; }
		[Required]
		public string Email { get; set; }
		[Required]
		public string Phone { get; set; }
		[Required]
		public string City { get; set; }
		[Required]
		public string State { get; set; }
		[Required]
		public string Address { get; set; }
		[Required]
		public string Zipcode { get; set; }
		public DateTime ArrivalDate { get; set; }
		[Required]
		public DateRange SkiDateRange { get; set; }

		public List<Skier> SkierList { get; set; }

	}
}
