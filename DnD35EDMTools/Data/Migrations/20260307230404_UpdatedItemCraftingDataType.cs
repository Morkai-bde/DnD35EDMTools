using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DnD35EDMTools.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedItemCraftingDataType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CraftSkillRequired",
                table: "Items");

            migrationBuilder.AddColumn<int>(
                name: "CraftSkillRequiredId",
                table: "Items",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_CraftSkillRequiredId",
                table: "Items",
                column: "CraftSkillRequiredId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Skills_CraftSkillRequiredId",
                table: "Items",
                column: "CraftSkillRequiredId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Skills_CraftSkillRequiredId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_CraftSkillRequiredId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "CraftSkillRequiredId",
                table: "Items");

            migrationBuilder.AddColumn<string>(
                name: "CraftSkillRequired",
                table: "Items",
                type: "TEXT",
                maxLength: 50,
                nullable: true);
        }
    }
}
