using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DnD35EDMTools.Migrations
{
    /// <inheritdoc />
    public partial class MigrationsMergeTwo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_RaceSkinColourJoinTable_RaceSkinColoursId",
                table: "RaceSkinColourJoinTable");

            migrationBuilder.DropIndex(
                name: "IX_RaceHairColourJoinTable_HairColoursId",
                table: "RaceHairColourJoinTable");

            migrationBuilder.DropIndex(
                name: "IX_RaceEyeColourJoinTable_EyeColoursId",
                table: "RaceEyeColourJoinTable");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RaceSkinColourJoinTable",
                table: "RaceSkinColourJoinTable",
                columns: new[] { "RaceSkinColoursId", "SkinColoursId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_RaceHairColourJoinTable",
                table: "RaceHairColourJoinTable",
                columns: new[] { "HairColoursId", "RaceHairColoursId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_RaceEyeColourJoinTable",
                table: "RaceEyeColourJoinTable",
                columns: new[] { "EyeColoursId", "RaceEyeColoursId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RaceSkinColourJoinTable",
                table: "RaceSkinColourJoinTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RaceHairColourJoinTable",
                table: "RaceHairColourJoinTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RaceEyeColourJoinTable",
                table: "RaceEyeColourJoinTable");

            migrationBuilder.CreateIndex(
                name: "IX_RaceSkinColourJoinTable_RaceSkinColoursId",
                table: "RaceSkinColourJoinTable",
                column: "RaceSkinColoursId");

            migrationBuilder.CreateIndex(
                name: "IX_RaceHairColourJoinTable_HairColoursId",
                table: "RaceHairColourJoinTable",
                column: "HairColoursId");

            migrationBuilder.CreateIndex(
                name: "IX_RaceEyeColourJoinTable_EyeColoursId",
                table: "RaceEyeColourJoinTable",
                column: "EyeColoursId");
        }
    }
}
