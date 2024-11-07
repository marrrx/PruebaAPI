using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PruebaAPI.Migrations
{
    /// <inheritdoc />
    public partial class Fixes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 2, 19, 10, 54, 577, DateTimeKind.Local).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 2, 19, 10, 54, 577, DateTimeKind.Local).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 2, 19, 10, 54, 577, DateTimeKind.Local).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 2, 19, 10, 54, 577, DateTimeKind.Local).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 2, 19, 10, 54, 577, DateTimeKind.Local).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 2, 19, 10, 54, 577, DateTimeKind.Local).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 11, 2, 19, 10, 54, 580, DateTimeKind.Local).AddTicks(4520), 10, "https://picsum.photos/640/480/?image=608" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 11, 2, 19, 10, 54, 580, DateTimeKind.Local).AddTicks(4850), 6, "https://picsum.photos/640/480/?image=97" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 11, 2, 19, 10, 54, 580, DateTimeKind.Local).AddTicks(4860), 6, "https://picsum.photos/640/480/?image=939" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 11, 2, 19, 10, 54, 580, DateTimeKind.Local).AddTicks(4870), 9, "https://picsum.photos/640/480/?image=400" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 11, 2, 19, 10, 54, 580, DateTimeKind.Local).AddTicks(4880), 5, "https://picsum.photos/640/480/?image=349" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 11, 2, 19, 10, 54, 580, DateTimeKind.Local).AddTicks(4880), 8, "https://picsum.photos/640/480/?image=653" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 11, 2, 19, 10, 54, 580, DateTimeKind.Local).AddTicks(4890), 8, "https://picsum.photos/640/480/?image=417" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 11, 2, 19, 10, 54, 580, DateTimeKind.Local).AddTicks(4900), 7, "https://picsum.photos/640/480/?image=34" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 11, 2, 19, 10, 54, 580, DateTimeKind.Local).AddTicks(4900), 10, "https://picsum.photos/640/480/?image=735" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 11, 2, 19, 10, 54, 580, DateTimeKind.Local).AddTicks(4910), 9, "https://picsum.photos/640/480/?image=776" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 1, new DateTime(2024, 11, 2, 19, 10, 54, 579, DateTimeKind.Local).AddTicks(2810), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Incredible Cotton Chair", 240.31999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 19, 10, 54, 579, DateTimeKind.Local).AddTicks(3230), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Licensed Steel Soap", 2.73 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 19, 10, 54, 579, DateTimeKind.Local).AddTicks(3260), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Refined Fresh Hat", 695.03999999999996 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 2, new DateTime(2024, 11, 2, 19, 10, 54, 579, DateTimeKind.Local).AddTicks(3280), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Gorgeous Rubber Mouse", 508.85000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 2, new DateTime(2024, 11, 2, 19, 10, 54, 579, DateTimeKind.Local).AddTicks(3300), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Refined Concrete Fish", 166.33000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 1, new DateTime(2024, 11, 2, 19, 10, 54, 579, DateTimeKind.Local).AddTicks(3320), "The Football Is Good For Training And Recreational Purposes", "Unbranded Metal Pants", 330.74000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 2, new DateTime(2024, 11, 2, 19, 10, 54, 579, DateTimeKind.Local).AddTicks(3340), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Gorgeous Frozen Bike", 891.37 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price" },
                values: new object[] { 3, new DateTime(2024, 11, 2, 19, 10, 54, 579, DateTimeKind.Local).AddTicks(3360), "Ergonomic Steel Pizza", 446.88999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 3, new DateTime(2024, 11, 2, 19, 10, 54, 579, DateTimeKind.Local).AddTicks(3370), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Gorgeous Steel Cheese", 970.66999999999996 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 2, new DateTime(2024, 11, 2, 19, 10, 54, 579, DateTimeKind.Local).AddTicks(3390), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Incredible Concrete Salad", 156.58000000000001 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 2, 19, 10, 54, 577, DateTimeKind.Local).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 2, 19, 10, 54, 577, DateTimeKind.Local).AddTicks(5000));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 2, 18, 57, 21, 265, DateTimeKind.Local).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 2, 18, 57, 21, 265, DateTimeKind.Local).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 2, 18, 57, 21, 265, DateTimeKind.Local).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 2, 18, 57, 21, 265, DateTimeKind.Local).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 2, 18, 57, 21, 265, DateTimeKind.Local).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 2, 18, 57, 21, 265, DateTimeKind.Local).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 11, 2, 18, 57, 21, 268, DateTimeKind.Local).AddTicks(9880), 2, "https://picsum.photos/640/480/?image=995" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 11, 2, 18, 57, 21, 269, DateTimeKind.Local).AddTicks(190), 7, "https://picsum.photos/640/480/?image=1079" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 11, 2, 18, 57, 21, 269, DateTimeKind.Local).AddTicks(200), 8, "https://picsum.photos/640/480/?image=433" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 11, 2, 18, 57, 21, 269, DateTimeKind.Local).AddTicks(210), 8, "https://picsum.photos/640/480/?image=754" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 11, 2, 18, 57, 21, 269, DateTimeKind.Local).AddTicks(220), 6, "https://picsum.photos/640/480/?image=258" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 11, 2, 18, 57, 21, 269, DateTimeKind.Local).AddTicks(230), 2, "https://picsum.photos/640/480/?image=981" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 11, 2, 18, 57, 21, 269, DateTimeKind.Local).AddTicks(230), 6, "https://picsum.photos/640/480/?image=188" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 11, 2, 18, 57, 21, 269, DateTimeKind.Local).AddTicks(240), 8, "https://picsum.photos/640/480/?image=348" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 11, 2, 18, 57, 21, 269, DateTimeKind.Local).AddTicks(240), 8, "https://picsum.photos/640/480/?image=981" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 11, 2, 18, 57, 21, 269, DateTimeKind.Local).AddTicks(260), 5, "https://picsum.photos/640/480/?image=140" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 3, new DateTime(2024, 11, 2, 18, 57, 21, 267, DateTimeKind.Local).AddTicks(8030), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Incredible Metal Ball", 948.26999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 18, 57, 21, 267, DateTimeKind.Local).AddTicks(8450), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Fantastic Frozen Car", 658.76999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 18, 57, 21, 267, DateTimeKind.Local).AddTicks(8480), "The Football Is Good For Training And Recreational Purposes", "Tasty Cotton Salad", 979.66999999999996 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 3, new DateTime(2024, 11, 2, 18, 57, 21, 267, DateTimeKind.Local).AddTicks(8500), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Intelligent Rubber Tuna", 42.799999999999997 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 1, new DateTime(2024, 11, 2, 18, 57, 21, 267, DateTimeKind.Local).AddTicks(8530), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Licensed Wooden Shirt", 344.39999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 2, new DateTime(2024, 11, 2, 18, 57, 21, 267, DateTimeKind.Local).AddTicks(8550), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Awesome Soft Table", 856.50999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 3, new DateTime(2024, 11, 2, 18, 57, 21, 267, DateTimeKind.Local).AddTicks(8570), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Unbranded Metal Sausages", 401.88999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price" },
                values: new object[] { 2, new DateTime(2024, 11, 2, 18, 57, 21, 267, DateTimeKind.Local).AddTicks(8580), "Refined Soft Fish", 956.69000000000005 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 2, new DateTime(2024, 11, 2, 18, 57, 21, 267, DateTimeKind.Local).AddTicks(8600), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Incredible Steel Gloves", 280.88 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 3, new DateTime(2024, 11, 2, 18, 57, 21, 267, DateTimeKind.Local).AddTicks(8620), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Handcrafted Plastic Gloves", 173.52000000000001 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 2, 18, 57, 21, 265, DateTimeKind.Local).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 2, 18, 57, 21, 265, DateTimeKind.Local).AddTicks(8440));
        }
    }
}
