using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DnD35EDMTools.Migrations
{
    /// <inheritdoc />
    public partial class AddSaves : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "FortitudeSavePerLevel",
                table: "Classes",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ReflexSavePerLevel",
                table: "Classes",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "WillSavePerLevel",
                table: "Classes",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "BaseFortitudeSave",
                table: "Characters",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "BaseReflexSave",
                table: "Characters",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "BaseWillSave",
                table: "Characters",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FortitudeSavePerLevel",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "ReflexSavePerLevel",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "WillSavePerLevel",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "BaseFortitudeSave",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "BaseReflexSave",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "BaseWillSave",
                table: "Characters");
        }
    }
}
