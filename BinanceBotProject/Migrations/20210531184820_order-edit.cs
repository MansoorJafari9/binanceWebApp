using Microsoft.EntityFrameworkCore.Migrations;

namespace BinanceBotProject.Migrations
{
    public partial class orderedit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LastSaveProfitValue",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastSaveProfitValue",
                table: "Orders");
        }
    }
}
