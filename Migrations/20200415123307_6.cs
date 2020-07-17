using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantReviewer.Migrations
{
    public partial class _6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FavoriteCartCartId",
                table: "FavoriteRestaurants",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteRestaurants_FavoriteCartCartId",
                table: "FavoriteRestaurants",
                column: "FavoriteCartCartId");

            migrationBuilder.AddForeignKey(
                name: "FK_FavoriteRestaurants_FavoriteCarts_FavoriteCartCartId",
                table: "FavoriteRestaurants",
                column: "FavoriteCartCartId",
                principalTable: "FavoriteCarts",
                principalColumn: "CartId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FavoriteRestaurants_FavoriteCarts_FavoriteCartCartId",
                table: "FavoriteRestaurants");

            migrationBuilder.DropIndex(
                name: "IX_FavoriteRestaurants_FavoriteCartCartId",
                table: "FavoriteRestaurants");

            migrationBuilder.DropColumn(
                name: "FavoriteCartCartId",
                table: "FavoriteRestaurants");
        }
    }
}
