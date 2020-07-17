using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantReviewer.Migrations
{
    public partial class _12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Users_Username",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_Username",
                table: "Reviews");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Reviews",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Username1",
                table: "Reviews",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_Username1",
                table: "Reviews",
                column: "Username1");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Users_Username1",
                table: "Reviews",
                column: "Username1",
                principalTable: "Users",
                principalColumn: "Username",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Users_Username1",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_Username1",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "Username1",
                table: "Reviews");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Reviews",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_Username",
                table: "Reviews",
                column: "Username");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Users_Username",
                table: "Reviews",
                column: "Username",
                principalTable: "Users",
                principalColumn: "Username",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
