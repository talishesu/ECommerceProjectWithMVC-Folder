using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerceProjectWithMVC.Migrations
{
    public partial class ColorUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DeletedDate",
                table: "Colors",
                newName: "DeletedTime");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DeletedTime",
                table: "Colors",
                newName: "DeletedDate");
        }
    }
}
