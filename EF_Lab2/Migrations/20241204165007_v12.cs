using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Lab2.Migrations
{
    /// <inheritdoc />
    public partial class v12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "auth_id", "cat_id" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "auth_id", "cat_id" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "auth_id", "cat_id" },
                values: new object[] { 0, 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "auth_id", "cat_id" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "auth_id", "cat_id" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "auth_id", "cat_id" },
                values: new object[] { 3, 3 });
        }
    }
}
