using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DnD35EDMTools.Migrations
{
    /// <inheritdoc />
    public partial class AddSkillsKeyForFilter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "AppliesTo",
                table: "PropertyDefinitions",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<int>(
                name: "AppliedToSpecificSkillId",
                table: "PropertyDefinitions",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PropertyDefinitions_AppliedToSpecificSkillId",
                table: "PropertyDefinitions",
                column: "AppliedToSpecificSkillId");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyDefinitions_Skills_AppliedToSpecificSkillId",
                table: "PropertyDefinitions",
                column: "AppliedToSpecificSkillId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyDefinitions_Skills_AppliedToSpecificSkillId",
                table: "PropertyDefinitions");

            migrationBuilder.DropIndex(
                name: "IX_PropertyDefinitions_AppliedToSpecificSkillId",
                table: "PropertyDefinitions");

            migrationBuilder.DropColumn(
                name: "AppliedToSpecificSkillId",
                table: "PropertyDefinitions");

            migrationBuilder.AlterColumn<string>(
                name: "AppliesTo",
                table: "PropertyDefinitions",
                type: "TEXT",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");
        }
    }
}
