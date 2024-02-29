using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FamilyTreeBuilder.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Unique gender identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "Gender name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RelationshipTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Unique relationship type identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Relationship type name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelationshipTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Unique person identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Person first name"),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Person last name"),
                    GenderId = table.Column<int>(type: "int", nullable: false, comment: "Identifier of gender entity"),
                    IsDeceased = table.Column<bool>(type: "bit", nullable: false, comment: "True if the person has died"),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Person's date of birth"),
                    DeathDate = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Person's date of death"),
                    Biography = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true, comment: "Person biography"),
                    FatherId = table.Column<int>(type: "int", nullable: true, comment: "Identifier of father's entity"),
                    MotherId = table.Column<int>(type: "int", nullable: true, comment: "Identifier of mother's entity")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                    table.ForeignKey(
                        name: "FK_People_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_People_People_FatherId",
                        column: x => x.FatherId,
                        principalTable: "People",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_People_People_MotherId",
                        column: x => x.MotherId,
                        principalTable: "People",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Facts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Unique fact identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false, comment: "Fact title"),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true, comment: "Fact description"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date of fact"),
                    PersonId = table.Column<int>(type: "int", nullable: false, comment: "Identifier of fact's person")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Facts_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FamilyTrees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Unique family tree identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Family tree name"),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true, comment: "Family tree description"),
                    OwnerId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Identifier of the user who owns the tree (usually the creator)"),
                    MainPersonId = table.Column<int>(type: "int", nullable: false, comment: "Identifier of the main person of the tree")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamilyTrees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FamilyTrees_AspNetUsers_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FamilyTrees_People_MainPersonId",
                        column: x => x.MainPersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Relationships",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Unique relationship identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeId = table.Column<int>(type: "int", nullable: false, comment: "Identifier of relationship type"),
                    Person1Id = table.Column<int>(type: "int", nullable: false, comment: "Identifier of first person in relationship"),
                    Person2Id = table.Column<int>(type: "int", nullable: false, comment: "Identifier of second person in relationship"),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date and time of relationship start")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relationships", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Relationships_People_Person1Id",
                        column: x => x.Person1Id,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Relationships_People_Person2Id",
                        column: x => x.Person2Id,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Relationships_RelationshipTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "RelationshipTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Facts_PersonId",
                table: "Facts",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_FamilyTrees_MainPersonId",
                table: "FamilyTrees",
                column: "MainPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_FamilyTrees_OwnerId",
                table: "FamilyTrees",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_People_FatherId",
                table: "People",
                column: "FatherId");

            migrationBuilder.CreateIndex(
                name: "IX_People_GenderId",
                table: "People",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_People_MotherId",
                table: "People",
                column: "MotherId");

            migrationBuilder.CreateIndex(
                name: "IX_Relationships_Person1Id",
                table: "Relationships",
                column: "Person1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Relationships_Person2Id",
                table: "Relationships",
                column: "Person2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Relationships_TypeId",
                table: "Relationships",
                column: "TypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Facts");

            migrationBuilder.DropTable(
                name: "FamilyTrees");

            migrationBuilder.DropTable(
                name: "Relationships");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "RelationshipTypes");

            migrationBuilder.DropTable(
                name: "Genders");
        }
    }
}
