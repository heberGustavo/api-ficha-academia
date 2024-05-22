using System.ComponentModel.DataAnnotations;

namespace ApiFichaAcademia.Models.DTO
{
	public class ClientDTO
	{
		public int Id { get; set; }

		[Required, StringLength(50)]
		public string Name { get; set; }

		[Required, Range(1, 200)]
		public int Age { get; set; }

		[Required, Range(1, 999)]
		public double Weight { get; set; }

		[Required, Range(1, 7)]
		public int WeeklyFrequency { get; set; }
	}
}
