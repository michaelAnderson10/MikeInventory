using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MikeInventory.Migrations
{
    /// <inheritdoc />
    public partial class NameChangedToDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Persons",
                newName: "Description");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Persons",
                newName: "Name");
        }
    }
}
