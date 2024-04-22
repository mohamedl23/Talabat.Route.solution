using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Talabat.Repository.Data.Migrations
{
    public partial class editTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_productBrands_ProductBrandId",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_products_productCategories_ProductCategoryId",
                table: "products");

            migrationBuilder.RenameColumn(
                name: "ProductCategoryId",
                table: "products",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "ProductBrandId",
                table: "products",
                newName: "BrandId");

            migrationBuilder.RenameColumn(
                name: "Discription",
                table: "products",
                newName: "Description");

            migrationBuilder.RenameIndex(
                name: "IX_products_ProductCategoryId",
                table: "products",
                newName: "IX_products_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_products_ProductBrandId",
                table: "products",
                newName: "IX_products_BrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_products_productBrands_BrandId",
                table: "products",
                column: "BrandId",
                principalTable: "productBrands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_products_productCategories_CategoryId",
                table: "products",
                column: "CategoryId",
                principalTable: "productCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_productBrands_BrandId",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_products_productCategories_CategoryId",
                table: "products");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "products",
                newName: "Discription");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "products",
                newName: "ProductCategoryId");

            migrationBuilder.RenameColumn(
                name: "BrandId",
                table: "products",
                newName: "ProductBrandId");

            migrationBuilder.RenameIndex(
                name: "IX_products_CategoryId",
                table: "products",
                newName: "IX_products_ProductCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_products_BrandId",
                table: "products",
                newName: "IX_products_ProductBrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_products_productBrands_ProductBrandId",
                table: "products",
                column: "ProductBrandId",
                principalTable: "productBrands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_products_productCategories_ProductCategoryId",
                table: "products",
                column: "ProductCategoryId",
                principalTable: "productCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
