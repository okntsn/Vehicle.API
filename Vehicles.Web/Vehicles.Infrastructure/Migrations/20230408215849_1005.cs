using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Vehicles.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class _1005 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Boats",
                columns: new[] { "Id", "Capacity", "Color", "LightOn" },
                values: new object[] { 3, 4, "white", false });

            migrationBuilder.InsertData(
                table: "Buses",
                columns: new[] { "Id", "Color", "LightOn", "Wheel" },
                values: new object[,]
                {
                    { 4, "yellow", true, 6 },
                    { 5, "blue", false, 8 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Color", "LightOn", "Wheel" },
                values: new object[,]
                {
                    { 1, "black", false, 4 },
                    { 2, "red", true, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Boats",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Buses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Buses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
