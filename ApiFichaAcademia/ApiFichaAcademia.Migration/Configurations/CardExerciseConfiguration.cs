using ApiFichaAcademia.Models.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiFichaAcademia.Migrations.Configurations
{
	public class CardExerciseConfiguration : IEntityTypeConfiguration<CardExercise>
	{
		public void Configure(EntityTypeBuilder<CardExercise> builder)
		{
			builder.HasKey(ce => new { ce.CardId, ce.ExerciseId });
			builder.HasOne(ce => ce.Card).WithMany(ce => ce.CardExercises).HasForeignKey(ce => ce.CardId);
			builder.HasOne(ce => ce.Exercise).WithMany(ce => ce.CardExercises).HasForeignKey(ce => ce.ExerciseId);
		}
	}
}
