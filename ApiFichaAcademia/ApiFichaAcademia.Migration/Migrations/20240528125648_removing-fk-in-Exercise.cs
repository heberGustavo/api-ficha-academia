using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiFichaAcademia.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class removingfkinExercise : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_EXERCISE_TB_LEVEL_EXERCISE_LevelExerciceId",
                table: "TB_EXERCISE");

            migrationBuilder.DropIndex(
                name: "IX_TB_EXERCISE_LevelExerciceId",
                table: "TB_EXERCISE");

            migrationBuilder.DropColumn(
                name: "IdLevel",
                table: "TB_EXERCISE");

            migrationBuilder.DropColumn(
                name: "LevelExerciceId",
                table: "TB_EXERCISE");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdLevel",
                table: "TB_EXERCISE",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LevelExerciceId",
                table: "TB_EXERCISE",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TB_EXERCISE_LevelExerciceId",
                table: "TB_EXERCISE",
                column: "LevelExerciceId");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_EXERCISE_TB_LEVEL_EXERCISE_LevelExerciceId",
                table: "TB_EXERCISE",
                column: "LevelExerciceId",
                principalTable: "TB_LEVEL_EXERCISE",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
