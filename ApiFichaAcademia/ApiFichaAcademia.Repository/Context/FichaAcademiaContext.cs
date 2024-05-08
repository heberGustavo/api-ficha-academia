using ApiFichaAcademia.Models.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiFichaAcademia.Migrations.Context
{
	public class FichaAcademiaContext : DbContext
	{
        public FichaAcademiaContext(DbContextOptions<FichaAcademiaContext> option) : base(option) { }

        public DbSet<Teacher> Teachers { get; set; }
    }
}
