using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MikeInventory.Migrations
{
    /// <inheritdoc />
    public partial class ToolAndPartCollectionAddedToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Tools",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Parts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tools_UserId",
                table: "Tools",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Parts_UserId",
                table: "Parts",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Parts_Users_UserId",
                table: "Parts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tools_Users_UserId",
                table: "Tools",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parts_Users_UserId",
                table: "Parts");

            migrationBuilder.DropForeignKey(
                name: "FK_Tools_Users_UserId",
                table: "Tools");

            migrationBuilder.DropIndex(
                name: "IX_Tools_UserId",
                table: "Tools");

            migrationBuilder.DropIndex(
                name: "IX_Parts_UserId",
                table: "Parts");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Tools");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Parts");
        }
    }
}
