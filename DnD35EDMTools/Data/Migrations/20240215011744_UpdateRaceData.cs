using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DnD35EDMTools.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRaceData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KnowledgetheplanesBonus",
                table: "Races",
                newName: "KnowledgeThePlanesBonus");

            migrationBuilder.RenameColumn(
                name: "KnowledgereligionBonus",
                table: "Races",
                newName: "KnowledgeReligionBonus");

            migrationBuilder.RenameColumn(
                name: "KnowledgeravenloftBonus",
                table: "Races",
                newName: "KnowledgeRavenloftBonus");

            migrationBuilder.RenameColumn(
                name: "KnowledgepsionicsBonus",
                table: "Races",
                newName: "KnowledgePsionicsBonus");

            migrationBuilder.RenameColumn(
                name: "KnowledgenobilityBonus",
                table: "Races",
                newName: "KnowledgeNobilityBonus");

            migrationBuilder.RenameColumn(
                name: "KnowledgenatureBonus",
                table: "Races",
                newName: "KnowledgeNatureBonus");

            migrationBuilder.RenameColumn(
                name: "KnowledgemonsterloreBonus",
                table: "Races",
                newName: "KnowledgeMonsterLoreBonus");

            migrationBuilder.RenameColumn(
                name: "KnowledgelocalBonus",
                table: "Races",
                newName: "KnowledgeLocalBonus");

            migrationBuilder.RenameColumn(
                name: "KnowledgehistoryBonus",
                table: "Races",
                newName: "KnowledgeHistoryBonus");

            migrationBuilder.RenameColumn(
                name: "KnowledgegeographyBonus",
                table: "Races",
                newName: "KnowledgeGeographyBonus");

            migrationBuilder.RenameColumn(
                name: "KnowledgedungeoneeringBonus",
                table: "Races",
                newName: "KnowledgeDungeoneeringBonus");

            migrationBuilder.RenameColumn(
                name: "KnowledgearchandengBonus",
                table: "Races",
                newName: "KnowledgeArchAndEngBonus");

            migrationBuilder.RenameColumn(
                name: "KnowledgearcanaBonus",
                table: "Races",
                newName: "KnowledgeArcanaBonus");

            migrationBuilder.RenameColumn(
                name: "FemaleHight",
                table: "Races",
                newName: "SkillPointsPerLevelBonus");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Races",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<int>(
                name: "FemaleHeight",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FemaleHeight",
                table: "Races");

            migrationBuilder.RenameColumn(
                name: "KnowledgeThePlanesBonus",
                table: "Races",
                newName: "KnowledgetheplanesBonus");

            migrationBuilder.RenameColumn(
                name: "KnowledgeReligionBonus",
                table: "Races",
                newName: "KnowledgereligionBonus");

            migrationBuilder.RenameColumn(
                name: "KnowledgeRavenloftBonus",
                table: "Races",
                newName: "KnowledgeravenloftBonus");

            migrationBuilder.RenameColumn(
                name: "KnowledgePsionicsBonus",
                table: "Races",
                newName: "KnowledgepsionicsBonus");

            migrationBuilder.RenameColumn(
                name: "KnowledgeNobilityBonus",
                table: "Races",
                newName: "KnowledgenobilityBonus");

            migrationBuilder.RenameColumn(
                name: "KnowledgeNatureBonus",
                table: "Races",
                newName: "KnowledgenatureBonus");

            migrationBuilder.RenameColumn(
                name: "KnowledgeMonsterLoreBonus",
                table: "Races",
                newName: "KnowledgemonsterloreBonus");

            migrationBuilder.RenameColumn(
                name: "KnowledgeLocalBonus",
                table: "Races",
                newName: "KnowledgelocalBonus");

            migrationBuilder.RenameColumn(
                name: "KnowledgeHistoryBonus",
                table: "Races",
                newName: "KnowledgehistoryBonus");

            migrationBuilder.RenameColumn(
                name: "KnowledgeGeographyBonus",
                table: "Races",
                newName: "KnowledgegeographyBonus");

            migrationBuilder.RenameColumn(
                name: "KnowledgeDungeoneeringBonus",
                table: "Races",
                newName: "KnowledgedungeoneeringBonus");

            migrationBuilder.RenameColumn(
                name: "KnowledgeArchAndEngBonus",
                table: "Races",
                newName: "KnowledgearchandengBonus");

            migrationBuilder.RenameColumn(
                name: "KnowledgeArcanaBonus",
                table: "Races",
                newName: "KnowledgearcanaBonus");

            migrationBuilder.RenameColumn(
                name: "SkillPointsPerLevelBonus",
                table: "Races",
                newName: "FemaleHight");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Races",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);
        }
    }
}
