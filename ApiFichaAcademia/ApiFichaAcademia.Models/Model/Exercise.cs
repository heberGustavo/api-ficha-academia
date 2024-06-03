using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiFichaAcademia.Models.Model
{
    [Table("TB_EXERCISE")]
	public class Exercise
	{
        [Key]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }

		[Required, Range(1, 3)]
		public int IdLevel { get; set; }

        [ForeignKey("IdLevel")]
        public virtual LevelExercise LevelExercise { get; set; }

        public virtual ICollection<CardExercise> CardExercises { get; set; }
    }
}
