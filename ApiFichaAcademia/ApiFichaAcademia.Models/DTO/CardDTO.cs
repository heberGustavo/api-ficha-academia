using System.ComponentModel.DataAnnotations;

namespace ApiFichaAcademia.Models.DTO
{
	public class CardDTO
	{
		public int Id { get; set; }

		[Required]
		public DateTime DateStart { get; set; }

		[Required]
		public DateTime DateEnd { get; set; }

		[Required]
		public int IdClient { get; set; }

		[Required]
		public int IdObjective { get; set; }

		[Required]
		public int IdTeacher { get; set; }
	}
}
