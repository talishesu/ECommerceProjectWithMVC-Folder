using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerceProjectWithMVC.Migrations
{
    public partial class UserCardItemsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserCardItems",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ProductPricingId = table.Column<int>(type: "int", nullable: false),
                    ProductPricingSizeId = table.Column<int>(type: "int", nullable: false),
                    ProductPricingProductId = table.Column<int>(type: "int", nullable: false),
                    ProductPricingColorId = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCardItems", x => new { x.UserId, x.ProductPricingId });
                    table.ForeignKey(
                        name: "FK_UserCardItems_ProductPricings_ProductPricingSizeId_ProductPricingProductId_ProductPricingColorId",
                        columns: x => new { x.ProductPricingSizeId, x.ProductPricingProductId, x.ProductPricingColorId },
                        principalTable: "ProductPricings",
                        principalColumns: new[] { "SizeId", "ProductId", "ColorId" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserCardItems_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "Membership",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserCardItems_ProductPricingSizeId_ProductPricingProductId_ProductPricingColorId",
                table: "UserCardItems",
                columns: new[] { "ProductPricingSizeId", "ProductPricingProductId", "ProductPricingColorId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserCardItems");
        }
    }
}
