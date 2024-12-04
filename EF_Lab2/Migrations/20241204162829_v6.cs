using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Lab2.Migrations
{
    /// <inheritdoc />
    public partial class v6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "NewDateTime",
                value: new DateTime(2024, 12, 4, 18, 28, 29, 19, DateTimeKind.Local).AddTicks(9443));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "NewDateTime",
                value: new DateTime(2024, 12, 4, 18, 28, 29, 21, DateTimeKind.Local).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "NewDateTime",
                value: new DateTime(2024, 12, 4, 18, 28, 29, 21, DateTimeKind.Local).AddTicks(5219));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "NewDateTime",
                value: new DateTime(2024, 12, 4, 18, 22, 56, 324, DateTimeKind.Local).AddTicks(8849));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "NewDateTime",
                value: new DateTime(2024, 12, 4, 18, 22, 56, 326, DateTimeKind.Local).AddTicks(5476));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "NewDateTime",
                value: new DateTime(2024, 12, 4, 18, 22, 56, 326, DateTimeKind.Local).AddTicks(5493));
        }
    }
}
