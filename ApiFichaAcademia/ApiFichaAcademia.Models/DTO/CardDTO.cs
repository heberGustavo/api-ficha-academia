using System.ComponentModel.DataAnnotations;

namespace ApiFichaAcademia.Models.DTO
{
	public class CardDTO
	{
		public int Id { get; set; }
		public int IdClient { get; set; }
		public int IdExercise { get; set; }

		[Required]
		public DateTime DateStart { get; set; }
		
		[Required]
		public DateTime DateEnd { get; set; }
	}
}
