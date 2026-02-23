using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DnD35EDMTools.Migrations
{
    /// <inheritdoc />
    public partial class AddItemTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemType",
                table: "PropertyDefinitions");

            migrationBuilder.DropColumn(
                name: "ItemCategory",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "LootCategory",
                table: "Items");

            migrationBuilder.AddColumn<string>(
                name: "ApplicableItemSubtypeIds",
                table: "PropertyDefinitions",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ApplicableItemTypeIds",
                table: "PropertyDefinitions",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ItemSubtype",
                table: "Items",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemType",
                table: "Items",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "LootCategories",
                table: "Items",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApplicableItemSubtypeIds",
                table: "PropertyDefinitions");

            migrationBuilder.DropColumn(
                name: "ApplicableItemTypeIds",
                table: "PropertyDefinitions");

            migrationBuilder.DropColumn(
                name: "ItemSubtype",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ItemType",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "LootCategories",
                table: "Items");

            migrationBuilder.AddColumn<string>(
                name: "ItemType",
                table: "PropertyDefinitions",
                type: "TEXT",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ItemCategory",
                table: "Items",
                type: "TEXT",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LootCategory",
                table: "Items",
                type: "TEXT",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }
    }
}
