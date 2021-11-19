using Microsoft.EntityFrameworkCore.Migrations;

namespace BinanceBotProject.Migrations
{
    public partial class editpos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PositionStatus",
                table: "Positions",
                newName: "Completed");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Completed",
                table: "Positions",
                newName: "PositionStatus");
        }
    }
}
