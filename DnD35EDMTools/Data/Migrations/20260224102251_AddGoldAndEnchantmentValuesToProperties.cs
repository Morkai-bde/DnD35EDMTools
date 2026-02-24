using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DnD35EDMTools.Migrations
{
    /// <inheritdoc />
    public partial class AddGoldAndEnchantmentValuesToProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EnchantmentCost",
                table: "PropertyDefinitions",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "GoldCostMultiplier",
                table: "PropertyDefinitions",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnchantmentCost",
                table: "PropertyDefinitions");

            migrationBuilder.DropColumn(
                name: "GoldCostMultiplier",
                table: "PropertyDefinitions");
        }
    }
}
