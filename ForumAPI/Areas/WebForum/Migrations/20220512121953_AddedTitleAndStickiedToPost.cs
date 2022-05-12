using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ForumAPI.Areas.WebForum.Migrations
{
    public partial class AddedTitleAndStickiedToPost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Stickied",
                table: "Posts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CategoryName",
                value: "Elden Ring Builds");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CategoryName",
                value: "Elden Ring Community");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CategoryName",
                value: "Elden Ring Co-op and Help");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "IntroText" },
                values: new object[,]
                {
                    { 5, "Elden Ring PvP", null },
                    { 6, "Elden Ring Support", null },
                    { 7, "Elden Ring Trade", null }
                });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TimeOfCreation", "UserId" },
                values: new object[] { new DateTime(2022, 5, 12, 14, 19, 52, 764, DateTimeKind.Local).AddTicks(7586), 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TimeOfCreation", "UserId" },
                values: new object[] { new DateTime(2022, 5, 12, 14, 19, 52, 764, DateTimeKind.Local).AddTicks(7589), 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "TimeOfCreation", "UserId" },
                values: new object[] { new DateTime(2022, 5, 12, 14, 19, 52, 764, DateTimeKind.Local).AddTicks(7591), 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "TimeOfCreation", "UserId" },
                values: new object[] { new DateTime(2022, 5, 12, 14, 19, 52, 764, DateTimeKind.Local).AddTicks(7592), 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "TimeOfCreation", "UserId" },
                values: new object[] { new DateTime(2022, 5, 12, 14, 19, 52, 764, DateTimeKind.Local).AddTicks(7623), 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "TimeOfCreation", "UserId" },
                values: new object[] { new DateTime(2022, 5, 12, 14, 19, 52, 764, DateTimeKind.Local).AddTicks(7626), 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "TimeOfCreation", "UserId" },
                values: new object[] { new DateTime(2022, 5, 12, 14, 19, 52, 764, DateTimeKind.Local).AddTicks(7628), 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "TimeOfCreation", "UserId" },
                values: new object[] { new DateTime(2022, 5, 12, 14, 19, 52, 764, DateTimeKind.Local).AddTicks(7630), 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "TimeOfCreation", "UserId" },
                values: new object[] { new DateTime(2022, 5, 12, 14, 19, 52, 764, DateTimeKind.Local).AddTicks(7631), 3 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfCreation", "Title" },
                values: new object[] { new DateTime(2022, 5, 12, 14, 19, 52, 764, DateTimeKind.Local).AddTicks(7523), "MIN TITEL ER DEN BEDSTE" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfCreation", "Title" },
                values: new object[] { new DateTime(2022, 5, 12, 14, 19, 52, 764, DateTimeKind.Local).AddTicks(7567), "Den er meget fin" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfCreation", "Title" },
                values: new object[] { new DateTime(2022, 5, 12, 14, 19, 52, 764, DateTimeKind.Local).AddTicks(7569), "Dette build er over powered" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfCreation", "Title" },
                values: new object[] { new DateTime(2022, 5, 12, 14, 19, 52, 764, DateTimeKind.Local).AddTicks(7571), "Hjælp til første boss" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DropColumn(
                name: "Stickied",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Posts");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CategoryName",
                value: "Elden Ring Lore");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CategoryName",
                value: "Elden Ring PvP");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CategoryName",
                value: "Elden Ring Trade Co-op and Help");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TimeOfCreation", "UserId" },
                values: new object[] { new DateTime(2022, 5, 11, 12, 35, 39, 896, DateTimeKind.Local).AddTicks(542), null });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TimeOfCreation", "UserId" },
                values: new object[] { new DateTime(2022, 5, 11, 12, 35, 39, 896, DateTimeKind.Local).AddTicks(544), null });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "TimeOfCreation", "UserId" },
                values: new object[] { new DateTime(2022, 5, 11, 12, 35, 39, 896, DateTimeKind.Local).AddTicks(546), null });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "TimeOfCreation", "UserId" },
                values: new object[] { new DateTime(2022, 5, 11, 12, 35, 39, 896, DateTimeKind.Local).AddTicks(547), null });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "TimeOfCreation", "UserId" },
                values: new object[] { new DateTime(2022, 5, 11, 12, 35, 39, 896, DateTimeKind.Local).AddTicks(549), null });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "TimeOfCreation", "UserId" },
                values: new object[] { new DateTime(2022, 5, 11, 12, 35, 39, 896, DateTimeKind.Local).AddTicks(550), null });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "TimeOfCreation", "UserId" },
                values: new object[] { new DateTime(2022, 5, 11, 12, 35, 39, 896, DateTimeKind.Local).AddTicks(552), null });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "TimeOfCreation", "UserId" },
                values: new object[] { new DateTime(2022, 5, 11, 12, 35, 39, 896, DateTimeKind.Local).AddTicks(553), null });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "TimeOfCreation", "UserId" },
                values: new object[] { new DateTime(2022, 5, 11, 12, 35, 39, 896, DateTimeKind.Local).AddTicks(555), null });

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
        }
    }
}
