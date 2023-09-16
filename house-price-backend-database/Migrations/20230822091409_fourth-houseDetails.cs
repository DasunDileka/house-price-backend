using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace house_price_backend_database.Migrations
{
    /// <inheritdoc />
    public partial class fourthhouseDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HouseDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoOfBedRoomS = table.Column<int>(type: "int", nullable: false),
                    NoOfBathRooms = table.Column<int>(type: "int", nullable: false),
                    LandSize = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseDetails", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HouseDetails");
        }
    }
}
