using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QPLate_Water.OracleIntegrationAPI.DAL.Migrations
{
    public partial class EditVisitor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Vehicle_VisitorId",
                table: "Vehicle");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VisitorId",
                table: "Vehicle",
                column: "VisitorId",
                unique: true,
                filter: "[VisitorId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Vehicle_VisitorId",
                table: "Vehicle");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VisitorId",
                table: "Vehicle",
                column: "VisitorId");
        }
    }
}
