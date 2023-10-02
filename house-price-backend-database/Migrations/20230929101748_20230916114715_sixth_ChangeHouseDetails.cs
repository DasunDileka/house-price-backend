using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace house_price_backend_database.Migrations
{
    /// <inheritdoc />
    public partial class _20230916114715_sixth_ChangeHouseDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LandSize",
                table: "HouseDetails",
                newName: "LivingArea");

            migrationBuilder.AddColumn<int>(
                name: "CurrencyRate",
                table: "HouseDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "HouseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "LandArea",
                table: "HouseDetails",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Link",
                table: "HouseDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "HouseDetails",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "School",
                table: "HouseDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ShappingMall",
                table: "HouseDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Transport",
                table: "HouseDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "floors",
                table: "HouseDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrencyRate",
                table: "HouseDetails");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "HouseDetails");

            migrationBuilder.DropColumn(
                name: "LandArea",
                table: "HouseDetails");

            migrationBuilder.DropColumn(
                name: "Link",
                table: "HouseDetails");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "HouseDetails");

            migrationBuilder.DropColumn(
                name: "School",
                table: "HouseDetails");

            migrationBuilder.DropColumn(
                name: "ShappingMall",
                table: "HouseDetails");

            migrationBuilder.DropColumn(
                name: "Transport",
                table: "HouseDetails");

            migrationBuilder.DropColumn(
                name: "floors",
                table: "HouseDetails");

            migrationBuilder.RenameColumn(
                name: "LivingArea",
                table: "HouseDetails",
                newName: "LandSize");
        }
    }
}
