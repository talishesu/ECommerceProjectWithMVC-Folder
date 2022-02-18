using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerceProjectWithMVC.Migrations
{
    public partial class SpecificationCategoryItemsAdded3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "SpecificationCategoryItems",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                table: "SpecificationCategoryItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedByUserId",
                table: "SpecificationCategoryItems",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                table: "SpecificationCategoryItems",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "SpecificationCategoryItems");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                table: "SpecificationCategoryItems");

            migrationBuilder.DropColumn(
                name: "DeletedByUserId",
                table: "SpecificationCategoryItems");

            migrationBuilder.DropColumn(
                name: "DeletedTime",
                table: "SpecificationCategoryItems");
        }
    }
}
