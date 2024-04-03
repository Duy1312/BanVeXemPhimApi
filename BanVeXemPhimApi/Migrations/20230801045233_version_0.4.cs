using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BanVeXemPhimApi.Migrations
{
    public partial class version_04 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "movies",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 1, 11, 52, 33, 391, DateTimeKind.Local).AddTicks(6573));

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Price", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 8, 1, 11, 52, 33, 388, DateTimeKind.Local).AddTicks(1825), 80000.0, new DateTime(2023, 8, 1, 11, 52, 33, 389, DateTimeKind.Local).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Price", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 8, 1, 11, 52, 33, 389, DateTimeKind.Local).AddTicks(9399), 80000.0, new DateTime(2023, 8, 1, 11, 52, 33, 389, DateTimeKind.Local).AddTicks(9409) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Price", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 8, 1, 11, 52, 33, 389, DateTimeKind.Local).AddTicks(9412), 80000.0, new DateTime(2023, 8, 1, 11, 52, 33, 389, DateTimeKind.Local).AddTicks(9414) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Price", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 8, 1, 11, 52, 33, 389, DateTimeKind.Local).AddTicks(9416), 80000.0, new DateTime(2023, 8, 1, 11, 52, 33, 389, DateTimeKind.Local).AddTicks(9417) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Price", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 8, 1, 11, 52, 33, 389, DateTimeKind.Local).AddTicks(9418), 80000.0, new DateTime(2023, 8, 1, 11, 52, 33, 389, DateTimeKind.Local).AddTicks(9423) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "movies");

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
    }
}
