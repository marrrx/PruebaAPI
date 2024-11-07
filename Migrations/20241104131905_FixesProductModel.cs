using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PruebaAPI.Migrations
{
    /// <inheritdoc />
    public partial class FixesProductModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CreatedAt", "Url" },
                values: new object[] { new DateTime(2024, 11, 4, 7, 19, 5, 284, DateTimeKind.Local).AddTicks(8090), "https://picsum.photos/640/480/?image=399" });

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
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 11, 4, 7, 19, 5, 284, DateTimeKind.Local).AddTicks(8120), 1, "https://picsum.photos/640/480/?image=640" });

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
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 1, new DateTime(2024, 11, 4, 7, 19, 5, 283, DateTimeKind.Local).AddTicks(5050), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Ergonomic Metal Hat", 598.19000000000005 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 7, 19, 5, 283, DateTimeKind.Local).AddTicks(5520), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Unbranded Steel Car", 937.35000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 7, 19, 5, 283, DateTimeKind.Local).AddTicks(5550), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Handcrafted Soft Bike", 614.58000000000004 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 7, 19, 5, 283, DateTimeKind.Local).AddTicks(5570), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Rustic Wooden Towels", 593.87 });

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
                columns: new[] { "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 7, 19, 5, 283, DateTimeKind.Local).AddTicks(5640), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Gorgeous Metal Keyboard", 244.28 });

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
                columns: new[] { "CreatedAt", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 7, 19, 5, 283, DateTimeKind.Local).AddTicks(5680), "Fantastic Plastic Chair", 339.23000000000002 });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CreatedAt", "ProductId", "Url" },
                values: new object[] { new DateTime(2024, 11, 4, 7, 16, 3, 190, DateTimeKind.Local).AddTicks(1960), 6, "https://picsum.photos/640/480/?image=856" });

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
                columns: new[] { "CreatedAt", "Url" },
                values: new object[] { new DateTime(2024, 11, 4, 7, 16, 3, 190, DateTimeKind.Local).AddTicks(1990), "https://picsum.photos/640/480/?image=780" });

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
                columns: new[] { "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 7, 16, 3, 189, DateTimeKind.Local).AddTicks(360), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Licensed Wooden Computer", 632.71000000000004 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 7, 16, 3, 189, DateTimeKind.Local).AddTicks(380), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Awesome Steel Pants", 822.42999999999995 });

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
                columns: new[] { "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 7, 16, 3, 189, DateTimeKind.Local).AddTicks(420), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Rustic Frozen Gloves", 214.05000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 2, new DateTime(2024, 11, 4, 7, 16, 3, 189, DateTimeKind.Local).AddTicks(440), "The Football Is Good For Training And Recreational Purposes", "Sleek Wooden Ball", 807.13999999999999 });

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
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 3, new DateTime(2024, 11, 4, 7, 16, 3, 189, DateTimeKind.Local).AddTicks(500), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Sleek Cotton Tuna", 379.56 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Name", "Price" },
                values: new object[] { new DateTime(2024, 11, 4, 7, 16, 3, 189, DateTimeKind.Local).AddTicks(520), "Refined Metal Fish", 386.62 });

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
    }
}
