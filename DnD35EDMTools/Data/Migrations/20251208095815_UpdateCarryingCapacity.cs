using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DnD35EDMTools.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCarryingCapacity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HeavyLoad",
                table: "Characters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LiftOffGround",
                table: "Characters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LiftOverHead",
                table: "Characters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LightLoad",
                table: "Characters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MediumLoad",
                table: "Characters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PushOrDrag",
                table: "Characters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LiftOffGround",
                table: "CarryingCapacity",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LiftOverHead",
                table: "CarryingCapacity",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PushOrDrag",
                table: "CarryingCapacity",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "LiftOffGround",
                table: "CarryingCapacity");

            migrationBuilder.DropColumn(
                name: "LiftOverHead",
                table: "CarryingCapacity");

            migrationBuilder.DropColumn(
                name: "PushOrDrag",
                table: "CarryingCapacity");
        }
    }
}
