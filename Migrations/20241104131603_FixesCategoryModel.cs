using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PruebaAPI.Migrations
{
    /// <inheritdoc />
    public partial class FixesCategoryModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 4, 7, 16, 3, 187, DateTimeKind.Local).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 4, 7, 16, 3, 187, DateTimeKind.Local).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 4, 7, 16, 3, 187, DateTimeKind.Local).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 4, 7, 16, 3, 187, DateTimeKind.Local).AddTicks(1640));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 4, 7, 16, 3, 187, DateTimeKind.Local).AddTicks(1650));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 4, 7, 16, 3, 187, DateTimeKind.Local).AddTicks(1650));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 11, 4, 7, 16, 3, 190, DateTimeKind.Local).AddTicks(1640), 5, "https://picsum.photos/640/480/?image=97" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Url" },
                values: new object[] { new DateTime(2024, 11, 4, 7, 16, 3, 190, DateTimeKind.Local).AddTicks(1960), "https://picsum.photos/640/480/?image=856" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 11, 4, 7, 16, 3, 190, DateTimeKind.Local).AddTicks(1970), 1, "https://picsum.photos/640/480/?image=726" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 11, 4, 7, 16, 3, 190, DateTimeKind.Local).AddTicks(1980), 10, "https://picsum.photos/640/480/?image=594" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 11, 4, 7, 16, 3, 190, DateTimeKind.Local).AddTicks(1990), 8, "https://picsum.photos/640/480/?image=780" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 11, 4, 7, 16, 3, 190, DateTimeKind.Local).AddTicks(1990), 1, "https://picsum.photos/640/480/?image=1081" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 11, 4, 7, 16, 3, 190, DateTimeKind.Local).AddTicks(2000), 1, "https://picsum.photos/640/480/?image=994" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 11, 4, 7, 16, 3, 190, DateTimeKind.Local).AddTicks(2010), 4, "https://picsum.photos/640/480/?image=648" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 11, 4, 7, 16, 3, 190, DateTimeKind.Local).AddTicks(2010), 1, "https://picsum.photos/640/480/?image=272" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 11, 4, 7, 16, 3, 190, DateTimeKind.Local).AddTicks(2020), 4, "https://picsum.photos/640/480/?image=290" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 2, new DateTime(2024, 11, 4, 7, 16, 3, 188, DateTimeKind.Local).AddTicks(9950), "The Football Is Good For Training And Recreational Purposes", "Generic Frozen Soap", 797.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 2, new DateTime(2024, 11, 4, 7, 16, 3, 189, DateTimeKind.Local).AddTicks(360), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Licensed Wooden Computer", 632.71000000000004 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 3, new DateTime(2024, 11, 4, 7, 16, 3, 189, DateTimeKind.Local).AddTicks(380), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Awesome Steel Pants", 822.42999999999995 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 7, 16, 3, 189, DateTimeKind.Local).AddTicks(410), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Rustic Soft Shoes", 33.899999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 1, new DateTime(2024, 11, 4, 7, 16, 3, 189, DateTimeKind.Local).AddTicks(420), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Rustic Frozen Gloves", 214.05000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price" },
                values: new object[] { 2, new DateTime(2024, 11, 4, 7, 16, 3, 189, DateTimeKind.Local).AddTicks(440), "Sleek Wooden Ball", 807.13999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 7, 16, 3, 189, DateTimeKind.Local).AddTicks(460), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Gorgeous Wooden Pants", 352.06999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 7, 16, 3, 189, DateTimeKind.Local).AddTicks(480), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Handmade Concrete Chicken", 637.38 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 7, 16, 3, 189, DateTimeKind.Local).AddTicks(500), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Sleek Cotton Tuna", 379.56 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 7, 16, 3, 189, DateTimeKind.Local).AddTicks(520), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Refined Metal Fish", 386.62 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 4, 7, 16, 3, 187, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 4, 7, 16, 3, 187, DateTimeKind.Local).AddTicks(1580));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CreatedAt", "Url" },
                values: new object[] { new DateTime(2024, 11, 2, 19, 10, 54, 580, DateTimeKind.Local).AddTicks(4850), "https://picsum.photos/640/480/?image=97" });

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
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 1, new DateTime(2024, 11, 2, 19, 10, 54, 579, DateTimeKind.Local).AddTicks(3230), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Licensed Steel Soap", 2.73 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 1, new DateTime(2024, 11, 2, 19, 10, 54, 579, DateTimeKind.Local).AddTicks(3260), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Refined Fresh Hat", 695.03999999999996 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 19, 10, 54, 579, DateTimeKind.Local).AddTicks(3280), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Gorgeous Rubber Mouse", 508.85000000000002 });

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
                columns: new[] { "CategoryId", "CreatedAt", "Name", "Price" },
                values: new object[] { 1, new DateTime(2024, 11, 2, 19, 10, 54, 579, DateTimeKind.Local).AddTicks(3320), "Unbranded Metal Pants", 330.74000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 19, 10, 54, 579, DateTimeKind.Local).AddTicks(3340), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Gorgeous Frozen Bike", 891.37 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 19, 10, 54, 579, DateTimeKind.Local).AddTicks(3360), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Ergonomic Steel Pizza", 446.88999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 19, 10, 54, 579, DateTimeKind.Local).AddTicks(3370), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Gorgeous Steel Cheese", 970.66999999999996 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 2, 19, 10, 54, 579, DateTimeKind.Local).AddTicks(3390), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Incredible Concrete Salad", 156.58000000000001 });

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
    }
}
