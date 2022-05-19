using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ForumAPI.Areas.WebForum.Migrations
{
    public partial class UserNameUnique_CategoryLink : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageLink",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryName", "ImageLink" },
                values: new object[] { "Elden Ring General Discussion", "https://eldenring.wiki.fextralife.com/file/Elden-Ring/flask_of_crimson_tears_elden_ring_wiki_guide_200px.png" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageLink",
                value: "https://eldenring.wiki.fextralife.com/file/Elden-Ring/crafting_kit_elden_ring_wiki_guide_200px.png");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageLink",
                value: "https://eldenring.wiki.fextralife.com/file/Elden-Ring/golden_order_seal_sacred_seal_weapon_elden_ring_wiki_guide_200px.png");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageLink",
                value: "https://eldenring.wiki.fextralife.com/file/Elden-Ring/tarnisheds_furled_finger_elden_ring_wiki_guide_200px.png");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryName", "ImageLink" },
                values: new object[] { "Elden Ring Lore", "https://eldenring.wiki.fextralife.com/file/Elden-Ring/conspectus_scroll_elden_ring_wiki_guide_200px.png" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryName", "ImageLink" },
                values: new object[] { "Elden Ring PvP", "https://eldenring.wiki.fextralife.com/file/Elden-Ring/recusant_finger_elden_ring_wiki_guide_200px.png" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryName", "ImageLink" },
                values: new object[] { "Elden Ring Support", "https://eldenring.wiki.fextralife.com/file/Elden-Ring/spirit_calling_bell_elden_ring_wiki_guide_200px.png" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "ImageLink", "IntroText" },
                values: new object[] { 8, "Elden Ring Trade", "https://eldenring.wiki.fextralife.com/file/Elden-Ring/lords-rune-tools-elden-ring-wiki-guide.png", null });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DropColumn(
                name: "ImageLink",
                table: "Categories");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CategoryName",
                value: "Elden Ring General Diskussion");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CategoryName",
                value: "Elden Ring PvP");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CategoryName",
                value: "Elden Ring Support");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CategoryName",
                value: "Elden Ring Trade");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 12, 14, 19, 52, 764, DateTimeKind.Local).AddTicks(7586));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 12, 14, 19, 52, 764, DateTimeKind.Local).AddTicks(7589));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 12, 14, 19, 52, 764, DateTimeKind.Local).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 12, 14, 19, 52, 764, DateTimeKind.Local).AddTicks(7592));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 12, 14, 19, 52, 764, DateTimeKind.Local).AddTicks(7623));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 12, 14, 19, 52, 764, DateTimeKind.Local).AddTicks(7626));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 12, 14, 19, 52, 764, DateTimeKind.Local).AddTicks(7628));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 12, 14, 19, 52, 764, DateTimeKind.Local).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "TimeOfCreation",
                value: new DateTime(2022, 5, 12, 14, 19, 52, 764, DateTimeKind.Local).AddTicks(7631));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfCreation",
                value: new DateTime(2022, 5, 12, 14, 19, 52, 764, DateTimeKind.Local).AddTicks(7523));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfCreation",
                value: new DateTime(2022, 5, 12, 14, 19, 52, 764, DateTimeKind.Local).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfCreation",
                value: new DateTime(2022, 5, 12, 14, 19, 52, 764, DateTimeKind.Local).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfCreation",
                value: new DateTime(2022, 5, 12, 14, 19, 52, 764, DateTimeKind.Local).AddTicks(7571));
        }
    }
}
