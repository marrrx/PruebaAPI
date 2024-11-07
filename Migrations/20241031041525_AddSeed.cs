using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PruebaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 30, 22, 15, 24, 599, DateTimeKind.Local).AddTicks(1630), "Protein" },
                    { 2, new DateTime(2024, 10, 30, 22, 15, 24, 599, DateTimeKind.Local).AddTicks(1630), "Creatine" },
                    { 3, new DateTime(2024, 10, 30, 22, 15, 24, 599, DateTimeKind.Local).AddTicks(1630), "Pre-Workout" }
                });

            migrationBuilder.InsertData(
                table: "OrderStatuses",
                columns: new[] { "Id", "CreatedAt", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 30, 22, 15, 24, 599, DateTimeKind.Local).AddTicks(1600), "Pendiente" },
                    { 2, new DateTime(2024, 10, 30, 22, 15, 24, 599, DateTimeKind.Local).AddTicks(1600), "En proceso" },
                    { 3, new DateTime(2024, 10, 30, 22, 15, 24, 599, DateTimeKind.Local).AddTicks(1600), "Completado" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "Name", "Password" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 30, 22, 15, 24, 599, DateTimeKind.Local).AddTicks(1520), "example@example.com", "Usuario1", "1234" },
                    { 2, new DateTime(2024, 10, 30, 22, 15, 24, 599, DateTimeKind.Local).AddTicks(1530), "example1@example.com", "Usuario2", "1234" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 10, 30, 22, 15, 24, 599, DateTimeKind.Local).AddTicks(1650), "Xwxss", "Whey Protein", 29.989999999999998 },
                    { 2, 2, new DateTime(2024, 10, 30, 22, 15, 24, 599, DateTimeKind.Local).AddTicks(1650), "Xwxss", "Creatine Monohydrate", 19.989999999999998 },
                    { 3, 3, new DateTime(2024, 10, 30, 22, 15, 24, 599, DateTimeKind.Local).AddTicks(1650), "Xwxss", "Pre-Workout", 24.989999999999998 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
