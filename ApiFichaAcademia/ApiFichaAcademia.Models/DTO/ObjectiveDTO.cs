using System.ComponentModel.DataAnnotations;

namespace ApiFichaAcademia.Models.DTO
{
	public class ObjectiveDTO
	{
		public int Id { get; set; }

		[Required, StringLength(50)]
		public string Name { get; set; }

		[Required, StringLength(200)]
		public string Description { get; set; }
	}
}
