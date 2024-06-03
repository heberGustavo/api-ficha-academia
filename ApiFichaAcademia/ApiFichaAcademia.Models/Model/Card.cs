using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiFichaAcademia.Models.Model
{
    [Table("TB_CARD")]
	public class Card
	{
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime DateStart { get; set; }

		[Required]
		public DateTime DateEnd { get; set; }
        
        public int IdClient { get; set; }

        [ForeignKey("IdClient")]
        public virtual Client Client { get; set; }

        public int IdObjective { get; set; }
        [ForeignKey("IdObjective")]
        public virtual Objective Objective { get; set; }

        public int IdTeacher { get; set; }
		[ForeignKey("IdTeacher")]
		public virtual Teacher Teacher { get; set; }

        public virtual ICollection<CardExercise> CardExercises { get; set; }
        
    }
}
