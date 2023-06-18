using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoyalBureauShipping.Migrations
{
    /// <inheritdoc />
    public partial class data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ships_CargoShips_CargoShipId",
                table: "Ships");

            migrationBuilder.AlterColumn<int>(
                name: "CargoShipId",
                table: "Ships",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CERTNo",
                table: "Ships",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CasualHistory",
                table: "Ships",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CertificateValid",
                table: "Ships",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ClassificationCharacters",
                table: "Ships",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CompletionDateSurvey",
                table: "Ships",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Ships",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateBuildingContract",
                table: "Ships",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateDelivery",
                table: "Ships",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateofIssue",
                table: "Ships",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeadweightShip",
                table: "Ships",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DistinctiveNumber",
                table: "Ships",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EffectiveDate",
                table: "Ships",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ExemptionCertificate",
                table: "Ships",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FirstPostOutInspection",
                table: "Ships",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "GrossTonnage",
                table: "Ships",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IssuedAt",
                table: "Ships",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PortSurvey",
                table: "Ships",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RevisionDate",
                table: "Ships",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "SecondPostOutInspection",
                table: "Ships",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "TypeShipstrign",
                table: "Ships",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ValidUntil",
                table: "Ships",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "Ships",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Ships_CargoShips_CargoShipId",
                table: "Ships",
                column: "CargoShipId",
                principalTable: "CargoShips",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ships_CargoShips_CargoShipId",
                table: "Ships");

            migrationBuilder.DropColumn(
                name: "CERTNo",
                table: "Ships");

            migrationBuilder.DropColumn(
                name: "CasualHistory",
                table: "Ships");

            migrationBuilder.DropColumn(
                name: "CertificateValid",
                table: "Ships");

            migrationBuilder.DropColumn(
                name: "ClassificationCharacters",
                table: "Ships");

            migrationBuilder.DropColumn(
                name: "CompletionDateSurvey",
                table: "Ships");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Ships");

            migrationBuilder.DropColumn(
                name: "DateBuildingContract",
                table: "Ships");

            migrationBuilder.DropColumn(
                name: "DateDelivery",
                table: "Ships");

            migrationBuilder.DropColumn(
                name: "DateofIssue",
                table: "Ships");

            migrationBuilder.DropColumn(
                name: "DeadweightShip",
                table: "Ships");

            migrationBuilder.DropColumn(
                name: "DistinctiveNumber",
                table: "Ships");

            migrationBuilder.DropColumn(
                name: "EffectiveDate",
                table: "Ships");

            migrationBuilder.DropColumn(
                name: "ExemptionCertificate",
                table: "Ships");

            migrationBuilder.DropColumn(
                name: "FirstPostOutInspection",
                table: "Ships");

            migrationBuilder.DropColumn(
                name: "GrossTonnage",
                table: "Ships");

            migrationBuilder.DropColumn(
                name: "IssuedAt",
                table: "Ships");

            migrationBuilder.DropColumn(
                name: "PortSurvey",
                table: "Ships");

            migrationBuilder.DropColumn(
                name: "RevisionDate",
                table: "Ships");

            migrationBuilder.DropColumn(
                name: "SecondPostOutInspection",
                table: "Ships");

            migrationBuilder.DropColumn(
                name: "TypeShipstrign",
                table: "Ships");

            migrationBuilder.DropColumn(
                name: "ValidUntil",
                table: "Ships");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Ships");

            migrationBuilder.AlterColumn<int>(
                name: "CargoShipId",
                table: "Ships",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Ships_CargoShips_CargoShipId",
                table: "Ships",
                column: "CargoShipId",
                principalTable: "CargoShips",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
