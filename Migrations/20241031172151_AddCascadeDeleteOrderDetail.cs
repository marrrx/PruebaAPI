using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PruebaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddCascadeDeleteOrderDetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 31, 11, 21, 51, 118, DateTimeKind.Local).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 31, 11, 21, 51, 118, DateTimeKind.Local).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 31, 11, 21, 51, 118, DateTimeKind.Local).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 31, 11, 21, 51, 118, DateTimeKind.Local).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 31, 11, 21, 51, 118, DateTimeKind.Local).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 31, 11, 21, 51, 118, DateTimeKind.Local).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 31, 11, 21, 51, 118, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 31, 11, 21, 51, 118, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 31, 11, 21, 51, 118, DateTimeKind.Local).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 31, 11, 21, 51, 118, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 31, 11, 21, 51, 118, DateTimeKind.Local).AddTicks(3920));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 31, 11, 17, 25, 183, DateTimeKind.Local).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 31, 11, 17, 25, 183, DateTimeKind.Local).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 31, 11, 17, 25, 183, DateTimeKind.Local).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 31, 11, 17, 25, 183, DateTimeKind.Local).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 31, 11, 17, 25, 183, DateTimeKind.Local).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 31, 11, 17, 25, 183, DateTimeKind.Local).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 31, 11, 17, 25, 183, DateTimeKind.Local).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 31, 11, 17, 25, 183, DateTimeKind.Local).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 31, 11, 17, 25, 183, DateTimeKind.Local).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 31, 11, 17, 25, 183, DateTimeKind.Local).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 31, 11, 17, 25, 183, DateTimeKind.Local).AddTicks(3740));
        }
    }
}
