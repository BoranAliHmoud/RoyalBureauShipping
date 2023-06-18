using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoyalBureauShipping.Migrations
{
    /// <inheritdoc />
    public partial class AddShipModelAndCargoShip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CargoShips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargoShips", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ships",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VesselName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IMO_NO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Class_Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GRT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Port_Of_Register = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Depth = table.Column<int>(type: "int", nullable: false),
                    Leangh = table.Column<int>(type: "int", nullable: false),
                    Breadth = table.Column<int>(type: "int", nullable: false),
                    Propulsion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CargoShipId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ships", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ships_CargoShips_CargoShipId",
                        column: x => x.CargoShipId,
                        principalTable: "CargoShips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ships_CargoShipId",
                table: "Ships",
                column: "CargoShipId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ships");

            migrationBuilder.DropTable(
                name: "CargoShips");
        }
    }
}
