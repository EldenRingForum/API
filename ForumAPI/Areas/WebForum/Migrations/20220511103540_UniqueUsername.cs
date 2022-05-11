using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ForumAPI.Areas.WebForum.Migrations
{
    public partial class UniqueUsername : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 11, 12, 35, 39, 896, DateTimeKind.Local).AddTicks(542));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 11, 12, 35, 39, 896, DateTimeKind.Local).AddTicks(544));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 11, 12, 35, 39, 896, DateTimeKind.Local).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 11, 12, 35, 39, 896, DateTimeKind.Local).AddTicks(547));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 11, 12, 35, 39, 896, DateTimeKind.Local).AddTicks(549));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 11, 12, 35, 39, 896, DateTimeKind.Local).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 11, 12, 35, 39, 896, DateTimeKind.Local).AddTicks(552));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 11, 12, 35, 39, 896, DateTimeKind.Local).AddTicks(553));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 11, 12, 35, 39, 896, DateTimeKind.Local).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfCreation",
                value: new DateTime(2022, 5, 11, 12, 35, 39, 896, DateTimeKind.Local).AddTicks(494));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfCreation",
                value: new DateTime(2022, 5, 11, 12, 35, 39, 896, DateTimeKind.Local).AddTicks(526));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfCreation",
                value: new DateTime(2022, 5, 11, 12, 35, 39, 896, DateTimeKind.Local).AddTicks(528));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfCreation",
                value: new DateTime(2022, 5, 11, 12, 35, 39, 896, DateTimeKind.Local).AddTicks(530));

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true,
                filter: "[UserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_UserName",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 10, 14, 45, 55, 471, DateTimeKind.Local).AddTicks(2386));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 10, 14, 45, 55, 471, DateTimeKind.Local).AddTicks(2388));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 10, 14, 45, 55, 471, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 10, 14, 45, 55, 471, DateTimeKind.Local).AddTicks(2391));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 10, 14, 45, 55, 471, DateTimeKind.Local).AddTicks(2393));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 10, 14, 45, 55, 471, DateTimeKind.Local).AddTicks(2395));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 10, 14, 45, 55, 471, DateTimeKind.Local).AddTicks(2396));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 10, 14, 45, 55, 471, DateTimeKind.Local).AddTicks(2398));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 10, 14, 45, 55, 471, DateTimeKind.Local).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfCreation",
                value: new DateTime(2022, 5, 10, 14, 45, 55, 471, DateTimeKind.Local).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfCreation",
                value: new DateTime(2022, 5, 10, 14, 45, 55, 471, DateTimeKind.Local).AddTicks(2371));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfCreation",
                value: new DateTime(2022, 5, 10, 14, 45, 55, 471, DateTimeKind.Local).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfCreation",
                value: new DateTime(2022, 5, 10, 14, 45, 55, 471, DateTimeKind.Local).AddTicks(2374));
        }
    }
}
