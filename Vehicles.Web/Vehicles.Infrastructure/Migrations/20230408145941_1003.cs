using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vehicles.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class _1003 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_VehicleWarehouses",
                table: "VehicleWarehouses");

            migrationBuilder.DropColumn(
                name: "Capacity",
                table: "VehicleWarehouses");

            migrationBuilder.DropColumn(
                name: "Car_Wheel",
                table: "VehicleWarehouses");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "VehicleWarehouses");

            migrationBuilder.RenameTable(
                name: "VehicleWarehouses",
                newName: "Cars");

            migrationBuilder.AlterColumn<int>(
                name: "Wheel",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cars",
                table: "Cars",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Boats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LightOn = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Buses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Wheel = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LightOn = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buses", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Boats");

            migrationBuilder.DropTable(
                name: "Buses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cars",
                table: "Cars");

            migrationBuilder.RenameTable(
                name: "Cars",
                newName: "VehicleWarehouses");

            migrationBuilder.AlterColumn<int>(
                name: "Wheel",
                table: "VehicleWarehouses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehicleWarehouses",
                table: "VehicleWarehouses",
                column: "Id");
        }
    }
}
