using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ForumAPI.Areas.Identity.Migrations
{
    public partial class EmailUnique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "74379d0f-1055-4a73-ab60-d972dc91518a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58e77b3c-81e8-46ce-b3ad-ee2ac017dae0", "AQAAAAEAACcQAAAAEHVeF2xPtotVdk2et47x/baxkCDjZoG5ScnnZyXz51N3hlVinsjTZWuux0wqHuqm8w==", "92ade687-66d3-404d-92b1-7f9ae34ebb8f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "76bb83fe-ff31-4f1b-8884-cefb30e0c552",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0aba75ff-17f2-4e74-b1e4-d34c1d6e046b", "AQAAAAEAACcQAAAAEFBmFYaiOISKbCdw2gwshJZq8qY8Lz76LzDR0DYZgdO/Z5D7Tu3q9obMPUJ18o86cg==", "fcc92082-531c-4675-a9b9-46972b24464c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8af154e9-fb65-41ab-96ef-4f47775c32a7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0d5bfe9-c5cf-4600-916e-18c522d25317", "AQAAAAEAACcQAAAAEAyim3bPX8onWAkA/Uz0lOrSZqn3L5zMeIkqJPVxyjBvZufrlO1jPfb20NddxhXAPw==", "26c68cb7-ff8c-4547-a272-aad5d692b0bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ec66faf9-f096-47b1-8934-9e9c4746ebb1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93403d92-8e70-4886-a904-156577d964e7", "AQAAAAEAACcQAAAAEHlYWA4m/bGftXCavnd7RN8puavz9ce6hnPh7ShkAneY5x5CKwAezL60tjDlMo3mgw==", "61ffe5cd-51f7-4cd4-b531-f779e01ee488" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Email",
                table: "AspNetUsers",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Email",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "74379d0f-1055-4a73-ab60-d972dc91518a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f131b1e-ce5d-4e0e-97e8-d6bc77f132d4", "AQAAAAEAACcQAAAAEIUY8cEB2u45f/RcYxVVY6J1BQMZ31q9i6WIdcEYz5NkT+sUtxZO+sK3YQYH4ShX4g==", "c0533172-8fcd-4037-8def-5d04b4d6bd65" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "76bb83fe-ff31-4f1b-8884-cefb30e0c552",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2dfc644c-8e4d-46d4-900b-b3fd024b3feb", "AQAAAAEAACcQAAAAEIoTI8R+K4J6U90LJRpBo5HyisboqFRjMdz8yvJDc4lTMpJ6xWOSJRO7iPQXCyj7rA==", "77bf27db-c1fd-4436-827f-aa0b42f7b086" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8af154e9-fb65-41ab-96ef-4f47775c32a7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3fd898bc-3a70-401c-abc8-419b5a7eb77f", "AQAAAAEAACcQAAAAEHStYSlBv02HIlWZr3mHW8dYxk9Wtu0sAKKm87KbMFdhENwfegqLXAxHi5HZ0kpJag==", "d2c30cb2-7d50-4f04-a62f-875a65c85e63" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ec66faf9-f096-47b1-8934-9e9c4746ebb1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45a3c506-26b4-4a22-89e3-15d2c17df63b", "AQAAAAEAACcQAAAAEIilKH9AVHbpzfkWk1EJMdZkbkp+WM8SopIhDh+4nitPDDMWpF+WvhfyrxlynLzFew==", "a5c6bb08-50f7-44af-9841-4661865dcb5f" });
        }
    }
}
