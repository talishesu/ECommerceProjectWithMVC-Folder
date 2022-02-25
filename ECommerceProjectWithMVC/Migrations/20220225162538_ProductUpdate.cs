using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerceProjectWithMVC.Migrations
{
    public partial class ProductUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductsCategoryItems");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductsCategoryItems",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedByUserId = table.Column<int>(type: "int", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsCategoryItems", x => new { x.CategoryId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ProductsCategoryItems_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsCategoryItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductsCategoryItems_ProductId",
                table: "ProductsCategoryItems",
                column: "ProductId");
        }
    }
}
