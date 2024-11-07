using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PruebaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 10, 31, 11, 52, 25, 248, DateTimeKind.Local).AddTicks(4370), 8, "https://picsum.photos/640/480/?image=906" });

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
                columns: new[] { "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { new DateTime(2024, 10, 31, 11, 52, 25, 247, DateTimeKind.Local).AddTicks(2620), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Tasty Plastic Car", 245.56 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price" },
                values: new object[] { 1, new DateTime(2024, 10, 31, 11, 52, 25, 247, DateTimeKind.Local).AddTicks(2640), "Unbranded Metal Bacon", 163.72 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 1, new DateTime(2024, 10, 31, 11, 52, 25, 247, DateTimeKind.Local).AddTicks(2680), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Fantastic Rubber Bike", 908.10000000000002 });

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
                columns: new[] { "CreatedAt", "Name", "Price" },
                values: new object[] { new DateTime(2024, 10, 31, 11, 52, 25, 247, DateTimeKind.Local).AddTicks(2740), "Rustic Cotton Chips", 479.05000000000001 });

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
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 2, new DateTime(2024, 10, 31, 11, 52, 25, 247, DateTimeKind.Local).AddTicks(2780), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Small Cotton Fish", 527.66999999999996 });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 10, 31, 11, 39, 18, 197, DateTimeKind.Local).AddTicks(8660), 3, "https://picsum.photos/640/480/?image=319" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 10, 31, 11, 39, 18, 197, DateTimeKind.Local).AddTicks(8980), 3, "https://picsum.photos/640/480/?image=356" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 10, 31, 11, 39, 18, 197, DateTimeKind.Local).AddTicks(9000), 1, "https://picsum.photos/640/480/?image=30" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 10, 31, 11, 39, 18, 197, DateTimeKind.Local).AddTicks(9000), 1, "https://picsum.photos/640/480/?image=660" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 10, 31, 11, 39, 18, 197, DateTimeKind.Local).AddTicks(9010), 1, "https://picsum.photos/640/480/?image=142" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 10, 31, 11, 39, 18, 197, DateTimeKind.Local).AddTicks(9010), 1, "https://picsum.photos/640/480/?image=67" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 10, 31, 11, 39, 18, 197, DateTimeKind.Local).AddTicks(9040), 5, "https://picsum.photos/640/480/?image=1021" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 10, 31, 11, 39, 18, 197, DateTimeKind.Local).AddTicks(9040), 6, "https://picsum.photos/640/480/?image=435" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 10, 31, 11, 39, 18, 197, DateTimeKind.Local).AddTicks(9050), 9, "https://picsum.photos/640/480/?image=765" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 10, 31, 11, 39, 18, 197, DateTimeKind.Local).AddTicks(9060), 7, "https://picsum.photos/640/480/?image=485" });

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
                columns: new[] { "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { new DateTime(2024, 10, 31, 11, 39, 18, 196, DateTimeKind.Local).AddTicks(7290), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Tasty Fresh Salad", 552.86000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { new DateTime(2024, 10, 31, 11, 39, 18, 196, DateTimeKind.Local).AddTicks(7320), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Licensed Cotton Soap", 309.47000000000003 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price" },
                values: new object[] { 3, new DateTime(2024, 10, 31, 11, 39, 18, 196, DateTimeKind.Local).AddTicks(7340), "Ergonomic Soft Sausages", 557.47000000000003 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 2, new DateTime(2024, 10, 31, 11, 39, 18, 196, DateTimeKind.Local).AddTicks(7360), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Handcrafted Steel Chicken", 800.14999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 3, new DateTime(2024, 10, 31, 11, 39, 18, 196, DateTimeKind.Local).AddTicks(7380), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Tasty Soft Cheese", 355.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 3, new DateTime(2024, 10, 31, 11, 39, 18, 196, DateTimeKind.Local).AddTicks(7400), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Ergonomic Metal Soap", 624.34000000000003 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Name", "Price" },
                values: new object[] { new DateTime(2024, 10, 31, 11, 39, 18, 196, DateTimeKind.Local).AddTicks(7420), "Licensed Soft Pizza", 484.45999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 2, new DateTime(2024, 10, 31, 11, 39, 18, 196, DateTimeKind.Local).AddTicks(7430), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Tasty Wooden Car", 11.57 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 1, new DateTime(2024, 10, 31, 11, 39, 18, 196, DateTimeKind.Local).AddTicks(7450), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Licensed Granite Table", 939.05999999999995 });

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
        }
    }
}
