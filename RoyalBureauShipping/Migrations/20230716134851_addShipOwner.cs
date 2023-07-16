using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoyalBureauShipping.Migrations
{
    /// <inheritdoc />
    public partial class addShipOwner : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShipOwner",
                table: "Ships",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShipOwner",
                table: "Ships");
        }
    }
}
