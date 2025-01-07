using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Migrations
{
    /// <inheritdoc />
    public partial class DBInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    brandID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nameBrand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    brandID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.brandID);
                    table.ForeignKey(
                        name: "FK_Brand_Brand_brandID1",
                        column: x => x.brandID1,
                        principalTable: "Brand",
                        principalColumn: "brandID");
                });

            migrationBuilder.CreateTable(
                name: "Beer",
                columns: table => new
                {
                    beerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nameBeer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    brandID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beer", x => x.beerID);
                    table.ForeignKey(
                        name: "FK_Beer_Brand_brandID",
                        column: x => x.brandID,
                        principalTable: "Brand",
                        principalColumn: "brandID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Beer_brandID",
                table: "Beer",
                column: "brandID");

            migrationBuilder.CreateIndex(
                name: "IX_Brand_brandID1",
                table: "Brand",
                column: "brandID1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Beer");

            migrationBuilder.DropTable(
                name: "Brand");
        }
    }
}
