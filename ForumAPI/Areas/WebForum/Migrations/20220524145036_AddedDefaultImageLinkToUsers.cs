using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ForumAPI.Areas.WebForum.Migrations
{
    public partial class AddedDefaultImageLinkToUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProfilePicture",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "https://i.pinimg.com/736x/74/b3/54/74b35486d3a1f639519ba0cf12821016.jpg",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 24, 16, 50, 36, 661, DateTimeKind.Local).AddTicks(3894));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 24, 16, 50, 36, 661, DateTimeKind.Local).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 24, 16, 50, 36, 661, DateTimeKind.Local).AddTicks(3898));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 24, 16, 50, 36, 661, DateTimeKind.Local).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 24, 16, 50, 36, 661, DateTimeKind.Local).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 24, 16, 50, 36, 661, DateTimeKind.Local).AddTicks(3903));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 24, 16, 50, 36, 661, DateTimeKind.Local).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 24, 16, 50, 36, 661, DateTimeKind.Local).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 24, 16, 50, 36, 661, DateTimeKind.Local).AddTicks(3909));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfCreation",
                value: new DateTime(2022, 5, 24, 16, 50, 36, 661, DateTimeKind.Local).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfCreation",
                value: new DateTime(2022, 5, 24, 16, 50, 36, 661, DateTimeKind.Local).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfCreation",
                value: new DateTime(2022, 5, 24, 16, 50, 36, 661, DateTimeKind.Local).AddTicks(3876));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfCreation",
                value: new DateTime(2022, 5, 24, 16, 50, 36, 661, DateTimeKind.Local).AddTicks(3878));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProfilePicture",
                value: "https://i.pinimg.com/736x/74/b3/54/74b35486d3a1f639519ba0cf12821016.jpg");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProfilePicture",
                value: "https://i.pinimg.com/736x/74/b3/54/74b35486d3a1f639519ba0cf12821016.jpg");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProfilePicture",
                value: "https://i.pinimg.com/736x/74/b3/54/74b35486d3a1f639519ba0cf12821016.jpg");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "ProfilePicture",
                value: "https://i.pinimg.com/736x/74/b3/54/74b35486d3a1f639519ba0cf12821016.jpg");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "ProfilePicture",
                value: "https://i.pinimg.com/736x/74/b3/54/74b35486d3a1f639519ba0cf12821016.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProfilePicture",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "https://i.pinimg.com/736x/74/b3/54/74b35486d3a1f639519ba0cf12821016.jpg");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 20, 10, 50, 4, 821, DateTimeKind.Local).AddTicks(2248));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 20, 10, 50, 4, 821, DateTimeKind.Local).AddTicks(2251));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 20, 10, 50, 4, 821, DateTimeKind.Local).AddTicks(2253));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 20, 10, 50, 4, 821, DateTimeKind.Local).AddTicks(2255));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 20, 10, 50, 4, 821, DateTimeKind.Local).AddTicks(2256));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 20, 10, 50, 4, 821, DateTimeKind.Local).AddTicks(2258));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 20, 10, 50, 4, 821, DateTimeKind.Local).AddTicks(2261));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 20, 10, 50, 4, 821, DateTimeKind.Local).AddTicks(2263));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 20, 10, 50, 4, 821, DateTimeKind.Local).AddTicks(2265));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfCreation",
                value: new DateTime(2022, 5, 20, 10, 50, 4, 821, DateTimeKind.Local).AddTicks(2167));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfCreation",
                value: new DateTime(2022, 5, 20, 10, 50, 4, 821, DateTimeKind.Local).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfCreation",
                value: new DateTime(2022, 5, 20, 10, 50, 4, 821, DateTimeKind.Local).AddTicks(2202));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfCreation",
                value: new DateTime(2022, 5, 20, 10, 50, 4, 821, DateTimeKind.Local).AddTicks(2204));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProfilePicture",
                value: "PFPasString");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProfilePicture",
                value: "PFPasString");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProfilePicture",
                value: "PFPasString");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "ProfilePicture",
                value: "PFPasString");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "ProfilePicture",
                value: "PFPasString");
        }
    }
}
