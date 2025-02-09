using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorProperty.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisplayName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "DateRegistered", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09f62fba-3037-452b-9e3b-0cb09178ddbc", new DateTime(2025, 2, 9, 18, 49, 15, 38, DateTimeKind.Local).AddTicks(8627), "AQAAAAIAAYagAAAAECSkOgSbUZr8YtHPB0wYRzpRNnLonEwxLozeElWN1hwkpiGistcAg75BlbzXzfprcw==", "7a8a0282-724b-43e8-b308-83a35a7fdd68" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DisplayName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "DateRegistered", "DisplayName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b69fdb0e-4694-45f4-93f0-3e2f8eaea1a6", new DateTime(2025, 2, 9, 17, 28, 13, 199, DateTimeKind.Local).AddTicks(8625), null, "AQAAAAIAAYagAAAAEEhdaQCI+qvm3zwMSD+n5wbUc62vyg6PC9K9H7tjasRDx74wkq5cMV7Re5IfZx4jMA==", "83689032-1be6-4d2a-a8aa-a4329714187d" });
        }
    }
}
