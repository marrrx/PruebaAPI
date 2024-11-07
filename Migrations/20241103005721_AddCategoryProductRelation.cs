using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PruebaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoryProductRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

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
                columns: new[] { "CreatedAt", "Url" },
                values: new object[] { new DateTime(2024, 11, 2, 18, 57, 21, 269, DateTimeKind.Local).AddTicks(210), "https://picsum.photos/640/480/?image=754" });

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
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 1, new DateTime(2024, 11, 2, 18, 57, 21, 267, DateTimeKind.Local).AddTicks(8480), "The Football Is Good For Training And Recreational Purposes", "Tasty Cotton Salad", 979.66999999999996 });

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
                columns: new[] { "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 18, 57, 21, 267, DateTimeKind.Local).AddTicks(8530), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Licensed Wooden Shirt", 344.39999999999998 });

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
                columns: new[] { "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 18, 57, 21, 267, DateTimeKind.Local).AddTicks(8580), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Refined Soft Fish", 956.69000000000005 });

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
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price" },
                values: new object[] { 3, new DateTime(2024, 11, 2, 18, 57, 21, 267, DateTimeKind.Local).AddTicks(8620), "Handcrafted Plastic Gloves", 173.52000000000001 });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 31, 11, 52, 25, 245, DateTimeKind.Local).AddTicks(2840));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 31, 11, 52, 25, 245, DateTimeKind.Local).AddTicks(2840));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 31, 11, 52, 25, 245, DateTimeKind.Local).AddTicks(2840));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 31, 11, 52, 25, 245, DateTimeKind.Local).AddTicks(2810));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 31, 11, 52, 25, 245, DateTimeKind.Local).AddTicks(2810));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 31, 11, 52, 25, 245, DateTimeKind.Local).AddTicks(2820));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 10, 31, 11, 52, 25, 248, DateTimeKind.Local).AddTicks(4030), 1, "https://picsum.photos/640/480/?image=891" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 10, 31, 11, 52, 25, 248, DateTimeKind.Local).AddTicks(4360), 2, "https://picsum.photos/640/480/?image=545" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 10, 31, 11, 52, 25, 248, DateTimeKind.Local).AddTicks(4370), 2, "https://picsum.photos/640/480/?image=637" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Url" },
                values: new object[] { new DateTime(2024, 10, 31, 11, 52, 25, 248, DateTimeKind.Local).AddTicks(4370), "https://picsum.photos/640/480/?image=906" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 10, 31, 11, 52, 25, 248, DateTimeKind.Local).AddTicks(4410), 2, "https://picsum.photos/640/480/?image=706" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 10, 31, 11, 52, 25, 248, DateTimeKind.Local).AddTicks(4420), 5, "https://picsum.photos/640/480/?image=623" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 10, 31, 11, 52, 25, 248, DateTimeKind.Local).AddTicks(4420), 8, "https://picsum.photos/640/480/?image=979" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 10, 31, 11, 52, 25, 248, DateTimeKind.Local).AddTicks(4430), 10, "https://picsum.photos/640/480/?image=8" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 10, 31, 11, 52, 25, 248, DateTimeKind.Local).AddTicks(4440), 6, "https://picsum.photos/640/480/?image=828" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 10, 31, 11, 52, 25, 248, DateTimeKind.Local).AddTicks(4440), 9, "https://picsum.photos/640/480/?image=609" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 1, new DateTime(2024, 10, 31, 11, 52, 25, 247, DateTimeKind.Local).AddTicks(2180), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Refined Frozen Towels", 163.99000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { new DateTime(2024, 10, 31, 11, 52, 25, 247, DateTimeKind.Local).AddTicks(2590), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Handcrafted Fresh Towels", 486.56999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 2, new DateTime(2024, 10, 31, 11, 52, 25, 247, DateTimeKind.Local).AddTicks(2620), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Tasty Plastic Car", 245.56 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 1, new DateTime(2024, 10, 31, 11, 52, 25, 247, DateTimeKind.Local).AddTicks(2640), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Unbranded Metal Bacon", 163.72 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { new DateTime(2024, 10, 31, 11, 52, 25, 247, DateTimeKind.Local).AddTicks(2680), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Fantastic Rubber Bike", 908.10000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 1, new DateTime(2024, 10, 31, 11, 52, 25, 247, DateTimeKind.Local).AddTicks(2700), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Handmade Wooden Bike", 885.39999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 1, new DateTime(2024, 10, 31, 11, 52, 25, 247, DateTimeKind.Local).AddTicks(2720), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Handmade Fresh Table", 956.39999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { new DateTime(2024, 10, 31, 11, 52, 25, 247, DateTimeKind.Local).AddTicks(2740), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Rustic Cotton Chips", 479.05000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 1, new DateTime(2024, 10, 31, 11, 52, 25, 247, DateTimeKind.Local).AddTicks(2760), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Awesome Metal Shirt", 396.81 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price" },
                values: new object[] { 2, new DateTime(2024, 10, 31, 11, 52, 25, 247, DateTimeKind.Local).AddTicks(2780), "Small Cotton Fish", 527.66999999999996 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 31, 11, 52, 25, 245, DateTimeKind.Local).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 31, 11, 52, 25, 245, DateTimeKind.Local).AddTicks(2750));

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
