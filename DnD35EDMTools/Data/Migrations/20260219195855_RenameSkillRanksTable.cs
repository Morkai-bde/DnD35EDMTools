using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DnD35EDMTools.Migrations
{
    /// <inheritdoc />
    public partial class RenameSkillRanksTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterLevelSkillRanks_CharacterLevels_CharacterLevelId",
                table: "CharacterLevelSkillRanks");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterLevelSkillRanks_Skills_SkillId",
                table: "CharacterLevelSkillRanks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharacterLevelSkillRanks",
                table: "CharacterLevelSkillRanks");

            migrationBuilder.RenameTable(
                name: "CharacterLevelSkillRanks",
                newName: "JoinTableCharacterLevelSkillRanks");

            migrationBuilder.RenameIndex(
                name: "IX_CharacterLevelSkillRanks_SkillId",
                table: "JoinTableCharacterLevelSkillRanks",
                newName: "IX_JoinTableCharacterLevelSkillRanks_SkillId");

            migrationBuilder.RenameIndex(
                name: "IX_CharacterLevelSkillRanks_CharacterLevelId_SkillId",
                table: "JoinTableCharacterLevelSkillRanks",
                newName: "IX_JoinTableCharacterLevelSkillRanks_CharacterLevelId_SkillId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JoinTableCharacterLevelSkillRanks",
                table: "JoinTableCharacterLevelSkillRanks",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JoinTableCharacterLevelSkillRanks_CharacterLevels_CharacterLevelId",
                table: "JoinTableCharacterLevelSkillRanks",
                column: "CharacterLevelId",
                principalTable: "CharacterLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JoinTableCharacterLevelSkillRanks_Skills_SkillId",
                table: "JoinTableCharacterLevelSkillRanks",
                column: "SkillId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JoinTableCharacterLevelSkillRanks_CharacterLevels_CharacterLevelId",
                table: "JoinTableCharacterLevelSkillRanks");

            migrationBuilder.DropForeignKey(
                name: "FK_JoinTableCharacterLevelSkillRanks_Skills_SkillId",
                table: "JoinTableCharacterLevelSkillRanks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JoinTableCharacterLevelSkillRanks",
                table: "JoinTableCharacterLevelSkillRanks");

            migrationBuilder.RenameTable(
                name: "JoinTableCharacterLevelSkillRanks",
                newName: "CharacterLevelSkillRanks");

            migrationBuilder.RenameIndex(
                name: "IX_JoinTableCharacterLevelSkillRanks_SkillId",
                table: "CharacterLevelSkillRanks",
                newName: "IX_CharacterLevelSkillRanks_SkillId");

            migrationBuilder.RenameIndex(
                name: "IX_JoinTableCharacterLevelSkillRanks_CharacterLevelId_SkillId",
                table: "CharacterLevelSkillRanks",
                newName: "IX_CharacterLevelSkillRanks_CharacterLevelId_SkillId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterLevelSkillRanks",
                table: "CharacterLevelSkillRanks",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterLevelSkillRanks_CharacterLevels_CharacterLevelId",
                table: "CharacterLevelSkillRanks",
                column: "CharacterLevelId",
                principalTable: "CharacterLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterLevelSkillRanks_Skills_SkillId",
                table: "CharacterLevelSkillRanks",
                column: "SkillId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
