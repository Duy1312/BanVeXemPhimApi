using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BanVeXemPhimApi.Migrations
{
    public partial class version_05 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "cenimas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 17, 12, 36, 653, DateTimeKind.Local).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 8, 6, 17, 12, 36, 650, DateTimeKind.Local).AddTicks(4830), new DateTime(2023, 8, 6, 17, 12, 36, 651, DateTimeKind.Local).AddTicks(7168) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 8, 6, 17, 12, 36, 651, DateTimeKind.Local).AddTicks(7864), new DateTime(2023, 8, 6, 17, 12, 36, 651, DateTimeKind.Local).AddTicks(7870) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 8, 6, 17, 12, 36, 651, DateTimeKind.Local).AddTicks(7872), new DateTime(2023, 8, 6, 17, 12, 36, 651, DateTimeKind.Local).AddTicks(7873) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 8, 6, 17, 12, 36, 651, DateTimeKind.Local).AddTicks(7874), new DateTime(2023, 8, 6, 17, 12, 36, 651, DateTimeKind.Local).AddTicks(7876) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 8, 6, 17, 12, 36, 651, DateTimeKind.Local).AddTicks(7877), new DateTime(2023, 8, 6, 17, 12, 36, 651, DateTimeKind.Local).AddTicks(7878) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "cenimas");

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
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 8, 1, 11, 52, 33, 388, DateTimeKind.Local).AddTicks(1825), new DateTime(2023, 8, 1, 11, 52, 33, 389, DateTimeKind.Local).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 8, 1, 11, 52, 33, 389, DateTimeKind.Local).AddTicks(9399), new DateTime(2023, 8, 1, 11, 52, 33, 389, DateTimeKind.Local).AddTicks(9409) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 8, 1, 11, 52, 33, 389, DateTimeKind.Local).AddTicks(9412), new DateTime(2023, 8, 1, 11, 52, 33, 389, DateTimeKind.Local).AddTicks(9414) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 8, 1, 11, 52, 33, 389, DateTimeKind.Local).AddTicks(9416), new DateTime(2023, 8, 1, 11, 52, 33, 389, DateTimeKind.Local).AddTicks(9417) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 8, 1, 11, 52, 33, 389, DateTimeKind.Local).AddTicks(9418), new DateTime(2023, 8, 1, 11, 52, 33, 389, DateTimeKind.Local).AddTicks(9423) });
        }
    }
}
