using Microsoft.EntityFrameworkCore.Migrations;

namespace SearchGear.Migrations
{
    public partial class SeedDataWithFamilyProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Family",
                table: "Gears",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Gears",
                keyColumn: "GearId",
                keyValue: 1,
                column: "Family",
                value: "Backpacks");

            migrationBuilder.UpdateData(
                table: "Gears",
                keyColumn: "GearId",
                keyValue: 2,
                column: "Family",
                value: "Outerwear");

            migrationBuilder.UpdateData(
                table: "Gears",
                keyColumn: "GearId",
                keyValue: 3,
                column: "Family",
                value: "Accessories");

            migrationBuilder.UpdateData(
                table: "Gears",
                keyColumn: "GearId",
                keyValue: 4,
                column: "Family",
                value: "Cooking");

            migrationBuilder.UpdateData(
                table: "Gears",
                keyColumn: "GearId",
                keyValue: 5,
                column: "Family",
                value: "Footwear");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Family",
                table: "Gears");
        }
    }
}
