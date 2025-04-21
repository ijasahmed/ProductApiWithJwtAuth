using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiSampleCrud.Migrations
{
    /// <inheritdoc />
    public partial class Addcoloumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Login",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "Login");
        }
    }
}
