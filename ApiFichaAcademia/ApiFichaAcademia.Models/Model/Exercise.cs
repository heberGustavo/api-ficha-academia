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
        public int IdLevel { get; set; }

        [ForeignKey("IdLevel")]
        public virtual LevelExercise LevelExercise { get; set; }
    }
}
