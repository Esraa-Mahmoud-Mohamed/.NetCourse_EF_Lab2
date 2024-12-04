using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EF_Lab2.Migrations
{
    /// <inheritdoc />
    public partial class v8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "Brief", "Description", "NewDateTime", "Title", "auth_id", "cat_id" },
                values: new object[,]
                {
                    { 1, null, null, new DateTime(2024, 12, 4, 18, 35, 35, 112, DateTimeKind.Local).AddTicks(4745), "Mideast Stocks", 1, 1 },
                    { 2, null, null, new DateTime(2024, 12, 4, 18, 35, 35, 113, DateTimeKind.Local).AddTicks(7065), "Liverpool News", 2, 2 },
                    { 3, null, null, new DateTime(2024, 12, 4, 18, 35, 35, 113, DateTimeKind.Local).AddTicks(7074), "Film23 Release", 3, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
