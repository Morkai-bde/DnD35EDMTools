using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DnD35EDMTools.Migrations
{
    /// <inheritdoc />
    public partial class SetSkillBonusesDefault : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Races SET SkillBonuses = '{}' WHERE SkillBonuses IS NULL OR SkillBonuses = ''");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
