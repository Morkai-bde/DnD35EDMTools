using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DnD35EDMTools.Migrations
{
    /// <inheritdoc />
    public partial class FixGendersjoinTablename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JoinTableRaceGendersSkinColour_Genders_GendersId",
                table: "JoinTableRaceGendersSkinColour");

            migrationBuilder.DropForeignKey(
                name: "FK_JoinTableRaceGendersSkinColour_Races_RaceGendersId",
                table: "JoinTableRaceGendersSkinColour");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JoinTableRaceGendersSkinColour",
                table: "JoinTableRaceGendersSkinColour");

            migrationBuilder.RenameTable(
                name: "JoinTableRaceGendersSkinColour",
                newName: "JoinTableRaceGenders");

            migrationBuilder.RenameIndex(
                name: "IX_JoinTableRaceGendersSkinColour_RaceGendersId",
                table: "JoinTableRaceGenders",
                newName: "IX_JoinTableRaceGenders_RaceGendersId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JoinTableRaceGenders",
                table: "JoinTableRaceGenders",
                columns: new[] { "GendersId", "RaceGendersId" });

            migrationBuilder.AddForeignKey(
                name: "FK_JoinTableRaceGenders_Genders_GendersId",
                table: "JoinTableRaceGenders",
                column: "GendersId",
                principalTable: "Genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JoinTableRaceGenders_Races_RaceGendersId",
                table: "JoinTableRaceGenders",
                column: "RaceGendersId",
                principalTable: "Races",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JoinTableRaceGenders_Genders_GendersId",
                table: "JoinTableRaceGenders");

            migrationBuilder.DropForeignKey(
                name: "FK_JoinTableRaceGenders_Races_RaceGendersId",
                table: "JoinTableRaceGenders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JoinTableRaceGenders",
                table: "JoinTableRaceGenders");

            migrationBuilder.RenameTable(
                name: "JoinTableRaceGenders",
                newName: "JoinTableRaceGendersSkinColour");

            migrationBuilder.RenameIndex(
                name: "IX_JoinTableRaceGenders_RaceGendersId",
                table: "JoinTableRaceGendersSkinColour",
                newName: "IX_JoinTableRaceGendersSkinColour_RaceGendersId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JoinTableRaceGendersSkinColour",
                table: "JoinTableRaceGendersSkinColour",
                columns: new[] { "GendersId", "RaceGendersId" });

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
        }
    }
}
