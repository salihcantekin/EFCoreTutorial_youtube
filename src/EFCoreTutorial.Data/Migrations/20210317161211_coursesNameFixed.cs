using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreTutorial.Data.Migrations
{
    public partial class coursesNameFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "first_name",
                schema: "dbo",
                table: "courses",
                newName: "name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                schema: "dbo",
                table: "courses",
                newName: "first_name");
        }
    }
}
