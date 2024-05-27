using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiFichaAcademia.Models.Model
{
	[Table("TB_OBJECTIVE")]
	public class Objective
	{
		[Key]
		public int Id { get; set; }

		[Required, StringLength(50)]
		public string Name { get; set; }

		[Required, StringLength(200)]
        public string Description { get; set; }
    }
}
