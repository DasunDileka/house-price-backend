using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace house_price_backend_database.Migrations
{
    /// <inheritdoc />
    public partial class sevenupdateimage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Productimage",
                table: "Images",
                newName: "image");

            migrationBuilder.AddColumn<int>(
                name: "contact",
                table: "Images",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "floors",
                table: "Images",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "contact",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "floors",
                table: "Images");

            migrationBuilder.RenameColumn(
                name: "image",
                table: "Images",
                newName: "Productimage");
        }
    }
}
