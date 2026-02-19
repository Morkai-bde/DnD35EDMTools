using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DnD35EDMTools.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCharacterDataForLeveling : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BaseFortitudeSave",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "BaseReflexSave",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "BaseWillSave",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Class",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "HeavyLoad",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "LiftOffGround",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "LiftOverHead",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "LightLoad",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "MediumLoad",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "PushOrDrag",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Skills",
                table: "Characters");

            migrationBuilder.RenameColumn(
                name: "HitPoints",
                table: "Characters",
                newName: "Level");

            migrationBuilder.RenameColumn(
                name: "Created",
                table: "CharacterLevels",
                newName: "CreatedDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Level",
                table: "Characters",
                newName: "HitPoints");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "CharacterLevels",
                newName: "Created");

            migrationBuilder.AddColumn<double>(
                name: "BaseFortitudeSave",
                table: "Characters",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "BaseReflexSave",
                table: "Characters",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "BaseWillSave",
                table: "Characters",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "Class",
                table: "Characters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "HeavyLoad",
                table: "Characters",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "LiftOffGround",
                table: "Characters",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "LiftOverHead",
                table: "Characters",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "LightLoad",
                table: "Characters",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MediumLoad",
                table: "Characters",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "PushOrDrag",
                table: "Characters",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Skills",
                table: "Characters",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
