using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DnD35EDMTools.Migrations
{
    /// <inheritdoc />
    public partial class RenamedJoinTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RaceEyeColourJoinTable_Colours_EyeColoursId",
                table: "RaceEyeColourJoinTable");

            migrationBuilder.DropForeignKey(
                name: "FK_RaceEyeColourJoinTable_Races_RaceEyeColoursId",
                table: "RaceEyeColourJoinTable");

            migrationBuilder.DropForeignKey(
                name: "FK_RaceHairColourJoinTable_Colours_HairColoursId",
                table: "RaceHairColourJoinTable");

            migrationBuilder.DropForeignKey(
                name: "FK_RaceHairColourJoinTable_Races_RaceHairColoursId",
                table: "RaceHairColourJoinTable");

            migrationBuilder.DropForeignKey(
                name: "FK_RaceSkinColourJoinTable_Colours_SkinColoursId",
                table: "RaceSkinColourJoinTable");

            migrationBuilder.DropForeignKey(
                name: "FK_RaceSkinColourJoinTable_Races_RaceSkinColoursId",
                table: "RaceSkinColourJoinTable");

            migrationBuilder.DropForeignKey(
                name: "FK_RacGendersSkinColourJoinTable_Genders_GendersId",
                table: "RacGendersSkinColourJoinTable");

            migrationBuilder.DropForeignKey(
                name: "FK_RacGendersSkinColourJoinTable_Races_RaceGendersId",
                table: "RacGendersSkinColourJoinTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RacGendersSkinColourJoinTable",
                table: "RacGendersSkinColourJoinTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RaceSkinColourJoinTable",
                table: "RaceSkinColourJoinTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RaceHairColourJoinTable",
                table: "RaceHairColourJoinTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RaceEyeColourJoinTable",
                table: "RaceEyeColourJoinTable");

            migrationBuilder.RenameTable(
                name: "RacGendersSkinColourJoinTable",
                newName: "JoinTableRaceGendersSkinColour");

            migrationBuilder.RenameTable(
                name: "RaceSkinColourJoinTable",
                newName: "JoinTableRaceSkinColour");

            migrationBuilder.RenameTable(
                name: "RaceHairColourJoinTable",
                newName: "JoinTableRaceHairColour");

            migrationBuilder.RenameTable(
                name: "RaceEyeColourJoinTable",
                newName: "JoinTableRaceEyeColour");

            migrationBuilder.RenameIndex(
                name: "IX_RacGendersSkinColourJoinTable_RaceGendersId",
                table: "JoinTableRaceGendersSkinColour",
                newName: "IX_JoinTableRaceGendersSkinColour_RaceGendersId");

            migrationBuilder.RenameIndex(
                name: "IX_RaceSkinColourJoinTable_SkinColoursId",
                table: "JoinTableRaceSkinColour",
                newName: "IX_JoinTableRaceSkinColour_SkinColoursId");

            migrationBuilder.RenameIndex(
                name: "IX_RaceHairColourJoinTable_RaceHairColoursId",
                table: "JoinTableRaceHairColour",
                newName: "IX_JoinTableRaceHairColour_RaceHairColoursId");

            migrationBuilder.RenameIndex(
                name: "IX_RaceEyeColourJoinTable_RaceEyeColoursId",
                table: "JoinTableRaceEyeColour",
                newName: "IX_JoinTableRaceEyeColour_RaceEyeColoursId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JoinTableRaceGendersSkinColour",
                table: "JoinTableRaceGendersSkinColour",
                columns: new[] { "GendersId", "RaceGendersId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_JoinTableRaceSkinColour",
                table: "JoinTableRaceSkinColour",
                columns: new[] { "RaceSkinColoursId", "SkinColoursId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_JoinTableRaceHairColour",
                table: "JoinTableRaceHairColour",
                columns: new[] { "HairColoursId", "RaceHairColoursId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_JoinTableRaceEyeColour",
                table: "JoinTableRaceEyeColour",
                columns: new[] { "EyeColoursId", "RaceEyeColoursId" });

            migrationBuilder.AddForeignKey(
                name: "FK_JoinTableRaceEyeColour_Colours_EyeColoursId",
                table: "JoinTableRaceEyeColour",
                column: "EyeColoursId",
                principalTable: "Colours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JoinTableRaceEyeColour_Races_RaceEyeColoursId",
                table: "JoinTableRaceEyeColour",
                column: "RaceEyeColoursId",
                principalTable: "Races",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JoinTableRaceGendersSkinColour_Genders_GendersId",
                table: "JoinTableRaceGendersSkinColour",
                column: "GendersId",
                principalTable: "Genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JoinTableRaceGendersSkinColour_Races_RaceGendersId",
                table: "JoinTableRaceGendersSkinColour",
                column: "RaceGendersId",
                principalTable: "Races",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JoinTableRaceHairColour_Colours_HairColoursId",
                table: "JoinTableRaceHairColour",
                column: "HairColoursId",
                principalTable: "Colours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JoinTableRaceHairColour_Races_RaceHairColoursId",
                table: "JoinTableRaceHairColour",
                column: "RaceHairColoursId",
                principalTable: "Races",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JoinTableRaceSkinColour_Colours_SkinColoursId",
                table: "JoinTableRaceSkinColour",
                column: "SkinColoursId",
                principalTable: "Colours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JoinTableRaceSkinColour_Races_RaceSkinColoursId",
                table: "JoinTableRaceSkinColour",
                column: "RaceSkinColoursId",
                principalTable: "Races",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JoinTableRaceEyeColour_Colours_EyeColoursId",
                table: "JoinTableRaceEyeColour");

            migrationBuilder.DropForeignKey(
                name: "FK_JoinTableRaceEyeColour_Races_RaceEyeColoursId",
                table: "JoinTableRaceEyeColour");

            migrationBuilder.DropForeignKey(
                name: "FK_JoinTableRaceGendersSkinColour_Genders_GendersId",
                table: "JoinTableRaceGendersSkinColour");

            migrationBuilder.DropForeignKey(
                name: "FK_JoinTableRaceGendersSkinColour_Races_RaceGendersId",
                table: "JoinTableRaceGendersSkinColour");

            migrationBuilder.DropForeignKey(
                name: "FK_JoinTableRaceHairColour_Colours_HairColoursId",
                table: "JoinTableRaceHairColour");

            migrationBuilder.DropForeignKey(
                name: "FK_JoinTableRaceHairColour_Races_RaceHairColoursId",
                table: "JoinTableRaceHairColour");

            migrationBuilder.DropForeignKey(
                name: "FK_JoinTableRaceSkinColour_Colours_SkinColoursId",
                table: "JoinTableRaceSkinColour");

            migrationBuilder.DropForeignKey(
                name: "FK_JoinTableRaceSkinColour_Races_RaceSkinColoursId",
                table: "JoinTableRaceSkinColour");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JoinTableRaceSkinColour",
                table: "JoinTableRaceSkinColour");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JoinTableRaceHairColour",
                table: "JoinTableRaceHairColour");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JoinTableRaceGendersSkinColour",
                table: "JoinTableRaceGendersSkinColour");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JoinTableRaceEyeColour",
                table: "JoinTableRaceEyeColour");

            migrationBuilder.RenameTable(
                name: "JoinTableRaceSkinColour",
                newName: "RaceSkinColourJoinTable");

            migrationBuilder.RenameTable(
                name: "JoinTableRaceHairColour",
                newName: "RaceHairColourJoinTable");

            migrationBuilder.RenameTable(
                name: "JoinTableRaceGendersSkinColour",
                newName: "RacGendersSkinColourJoinTable");

            migrationBuilder.RenameTable(
                name: "JoinTableRaceEyeColour",
                newName: "RaceEyeColourJoinTable");

            migrationBuilder.RenameIndex(
                name: "IX_JoinTableRaceSkinColour_SkinColoursId",
                table: "RaceSkinColourJoinTable",
                newName: "IX_RaceSkinColourJoinTable_SkinColoursId");

            migrationBuilder.RenameIndex(
                name: "IX_JoinTableRaceHairColour_RaceHairColoursId",
                table: "RaceHairColourJoinTable",
                newName: "IX_RaceHairColourJoinTable_RaceHairColoursId");

            migrationBuilder.RenameIndex(
                name: "IX_JoinTableRaceGendersSkinColour_RaceGendersId",
                table: "RacGendersSkinColourJoinTable",
                newName: "IX_RacGendersSkinColourJoinTable_RaceGendersId");

            migrationBuilder.RenameIndex(
                name: "IX_JoinTableRaceEyeColour_RaceEyeColoursId",
                table: "RaceEyeColourJoinTable",
                newName: "IX_RaceEyeColourJoinTable_RaceEyeColoursId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RaceSkinColourJoinTable",
                table: "RaceSkinColourJoinTable",
                columns: new[] { "RaceSkinColoursId", "SkinColoursId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_RaceHairColourJoinTable",
                table: "RaceHairColourJoinTable",
                columns: new[] { "HairColoursId", "RaceHairColoursId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_RacGendersSkinColourJoinTable",
                table: "RacGendersSkinColourJoinTable",
                columns: new[] { "GendersId", "RaceGendersId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_RaceEyeColourJoinTable",
                table: "RaceEyeColourJoinTable",
                columns: new[] { "EyeColoursId", "RaceEyeColoursId" });

            migrationBuilder.AddForeignKey(
                name: "FK_RaceEyeColourJoinTable_Colours_EyeColoursId",
                table: "RaceEyeColourJoinTable",
                column: "EyeColoursId",
                principalTable: "Colours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RaceEyeColourJoinTable_Races_RaceEyeColoursId",
                table: "RaceEyeColourJoinTable",
                column: "RaceEyeColoursId",
                principalTable: "Races",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RaceHairColourJoinTable_Colours_HairColoursId",
                table: "RaceHairColourJoinTable",
                column: "HairColoursId",
                principalTable: "Colours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RaceHairColourJoinTable_Races_RaceHairColoursId",
                table: "RaceHairColourJoinTable",
                column: "RaceHairColoursId",
                principalTable: "Races",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RaceSkinColourJoinTable_Colours_SkinColoursId",
                table: "RaceSkinColourJoinTable",
                column: "SkinColoursId",
                principalTable: "Colours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RaceSkinColourJoinTable_Races_RaceSkinColoursId",
                table: "RaceSkinColourJoinTable",
                column: "RaceSkinColoursId",
                principalTable: "Races",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RacGendersSkinColourJoinTable_Genders_GendersId",
                table: "RacGendersSkinColourJoinTable",
                column: "GendersId",
                principalTable: "Genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RacGendersSkinColourJoinTable_Races_RaceGendersId",
                table: "RacGendersSkinColourJoinTable",
                column: "RaceGendersId",
                principalTable: "Races",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
