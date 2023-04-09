using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vehicles.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class _1002 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Capacity",
                table: "VehicleWarehouses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Car_Wheel",
                table: "VehicleWarehouses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "VehicleWarehouses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Wheel",
                table: "VehicleWarehouses",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Capacity",
                table: "VehicleWarehouses");

            migrationBuilder.DropColumn(
                name: "Car_Wheel",
                table: "VehicleWarehouses");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "VehicleWarehouses");

            migrationBuilder.DropColumn(
                name: "Wheel",
                table: "VehicleWarehouses");
        }
    }
}
