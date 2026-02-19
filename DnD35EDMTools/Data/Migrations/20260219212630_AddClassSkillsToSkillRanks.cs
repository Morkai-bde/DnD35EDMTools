using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DnD35EDMTools.Migrations
{
    /// <inheritdoc />
    public partial class AddClassSkillsToSkillRanks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsClassSkill",
                table: "JoinTableCharacterLevelSkillRanks",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsClassSkill",
                table: "JoinTableCharacterLevelSkillRanks");
        }
    }
}
