using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DnD35EDMTools.Migrations
{
    /// <inheritdoc />
    public partial class AddClassSkillJoinTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JoinTableClassSkills",
                columns: table => new
                {
                    ClassSkillsId = table.Column<int>(type: "INTEGER", nullable: false),
                    ClassesId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JoinTableClassSkills", x => new { x.ClassSkillsId, x.ClassesId });
                    table.ForeignKey(
                        name: "FK_JoinTableClassSkills_Classes_ClassesId",
                        column: x => x.ClassesId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JoinTableClassSkills_Skills_ClassSkillsId",
                        column: x => x.ClassSkillsId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JoinTableClassSkills_ClassesId",
                table: "JoinTableClassSkills",
                column: "ClassesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JoinTableClassSkills");
        }
    }
}
