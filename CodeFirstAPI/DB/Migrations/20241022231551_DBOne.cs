using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Migrations
{
    /// <inheritdoc />
    public partial class DBOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brand_Brand_brandID1",
                table: "Brand");

            migrationBuilder.DropIndex(
                name: "IX_Brand_brandID1",
                table: "Brand");

            migrationBuilder.DropColumn(
                name: "brandID1",
                table: "Brand");

            migrationBuilder.AlterColumn<string>(
                name: "nameBrand",
                table: "Brand",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "nameBeer",
                table: "Beer",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "nameBrand",
                table: "Brand",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "brandID1",
                table: "Brand",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nameBeer",
                table: "Beer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Brand_brandID1",
                table: "Brand",
                column: "brandID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Brand_Brand_brandID1",
                table: "Brand",
                column: "brandID1",
                principalTable: "Brand",
                principalColumn: "brandID");
        }
    }
}
