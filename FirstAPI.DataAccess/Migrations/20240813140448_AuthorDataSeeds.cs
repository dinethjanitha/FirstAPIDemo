using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FirstAPI.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AuthorDataSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Todos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FullName" },
                values: new object[,]
                {
                    { 1, "Dineth Janitha" },
                    { 2, "Sahan Madawa" },
                    { 3, "Pasan Yasas" },
                    { 4, "Chamod Lakshitha" }
                });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Created", "Due" },
                values: new object[] { 1, new DateTime(2024, 8, 13, 19, 34, 47, 816, DateTimeKind.Local).AddTicks(8997), new DateTime(2024, 8, 14, 19, 34, 47, 816, DateTimeKind.Local).AddTicks(9009) });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "AuthorId", "Created", "Description", "Due", "Status", "Title" },
                values: new object[,]
                {
                    { 2, 3, new DateTime(2024, 8, 13, 19, 34, 47, 816, DateTimeKind.Local).AddTicks(9018), "Test Description 3 - DB", new DateTime(2024, 8, 14, 19, 34, 47, 816, DateTimeKind.Local).AddTicks(9019), 1, "Test 2" },
                    { 3, 2, new DateTime(2024, 8, 13, 19, 34, 47, 816, DateTimeKind.Local).AddTicks(9020), "Test Description 3 - DB", new DateTime(2024, 8, 14, 19, 34, 47, 816, DateTimeKind.Local).AddTicks(9021), 2, "Test 3" },
                    { 4, 4, new DateTime(2024, 8, 13, 19, 34, 47, 816, DateTimeKind.Local).AddTicks(9022), "Test Description 4 - DB", new DateTime(2024, 8, 14, 19, 34, 47, 816, DateTimeKind.Local).AddTicks(9023), 0, "Test 4" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Todos_AuthorId",
                table: "Todos",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Authors_AuthorId",
                table: "Todos",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Authors_AuthorId",
                table: "Todos");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Todos_AuthorId",
                table: "Todos");

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Todos");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 8, 10, 18, 0, 15, 715, DateTimeKind.Local).AddTicks(1636), new DateTime(2024, 8, 11, 18, 0, 15, 715, DateTimeKind.Local).AddTicks(1652) });
        }
    }
}
