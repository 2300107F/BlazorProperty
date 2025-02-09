using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorProperty.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "DateRegistered", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b69fdb0e-4694-45f4-93f0-3e2f8eaea1a6", new DateTime(2025, 2, 9, 17, 28, 13, 199, DateTimeKind.Local).AddTicks(8625), "AQAAAAIAAYagAAAAEEhdaQCI+qvm3zwMSD+n5wbUc62vyg6PC9K9H7tjasRDx74wkq5cMV7Re5IfZx4jMA==", "83689032-1be6-4d2a-a8aa-a4329714187d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "DateRegistered", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c0fd87e-ff01-402b-b7cd-0227d6899c01", new DateTime(2025, 2, 9, 15, 55, 15, 312, DateTimeKind.Local).AddTicks(5076), "AQAAAAIAAYagAAAAEBCjAOnHCp7aSmuDf2ID8e0jq2tyiLQWGkW3F7F3By6q70kW+wwely7Ane3PjgAlTQ==", "b02d5793-7ecb-4fd5-8030-8b88b1926183" });
        }
    }
}
