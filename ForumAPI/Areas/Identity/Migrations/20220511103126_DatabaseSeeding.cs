using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ForumAPI.Areas.Identity.Migrations
{
    public partial class DatabaseSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "66cf8789-99dc-4e8a-a163-3c6d924e8efe", "2", "MODERATOR", "MODERATOR" },
                    { "9d3d19bc-efdd-4791-a967-7ce36e2a7061", "3", "ADMIN", "ADMIN" },
                    { "d950013d-971c-45f3-907b-bf282f37359f", "1", "USER", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "74379d0f-1055-4a73-ab60-d972dc91518a", 0, "1f131b1e-ce5d-4e0e-97e8-d6bc77f132d4", "jegeerenrigtigmail3@mail.com", true, false, null, "JEGEERENRIGTIGMAIL3@MAIL.COM", null, "AQAAAAEAACcQAAAAEIUY8cEB2u45f/RcYxVVY6J1BQMZ31q9i6WIdcEYz5NkT+sUtxZO+sK3YQYH4ShX4g==", "+111111111111", true, "c0533172-8fcd-4037-8def-5d04b4d6bd65", false, "Vraksi" },
                    { "76bb83fe-ff31-4f1b-8884-cefb30e0c552", 0, "2dfc644c-8e4d-46d4-900b-b3fd024b3feb", "enrigtigmail3@mail.com", true, false, null, "ENRIGTIGMAIL3@MAIL.COM", null, "AQAAAAEAACcQAAAAEIoTI8R+K4J6U90LJRpBo5HyisboqFRjMdz8yvJDc4lTMpJ6xWOSJRO7iPQXCyj7rA==", "+111111111111", true, "77bf27db-c1fd-4436-827f-aa0b42f7b086", false, "MindOfBenita" },
                    { "8af154e9-fb65-41ab-96ef-4f47775c32a7", 0, "3fd898bc-3a70-401c-abc8-419b5a7eb77f", "jegeerenmail3@mail.com", true, false, null, "JEGEERENMAIL3@MAIL.COM", null, "AQAAAAEAACcQAAAAEHStYSlBv02HIlWZr3mHW8dYxk9Wtu0sAKKm87KbMFdhENwfegqLXAxHi5HZ0kpJag==", "+111111111111", true, "d2c30cb2-7d50-4f04-a62f-875a65c85e63", false, "Gamerpigeon" },
                    { "ec66faf9-f096-47b1-8934-9e9c4746ebb1", 0, "45a3c506-26b4-4a22-89e3-15d2c17df63b", "eerenrigtigmail3@mail.com", true, false, null, "EERENRIGTIGMAIL3@MAIL.COM", null, "AQAAAAEAACcQAAAAEIilKH9AVHbpzfkWk1EJMdZkbkp+WM8SopIhDh+4nitPDDMWpF+WvhfyrxlynLzFew==", "+111111111111", true, "a5c6bb08-50f7-44af-9841-4661865dcb5f", false, "Benitarex" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "66cf8789-99dc-4e8a-a163-3c6d924e8efe", "74379d0f-1055-4a73-ab60-d972dc91518a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d950013d-971c-45f3-907b-bf282f37359f", "74379d0f-1055-4a73-ab60-d972dc91518a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d950013d-971c-45f3-907b-bf282f37359f", "ec66faf9-f096-47b1-8934-9e9c4746ebb1" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_UserName",
                table: "AspNetUsers",
                column: "UserName",
                unique: true,
                filter: "[UserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_UserName",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d3d19bc-efdd-4791-a967-7ce36e2a7061");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "66cf8789-99dc-4e8a-a163-3c6d924e8efe", "74379d0f-1055-4a73-ab60-d972dc91518a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d950013d-971c-45f3-907b-bf282f37359f", "74379d0f-1055-4a73-ab60-d972dc91518a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d950013d-971c-45f3-907b-bf282f37359f", "ec66faf9-f096-47b1-8934-9e9c4746ebb1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "76bb83fe-ff31-4f1b-8884-cefb30e0c552");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8af154e9-fb65-41ab-96ef-4f47775c32a7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "66cf8789-99dc-4e8a-a163-3c6d924e8efe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d950013d-971c-45f3-907b-bf282f37359f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "74379d0f-1055-4a73-ab60-d972dc91518a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ec66faf9-f096-47b1-8934-9e9c4746ebb1");
        }
    }
}
