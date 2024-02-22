using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DnD35EDMTools.Migrations
{
    /// <inheritdoc />
    public partial class AddedGenders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Gender = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RacGendersSkinColourJoinTable",
                columns: table => new
                {
                    GendersId = table.Column<int>(type: "INTEGER", nullable: false),
                    RaceGendersId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RacGendersSkinColourJoinTable", x => new { x.GendersId, x.RaceGendersId });
                    table.ForeignKey(
                        name: "FK_RacGendersSkinColourJoinTable_Genders_GendersId",
                        column: x => x.GendersId,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RacGendersSkinColourJoinTable_Races_RaceGendersId",
                        column: x => x.RaceGendersId,
                        principalTable: "Races",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RacGendersSkinColourJoinTable_RaceGendersId",
                table: "RacGendersSkinColourJoinTable",
                column: "RaceGendersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RacGendersSkinColourJoinTable");

            migrationBuilder.DropTable(
                name: "Genders");
        }
    }
}
