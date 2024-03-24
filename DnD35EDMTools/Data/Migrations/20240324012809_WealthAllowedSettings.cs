using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DnD35EDMTools.Migrations
{
    /// <inheritdoc />
    public partial class WealthAllowedSettings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CopperPieces",
                table: "Characters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GoldPieces",
                table: "Characters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PlatinumPieces",
                table: "Characters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SilverPieces",
                table: "Characters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "AllowWealthAverage",
                table: "Campaigns",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AllowWealthRandom",
                table: "Campaigns",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CopperPieces",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "GoldPieces",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "PlatinumPieces",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "SilverPieces",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "AllowWealthAverage",
                table: "Campaigns");

            migrationBuilder.DropColumn(
                name: "AllowWealthRandom",
                table: "Campaigns");
        }
    }
}
