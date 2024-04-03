using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BanVeXemPhimApi.Migrations
{
    public partial class version_02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PointsBalance",
                table: "users",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PointsBalance",
                table: "users");

            migrationBuilder.UpdateData(
                table: "admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 12, 14, 37, 55, 309, DateTimeKind.Local).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 6, 12, 14, 37, 55, 305, DateTimeKind.Local).AddTicks(6956), new DateTime(2023, 6, 12, 14, 37, 55, 307, DateTimeKind.Local).AddTicks(57) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 6, 12, 14, 37, 55, 307, DateTimeKind.Local).AddTicks(1213), new DateTime(2023, 6, 12, 14, 37, 55, 307, DateTimeKind.Local).AddTicks(1223) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 6, 12, 14, 37, 55, 307, DateTimeKind.Local).AddTicks(1228), new DateTime(2023, 6, 12, 14, 37, 55, 307, DateTimeKind.Local).AddTicks(1230) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 6, 12, 14, 37, 55, 307, DateTimeKind.Local).AddTicks(1232), new DateTime(2023, 6, 12, 14, 37, 55, 307, DateTimeKind.Local).AddTicks(1234) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 6, 12, 14, 37, 55, 307, DateTimeKind.Local).AddTicks(1236), new DateTime(2023, 6, 12, 14, 37, 55, 307, DateTimeKind.Local).AddTicks(1239) });
        }
    }
}
