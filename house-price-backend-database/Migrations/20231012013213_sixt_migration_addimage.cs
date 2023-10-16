using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace house_price_backend_database.Migrations
{
    /// <inheritdoc />
    public partial class sixt_migration_addimage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numberOfBedrooms = table.Column<int>(type: "int", nullable: false),
                    numberOfBathrooms = table.Column<int>(type: "int", nullable: false),
                    livingAreaSize = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    landSize = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Productimage = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");
        }
    }
}
