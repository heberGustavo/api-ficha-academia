using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiFichaAcademia.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class creatingtablecardExercise : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_CARD",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdClient = table.Column<int>(type: "int", nullable: false),
                    DateStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateEnd = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CARD", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_CARD_TB_CLIENT_IdClient",
                        column: x => x.IdClient,
                        principalTable: "TB_CLIENT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_CARD_EXERCISE",
                columns: table => new
                {
                    CardId = table.Column<int>(type: "int", nullable: false),
                    ExerciseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CARD_EXERCISE", x => new { x.CardId, x.ExerciseId });
                    table.ForeignKey(
                        name: "FK_TB_CARD_EXERCISE_TB_CARD_CardId",
                        column: x => x.CardId,
                        principalTable: "TB_CARD",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_CARD_EXERCISE_TB_EXERCISE_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "TB_EXERCISE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_CARD_IdClient",
                table: "TB_CARD",
                column: "IdClient");

            migrationBuilder.CreateIndex(
                name: "IX_TB_CARD_EXERCISE_ExerciseId",
                table: "TB_CARD_EXERCISE",
                column: "ExerciseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_CARD_EXERCISE");

            migrationBuilder.DropTable(
                name: "TB_CARD");
        }
    }
}
