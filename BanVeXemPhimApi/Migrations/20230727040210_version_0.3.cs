using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BanVeXemPhimApi.Migrations
{
    public partial class version_03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TicketReceiptCode",
                table: "order_tickets",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 11, 2, 10, 296, DateTimeKind.Local).AddTicks(125));

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 7, 27, 11, 2, 10, 293, DateTimeKind.Local).AddTicks(2308), new DateTime(2023, 7, 27, 11, 2, 10, 294, DateTimeKind.Local).AddTicks(2974) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 7, 27, 11, 2, 10, 294, DateTimeKind.Local).AddTicks(3958), new DateTime(2023, 7, 27, 11, 2, 10, 294, DateTimeKind.Local).AddTicks(3966) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 7, 27, 11, 2, 10, 294, DateTimeKind.Local).AddTicks(3969), new DateTime(2023, 7, 27, 11, 2, 10, 294, DateTimeKind.Local).AddTicks(3971) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 7, 27, 11, 2, 10, 294, DateTimeKind.Local).AddTicks(3973), new DateTime(2023, 7, 27, 11, 2, 10, 294, DateTimeKind.Local).AddTicks(3974) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 7, 27, 11, 2, 10, 294, DateTimeKind.Local).AddTicks(3976), new DateTime(2023, 7, 27, 11, 2, 10, 294, DateTimeKind.Local).AddTicks(3978) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TicketReceiptCode",
                table: "order_tickets");

            migrationBuilder.UpdateData(
                table: "admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 15, 10, 49, 35, 559, DateTimeKind.Local).AddTicks(3496));

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 7, 15, 10, 49, 35, 556, DateTimeKind.Local).AddTicks(6337), new DateTime(2023, 7, 15, 10, 49, 35, 557, DateTimeKind.Local).AddTicks(7147) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 7, 15, 10, 49, 35, 557, DateTimeKind.Local).AddTicks(8107), new DateTime(2023, 7, 15, 10, 49, 35, 557, DateTimeKind.Local).AddTicks(8115) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 7, 15, 10, 49, 35, 557, DateTimeKind.Local).AddTicks(8118), new DateTime(2023, 7, 15, 10, 49, 35, 557, DateTimeKind.Local).AddTicks(8120) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 7, 15, 10, 49, 35, 557, DateTimeKind.Local).AddTicks(8121), new DateTime(2023, 7, 15, 10, 49, 35, 557, DateTimeKind.Local).AddTicks(8123) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 7, 15, 10, 49, 35, 557, DateTimeKind.Local).AddTicks(8125), new DateTime(2023, 7, 15, 10, 49, 35, 557, DateTimeKind.Local).AddTicks(8127) });
        }
    }
}
