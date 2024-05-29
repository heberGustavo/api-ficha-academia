using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiFichaAcademia.Models.Model
{
    [Table("TB_CARD")]
	public class Card
	{
        [Key]
        public int Id { get; set; }
        public int IdClient { get; set; }
        public int IdExercise { get; set; }

        [Required]
        public DateTime DateStart { get; set; }

		[Required]
		public DateTime DateEnd { get; set; }

        [ForeignKey("IdClient")]
        public virtual Client Client { get; set; }

        [ForeignKey("IdExercise")]
        public virtual ICollection<Exercise> Exercises { get; set; }
        
    }
}
