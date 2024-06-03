using ApiFichaAcademia.Migrations.Configurations;
using ApiFichaAcademia.Models.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiFichaAcademia.Migrations.Context
{
	public class FichaAcademiaContext : DbContext
	{
        public FichaAcademiaContext(DbContextOptions<FichaAcademiaContext> option) : base(option) { }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Objective> Objectives { get; set; }
        public DbSet<LevelExercise> LevelExercise { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<CardExercise> CardExercises { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.ApplyConfiguration(new CardExerciseConfiguration());
		}
	}
}
