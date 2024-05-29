using System.ComponentModel.DataAnnotations;

namespace ApiFichaAcademia.Models.DTO
{
	public class ExerciseDTO
	{
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		[Required, Range(1, 3)]
		public int IdLevel { get; set; }
	}
}
