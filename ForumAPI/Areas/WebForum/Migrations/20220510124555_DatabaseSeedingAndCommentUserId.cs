using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ForumAPI.Areas.WebForum.Migrations
{
    public partial class DatabaseSeedingAndCommentUserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "IntroText" },
                values: new object[,]
                {
                    { 1, "Elden Ring General Diskussion", null },
                    { 2, "Elden Ring Lore", null },
                    { 3, "Elden Ring PvP", null },
                    { 4, "Elden Ring Trade Co-op and Help", null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserName",
                value: "TopDude");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserName",
                value: "Benitarex");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserName",
                value: "MindOfBenita");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "UserName",
                value: "Gamerpigeon");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "UserName",
                value: "Pigeon Boy");

            migrationBuilder.InsertData(
                table: "Moderators",
                columns: new[] { "Id", "CategoryId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 3, 2 },
                    { 4, 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "DateOfCreation", "FlaggedInapropriate", "Text", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 5, 10, 14, 45, 55, 471, DateTimeKind.Local).AddTicks(2338), false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris vel nunc ante. Fusce id nisl venenatis, mattis massa ut, laoreet velit. Vestibulum et est a diam rhoncus cursus non quis ipsum. Cras dignissim at massa ac finibus. Aenean non odio sed nisi ultrices ultrices vitae mollis risus. Quisque eleifend, leo quis consectetur placerat, mauris dolor congue quam, sit amet gravida augue quam quis augue. Maecenas et pulvinar ipsum. Sed lobortis vestibulum dolor vel rhoncus. Vestibulum non venenatis sapien, non blandit augue. Vivamus tortor libero, viverra ac vestibulum vel, c", 1 },
                    { 2, 1, new DateTime(2022, 5, 10, 14, 45, 55, 471, DateTimeKind.Local).AddTicks(2371), false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris vel nunc ante. Fusce id nisl venenatis, mattis massa ut, laoreet velit. Vestibulum et est a diam rhoncus cursus non quis ipsum. Cras dignissim at massa ac finibus. Aenean non odio sed nisi ultrices ultrices vitae mollis risus. Quisque eleifend, leo quis consectetur placerat, mauris dolor congue quam, sit amet gravida augue quam quis augue. Maecenas et pulvinar ipsum. Sed lobortis vestibulum dolor vel rhoncus. Vestibulum non venenatis sapien, non blandit augue. Vivamus tortor libero, viverra ac vestibulum vel, c", 1 },
                    { 3, 2, new DateTime(2022, 5, 10, 14, 45, 55, 471, DateTimeKind.Local).AddTicks(2372), false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris vel nunc ante. Fusce id nisl venenatis, mattis massa ut, laoreet velit. Vestibulum et est a diam rhoncus cursus non quis ipsum. Cras dignissim at massa ac finibus. Aenean non odio sed nisi ultrices ultrices vitae mollis risus. Quisque eleifend, leo quis consectetur placerat, mauris dolor congue quam, sit amet gravida augue quam quis augue. Maecenas et pulvinar ipsum. Sed lobortis vestibulum dolor vel rhoncus. Vestibulum non venenatis sapien, non blandit augue. Vivamus tortor libero, viverra ac vestibulum vel, c", 2 },
                    { 4, 4, new DateTime(2022, 5, 10, 14, 45, 55, 471, DateTimeKind.Local).AddTicks(2374), false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris vel nunc ante. Fusce id nisl venenatis, mattis massa ut, laoreet velit. Vestibulum et est a diam rhoncus cursus non quis ipsum. Cras dignissim at massa ac finibus. Aenean non odio sed nisi ultrices ultrices vitae mollis risus. Quisque eleifend, leo quis consectetur placerat, mauris dolor congue quam, sit amet gravida augue quam quis augue. Maecenas et pulvinar ipsum. Sed lobortis vestibulum dolor vel rhoncus. Vestibulum non venenatis sapien, non blandit augue. Vivamus tortor libero, viverra ac vestibulum vel, c", 3 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "FlaggedInapropriate", "PostId", "Text", "TimeOfCreation", "UserId" },
                values: new object[,]
                {
                    { 1, false, 1, "Imagine using Lorum Ipsum :)", new DateTime(2022, 5, 10, 14, 45, 55, 471, DateTimeKind.Local).AddTicks(2386), null },
                    { 2, false, 1, "Imagine using Lorum Ipsum :)", new DateTime(2022, 5, 10, 14, 45, 55, 471, DateTimeKind.Local).AddTicks(2388), null },
                    { 3, false, 1, "Imagine using Lorum Ipsum :)", new DateTime(2022, 5, 10, 14, 45, 55, 471, DateTimeKind.Local).AddTicks(2390), null },
                    { 4, false, 2, "Imagine using Lorum Ipsum :)", new DateTime(2022, 5, 10, 14, 45, 55, 471, DateTimeKind.Local).AddTicks(2391), null },
                    { 5, false, 2, "Imagine using Lorum Ipsum :)", new DateTime(2022, 5, 10, 14, 45, 55, 471, DateTimeKind.Local).AddTicks(2393), null },
                    { 6, false, 1, "Imagine using Lorum Ipsum :)", new DateTime(2022, 5, 10, 14, 45, 55, 471, DateTimeKind.Local).AddTicks(2395), null },
                    { 7, false, 4, "Imagine using Lorum Ipsum :)", new DateTime(2022, 5, 10, 14, 45, 55, 471, DateTimeKind.Local).AddTicks(2396), null },
                    { 8, false, 4, "Imagine using Lorum Ipsum :)", new DateTime(2022, 5, 10, 14, 45, 55, 471, DateTimeKind.Local).AddTicks(2398), null },
                    { 9, false, 3, "Imagine using Lorum Ipsum :)", new DateTime(2022, 5, 10, 14, 45, 55, 471, DateTimeKind.Local).AddTicks(2399), null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Moderators",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Moderators",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Moderators",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Moderators",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserName",
                value: "Vraksi");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserName",
                value: "Vraksi");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserName",
                value: "Vraksi");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "UserName",
                value: "Vraksi");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "UserName",
                value: "Vraksi");
        }
    }
}
