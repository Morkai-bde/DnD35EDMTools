using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DnD35EDMTools.Migrations
{
    /// <inheritdoc />
    public partial class ReworkRaceSkillsDataStoreage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppraiseBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "AutohypnosisBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "BalanceBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "BluffBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "ClimbBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "ConcentrationBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "ControlShapeBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "CraftAlchemyBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "DecipherScriptBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "DiplomacyBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "DisableDeviceBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "DisguiseBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "EscapeArtistBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "ForgeryBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "GatherInformationBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "HandleAnimalBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "HealBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "HideBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "HypnosisBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "IntimidateBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "JumpBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "KnowledgeArcanaBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "KnowledgeArchAndEngBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "KnowledgeDungeoneeringBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "KnowledgeGeographyBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "KnowledgeHistoryBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "KnowledgeLocalBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "KnowledgeMonsterLoreBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "KnowledgeNatureBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "KnowledgeNobilityBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "KnowledgePsionicsBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "KnowledgeRavenloftBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "KnowledgeReligionBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "KnowledgeThePlanesBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "ListenBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "MartialLoreBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "MoveSilentlyBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "OpenLockBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "PsicraftBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "RideBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "SearchBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "SenseMotiveBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "SkillTricksBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "SleightofHandBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "SpeakLanguageBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "SpellcraftBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "SpotBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "SurvivalBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "SwimBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "TumbleBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "UseMagicDeviceBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "UsePsionicDeviceBonus",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "UseRopeBonus",
                table: "Races");

            migrationBuilder.AddColumn<string>(
                name: "SkillBonuses",
                table: "Races",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SkillBonuses",
                table: "Races");

            migrationBuilder.AddColumn<int>(
                name: "AppraiseBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AutohypnosisBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BalanceBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BluffBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClimbBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ConcentrationBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ControlShapeBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CraftAlchemyBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DecipherScriptBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DiplomacyBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DisableDeviceBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DisguiseBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EscapeArtistBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ForgeryBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GatherInformationBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HandleAnimalBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HealBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HideBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HypnosisBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IntimidateBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "JumpBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KnowledgeArcanaBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KnowledgeArchAndEngBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KnowledgeDungeoneeringBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KnowledgeGeographyBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KnowledgeHistoryBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KnowledgeLocalBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KnowledgeMonsterLoreBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KnowledgeNatureBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KnowledgeNobilityBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KnowledgePsionicsBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KnowledgeRavenloftBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KnowledgeReligionBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KnowledgeThePlanesBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ListenBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MartialLoreBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MoveSilentlyBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OpenLockBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PsicraftBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RideBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SearchBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SenseMotiveBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SkillTricksBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SleightofHandBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SpeakLanguageBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SpellcraftBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SpotBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SurvivalBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SwimBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TumbleBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UseMagicDeviceBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsePsionicDeviceBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UseRopeBonus",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
