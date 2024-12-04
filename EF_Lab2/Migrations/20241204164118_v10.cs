using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EF_Lab2.Migrations
{
    /// <inheritdoc />
    public partial class v10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Brief", "JoinDate", "Name", "Password", "Username" },
                values: new object[,]
                {
                    { 1, null, new DateOnly(2012, 5, 1), "Ahmed Hassan", "123", "Ahmed Hassan" },
                    { 2, null, new DateOnly(2012, 5, 1), "Mona Mohamed", "123", "Mona Mohamed" },
                    { 3, null, new DateOnly(2012, 5, 1), "Mazen Mostafa", "123", "Mazen Mostafa" }
                });

            migrationBuilder.InsertData(
                table: "Catalogs",
                columns: new[] { "ID", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Business", "Business" },
                    { 2, "Sports", "Sports" },
                    { 3, "Entertainment", "Entertainment" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Catalogs",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Catalogs",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Catalogs",
                keyColumn: "ID",
                keyValue: 3);
        }
    }
}
