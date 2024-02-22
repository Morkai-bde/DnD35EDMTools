using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DnD35EDMTools.Migrations
{
    /// <inheritdoc />
    public partial class RemoveUnusedKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Moralities_Alignments_AlignmentDataId",
                table: "Moralities");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Alignments_AlignmentDataId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_AlignmentDataId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Moralities_AlignmentDataId",
                table: "Moralities");

            migrationBuilder.DropColumn(
                name: "AlignmentDataId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "AlignmentDataId",
                table: "Moralities");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AlignmentDataId",
                table: "Orders",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AlignmentDataId",
                table: "Moralities",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AlignmentDataId",
                table: "Orders",
                column: "AlignmentDataId");

            migrationBuilder.CreateIndex(
                name: "IX_Moralities_AlignmentDataId",
                table: "Moralities",
                column: "AlignmentDataId");

            migrationBuilder.AddForeignKey(
                name: "FK_Moralities_Alignments_AlignmentDataId",
                table: "Moralities",
                column: "AlignmentDataId",
                principalTable: "Alignments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Alignments_AlignmentDataId",
                table: "Orders",
                column: "AlignmentDataId",
                principalTable: "Alignments",
                principalColumn: "Id");
        }
    }
}
