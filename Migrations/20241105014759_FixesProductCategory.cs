using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PruebaAPI.Migrations
{
    /// <inheritdoc />
    public partial class FixesProductCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 4, 19, 47, 58, 966, DateTimeKind.Local).AddTicks(7980));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 4, 19, 47, 58, 966, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 4, 19, 47, 58, 966, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 4, 19, 47, 58, 966, DateTimeKind.Local).AddTicks(7960));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 4, 19, 47, 58, 966, DateTimeKind.Local).AddTicks(7960));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 4, 19, 47, 58, 966, DateTimeKind.Local).AddTicks(7960));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 11, 4, 19, 47, 58, 969, DateTimeKind.Local).AddTicks(8870), 9, "https://picsum.photos/640/480/?image=1009" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 11, 4, 19, 47, 58, 969, DateTimeKind.Local).AddTicks(9220), 6, "https://picsum.photos/640/480/?image=2" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 11, 4, 19, 47, 58, 969, DateTimeKind.Local).AddTicks(9230), 6, "https://picsum.photos/640/480/?image=616" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 11, 4, 19, 47, 58, 969, DateTimeKind.Local).AddTicks(9240), 1, "https://picsum.photos/640/480/?image=844" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 11, 4, 19, 47, 58, 969, DateTimeKind.Local).AddTicks(9250), 2, "https://picsum.photos/640/480/?image=740" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 11, 4, 19, 47, 58, 969, DateTimeKind.Local).AddTicks(9260), 9, "https://picsum.photos/640/480/?image=689" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 11, 4, 19, 47, 58, 969, DateTimeKind.Local).AddTicks(9260), 2, "https://picsum.photos/640/480/?image=254" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Url" },
                values: new object[] { new DateTime(2024, 11, 4, 19, 47, 58, 969, DateTimeKind.Local).AddTicks(9270), "https://picsum.photos/640/480/?image=1081" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 11, 4, 19, 47, 58, 969, DateTimeKind.Local).AddTicks(9280), 7, "https://picsum.photos/640/480/?image=639" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 11, 4, 19, 47, 58, 969, DateTimeKind.Local).AddTicks(9290), 6, "https://picsum.photos/640/480/?image=449" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 19, 47, 58, 968, DateTimeKind.Local).AddTicks(5770), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Rustic Wooden Bike", 351.19999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 1, new DateTime(2024, 11, 4, 19, 47, 58, 968, DateTimeKind.Local).AddTicks(6200), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Tasty Soft Computer", 838.41999999999996 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 1, new DateTime(2024, 11, 4, 19, 47, 58, 968, DateTimeKind.Local).AddTicks(6230), "The Football Is Good For Training And Recreational Purposes", "Intelligent Fresh Mouse", 192.38999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 1, new DateTime(2024, 11, 4, 19, 47, 58, 968, DateTimeKind.Local).AddTicks(6300), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Ergonomic Fresh Bike", 835.88 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 19, 47, 58, 968, DateTimeKind.Local).AddTicks(6330), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Rustic Rubber Shirt", 534.00999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 2, new DateTime(2024, 11, 4, 19, 47, 58, 968, DateTimeKind.Local).AddTicks(6340), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Rustic Frozen Bike", 135.56 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 19, 47, 58, 968, DateTimeKind.Local).AddTicks(6370), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Refined Wooden Shoes", 80.579999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 2, new DateTime(2024, 11, 4, 19, 47, 58, 968, DateTimeKind.Local).AddTicks(6390), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Practical Plastic Mouse", 680.77999999999997 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 3, new DateTime(2024, 11, 4, 19, 47, 58, 968, DateTimeKind.Local).AddTicks(6410), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Intelligent Fresh Pizza", 443.31999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 3, new DateTime(2024, 11, 4, 19, 47, 58, 968, DateTimeKind.Local).AddTicks(6430), "The Football Is Good For Training And Recreational Purposes", "Tasty Wooden Car", 43.840000000000003 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 4, 19, 47, 58, 966, DateTimeKind.Local).AddTicks(7890));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 4, 19, 47, 58, 966, DateTimeKind.Local).AddTicks(7890));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 4, 7, 19, 5, 281, DateTimeKind.Local).AddTicks(6370));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 4, 7, 19, 5, 281, DateTimeKind.Local).AddTicks(6370));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 4, 7, 19, 5, 281, DateTimeKind.Local).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 4, 7, 19, 5, 281, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 4, 7, 19, 5, 281, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 4, 7, 19, 5, 281, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 11, 4, 7, 19, 5, 284, DateTimeKind.Local).AddTicks(7730), 6, "https://picsum.photos/640/480/?image=125" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 11, 4, 7, 19, 5, 284, DateTimeKind.Local).AddTicks(8070), 9, "https://picsum.photos/640/480/?image=716" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 11, 4, 7, 19, 5, 284, DateTimeKind.Local).AddTicks(8080), 3, "https://picsum.photos/640/480/?image=694" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 11, 4, 7, 19, 5, 284, DateTimeKind.Local).AddTicks(8090), 9, "https://picsum.photos/640/480/?image=28" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 11, 4, 7, 19, 5, 284, DateTimeKind.Local).AddTicks(8090), 8, "https://picsum.photos/640/480/?image=399" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 11, 4, 7, 19, 5, 284, DateTimeKind.Local).AddTicks(8100), 4, "https://picsum.photos/640/480/?image=1036" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 11, 4, 7, 19, 5, 284, DateTimeKind.Local).AddTicks(8110), 5, "https://picsum.photos/640/480/?image=53" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Url" },
                values: new object[] { new DateTime(2024, 11, 4, 7, 19, 5, 284, DateTimeKind.Local).AddTicks(8120), "https://picsum.photos/640/480/?image=640" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 11, 4, 7, 19, 5, 284, DateTimeKind.Local).AddTicks(8120), 9, "https://picsum.photos/640/480/?image=79" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 11, 4, 7, 19, 5, 284, DateTimeKind.Local).AddTicks(8130), 3, "https://picsum.photos/640/480/?image=213" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 7, 19, 5, 283, DateTimeKind.Local).AddTicks(5050), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Ergonomic Metal Hat", 598.19000000000005 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 2, new DateTime(2024, 11, 4, 7, 19, 5, 283, DateTimeKind.Local).AddTicks(5520), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Unbranded Steel Car", 937.35000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 3, new DateTime(2024, 11, 4, 7, 19, 5, 283, DateTimeKind.Local).AddTicks(5550), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Handcrafted Soft Bike", 614.58000000000004 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 2, new DateTime(2024, 11, 4, 7, 19, 5, 283, DateTimeKind.Local).AddTicks(5570), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Rustic Wooden Towels", 593.87 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 7, 19, 5, 283, DateTimeKind.Local).AddTicks(5590), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Small Fresh Chicken", 64.810000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 3, new DateTime(2024, 11, 4, 7, 19, 5, 283, DateTimeKind.Local).AddTicks(5610), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Licensed Fresh Bike", 993.15999999999997 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 7, 19, 5, 283, DateTimeKind.Local).AddTicks(5620), "The Football Is Good For Training And Recreational Purposes", "Generic Cotton Shoes", 133.27000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 3, new DateTime(2024, 11, 4, 7, 19, 5, 283, DateTimeKind.Local).AddTicks(5640), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Gorgeous Metal Keyboard", 244.28 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 2, new DateTime(2024, 11, 4, 7, 19, 5, 283, DateTimeKind.Local).AddTicks(5660), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Small Cotton Mouse", 379.82999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 2, new DateTime(2024, 11, 4, 7, 19, 5, 283, DateTimeKind.Local).AddTicks(5680), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Fantastic Plastic Chair", 339.23000000000002 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 4, 7, 19, 5, 281, DateTimeKind.Local).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 4, 7, 19, 5, 281, DateTimeKind.Local).AddTicks(6260));
        }
    }
}
