using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DnD35EDMTools.Migrations
{
    /// <inheritdoc />
    public partial class ReworkAutomaticAndBonusLanguages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RequiredClass",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "RequiredRace",
                table: "Languages");

            migrationBuilder.RenameColumn(
                name: "IsBonus",
                table: "Languages",
                newName: "IsAutomatic");

            migrationBuilder.CreateTable(
                name: "ClassAutomaticLanguages",
                columns: table => new
                {
                    AutomaticLanguagesId = table.Column<int>(type: "INTEGER", nullable: false),
                    ClassDataId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassAutomaticLanguages", x => new { x.AutomaticLanguagesId, x.ClassDataId });
                    table.ForeignKey(
                        name: "FK_ClassAutomaticLanguages_Classes_ClassDataId",
                        column: x => x.ClassDataId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassAutomaticLanguages_Languages_AutomaticLanguagesId",
                        column: x => x.AutomaticLanguagesId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassBonusLanguages",
                columns: table => new
                {
                    BonusLanguagesId = table.Column<int>(type: "INTEGER", nullable: false),
                    ClassData1Id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassBonusLanguages", x => new { x.BonusLanguagesId, x.ClassData1Id });
                    table.ForeignKey(
                        name: "FK_ClassBonusLanguages_Classes_ClassData1Id",
                        column: x => x.ClassData1Id,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassBonusLanguages_Languages_BonusLanguagesId",
                        column: x => x.BonusLanguagesId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RaceAutomaticLanguages",
                columns: table => new
                {
                    AutomaticLanguagesId = table.Column<int>(type: "INTEGER", nullable: false),
                    RaceDataId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaceAutomaticLanguages", x => new { x.AutomaticLanguagesId, x.RaceDataId });
                    table.ForeignKey(
                        name: "FK_RaceAutomaticLanguages_Languages_AutomaticLanguagesId",
                        column: x => x.AutomaticLanguagesId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RaceAutomaticLanguages_Races_RaceDataId",
                        column: x => x.RaceDataId,
                        principalTable: "Races",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RaceBonusLanguages",
                columns: table => new
                {
                    BonusLanguagesId = table.Column<int>(type: "INTEGER", nullable: false),
                    RaceData1Id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaceBonusLanguages", x => new { x.BonusLanguagesId, x.RaceData1Id });
                    table.ForeignKey(
                        name: "FK_RaceBonusLanguages_Languages_BonusLanguagesId",
                        column: x => x.BonusLanguagesId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RaceBonusLanguages_Races_RaceData1Id",
                        column: x => x.RaceData1Id,
                        principalTable: "Races",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClassAutomaticLanguages_ClassDataId",
                table: "ClassAutomaticLanguages",
                column: "ClassDataId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassBonusLanguages_ClassData1Id",
                table: "ClassBonusLanguages",
                column: "ClassData1Id");

            migrationBuilder.CreateIndex(
                name: "IX_RaceAutomaticLanguages_RaceDataId",
                table: "RaceAutomaticLanguages",
                column: "RaceDataId");

            migrationBuilder.CreateIndex(
                name: "IX_RaceBonusLanguages_RaceData1Id",
                table: "RaceBonusLanguages",
                column: "RaceData1Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassAutomaticLanguages");

            migrationBuilder.DropTable(
                name: "ClassBonusLanguages");

            migrationBuilder.DropTable(
                name: "RaceAutomaticLanguages");

            migrationBuilder.DropTable(
                name: "RaceBonusLanguages");

            migrationBuilder.RenameColumn(
                name: "IsAutomatic",
                table: "Languages",
                newName: "IsBonus");

            migrationBuilder.AddColumn<string>(
                name: "RequiredClass",
                table: "Languages",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RequiredRace",
                table: "Languages",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
