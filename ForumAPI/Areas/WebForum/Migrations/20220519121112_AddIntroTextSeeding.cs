using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ForumAPI.Areas.WebForum.Migrations
{
    public partial class AddIntroTextSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "IntroText",
                value: "Hej dette er min intro text1");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "IntroText",
                value: "Hej dette er min intro text2");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "IntroText",
                value: "Hej dette er min intro text3");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "IntroText",
                value: "Hej dette er min intro text4");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "IntroText",
                value: "Hej dette er min intro text5");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "IntroText",
                value: "Hej dette er min intro text6");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "IntroText",
                value: "Hej dette er min intro text7");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "IntroText",
                value: "Hej dette er min intro text8");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 19, 14, 11, 12, 113, DateTimeKind.Local).AddTicks(3484));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 19, 14, 11, 12, 113, DateTimeKind.Local).AddTicks(3487));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 19, 14, 11, 12, 113, DateTimeKind.Local).AddTicks(3488));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 19, 14, 11, 12, 113, DateTimeKind.Local).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 19, 14, 11, 12, 113, DateTimeKind.Local).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 19, 14, 11, 12, 113, DateTimeKind.Local).AddTicks(3494));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 19, 14, 11, 12, 113, DateTimeKind.Local).AddTicks(3496));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 19, 14, 11, 12, 113, DateTimeKind.Local).AddTicks(3498));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 19, 14, 11, 12, 113, DateTimeKind.Local).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfCreation",
                value: new DateTime(2022, 5, 19, 14, 11, 12, 113, DateTimeKind.Local).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfCreation",
                value: new DateTime(2022, 5, 19, 14, 11, 12, 113, DateTimeKind.Local).AddTicks(3467));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfCreation",
                value: new DateTime(2022, 5, 19, 14, 11, 12, 113, DateTimeKind.Local).AddTicks(3469));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfCreation",
                value: new DateTime(2022, 5, 19, 14, 11, 12, 113, DateTimeKind.Local).AddTicks(3471));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "IntroText",
                value: null);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "IntroText",
                value: null);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "IntroText",
                value: null);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "IntroText",
                value: null);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "IntroText",
                value: null);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "IntroText",
                value: null);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "IntroText",
                value: null);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "IntroText",
                value: null);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 19, 13, 8, 34, 715, DateTimeKind.Local).AddTicks(9055));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 19, 13, 8, 34, 715, DateTimeKind.Local).AddTicks(9058));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 19, 13, 8, 34, 715, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 19, 13, 8, 34, 715, DateTimeKind.Local).AddTicks(9062));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 19, 13, 8, 34, 715, DateTimeKind.Local).AddTicks(9064));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 19, 13, 8, 34, 715, DateTimeKind.Local).AddTicks(9065));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 19, 13, 8, 34, 715, DateTimeKind.Local).AddTicks(9067));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 19, 13, 8, 34, 715, DateTimeKind.Local).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 19, 13, 8, 34, 715, DateTimeKind.Local).AddTicks(9071));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfCreation",
                value: new DateTime(2022, 5, 19, 13, 8, 34, 715, DateTimeKind.Local).AddTicks(9003));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfCreation",
                value: new DateTime(2022, 5, 19, 13, 8, 34, 715, DateTimeKind.Local).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfCreation",
                value: new DateTime(2022, 5, 19, 13, 8, 34, 715, DateTimeKind.Local).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfCreation",
                value: new DateTime(2022, 5, 19, 13, 8, 34, 715, DateTimeKind.Local).AddTicks(9042));
        }
    }
}
