using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerceProjectWithMVC.Migrations
{
    public partial class OrderUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DeletedTime",
                table: "Orders",
                newName: "LastUpdateTime");

            migrationBuilder.RenameColumn(
                name: "DeletedByUserId",
                table: "Orders",
                newName: "LastUpdateByUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastUpdateTime",
                table: "Orders",
                newName: "DeletedTime");

            migrationBuilder.RenameColumn(
                name: "LastUpdateByUserId",
                table: "Orders",
                newName: "DeletedByUserId");
        }
    }
}
