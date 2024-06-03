using System.ComponentModel.DataAnnotations.Schema;

namespace ApiFichaAcademia.Models.Model
{
	[Table("TB_CARD_EXERCISE")]
	public class CardExercise
	{
		public int CardId { get; set; }
		public Card Card { get; set; }

		public int ExerciseId { get; set; }
		public Exercise Exercise { get; set; }
	}
}
