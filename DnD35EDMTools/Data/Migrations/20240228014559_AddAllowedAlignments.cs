using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DnD35EDMTools.Migrations
{
    /// <inheritdoc />
    public partial class AddAllowedAlignments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JoinTableAllowedAlignments",
                columns: table => new
                {
                    AlignmentDataId = table.Column<int>(type: "INTEGER", nullable: false),
                    AllowedAlignmentId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JoinTableAllowedAlignments", x => new { x.AlignmentDataId, x.AllowedAlignmentId });
                    table.ForeignKey(
                        name: "FK_JoinTableAllowedAlignments_Alignments_AlignmentDataId",
                        column: x => x.AlignmentDataId,
                        principalTable: "Alignments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JoinTableAllowedAlignments_Alignments_AllowedAlignmentId",
                        column: x => x.AllowedAlignmentId,
                        principalTable: "Alignments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JoinTableAllowedAlignments_AllowedAlignmentId",
                table: "JoinTableAllowedAlignments",
                column: "AllowedAlignmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JoinTableAllowedAlignments");
        }
    }
}
