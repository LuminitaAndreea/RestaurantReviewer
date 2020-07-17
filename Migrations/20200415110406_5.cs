using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantReviewer.Migrations
{
    public partial class _5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FavoriteRestaurants_FavoriteCarts_CartId1",
                table: "FavoriteRestaurants");

            migrationBuilder.DropIndex(
                name: "IX_FavoriteRestaurants_CartId1",
                table: "FavoriteRestaurants");

            migrationBuilder.DropColumn(
                name: "CartId1",
                table: "FavoriteRestaurants");

            migrationBuilder.AddColumn<string>(
                name: "CartId",
                table: "FavoriteRestaurants",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CartId",
                table: "FavoriteRestaurants");

            migrationBuilder.AddColumn<string>(
                name: "CartId1",
                table: "FavoriteRestaurants",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteRestaurants_CartId1",
                table: "FavoriteRestaurants",
                column: "CartId1");

            migrationBuilder.AddForeignKey(
                name: "FK_FavoriteRestaurants_FavoriteCarts_CartId1",
                table: "FavoriteRestaurants",
                column: "CartId1",
                principalTable: "FavoriteCarts",
                principalColumn: "CartId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
