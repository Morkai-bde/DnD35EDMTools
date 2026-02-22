using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DnD35EDMTools.Migrations
{
    /// <inheritdoc />
    public partial class AddBaseEquipmentSystem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Weight = table.Column<double>(type: "REAL", nullable: false),
                    Enchantment = table.Column<int>(type: "INTEGER", nullable: false),
                    LootCategory = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    ItemCategory = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    BaseGoldValue = table.Column<double>(type: "REAL", nullable: false),
                    CraftRequiredFeats = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    CraftSkillRequired = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    CraftDC = table.Column<int>(type: "INTEGER", nullable: false),
                    CraftGoldCost = table.Column<double>(type: "REAL", nullable: false),
                    CraftCostXp = table.Column<int>(type: "INTEGER", nullable: false),
                    SourceBook = table.Column<string>(type: "TEXT", maxLength: 5, nullable: true),
                    Page = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PropertyDefinitions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    ItemType = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    ValueType = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    AppliesTo = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyDefinitions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JoinTableCharacterInventory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CharacterId = table.Column<int>(type: "INTEGER", nullable: false),
                    ItemId = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    Location = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    EquippedSlot = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JoinTableCharacterInventory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JoinTableCharacterInventory_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JoinTableCharacterInventory_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JoinTableItemProperties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ItemId = table.Column<int>(type: "INTEGER", nullable: false),
                    PropertyDefinitionId = table.Column<int>(type: "INTEGER", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JoinTableItemProperties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JoinTableItemProperties_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JoinTableItemProperties_PropertyDefinitions_PropertyDefinitionId",
                        column: x => x.PropertyDefinitionId,
                        principalTable: "PropertyDefinitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JoinTableCharacterInventory_CharacterId_EquippedSlot",
                table: "JoinTableCharacterInventory",
                columns: new[] { "CharacterId", "EquippedSlot" },
                unique: true,
                filter: "[EquippedSlot] IS NOT NULL AND [Location] = 'Equipped'");

            migrationBuilder.CreateIndex(
                name: "IX_JoinTableCharacterInventory_ItemId",
                table: "JoinTableCharacterInventory",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_JoinTableItemProperties_ItemId_PropertyDefinitionId",
                table: "JoinTableItemProperties",
                columns: new[] { "ItemId", "PropertyDefinitionId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_JoinTableItemProperties_PropertyDefinitionId",
                table: "JoinTableItemProperties",
                column: "PropertyDefinitionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JoinTableCharacterInventory");

            migrationBuilder.DropTable(
                name: "JoinTableItemProperties");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "PropertyDefinitions");
        }
    }
}
