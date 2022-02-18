using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerceProjectWithMVC.Migrations
{
    public partial class SpecificationCategoryItemsAdded2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_SpecificationCategoryItems_CategoryId",
                table: "SpecificationCategoryItems",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_SpecificationCategoryItems_Categories_CategoryId",
                table: "SpecificationCategoryItems",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SpecificationCategoryItems_Specifications_SpecificationId",
                table: "SpecificationCategoryItems",
                column: "SpecificationId",
                principalTable: "Specifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SpecificationCategoryItems_Categories_CategoryId",
                table: "SpecificationCategoryItems");

            migrationBuilder.DropForeignKey(
                name: "FK_SpecificationCategoryItems_Specifications_SpecificationId",
                table: "SpecificationCategoryItems");

            migrationBuilder.DropIndex(
                name: "IX_SpecificationCategoryItems_CategoryId",
                table: "SpecificationCategoryItems");
        }
    }
}
