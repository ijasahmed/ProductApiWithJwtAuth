using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiSampleCrud.Migrations
{
    /// <inheritdoc />
    public partial class changename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "username",
                table: "Login",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "Login",
                newName: "Password");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Login",
                newName: "username");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Login",
                newName: "password");
        }
    }
}
