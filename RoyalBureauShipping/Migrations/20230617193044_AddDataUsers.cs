using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoyalBureauShipping.Migrations
{
    /// <inheritdoc />
    public partial class AddDataUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Password" },
                values: new object[] { 1, "RoyalBureauShipping@admin.com", "Admin", "Admin", "123456789" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
