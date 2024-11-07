using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PruebaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddTestdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 31, 11, 39, 18, 194, DateTimeKind.Local).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 31, 11, 39, 18, 194, DateTimeKind.Local).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 31, 11, 39, 18, 194, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 31, 11, 39, 18, 194, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 31, 11, 39, 18, 194, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 31, 11, 39, 18, 194, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedAt", "ProductId", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 31, 11, 39, 18, 197, DateTimeKind.Local).AddTicks(8660), 3, "https://picsum.photos/640/480/?image=319" },
                    { 2, new DateTime(2024, 10, 31, 11, 39, 18, 197, DateTimeKind.Local).AddTicks(8980), 3, "https://picsum.photos/640/480/?image=356" },
                    { 3, new DateTime(2024, 10, 31, 11, 39, 18, 197, DateTimeKind.Local).AddTicks(9000), 1, "https://picsum.photos/640/480/?image=30" },
                    { 4, new DateTime(2024, 10, 31, 11, 39, 18, 197, DateTimeKind.Local).AddTicks(9000), 1, "https://picsum.photos/640/480/?image=660" },
                    { 5, new DateTime(2024, 10, 31, 11, 39, 18, 197, DateTimeKind.Local).AddTicks(9010), 1, "https://picsum.photos/640/480/?image=142" },
                    { 6, new DateTime(2024, 10, 31, 11, 39, 18, 197, DateTimeKind.Local).AddTicks(9010), 1, "https://picsum.photos/640/480/?image=67" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 2, new DateTime(2024, 10, 31, 11, 39, 18, 196, DateTimeKind.Local).AddTicks(6870), "The Football Is Good For Training And Recreational Purposes", "Handcrafted Fresh Pizza", 870.72000000000003 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 1, new DateTime(2024, 10, 31, 11, 39, 18, 196, DateTimeKind.Local).AddTicks(7290), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Tasty Fresh Salad", 552.86000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 2, new DateTime(2024, 10, 31, 11, 39, 18, 196, DateTimeKind.Local).AddTicks(7320), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Licensed Cotton Soap", 309.47000000000003 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 4, 3, new DateTime(2024, 10, 31, 11, 39, 18, 196, DateTimeKind.Local).AddTicks(7340), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Ergonomic Soft Sausages", 557.47000000000003 },
                    { 5, 2, new DateTime(2024, 10, 31, 11, 39, 18, 196, DateTimeKind.Local).AddTicks(7360), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Handcrafted Steel Chicken", 800.14999999999998 },
                    { 6, 3, new DateTime(2024, 10, 31, 11, 39, 18, 196, DateTimeKind.Local).AddTicks(7380), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Tasty Soft Cheese", 355.0 },
                    { 7, 3, new DateTime(2024, 10, 31, 11, 39, 18, 196, DateTimeKind.Local).AddTicks(7400), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Ergonomic Metal Soap", 624.34000000000003 },
                    { 8, 2, new DateTime(2024, 10, 31, 11, 39, 18, 196, DateTimeKind.Local).AddTicks(7420), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Licensed Soft Pizza", 484.45999999999998 },
                    { 9, 2, new DateTime(2024, 10, 31, 11, 39, 18, 196, DateTimeKind.Local).AddTicks(7430), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Tasty Wooden Car", 11.57 },
                    { 10, 1, new DateTime(2024, 10, 31, 11, 39, 18, 196, DateTimeKind.Local).AddTicks(7450), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Licensed Granite Table", 939.05999999999995 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 31, 11, 39, 18, 194, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 31, 11, 39, 18, 194, DateTimeKind.Local).AddTicks(8000));

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedAt", "ProductId", "Url" },
                values: new object[,]
                {
                    { 7, new DateTime(2024, 10, 31, 11, 39, 18, 197, DateTimeKind.Local).AddTicks(9040), 5, "https://picsum.photos/640/480/?image=1021" },
                    { 8, new DateTime(2024, 10, 31, 11, 39, 18, 197, DateTimeKind.Local).AddTicks(9040), 6, "https://picsum.photos/640/480/?image=435" },
                    { 9, new DateTime(2024, 10, 31, 11, 39, 18, 197, DateTimeKind.Local).AddTicks(9050), 9, "https://picsum.photos/640/480/?image=765" },
                    { 10, new DateTime(2024, 10, 31, 11, 39, 18, 197, DateTimeKind.Local).AddTicks(9060), 7, "https://picsum.photos/640/480/?image=485" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

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
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 1, new DateTime(2024, 10, 31, 11, 21, 51, 118, DateTimeKind.Local).AddTicks(4020), "Xwxss", "Whey Protein", 29.989999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 2, new DateTime(2024, 10, 31, 11, 21, 51, 118, DateTimeKind.Local).AddTicks(4020), "Xwxss", "Creatine Monohydrate", 19.989999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 3, new DateTime(2024, 10, 31, 11, 21, 51, 118, DateTimeKind.Local).AddTicks(4030), "Xwxss", "Pre-Workout", 24.989999999999998 });

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
    }
}
