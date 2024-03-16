using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FamilyTreeBuilder.Data.Migrations
{
    public partial class AddTableComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "452e31c3-35d2-4e20-a8c3-6d9867eed7c5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e242c80f-4ea6-4e87-9e45-dddc94e6fcc8");

            migrationBuilder.AlterTable(
                name: "RelationshipTypes",
                comment: "Type of relationship between two people");

            migrationBuilder.AlterTable(
                name: "Relationships",
                comment: "Relationship between two people");

            migrationBuilder.AlterTable(
                name: "People",
                comment: "Person information");

            migrationBuilder.AlterTable(
                name: "Genders",
                comment: "Person gender");

            migrationBuilder.AlterTable(
                name: "FamilyTrees",
                comment: "Family tree to store all people");

            migrationBuilder.AlterTable(
                name: "Facts",
                comment: "Person fact");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0b6508aa-6609-41e6-9f7f-e9557f249a5d", 0, "4960dd55-7372-4cb2-8888-0f1c09a2abff", "test@gmail.com", false, false, null, "TEST@GMAIL.COM", "TEST@GMAIL.COM", "AQAAAAEAACcQAAAAEJ9fmoZpFVw/sF1cqRUNcpWXkBIUC+NDAA8zgkch/lr2m0W34LBD53YTEeUiOBBqBA==", null, false, "0ac66297-864d-4f97-8521-b01c07ee69c8", false, "test@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d3df2706-f4fd-423b-8b6e-25f2808e280a", 0, "cb297c8d-50cb-4930-bf80-9bc7be29bf48", "test2@gmail.com", false, false, null, "TEST2@GMAIL.COM", "TEST2@GMAIL.COM", "AQAAAAEAACcQAAAAEEQjRdKnGLTLIdIz0Ipcd1QsrVcrgEol3nj4XQJY1GK4uuIZaRp3LRj3UufVDCIXug==", null, false, "3875d59b-9e36-4129-a6d0-5d330c63e240", false, "test2@gmail.com" });

            migrationBuilder.UpdateData(
                table: "FamilyTrees",
                keyColumn: "Id",
                keyValue: 1,
                column: "OwnerId",
                value: "0b6508aa-6609-41e6-9f7f-e9557f249a5d");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b6508aa-6609-41e6-9f7f-e9557f249a5d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d3df2706-f4fd-423b-8b6e-25f2808e280a");

            migrationBuilder.AlterTable(
                name: "RelationshipTypes",
                oldComment: "Type of relationship between two people");

            migrationBuilder.AlterTable(
                name: "Relationships",
                oldComment: "Relationship between two people");

            migrationBuilder.AlterTable(
                name: "People",
                oldComment: "Person information");

            migrationBuilder.AlterTable(
                name: "Genders",
                oldComment: "Person gender");

            migrationBuilder.AlterTable(
                name: "FamilyTrees",
                oldComment: "Family tree to store all people");

            migrationBuilder.AlterTable(
                name: "Facts",
                oldComment: "Person fact");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "452e31c3-35d2-4e20-a8c3-6d9867eed7c5", 0, "76e1e4d1-9988-457d-9b40-b98557fdcf61", "test2@gmail.com", false, false, null, "TEST2@GMAIL.COM", "TEST2@GMAIL.COM", "AQAAAAEAACcQAAAAEC2a/sUHFRJ7+FbmXNNYgsm1QC6kD1dUVLX3xtTOEYuD+agpQR9Ac2SnDngcGTnfhQ==", null, false, "77ae96e3-3ce8-4178-b780-681186f32ca5", false, "test2@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e242c80f-4ea6-4e87-9e45-dddc94e6fcc8", 0, "446f1b6c-12ec-4ce3-833a-e40c3bf30a21", "test@gmail.com", false, false, null, "TEST@GMAIL.COM", "TEST@GMAIL.COM", "AQAAAAEAACcQAAAAEDvque7MB85KU16uAVUUEZc3VnzzjISp31DWb4yu2GvOrGXTtWwe2Jinv4FLKWpZaQ==", null, false, "f949c61e-ad49-4dd2-8ac1-2839a64af72d", false, "test@gmail.com" });

            migrationBuilder.UpdateData(
                table: "FamilyTrees",
                keyColumn: "Id",
                keyValue: 1,
                column: "OwnerId",
                value: "e242c80f-4ea6-4e87-9e45-dddc94e6fcc8");
        }
    }
}
