using System.ComponentModel.DataAnnotations;

namespace ReservationsApp.Data
{
	public class Skier
	{
		[Required]
		public string Name { get; set; }
		[Required]
		public string Height { get; set; }
		[Required]
		public string Weight { get; set; }
		public int? Age { get; set; }
		public decimal? ShoeSize { get; set; }
		[Required]
		public int SkierType { get; set; }
		[Required]
		public bool Insurance { get; set; }
		[Required]
		public string SkiOrBoard { get; set; }
		[Required]
		public string SkiPackage { get; set; }
		public int DailyRentalPrice { get; set; }
		public int TotalRentalPrice { get; set; }
	}
}
