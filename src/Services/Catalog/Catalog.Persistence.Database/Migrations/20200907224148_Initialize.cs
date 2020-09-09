using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Persistence.Database.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Catalog");

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "Catalog",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                schema: "Catalog",
                columns: table => new
                {
                    ProductInStockId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    Stock = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.ProductInStockId);
                    table.ForeignKey(
                        name: "FK_Stocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Catalog",
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Description for product 1", "Product 1", 656m },
                    { 73, "Description for product 73", "Product 73", 910m },
                    { 72, "Description for product 72", "Product 72", 970m },
                    { 71, "Description for product 71", "Product 71", 323m },
                    { 70, "Description for product 70", "Product 70", 569m },
                    { 69, "Description for product 69", "Product 69", 783m },
                    { 68, "Description for product 68", "Product 68", 673m },
                    { 67, "Description for product 67", "Product 67", 188m },
                    { 66, "Description for product 66", "Product 66", 804m },
                    { 65, "Description for product 65", "Product 65", 274m },
                    { 64, "Description for product 64", "Product 64", 560m },
                    { 63, "Description for product 63", "Product 63", 259m },
                    { 62, "Description for product 62", "Product 62", 464m },
                    { 61, "Description for product 61", "Product 61", 289m },
                    { 60, "Description for product 60", "Product 60", 883m },
                    { 59, "Description for product 59", "Product 59", 706m },
                    { 58, "Description for product 58", "Product 58", 933m },
                    { 57, "Description for product 57", "Product 57", 834m },
                    { 56, "Description for product 56", "Product 56", 624m },
                    { 55, "Description for product 55", "Product 55", 764m },
                    { 54, "Description for product 54", "Product 54", 343m },
                    { 53, "Description for product 53", "Product 53", 360m },
                    { 74, "Description for product 74", "Product 74", 318m },
                    { 52, "Description for product 52", "Product 52", 764m },
                    { 75, "Description for product 75", "Product 75", 981m },
                    { 77, "Description for product 77", "Product 77", 325m },
                    { 98, "Description for product 98", "Product 98", 345m },
                    { 97, "Description for product 97", "Product 97", 869m },
                    { 96, "Description for product 96", "Product 96", 129m },
                    { 95, "Description for product 95", "Product 95", 915m },
                    { 94, "Description for product 94", "Product 94", 800m },
                    { 93, "Description for product 93", "Product 93", 587m },
                    { 92, "Description for product 92", "Product 92", 578m },
                    { 91, "Description for product 91", "Product 91", 172m },
                    { 90, "Description for product 90", "Product 90", 137m },
                    { 89, "Description for product 89", "Product 89", 456m },
                    { 88, "Description for product 88", "Product 88", 333m },
                    { 87, "Description for product 87", "Product 87", 194m },
                    { 86, "Description for product 86", "Product 86", 759m },
                    { 85, "Description for product 85", "Product 85", 663m },
                    { 84, "Description for product 84", "Product 84", 734m },
                    { 83, "Description for product 83", "Product 83", 665m },
                    { 82, "Description for product 82", "Product 82", 831m },
                    { 81, "Description for product 81", "Product 81", 499m },
                    { 80, "Description for product 80", "Product 80", 970m },
                    { 79, "Description for product 79", "Product 79", 607m },
                    { 78, "Description for product 78", "Product 78", 423m },
                    { 76, "Description for product 76", "Product 76", 425m },
                    { 51, "Description for product 51", "Product 51", 421m },
                    { 50, "Description for product 50", "Product 50", 894m },
                    { 49, "Description for product 49", "Product 49", 960m },
                    { 22, "Description for product 22", "Product 22", 131m },
                    { 21, "Description for product 21", "Product 21", 454m },
                    { 20, "Description for product 20", "Product 20", 476m },
                    { 19, "Description for product 19", "Product 19", 422m },
                    { 18, "Description for product 18", "Product 18", 595m },
                    { 17, "Description for product 17", "Product 17", 264m },
                    { 16, "Description for product 16", "Product 16", 735m },
                    { 15, "Description for product 15", "Product 15", 476m },
                    { 14, "Description for product 14", "Product 14", 445m },
                    { 13, "Description for product 13", "Product 13", 794m },
                    { 12, "Description for product 12", "Product 12", 665m },
                    { 11, "Description for product 11", "Product 11", 259m },
                    { 10, "Description for product 10", "Product 10", 697m },
                    { 9, "Description for product 9", "Product 9", 545m },
                    { 8, "Description for product 8", "Product 8", 788m },
                    { 7, "Description for product 7", "Product 7", 990m },
                    { 6, "Description for product 6", "Product 6", 798m },
                    { 5, "Description for product 5", "Product 5", 962m },
                    { 4, "Description for product 4", "Product 4", 743m },
                    { 3, "Description for product 3", "Product 3", 245m },
                    { 2, "Description for product 2", "Product 2", 945m },
                    { 23, "Description for product 23", "Product 23", 210m },
                    { 24, "Description for product 24", "Product 24", 311m },
                    { 25, "Description for product 25", "Product 25", 136m },
                    { 26, "Description for product 26", "Product 26", 179m },
                    { 48, "Description for product 48", "Product 48", 777m },
                    { 47, "Description for product 47", "Product 47", 679m },
                    { 46, "Description for product 46", "Product 46", 166m },
                    { 45, "Description for product 45", "Product 45", 704m },
                    { 44, "Description for product 44", "Product 44", 787m },
                    { 43, "Description for product 43", "Product 43", 806m },
                    { 42, "Description for product 42", "Product 42", 128m },
                    { 41, "Description for product 41", "Product 41", 494m },
                    { 40, "Description for product 40", "Product 40", 204m },
                    { 39, "Description for product 39", "Product 39", 684m },
                    { 99, "Description for product 99", "Product 99", 613m },
                    { 38, "Description for product 38", "Product 38", 294m },
                    { 36, "Description for product 36", "Product 36", 906m },
                    { 35, "Description for product 35", "Product 35", 662m },
                    { 34, "Description for product 34", "Product 34", 221m },
                    { 33, "Description for product 33", "Product 33", 577m },
                    { 32, "Description for product 32", "Product 32", 455m },
                    { 31, "Description for product 31", "Product 31", 523m },
                    { 30, "Description for product 30", "Product 30", 985m },
                    { 29, "Description for product 29", "Product 29", 629m },
                    { 28, "Description for product 28", "Product 28", 625m },
                    { 27, "Description for product 27", "Product 27", 609m },
                    { 37, "Description for product 37", "Product 37", 512m },
                    { 100, "Description for product 100", "Product 100", 899m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 22 },
                    { 73, 73, 74 },
                    { 72, 72, 82 },
                    { 71, 71, 84 },
                    { 70, 70, 29 },
                    { 69, 69, 9 },
                    { 68, 68, 29 },
                    { 67, 67, 24 },
                    { 66, 66, 22 },
                    { 65, 65, 81 },
                    { 64, 64, 38 },
                    { 63, 63, 58 },
                    { 62, 62, 48 },
                    { 61, 61, 77 },
                    { 60, 60, 48 },
                    { 59, 59, 58 },
                    { 58, 58, 31 },
                    { 57, 57, 78 },
                    { 56, 56, 42 },
                    { 55, 55, 8 },
                    { 54, 54, 26 },
                    { 53, 53, 68 },
                    { 74, 74, 79 },
                    { 52, 52, 19 },
                    { 75, 75, 91 },
                    { 77, 77, 75 },
                    { 98, 98, 66 },
                    { 97, 97, 94 },
                    { 96, 96, 52 },
                    { 95, 95, 14 },
                    { 94, 94, 73 },
                    { 93, 93, 9 },
                    { 92, 92, 37 },
                    { 91, 91, 2 },
                    { 90, 90, 54 },
                    { 89, 89, 80 },
                    { 88, 88, 2 },
                    { 87, 87, 48 },
                    { 86, 86, 21 },
                    { 85, 85, 33 },
                    { 84, 84, 37 },
                    { 83, 83, 41 },
                    { 82, 82, 66 },
                    { 81, 81, 56 },
                    { 80, 80, 53 },
                    { 79, 79, 78 },
                    { 78, 78, 60 },
                    { 76, 76, 33 },
                    { 51, 51, 66 },
                    { 50, 50, 61 },
                    { 49, 49, 75 },
                    { 22, 22, 80 },
                    { 21, 21, 86 },
                    { 20, 20, 92 },
                    { 19, 19, 71 },
                    { 18, 18, 95 },
                    { 17, 17, 50 },
                    { 16, 16, 52 },
                    { 15, 15, 10 },
                    { 14, 14, 6 },
                    { 13, 13, 18 },
                    { 12, 12, 53 },
                    { 11, 11, 39 },
                    { 10, 10, 22 },
                    { 9, 9, 38 },
                    { 8, 8, 57 },
                    { 7, 7, 65 },
                    { 6, 6, 85 },
                    { 5, 5, 34 },
                    { 4, 4, 28 },
                    { 3, 3, 98 },
                    { 2, 2, 67 },
                    { 23, 23, 89 },
                    { 24, 24, 67 },
                    { 25, 25, 69 },
                    { 26, 26, 85 },
                    { 48, 48, 41 },
                    { 47, 47, 29 },
                    { 46, 46, 15 },
                    { 45, 45, 89 },
                    { 44, 44, 28 },
                    { 43, 43, 4 },
                    { 42, 42, 52 },
                    { 41, 41, 0 },
                    { 40, 40, 92 },
                    { 39, 39, 21 },
                    { 99, 99, 47 },
                    { 38, 38, 67 },
                    { 36, 36, 80 },
                    { 35, 35, 96 },
                    { 34, 34, 88 },
                    { 33, 33, 29 },
                    { 32, 32, 16 },
                    { 31, 31, 41 },
                    { 30, 30, 0 },
                    { 29, 29, 99 },
                    { 28, 28, 17 },
                    { 27, 27, 7 },
                    { 37, 37, 68 },
                    { 100, 100, 66 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductId",
                schema: "Catalog",
                table: "Products",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductId",
                schema: "Catalog",
                table: "Stocks",
                column: "ProductId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stocks",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "Catalog");
        }
    }
}
