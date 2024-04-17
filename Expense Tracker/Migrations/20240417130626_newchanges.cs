using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Expense_Tracker.Migrations
{
    public partial class newchanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tiltle",
                table: "categories",
                newName: "Title");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "categories",
                newName: "Tiltle");
        }
    }
}
