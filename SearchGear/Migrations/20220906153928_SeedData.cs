using Microsoft.EntityFrameworkCore.Migrations;

namespace SearchGear.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Gears",
                type: "double",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.InsertData(
                table: "Gears",
                columns: new[] { "GearId", "Brand", "Model", "Price" },
                values: new object[,]
                {
                    { 1, "Osprey", "Aether 55", 219.99000000000001 },
                    { 2, "Arcteryx", "Alpha SV", 599.99000000000001 },
                    { 3, "Leki", "Trekking Poles", 139.99000000000001 },
                    { 4, "MSR", "Pocket Rocket", 49.990000000000002 },
                    { 5, "Lowa", "Weisshorn", 499.99000000000001 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Gears",
                keyColumn: "GearId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Gears",
                keyColumn: "GearId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Gears",
                keyColumn: "GearId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Gears",
                keyColumn: "GearId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Gears",
                keyColumn: "GearId",
                keyValue: 5);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Gears",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double");
        }
    }
}
