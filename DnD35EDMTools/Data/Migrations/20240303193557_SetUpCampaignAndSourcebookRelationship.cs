using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DnD35EDMTools.Migrations
{
    /// <inheritdoc />
    public partial class SetUpCampaignAndSourcebookRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SourceBooks_Campaigns_CampaignDataId",
                table: "SourceBooks");

            migrationBuilder.DropIndex(
                name: "IX_SourceBooks_CampaignDataId",
                table: "SourceBooks");

            migrationBuilder.DropColumn(
                name: "CampaignDataId",
                table: "SourceBooks");

            migrationBuilder.CreateTable(
                name: "JoinTableCampaignSourceBooks",
                columns: table => new
                {
                    AllowedSourcesId = table.Column<int>(type: "INTEGER", nullable: false),
                    CampaignSourceBooksId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JoinTableCampaignSourceBooks", x => new { x.AllowedSourcesId, x.CampaignSourceBooksId });
                    table.ForeignKey(
                        name: "FK_JoinTableCampaignSourceBooks_Campaigns_CampaignSourceBooksId",
                        column: x => x.CampaignSourceBooksId,
                        principalTable: "Campaigns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JoinTableCampaignSourceBooks_SourceBooks_AllowedSourcesId",
                        column: x => x.AllowedSourcesId,
                        principalTable: "SourceBooks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JoinTableCampaignSourceBooks_CampaignSourceBooksId",
                table: "JoinTableCampaignSourceBooks",
                column: "CampaignSourceBooksId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JoinTableCampaignSourceBooks");

            migrationBuilder.AddColumn<int>(
                name: "CampaignDataId",
                table: "SourceBooks",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SourceBooks_CampaignDataId",
                table: "SourceBooks",
                column: "CampaignDataId");

            migrationBuilder.AddForeignKey(
                name: "FK_SourceBooks_Campaigns_CampaignDataId",
                table: "SourceBooks",
                column: "CampaignDataId",
                principalTable: "Campaigns",
                principalColumn: "Id");
        }
    }
}
