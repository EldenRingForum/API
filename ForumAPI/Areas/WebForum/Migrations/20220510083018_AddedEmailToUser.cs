using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ForumAPI.Areas.WebForum.Migrations
{
    public partial class AddedEmailToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ProfilePicture", "UserName" },
                values: new object[,]
                {
                    { 1, "jegeerenrigtigmail3@mail.com", "PFPasString", "Vraksi" },
                    { 2, "eerenrigtigmail3@mail.com", "PFPasString", "Vraksi" },
                    { 3, "enrigtigmail3@mail.com", "PFPasString", "Vraksi" },
                    { 4, "jegeerenmail3@mail.com", "PFPasString", "Vraksi" },
                    { 5, "jegeerenrigtigmail123@mail.com", "PFPasString", "Vraksi" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");
        }
    }
}
