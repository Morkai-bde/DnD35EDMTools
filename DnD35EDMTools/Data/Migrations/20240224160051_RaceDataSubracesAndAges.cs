using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DnD35EDMTools.Migrations
{
    /// <inheritdoc />
    public partial class RaceDataSubracesAndAges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "YoungAgeDice",
                table: "Races",
                newName: "SimpleDice");

            migrationBuilder.RenameColumn(
                name: "OldAgeDice",
                table: "Races",
                newName: "ModerateDice");

            migrationBuilder.RenameColumn(
                name: "MiddleAgeDice",
                table: "Races",
                newName: "ComplexDice");

            migrationBuilder.AddColumn<int>(
                name: "MaxAge",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SubRace",
                table: "Races",
                type: "TEXT",
                maxLength: 30,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaxAge",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "SubRace",
                table: "Races");

            migrationBuilder.RenameColumn(
                name: "SimpleDice",
                table: "Races",
                newName: "YoungAgeDice");

            migrationBuilder.RenameColumn(
                name: "ModerateDice",
                table: "Races",
                newName: "OldAgeDice");

            migrationBuilder.RenameColumn(
                name: "ComplexDice",
                table: "Races",
                newName: "MiddleAgeDice");
        }
    }
}
