using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerceProjectWithMVC.Migrations
{
    public partial class ContactsUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Answer",
                table: "Contacts");

            migrationBuilder.AddColumn<bool>(
                name: "Answered",
                table: "Contacts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "EmailConfirmTime",
                table: "Contacts",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Answered",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "EmailConfirmTime",
                table: "Contacts");

            migrationBuilder.AddColumn<string>(
                name: "Answer",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
