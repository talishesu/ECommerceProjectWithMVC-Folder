using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerceProjectWithMVC.Migrations
{
    public partial class ContactsUpdated2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AnswerMessage",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnswerMessage",
                table: "Contacts");
        }
    }
}
