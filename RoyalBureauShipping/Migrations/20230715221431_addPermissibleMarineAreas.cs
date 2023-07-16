using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoyalBureauShipping.Migrations
{
    /// <inheritdoc />
    public partial class addPermissibleMarineAreas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ships_CargoShips_CargoShipId",
                table: "Ships");

            migrationBuilder.DropIndex(
                name: "IX_Ships_CargoShipId",
                table: "Ships");

            migrationBuilder.DropColumn(
                name: "CERTNo",
                table: "Ships");

            migrationBuilder.AddColumn<string>(
                name: "PermissibleMarineAreas",
                table: "Ships",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PermissibleMarineAreas",
                table: "Ships");

            migrationBuilder.AddColumn<int>(
                name: "CERTNo",
                table: "Ships",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ships_CargoShipId",
                table: "Ships",
                column: "CargoShipId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ships_CargoShips_CargoShipId",
                table: "Ships",
                column: "CargoShipId",
                principalTable: "CargoShips",
                principalColumn: "Id");
        }
    }
}
