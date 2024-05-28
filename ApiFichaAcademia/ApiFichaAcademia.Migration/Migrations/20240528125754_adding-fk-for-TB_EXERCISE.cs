using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiFichaAcademia.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class addingfkforTB_EXERCISE : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdLevel",
                table: "TB_EXERCISE",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TB_EXERCISE_IdLevel",
                table: "TB_EXERCISE",
                column: "IdLevel");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_EXERCISE_TB_LEVEL_EXERCISE_IdLevel",
                table: "TB_EXERCISE",
                column: "IdLevel",
                principalTable: "TB_LEVEL_EXERCISE",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_EXERCISE_TB_LEVEL_EXERCISE_IdLevel",
                table: "TB_EXERCISE");

            migrationBuilder.DropIndex(
                name: "IX_TB_EXERCISE_IdLevel",
                table: "TB_EXERCISE");

            migrationBuilder.DropColumn(
                name: "IdLevel",
                table: "TB_EXERCISE");
        }
    }
}
