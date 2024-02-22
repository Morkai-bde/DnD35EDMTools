using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DnD35EDMTools.Migrations
{
    /// <inheritdoc />
    public partial class AddAlignments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Diety",
                table: "Characters");

            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                table: "Characters",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<int>(
                name: "Deity",
                table: "Characters",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Morality",
                table: "Characters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "Characters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Alignments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alignments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Moralities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Morality = table.Column<string>(type: "TEXT", nullable: false),
                    MinValue = table.Column<int>(type: "INTEGER", nullable: false),
                    Midpoint = table.Column<int>(type: "INTEGER", nullable: false),
                    MaxValue = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    AlignmentDataId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moralities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Moralities_Alignments_AlignmentDataId",
                        column: x => x.AlignmentDataId,
                        principalTable: "Alignments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Order = table.Column<string>(type: "TEXT", nullable: false),
                    MinValue = table.Column<int>(type: "INTEGER", nullable: false),
                    Midpoint = table.Column<int>(type: "INTEGER", nullable: false),
                    MaxValue = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    AlignmentDataId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Alignments_AlignmentDataId",
                        column: x => x.AlignmentDataId,
                        principalTable: "Alignments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Moralities_AlignmentDataId",
                table: "Moralities",
                column: "AlignmentDataId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AlignmentDataId",
                table: "Orders",
                column: "AlignmentDataId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Moralities");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Alignments");

            migrationBuilder.DropColumn(
                name: "Deity",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Morality",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "Characters");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Characters",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<string>(
                name: "Diety",
                table: "Characters",
                type: "TEXT",
                nullable: true);
        }
    }
}
