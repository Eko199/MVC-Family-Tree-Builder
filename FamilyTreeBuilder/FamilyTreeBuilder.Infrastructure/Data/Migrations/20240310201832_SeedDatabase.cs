using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FamilyTreeBuilder.Data.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "452e31c3-35d2-4e20-a8c3-6d9867eed7c5", 0, "76e1e4d1-9988-457d-9b40-b98557fdcf61", "test2@gmail.com", false, false, null, "TEST2@GMAIL.COM", "TEST2@GMAIL.COM", "AQAAAAEAACcQAAAAEC2a/sUHFRJ7+FbmXNNYgsm1QC6kD1dUVLX3xtTOEYuD+agpQR9Ac2SnDngcGTnfhQ==", null, false, "77ae96e3-3ce8-4178-b780-681186f32ca5", false, "test2@gmail.com" },
                    { "e242c80f-4ea6-4e87-9e45-dddc94e6fcc8", 0, "446f1b6c-12ec-4ce3-833a-e40c3bf30a21", "test@gmail.com", false, false, null, "TEST@GMAIL.COM", "TEST@GMAIL.COM", "AQAAAAEAACcQAAAAEDvque7MB85KU16uAVUUEZc3VnzzjISp31DWb4yu2GvOrGXTtWwe2Jinv4FLKWpZaQ==", null, false, "f949c61e-ad49-4dd2-8ac1-2839a64af72d", false, "test@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "male" },
                    { 2, "female" }
                });

            migrationBuilder.InsertData(
                table: "RelationshipTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Married" },
                    { 2, "Divorced" },
                    { 3, "Partners" }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Biography", "Birthday", "DeathDate", "FatherId", "FirstName", "GenderId", "IsDeceased", "LastName", "MotherId" },
                values: new object[,]
                {
                    { 3, null, new DateTime(1955, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Gergana", 2, false, "Ivanova", null },
                    { 4, null, new DateTime(1920, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Peter", 1, true, "Ivanov", null },
                    { 5, null, null, null, null, "Maria", 2, false, "Ivanova", null },
                    { 7, null, new DateTime(1982, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ivanka", 2, false, "Ivanova", null }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Biography", "Birthday", "DeathDate", "FatherId", "FirstName", "GenderId", "IsDeceased", "LastName", "MotherId" },
                values: new object[] { 2, null, new DateTime(1950, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, "Georgi", 1, false, "Ivanov", 5 });

            migrationBuilder.InsertData(
                table: "Relationships",
                columns: new[] { "Id", "Person1Id", "Person2Id", "Start", "TypeId" },
                values: new object[] { 1, 4, 5, new DateTime(1949, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Biography", "Birthday", "DeathDate", "FatherId", "FirstName", "GenderId", "IsDeceased", "LastName", "MotherId" },
                values: new object[] { 1, "Default biography", new DateTime(1980, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, "Ivan", 1, false, "Ivanov", 3 });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Biography", "Birthday", "DeathDate", "FatherId", "FirstName", "GenderId", "IsDeceased", "LastName", "MotherId" },
                values: new object[] { 6, null, new DateTime(1985, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, "Ivancho", 1, false, "Ivanov", 3 });

            migrationBuilder.InsertData(
                table: "Relationships",
                columns: new[] { "Id", "Person1Id", "Person2Id", "Start", "TypeId" },
                values: new object[] { 2, 2, 3, null, 2 });

            migrationBuilder.InsertData(
                table: "Facts",
                columns: new[] { "Id", "Date", "Description", "PersonId", "Title" },
                values: new object[] { 1, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is a test fact", 1, "Test fact" });

            migrationBuilder.InsertData(
                table: "FamilyTrees",
                columns: new[] { "Id", "Description", "MainPersonId", "OwnerId", "Title" },
                values: new object[] { 1, "Default description", 1, "e242c80f-4ea6-4e87-9e45-dddc94e6fcc8", "Test Tree" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Biography", "Birthday", "DeathDate", "FatherId", "FirstName", "GenderId", "IsDeceased", "LastName", "MotherId" },
                values: new object[] { 8, null, new DateTime(2012, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "Ivanka", 2, false, "Ivanova", 7 });

            migrationBuilder.InsertData(
                table: "Facts",
                columns: new[] { "Id", "Date", "Description", "PersonId", "Title" },
                values: new object[] { 2, new DateTime(2019, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Primary education", 8, "Education" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "452e31c3-35d2-4e20-a8c3-6d9867eed7c5");

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FamilyTrees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RelationshipTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Relationships",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Relationships",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e242c80f-4ea6-4e87-9e45-dddc94e6fcc8");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "RelationshipTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RelationshipTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
