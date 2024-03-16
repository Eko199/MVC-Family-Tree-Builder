﻿// <auto-generated />
using System;
using FamilyTreeBuilder.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FamilyTreeBuilder.Data.Migrations
{
    [DbContext(typeof(FamilyTreeBuilderDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FamilyTreeBuilder.Infrastructure.Data.Models.Fact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Unique fact identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2")
                        .HasComment("Date of fact");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasComment("Fact description");

                    b.Property<int>("PersonId")
                        .HasColumnType("int")
                        .HasComment("Identifier of fact's person");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)")
                        .HasComment("Fact title");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Facts");

                    b.HasComment("Person fact");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is a test fact",
                            PersonId = 1,
                            Title = "Test fact"
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2019, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Primary education",
                            PersonId = 8,
                            Title = "Education"
                        });
                });

            modelBuilder.Entity("FamilyTreeBuilder.Infrastructure.Data.Models.FamilyTree", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Unique family tree identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasComment("Family tree description");

                    b.Property<int>("MainPersonId")
                        .HasColumnType("int")
                        .HasComment("Identifier of the main person of the tree");

                    b.Property<string>("OwnerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Identifier of the user who owns the tree (usually the creator)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Family tree name");

                    b.HasKey("Id");

                    b.HasIndex("MainPersonId");

                    b.HasIndex("OwnerId");

                    b.ToTable("FamilyTrees");

                    b.HasComment("Family tree to store all people");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Default description",
                            MainPersonId = 1,
                            OwnerId = "0b6508aa-6609-41e6-9f7f-e9557f249a5d",
                            Title = "Test Tree"
                        });
                });

            modelBuilder.Entity("FamilyTreeBuilder.Infrastructure.Data.Models.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Unique gender identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasComment("Gender name");

                    b.HasKey("Id");

                    b.ToTable("Genders");

                    b.HasComment("Person gender");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "male"
                        },
                        new
                        {
                            Id = 2,
                            Name = "female"
                        });
                });

            modelBuilder.Entity("FamilyTreeBuilder.Infrastructure.Data.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Unique person identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Biography")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasComment("Person biography");

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("datetime2")
                        .HasComment("Person's date of birth");

                    b.Property<DateTime?>("DeathDate")
                        .HasColumnType("datetime2")
                        .HasComment("Person's date of death");

                    b.Property<int?>("FatherId")
                        .HasColumnType("int")
                        .HasComment("Identifier of father's entity");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Person first name");

                    b.Property<int>("GenderId")
                        .HasColumnType("int")
                        .HasComment("Identifier of gender entity");

                    b.Property<bool>("IsDeceased")
                        .HasColumnType("bit")
                        .HasComment("True if the person has died");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("Person last name");

                    b.Property<int?>("MotherId")
                        .HasColumnType("int")
                        .HasComment("Identifier of mother's entity");

                    b.HasKey("Id");

                    b.HasIndex("FatherId");

                    b.HasIndex("GenderId");

                    b.HasIndex("MotherId");

                    b.ToTable("People");

                    b.HasComment("Person information");

                    b.HasData(
                        new
                        {
                            Id = 4,
                            Birthday = new DateTime(1920, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeathDate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Peter",
                            GenderId = 1,
                            IsDeceased = true,
                            LastName = "Ivanov"
                        },
                        new
                        {
                            Id = 5,
                            FirstName = "Maria",
                            GenderId = 2,
                            IsDeceased = false,
                            LastName = "Ivanova"
                        },
                        new
                        {
                            Id = 2,
                            Birthday = new DateTime(1950, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FatherId = 4,
                            FirstName = "Georgi",
                            GenderId = 1,
                            IsDeceased = false,
                            LastName = "Ivanov",
                            MotherId = 5
                        },
                        new
                        {
                            Id = 3,
                            Birthday = new DateTime(1955, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Gergana",
                            GenderId = 2,
                            IsDeceased = false,
                            LastName = "Ivanova"
                        },
                        new
                        {
                            Id = 1,
                            Biography = "Default biography",
                            Birthday = new DateTime(1980, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FatherId = 2,
                            FirstName = "Ivan",
                            GenderId = 1,
                            IsDeceased = false,
                            LastName = "Ivanov",
                            MotherId = 3
                        },
                        new
                        {
                            Id = 6,
                            Birthday = new DateTime(1985, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FatherId = 2,
                            FirstName = "Ivancho",
                            GenderId = 1,
                            IsDeceased = false,
                            LastName = "Ivanov",
                            MotherId = 3
                        },
                        new
                        {
                            Id = 7,
                            Birthday = new DateTime(1982, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Ivanka",
                            GenderId = 2,
                            IsDeceased = false,
                            LastName = "Ivanova"
                        },
                        new
                        {
                            Id = 8,
                            Birthday = new DateTime(2012, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FatherId = 1,
                            FirstName = "Ivanka",
                            GenderId = 2,
                            IsDeceased = false,
                            LastName = "Ivanova",
                            MotherId = 7
                        });
                });

            modelBuilder.Entity("FamilyTreeBuilder.Infrastructure.Data.Models.Relationship", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Unique relationship identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Person1Id")
                        .HasColumnType("int")
                        .HasComment("Identifier of first person in relationship");

                    b.Property<int>("Person2Id")
                        .HasColumnType("int")
                        .HasComment("Identifier of second person in relationship");

                    b.Property<DateTime?>("Start")
                        .HasColumnType("datetime2")
                        .HasComment("Date and time of relationship start");

                    b.Property<int>("TypeId")
                        .HasColumnType("int")
                        .HasComment("Identifier of relationship type");

                    b.HasKey("Id");

                    b.HasIndex("Person1Id");

                    b.HasIndex("Person2Id");

                    b.HasIndex("TypeId");

                    b.ToTable("Relationships");

                    b.HasComment("Relationship between two people");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Person1Id = 4,
                            Person2Id = 5,
                            Start = new DateTime(1949, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TypeId = 1
                        },
                        new
                        {
                            Id = 2,
                            Person1Id = 2,
                            Person2Id = 3,
                            TypeId = 2
                        });
                });

            modelBuilder.Entity("FamilyTreeBuilder.Infrastructure.Data.Models.RelationshipType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Unique relationship type identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasComment("Relationship type name");

                    b.HasKey("Id");

                    b.ToTable("RelationshipTypes");

                    b.HasComment("Type of relationship between two people");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Married"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Divorced"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Partners"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "0b6508aa-6609-41e6-9f7f-e9557f249a5d",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4960dd55-7372-4cb2-8888-0f1c09a2abff",
                            Email = "test@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "TEST@GMAIL.COM",
                            NormalizedUserName = "TEST@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEJ9fmoZpFVw/sF1cqRUNcpWXkBIUC+NDAA8zgkch/lr2m0W34LBD53YTEeUiOBBqBA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0ac66297-864d-4f97-8521-b01c07ee69c8",
                            TwoFactorEnabled = false,
                            UserName = "test@gmail.com"
                        },
                        new
                        {
                            Id = "d3df2706-f4fd-423b-8b6e-25f2808e280a",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "cb297c8d-50cb-4930-bf80-9bc7be29bf48",
                            Email = "test2@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "TEST2@GMAIL.COM",
                            NormalizedUserName = "TEST2@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEEQjRdKnGLTLIdIz0Ipcd1QsrVcrgEol3nj4XQJY1GK4uuIZaRp3LRj3UufVDCIXug==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3875d59b-9e36-4129-a6d0-5d330c63e240",
                            TwoFactorEnabled = false,
                            UserName = "test2@gmail.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("FamilyTreeBuilder.Infrastructure.Data.Models.Fact", b =>
                {
                    b.HasOne("FamilyTreeBuilder.Infrastructure.Data.Models.Person", "Person")
                        .WithMany("Facts")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("FamilyTreeBuilder.Infrastructure.Data.Models.FamilyTree", b =>
                {
                    b.HasOne("FamilyTreeBuilder.Infrastructure.Data.Models.Person", "MainPerson")
                        .WithMany()
                        .HasForeignKey("MainPersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MainPerson");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("FamilyTreeBuilder.Infrastructure.Data.Models.Person", b =>
                {
                    b.HasOne("FamilyTreeBuilder.Infrastructure.Data.Models.Person", "Father")
                        .WithMany()
                        .HasForeignKey("FatherId");

                    b.HasOne("FamilyTreeBuilder.Infrastructure.Data.Models.Gender", "Gender")
                        .WithMany("People")
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FamilyTreeBuilder.Infrastructure.Data.Models.Person", "Mother")
                        .WithMany()
                        .HasForeignKey("MotherId");

                    b.Navigation("Father");

                    b.Navigation("Gender");

                    b.Navigation("Mother");
                });

            modelBuilder.Entity("FamilyTreeBuilder.Infrastructure.Data.Models.Relationship", b =>
                {
                    b.HasOne("FamilyTreeBuilder.Infrastructure.Data.Models.Person", "Person1")
                        .WithMany("Relationships")
                        .HasForeignKey("Person1Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FamilyTreeBuilder.Infrastructure.Data.Models.Person", "Person2")
                        .WithMany()
                        .HasForeignKey("Person2Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FamilyTreeBuilder.Infrastructure.Data.Models.RelationshipType", "Type")
                        .WithMany("Relationships")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person1");

                    b.Navigation("Person2");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FamilyTreeBuilder.Infrastructure.Data.Models.Gender", b =>
                {
                    b.Navigation("People");
                });

            modelBuilder.Entity("FamilyTreeBuilder.Infrastructure.Data.Models.Person", b =>
                {
                    b.Navigation("Facts");

                    b.Navigation("Relationships");
                });

            modelBuilder.Entity("FamilyTreeBuilder.Infrastructure.Data.Models.RelationshipType", b =>
                {
                    b.Navigation("Relationships");
                });
#pragma warning restore 612, 618
        }
    }
}
