using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiFichaAcademia.Models.Model
{
	[Table("TB_CLIENT")]
	public class Client
	{
        [Key]
        public int Id { get; set; }

		[Required, StringLength(50)]
		public string Name { get; set; }

        [Required, Range(1, 200)]
        public int Age { get; set; }

        [Required, Range(1, 999)]
        public double Weight { get; set; }

        [Required, Range(1, 7)]
        public int WeeklyFrequency { get; set; }

        //person has a Objective, Teacher and Card
    }
}
