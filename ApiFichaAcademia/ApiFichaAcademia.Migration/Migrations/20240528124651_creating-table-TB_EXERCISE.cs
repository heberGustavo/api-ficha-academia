using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiFichaAcademia.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class creatingtableTB_EXERCISE : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_EXERCISE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IdLevel = table.Column<int>(type: "int", nullable: false),
                    LevelExerciceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_EXERCISE", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_EXERCISE_TB_LEVEL_EXERCISE_LevelExerciceId",
                        column: x => x.LevelExerciceId,
                        principalTable: "TB_LEVEL_EXERCISE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_EXERCISE_LevelExerciceId",
                table: "TB_EXERCISE",
                column: "LevelExerciceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_EXERCISE");
        }
    }
}
