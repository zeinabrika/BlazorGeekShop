using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorShop.Server.Migrations
{
    public partial class ProductRemove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 1, 15, 21, 29, 13, 753, DateTimeKind.Local).AddTicks(3688));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 1, 15, 21, 29, 13, 756, DateTimeKind.Local).AddTicks(1496));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 1, 15, 21, 29, 13, 756, DateTimeKind.Local).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 1, 15, 21, 29, 13, 756, DateTimeKind.Local).AddTicks(1533));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 1, 15, 21, 29, 13, 756, DateTimeKind.Local).AddTicks(1536));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 1, 15, 21, 29, 13, 756, DateTimeKind.Local).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 1, 15, 21, 29, 13, 756, DateTimeKind.Local).AddTicks(1542));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 1, 15, 21, 29, 13, 756, DateTimeKind.Local).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 1, 15, 21, 29, 13, 756, DateTimeKind.Local).AddTicks(1548));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 1, 15, 21, 7, 17, 122, DateTimeKind.Local).AddTicks(9067));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 1, 15, 21, 7, 17, 131, DateTimeKind.Local).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 1, 15, 21, 7, 17, 131, DateTimeKind.Local).AddTicks(9222));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 1, 15, 21, 7, 17, 131, DateTimeKind.Local).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 1, 15, 21, 7, 17, 131, DateTimeKind.Local).AddTicks(9235));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 1, 15, 21, 7, 17, 131, DateTimeKind.Local).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 1, 15, 21, 7, 17, 131, DateTimeKind.Local).AddTicks(9244));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 1, 15, 21, 7, 17, 131, DateTimeKind.Local).AddTicks(9249));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 1, 15, 21, 7, 17, 131, DateTimeKind.Local).AddTicks(9253));
        }
    }
}
