using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiFichaAcademia.Models.Model
{
    [Table("TB_TEACHER")]
	public class Teacher
	{
        [Key]
        public int Id { get; set; }

        [Required, StringLength(50)]
		public string Name { get; set; }

		[StringLength(50)]
		public string? Phone { get; set; }

        [Required]
        public int Period { get; set; } //period enum
    }
}
