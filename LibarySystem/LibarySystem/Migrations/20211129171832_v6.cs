using Microsoft.EntityFrameworkCore.Migrations;

namespace LibarySystem.Migrations
{
    public partial class v6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "title",
                table: "Nutionalities");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Nutionalities",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Nutionalities");

            migrationBuilder.AddColumn<string>(
                name: "title",
                table: "Nutionalities",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
