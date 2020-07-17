using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantReviewer.Migrations
{
    public partial class _9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IpAddress",
                table: "Reviews");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IpAddress",
                table: "Reviews",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
