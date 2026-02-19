using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DnD35EDMTools.Migrations
{
    /// <inheritdoc />
    public partial class RenameJoinTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassAutomaticLanguages_Classes_ClassDataId",
                table: "ClassAutomaticLanguages");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassAutomaticLanguages_Languages_AutomaticLanguagesId",
                table: "ClassAutomaticLanguages");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassBonusLanguages_Classes_ClassData1Id",
                table: "ClassBonusLanguages");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassBonusLanguages_Languages_BonusLanguagesId",
                table: "ClassBonusLanguages");

            migrationBuilder.DropForeignKey(
                name: "FK_RaceAutomaticLanguages_Languages_AutomaticLanguagesId",
                table: "RaceAutomaticLanguages");

            migrationBuilder.DropForeignKey(
                name: "FK_RaceAutomaticLanguages_Races_RaceDataId",
                table: "RaceAutomaticLanguages");

            migrationBuilder.DropForeignKey(
                name: "FK_RaceBonusLanguages_Languages_BonusLanguagesId",
                table: "RaceBonusLanguages");

            migrationBuilder.DropForeignKey(
                name: "FK_RaceBonusLanguages_Races_RaceData1Id",
                table: "RaceBonusLanguages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RaceBonusLanguages",
                table: "RaceBonusLanguages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RaceAutomaticLanguages",
                table: "RaceAutomaticLanguages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClassBonusLanguages",
                table: "ClassBonusLanguages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClassAutomaticLanguages",
                table: "ClassAutomaticLanguages");

            migrationBuilder.RenameTable(
                name: "RaceBonusLanguages",
                newName: "JoinTableRaceBonusLanguages");

            migrationBuilder.RenameTable(
                name: "RaceAutomaticLanguages",
                newName: "JoinTableRaceAutomaticLanguages");

            migrationBuilder.RenameTable(
                name: "ClassBonusLanguages",
                newName: "JoinTableClassBonusLanguages");

            migrationBuilder.RenameTable(
                name: "ClassAutomaticLanguages",
                newName: "JoinTableClassAutomaticLanguages");

            migrationBuilder.RenameIndex(
                name: "IX_RaceBonusLanguages_RaceData1Id",
                table: "JoinTableRaceBonusLanguages",
                newName: "IX_JoinTableRaceBonusLanguages_RaceData1Id");

            migrationBuilder.RenameIndex(
                name: "IX_RaceAutomaticLanguages_RaceDataId",
                table: "JoinTableRaceAutomaticLanguages",
                newName: "IX_JoinTableRaceAutomaticLanguages_RaceDataId");

            migrationBuilder.RenameIndex(
                name: "IX_ClassBonusLanguages_ClassData1Id",
                table: "JoinTableClassBonusLanguages",
                newName: "IX_JoinTableClassBonusLanguages_ClassData1Id");

            migrationBuilder.RenameIndex(
                name: "IX_ClassAutomaticLanguages_ClassDataId",
                table: "JoinTableClassAutomaticLanguages",
                newName: "IX_JoinTableClassAutomaticLanguages_ClassDataId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JoinTableRaceBonusLanguages",
                table: "JoinTableRaceBonusLanguages",
                columns: new[] { "BonusLanguagesId", "RaceData1Id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_JoinTableRaceAutomaticLanguages",
                table: "JoinTableRaceAutomaticLanguages",
                columns: new[] { "AutomaticLanguagesId", "RaceDataId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_JoinTableClassBonusLanguages",
                table: "JoinTableClassBonusLanguages",
                columns: new[] { "BonusLanguagesId", "ClassData1Id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_JoinTableClassAutomaticLanguages",
                table: "JoinTableClassAutomaticLanguages",
                columns: new[] { "AutomaticLanguagesId", "ClassDataId" });

            migrationBuilder.AddForeignKey(
                name: "FK_JoinTableClassAutomaticLanguages_Classes_ClassDataId",
                table: "JoinTableClassAutomaticLanguages",
                column: "ClassDataId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JoinTableClassAutomaticLanguages_Languages_AutomaticLanguagesId",
                table: "JoinTableClassAutomaticLanguages",
                column: "AutomaticLanguagesId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JoinTableClassBonusLanguages_Classes_ClassData1Id",
                table: "JoinTableClassBonusLanguages",
                column: "ClassData1Id",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JoinTableClassBonusLanguages_Languages_BonusLanguagesId",
                table: "JoinTableClassBonusLanguages",
                column: "BonusLanguagesId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JoinTableRaceAutomaticLanguages_Languages_AutomaticLanguagesId",
                table: "JoinTableRaceAutomaticLanguages",
                column: "AutomaticLanguagesId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JoinTableRaceAutomaticLanguages_Races_RaceDataId",
                table: "JoinTableRaceAutomaticLanguages",
                column: "RaceDataId",
                principalTable: "Races",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JoinTableRaceBonusLanguages_Languages_BonusLanguagesId",
                table: "JoinTableRaceBonusLanguages",
                column: "BonusLanguagesId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JoinTableRaceBonusLanguages_Races_RaceData1Id",
                table: "JoinTableRaceBonusLanguages",
                column: "RaceData1Id",
                principalTable: "Races",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JoinTableClassAutomaticLanguages_Classes_ClassDataId",
                table: "JoinTableClassAutomaticLanguages");

            migrationBuilder.DropForeignKey(
                name: "FK_JoinTableClassAutomaticLanguages_Languages_AutomaticLanguagesId",
                table: "JoinTableClassAutomaticLanguages");

            migrationBuilder.DropForeignKey(
                name: "FK_JoinTableClassBonusLanguages_Classes_ClassData1Id",
                table: "JoinTableClassBonusLanguages");

            migrationBuilder.DropForeignKey(
                name: "FK_JoinTableClassBonusLanguages_Languages_BonusLanguagesId",
                table: "JoinTableClassBonusLanguages");

            migrationBuilder.DropForeignKey(
                name: "FK_JoinTableRaceAutomaticLanguages_Languages_AutomaticLanguagesId",
                table: "JoinTableRaceAutomaticLanguages");

            migrationBuilder.DropForeignKey(
                name: "FK_JoinTableRaceAutomaticLanguages_Races_RaceDataId",
                table: "JoinTableRaceAutomaticLanguages");

            migrationBuilder.DropForeignKey(
                name: "FK_JoinTableRaceBonusLanguages_Languages_BonusLanguagesId",
                table: "JoinTableRaceBonusLanguages");

            migrationBuilder.DropForeignKey(
                name: "FK_JoinTableRaceBonusLanguages_Races_RaceData1Id",
                table: "JoinTableRaceBonusLanguages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JoinTableRaceBonusLanguages",
                table: "JoinTableRaceBonusLanguages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JoinTableRaceAutomaticLanguages",
                table: "JoinTableRaceAutomaticLanguages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JoinTableClassBonusLanguages",
                table: "JoinTableClassBonusLanguages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JoinTableClassAutomaticLanguages",
                table: "JoinTableClassAutomaticLanguages");

            migrationBuilder.RenameTable(
                name: "JoinTableRaceBonusLanguages",
                newName: "RaceBonusLanguages");

            migrationBuilder.RenameTable(
                name: "JoinTableRaceAutomaticLanguages",
                newName: "RaceAutomaticLanguages");

            migrationBuilder.RenameTable(
                name: "JoinTableClassBonusLanguages",
                newName: "ClassBonusLanguages");

            migrationBuilder.RenameTable(
                name: "JoinTableClassAutomaticLanguages",
                newName: "ClassAutomaticLanguages");

            migrationBuilder.RenameIndex(
                name: "IX_JoinTableRaceBonusLanguages_RaceData1Id",
                table: "RaceBonusLanguages",
                newName: "IX_RaceBonusLanguages_RaceData1Id");

            migrationBuilder.RenameIndex(
                name: "IX_JoinTableRaceAutomaticLanguages_RaceDataId",
                table: "RaceAutomaticLanguages",
                newName: "IX_RaceAutomaticLanguages_RaceDataId");

            migrationBuilder.RenameIndex(
                name: "IX_JoinTableClassBonusLanguages_ClassData1Id",
                table: "ClassBonusLanguages",
                newName: "IX_ClassBonusLanguages_ClassData1Id");

            migrationBuilder.RenameIndex(
                name: "IX_JoinTableClassAutomaticLanguages_ClassDataId",
                table: "ClassAutomaticLanguages",
                newName: "IX_ClassAutomaticLanguages_ClassDataId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RaceBonusLanguages",
                table: "RaceBonusLanguages",
                columns: new[] { "BonusLanguagesId", "RaceData1Id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_RaceAutomaticLanguages",
                table: "RaceAutomaticLanguages",
                columns: new[] { "AutomaticLanguagesId", "RaceDataId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClassBonusLanguages",
                table: "ClassBonusLanguages",
                columns: new[] { "BonusLanguagesId", "ClassData1Id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClassAutomaticLanguages",
                table: "ClassAutomaticLanguages",
                columns: new[] { "AutomaticLanguagesId", "ClassDataId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ClassAutomaticLanguages_Classes_ClassDataId",
                table: "ClassAutomaticLanguages",
                column: "ClassDataId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassAutomaticLanguages_Languages_AutomaticLanguagesId",
                table: "ClassAutomaticLanguages",
                column: "AutomaticLanguagesId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassBonusLanguages_Classes_ClassData1Id",
                table: "ClassBonusLanguages",
                column: "ClassData1Id",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassBonusLanguages_Languages_BonusLanguagesId",
                table: "ClassBonusLanguages",
                column: "BonusLanguagesId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RaceAutomaticLanguages_Languages_AutomaticLanguagesId",
                table: "RaceAutomaticLanguages",
                column: "AutomaticLanguagesId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RaceAutomaticLanguages_Races_RaceDataId",
                table: "RaceAutomaticLanguages",
                column: "RaceDataId",
                principalTable: "Races",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RaceBonusLanguages_Languages_BonusLanguagesId",
                table: "RaceBonusLanguages",
                column: "BonusLanguagesId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RaceBonusLanguages_Races_RaceData1Id",
                table: "RaceBonusLanguages",
                column: "RaceData1Id",
                principalTable: "Races",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
