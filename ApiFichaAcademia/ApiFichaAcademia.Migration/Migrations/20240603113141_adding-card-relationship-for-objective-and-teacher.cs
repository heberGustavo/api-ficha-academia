using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiFichaAcademia.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class addingcardrelationshipforobjectiveandteacher : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdObjective",
                table: "TB_CARD",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdTeacher",
                table: "TB_CARD",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TB_CARD_IdObjective",
                table: "TB_CARD",
                column: "IdObjective");

            migrationBuilder.CreateIndex(
                name: "IX_TB_CARD_IdTeacher",
                table: "TB_CARD",
                column: "IdTeacher");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_CARD_TB_OBJECTIVE_IdObjective",
                table: "TB_CARD",
                column: "IdObjective",
                principalTable: "TB_OBJECTIVE",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_CARD_TB_TEACHER_IdTeacher",
                table: "TB_CARD",
                column: "IdTeacher",
                principalTable: "TB_TEACHER",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_CARD_TB_OBJECTIVE_IdObjective",
                table: "TB_CARD");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_CARD_TB_TEACHER_IdTeacher",
                table: "TB_CARD");

            migrationBuilder.DropIndex(
                name: "IX_TB_CARD_IdObjective",
                table: "TB_CARD");

            migrationBuilder.DropIndex(
                name: "IX_TB_CARD_IdTeacher",
                table: "TB_CARD");

            migrationBuilder.DropColumn(
                name: "IdObjective",
                table: "TB_CARD");

            migrationBuilder.DropColumn(
                name: "IdTeacher",
                table: "TB_CARD");
        }
    }
}
