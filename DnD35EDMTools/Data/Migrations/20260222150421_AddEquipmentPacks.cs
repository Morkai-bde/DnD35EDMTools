using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DnD35EDMTools.Migrations
{
    /// <inheritdoc />
    public partial class AddEquipmentPacks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EquipmentPacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    TotalValue = table.Column<double>(type: "REAL", nullable: false),
                    SourceBook = table.Column<string>(type: "TEXT", maxLength: 5, nullable: false),
                    Page = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentPacks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JoinTableEquipmentPackItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EquipmentPackId = table.Column<int>(type: "INTEGER", nullable: false),
                    ItemId = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JoinTableEquipmentPackItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JoinTableEquipmentPackItems_EquipmentPacks_EquipmentPackId",
                        column: x => x.EquipmentPackId,
                        principalTable: "EquipmentPacks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JoinTableEquipmentPackItems_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JoinTableEquipmentPackItems_EquipmentPackId",
                table: "JoinTableEquipmentPackItems",
                column: "EquipmentPackId");

            migrationBuilder.CreateIndex(
                name: "IX_JoinTableEquipmentPackItems_ItemId",
                table: "JoinTableEquipmentPackItems",
                column: "ItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JoinTableEquipmentPackItems");

            migrationBuilder.DropTable(
                name: "EquipmentPacks");
        }
    }
}
