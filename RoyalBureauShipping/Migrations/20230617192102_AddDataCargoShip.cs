using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RoyalBureauShipping.Migrations
{
    /// <inheritdoc />
    public partial class AddDataCargoShip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CargoShips",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Bulk Carrier" },
                    { 2, "Oil Tanker" },
                    { 3, "Chemical Tanker" },
                    { 4, " Gas Carrier" },
                    { 5, "Cargo Ship other than any of the above" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CargoShips",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CargoShips",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CargoShips",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CargoShips",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CargoShips",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
