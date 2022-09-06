using Microsoft.EntityFrameworkCore.Migrations;

namespace SearchGear.Migrations
{
    public partial class ReSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Gears",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double");

            migrationBuilder.UpdateData(
                table: "Gears",
                keyColumn: "GearId",
                keyValue: 1,
                column: "Price",
                value: 219);

            migrationBuilder.UpdateData(
                table: "Gears",
                keyColumn: "GearId",
                keyValue: 2,
                column: "Price",
                value: 599);

            migrationBuilder.UpdateData(
                table: "Gears",
                keyColumn: "GearId",
                keyValue: 3,
                column: "Price",
                value: 139);

            migrationBuilder.UpdateData(
                table: "Gears",
                keyColumn: "GearId",
                keyValue: 4,
                column: "Price",
                value: 49);

            migrationBuilder.UpdateData(
                table: "Gears",
                keyColumn: "GearId",
                keyValue: 5,
                column: "Price",
                value: 499);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Gears",
                type: "double",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Gears",
                keyColumn: "GearId",
                keyValue: 1,
                column: "Price",
                value: 219.99000000000001);

            migrationBuilder.UpdateData(
                table: "Gears",
                keyColumn: "GearId",
                keyValue: 2,
                column: "Price",
                value: 599.99000000000001);

            migrationBuilder.UpdateData(
                table: "Gears",
                keyColumn: "GearId",
                keyValue: 3,
                column: "Price",
                value: 139.99000000000001);

            migrationBuilder.UpdateData(
                table: "Gears",
                keyColumn: "GearId",
                keyValue: 4,
                column: "Price",
                value: 49.990000000000002);

            migrationBuilder.UpdateData(
                table: "Gears",
                keyColumn: "GearId",
                keyValue: 5,
                column: "Price",
                value: 499.99000000000001);
        }
    }
}
