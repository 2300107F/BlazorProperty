using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorProperty.Migrations
{
    /// <inheritdoc />
    public partial class PropertyUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PostalCode",
                table: "Property",
                newName: "PropertyName");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "DateRegistered", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c0fd87e-ff01-402b-b7cd-0227d6899c01", new DateTime(2025, 2, 9, 15, 55, 15, 312, DateTimeKind.Local).AddTicks(5076), "AQAAAAIAAYagAAAAEBCjAOnHCp7aSmuDf2ID8e0jq2tyiLQWGkW3F7F3By6q70kW+wwely7Ane3PjgAlTQ==", "b02d5793-7ecb-4fd5-8030-8b88b1926183" });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "PropertyId",
                keyValue: 1,
                column: "PropertyName",
                value: "Tampines Blk 123 HDB");

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "PropertyId",
                keyValue: 2,
                column: "PropertyName",
                value: "Bedok Blk 456 HDB");

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "PropertyId",
                keyValue: 3,
                column: "PropertyName",
                value: "Kallang Blk 123 HDB");

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "PropertyId",
                keyValue: 4,
                column: "PropertyName",
                value: "Jurong East Blk456 HDB");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PropertyName",
                table: "Property",
                newName: "PostalCode");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "DateRegistered", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b036519-4ad5-42fe-bb05-84186c769269", new DateTime(2025, 2, 8, 22, 37, 23, 769, DateTimeKind.Local).AddTicks(3127), "AQAAAAIAAYagAAAAEKYgycoqoWQio2l9EDiCzMJ0A+1xtH5zKCUncIIIsQRItqZEQiJKvHtNnm9hk30Aig==", "5f75c52d-55fd-4dc1-9b65-6ea84c771712" });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "PropertyId",
                keyValue: 1,
                column: "PostalCode",
                value: "330022");

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "PropertyId",
                keyValue: 2,
                column: "PostalCode",
                value: "123456");

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "PropertyId",
                keyValue: 3,
                column: "PostalCode",
                value: "364029");

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "PropertyId",
                keyValue: 4,
                column: "PostalCode",
                value: "326432");
        }
    }
}
