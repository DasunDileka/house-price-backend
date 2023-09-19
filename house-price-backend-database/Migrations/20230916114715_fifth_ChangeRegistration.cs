using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace house_price_backend_database.Migrations
{
    /// <inheritdoc />
    public partial class fifth_ChangeRegistration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Users",
                newName: "UserType");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Users",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "EmailId",
                table: "Users",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "ContactNumber",
                table: "Users",
                newName: "Contact");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserType",
                table: "Users",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Users",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Users",
                newName: "EmailId");

            migrationBuilder.RenameColumn(
                name: "Contact",
                table: "Users",
                newName: "ContactNumber");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
