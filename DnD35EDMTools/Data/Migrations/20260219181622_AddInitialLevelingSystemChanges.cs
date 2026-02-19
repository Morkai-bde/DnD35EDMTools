using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DnD35EDMTools.Migrations
{
    /// <inheritdoc />
    public partial class AddInitialLevelingSystemChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CharacterLevels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CharacterId = table.Column<int>(type: "INTEGER", nullable: false),
                    Level = table.Column<int>(type: "INTEGER", nullable: false),
                    ClassId = table.Column<int>(type: "INTEGER", nullable: false),
                    HitPointsRolled = table.Column<int>(type: "INTEGER", nullable: false),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterLevels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CharacterLevels_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterLevels_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CharacterLevelSkillRanks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CharacterLevelId = table.Column<int>(type: "INTEGER", nullable: false),
                    SkillId = table.Column<int>(type: "INTEGER", nullable: false),
                    RanksPurchased = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterLevelSkillRanks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CharacterLevelSkillRanks_CharacterLevels_CharacterLevelId",
                        column: x => x.CharacterLevelId,
                        principalTable: "CharacterLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterLevelSkillRanks_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterLevels_CharacterId_Level",
                table: "CharacterLevels",
                columns: new[] { "CharacterId", "Level" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CharacterLevels_ClassId",
                table: "CharacterLevels",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterLevelSkillRanks_CharacterLevelId_SkillId",
                table: "CharacterLevelSkillRanks",
                columns: new[] { "CharacterLevelId", "SkillId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CharacterLevelSkillRanks_SkillId",
                table: "CharacterLevelSkillRanks",
                column: "SkillId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterLevelSkillRanks");

            migrationBuilder.DropTable(
                name: "CharacterLevels");
        }
    }
}
