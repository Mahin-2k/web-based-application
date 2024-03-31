﻿// <auto-generated />
using System;
using DigiCV.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DigiCV.Web.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DigiCV.Domain.Entities.Contact", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("DigiCV.Domain.Entities.Education", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Grade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PassingYear")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ResumeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("University")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ResumeId");

                    b.ToTable("Education");
                });

            modelBuilder.Entity("DigiCV.Domain.Entities.Email", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsSent")
                        .HasColumnType("bit");

                    b.Property<string>("ReceiverEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReceiverName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Emails");
                });

            modelBuilder.Entity("DigiCV.Domain.Entities.Experience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Companay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("JoiningDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ResignationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Responsibilities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ResumeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ResumeId");

                    b.ToTable("Experience");
                });

            modelBuilder.Entity("DigiCV.Domain.Entities.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ResumeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ResumeId");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("DigiCV.Domain.Entities.Reference", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Compnay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ResumeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ResumeId");

                    b.ToTable("Reference");
                });

            modelBuilder.Entity("DigiCV.Domain.Entities.Resume", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ApplicationUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkedIn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ResumeTemplateId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Skype")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Trainings")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("ResumeTemplateId");

                    b.ToTable("Resume");
                });

            modelBuilder.Entity("DigiCV.Domain.Entities.ResumeSkill", b =>
                {
                    b.Property<Guid>("ResumeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SkillId")
                        .HasColumnType("int");

                    b.HasKey("ResumeId", "SkillId");

                    b.HasIndex("SkillId");

                    b.ToTable("ResumeSkill");
                });

            modelBuilder.Entity("DigiCV.Domain.Entities.ResumeTemplate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ResumeTemplate");

                    b.HasData(
                        new
                        {
                            Id = new Guid("933b1bdb-19df-4e24-bf1f-49f5abd8aef6"),
                            ImageName = "34a90fa4-ce8a-499c-8182-852a7125141f.png",
                            IsActive = true,
                            Name = "Modern"
                        },
                        new
                        {
                            Id = new Guid("933b1bdb-19df-4e24-bf1f-49f5abd8aef7"),
                            ImageName = "22ce39f1-a576-4e66-a9b3-312552c95dde.png",
                            IsActive = true,
                            Name = "Standard"
                        });
                });

            modelBuilder.Entity("DigiCV.Domain.Entities.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Skill");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = ".Net Core, Web API, NodeJs"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Asp.net, .Net MVC"
                        },
                        new
                        {
                            Id = 3,
                            Name = "C#, VB.Net"
                        },
                        new
                        {
                            Id = 4,
                            Name = "LINQ, SQL, Entity Framework and MongoDB"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Angular 6, Angular 1 and MEAN Stack"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Javascript, JQuery and Ajax"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Bootstrap CSS, HTML"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Crystal and RDLC Report"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Design Pattern & Principles, OOP Software Design& Architecture"
                        },
                        new
                        {
                            Id = 10,
                            Name = "TFS, GIT, V. SourceSafe, Trello, Agile, SCRUM"
                        });
                });

            modelBuilder.Entity("DigiCV.Domain.Entities.Template", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Template");
                });

            modelBuilder.Entity("DigiCV.Domain.Entities.UserProfile", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Designation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Education")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Experience")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GithubUsername")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LinkedInUsername")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserProfile");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9749e4e1-f89c-42bd-8a04-5a79993a58f9"),
                            Address = "Room No. 419, BSMRH Hall, MBSTU",
                            Designation = ".NET Developer",
                            Education = "Mawlana Bhashani Science and Technology University, Tangail",
                            Experience = "C#, ASP.NET, EF Core",
                            GithubUsername = "absa1am",
                            ImageUrl = "24fc78b6-8f28-468f-9476-e21e4cfaca6b.png",
                            IsActive = true,
                            LinkedInUsername = "absa1am"
                        },
                        new
                        {
                            Id = new Guid("a618e70b-3cdb-420a-a1b3-702d0b06e9c2"),
                            Address = "Room No. 419, BSMRH Hall, MBSTU",
                            Designation = ".NET Developer",
                            Education = "Mawlana Bhashani Science and Technology University, Tangail",
                            Experience = "C#, ASP.NET, EF Core",
                            GithubUsername = "absa1am",
                            ImageUrl = "6d0bcabd-744c-4bdd-8e69-8f30088c984d.png",
                            IsActive = true,
                            LinkedInUsername = "absa1am"
                        });
                });

            modelBuilder.Entity("DigiCV.Persistence.Features.Membership.ApplicationRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

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

            modelBuilder.Entity("DigiCV.Persistence.Features.Membership.ApplicationRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("DigiCV.Persistence.Features.Membership.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

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

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("JoiningDate")
                        .HasColumnType("datetime2");

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

                    b.Property<Guid>("UserProfileId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("UserProfileId");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("e26967f0-ce4c-4c14-8a0b-45beb8c9eb48"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "09960ff2-3d4b-41cf-9c4e-57d96c988693",
                            Email = "admin@digicv.com",
                            EmailConfirmed = true,
                            FullName = "Admin",
                            JoiningDate = new DateTime(2023, 10, 28, 3, 44, 46, 900, DateTimeKind.Local).AddTicks(2186),
                            LockoutEnabled = true,
                            NormalizedEmail = "ADMIN@DIGICV.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAIAAYagAAAAECxZd1huf+2OLCZK18ayYdmtOD/at7yjlVp6v/A+Q/83ty3XIaSd73qU59tn1gWe1w==",
                            PhoneNumber = "+8801856817465",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "BFCC7B453A8B4B6C8A4C93EE28A3B4A8",
                            TwoFactorEnabled = false,
                            UserName = "admin",
                            UserProfileId = new Guid("9749e4e1-f89c-42bd-8a04-5a79993a58f9")
                        },
                        new
                        {
                            Id = new Guid("5f4c76d3-79b0-4923-86a7-511ac60c2ab9"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c39ac3d7-09cb-486f-8544-fc4dd6ff83c9",
                            Email = "manager@digicv.com",
                            EmailConfirmed = true,
                            FullName = "Manager",
                            JoiningDate = new DateTime(2023, 10, 28, 3, 44, 46, 949, DateTimeKind.Local).AddTicks(3801),
                            LockoutEnabled = true,
                            NormalizedEmail = "MANAGER@DIGICV.COM",
                            NormalizedUserName = "MANAGER",
                            PasswordHash = "AQAAAAIAAYagAAAAEJU72hWURWHMCL7m5ZMd9owy+HqRgZdHDg53AExekMqu+r7H5vvYW6mPHxXctSYF7A==",
                            PhoneNumber = "+8801856817465",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "FC37C84E276C4D978DF9054129D0CB23",
                            TwoFactorEnabled = false,
                            UserName = "manager",
                            UserProfileId = new Guid("a618e70b-3cdb-420a-a1b3-702d0b06e9c2")
                        });
                });

            modelBuilder.Entity("DigiCV.Persistence.Features.Membership.ApplicationUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClaimType = "Administrator",
                            ClaimValue = "Administrator",
                            UserId = new Guid("e26967f0-ce4c-4c14-8a0b-45beb8c9eb48")
                        },
                        new
                        {
                            Id = 2,
                            ClaimType = "Manager",
                            ClaimValue = "Manager",
                            UserId = new Guid("5f4c76d3-79b0-4923-86a7-511ac60c2ab9")
                        });
                });

            modelBuilder.Entity("DigiCV.Persistence.Features.Membership.ApplicationUserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("DigiCV.Persistence.Features.Membership.ApplicationUserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("DigiCV.Persistence.Features.Membership.ApplicationUserToken", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("DigiCV.Domain.Entities.Education", b =>
                {
                    b.HasOne("DigiCV.Domain.Entities.Resume", "Resume")
                        .WithMany("Educations")
                        .HasForeignKey("ResumeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resume");
                });

            modelBuilder.Entity("DigiCV.Domain.Entities.Experience", b =>
                {
                    b.HasOne("DigiCV.Domain.Entities.Resume", "Resume")
                        .WithMany("Experiences")
                        .HasForeignKey("ResumeId");

                    b.Navigation("Resume");
                });

            modelBuilder.Entity("DigiCV.Domain.Entities.Project", b =>
                {
                    b.HasOne("DigiCV.Domain.Entities.Resume", "Resume")
                        .WithMany("Projects")
                        .HasForeignKey("ResumeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resume");
                });

            modelBuilder.Entity("DigiCV.Domain.Entities.Reference", b =>
                {
                    b.HasOne("DigiCV.Domain.Entities.Resume", "Resume")
                        .WithMany("References")
                        .HasForeignKey("ResumeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resume");
                });

            modelBuilder.Entity("DigiCV.Domain.Entities.Resume", b =>
                {
                    b.HasOne("DigiCV.Persistence.Features.Membership.ApplicationUser", null)
                        .WithMany("Resumes")
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("DigiCV.Domain.Entities.ResumeTemplate", "ResumeTemplate")
                        .WithMany("Resumes")
                        .HasForeignKey("ResumeTemplateId");

                    b.Navigation("ResumeTemplate");
                });

            modelBuilder.Entity("DigiCV.Domain.Entities.ResumeSkill", b =>
                {
                    b.HasOne("DigiCV.Domain.Entities.Resume", "Resume")
                        .WithMany("Skills")
                        .HasForeignKey("ResumeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DigiCV.Domain.Entities.Skill", "Skill")
                        .WithMany("Resumes")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resume");

                    b.Navigation("Skill");
                });

            modelBuilder.Entity("DigiCV.Persistence.Features.Membership.ApplicationRoleClaim", b =>
                {
                    b.HasOne("DigiCV.Persistence.Features.Membership.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DigiCV.Persistence.Features.Membership.ApplicationUser", b =>
                {
                    b.HasOne("DigiCV.Domain.Entities.UserProfile", "UserProfile")
                        .WithMany()
                        .HasForeignKey("UserProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserProfile");
                });

            modelBuilder.Entity("DigiCV.Persistence.Features.Membership.ApplicationUserClaim", b =>
                {
                    b.HasOne("DigiCV.Persistence.Features.Membership.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DigiCV.Persistence.Features.Membership.ApplicationUserLogin", b =>
                {
                    b.HasOne("DigiCV.Persistence.Features.Membership.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DigiCV.Persistence.Features.Membership.ApplicationUserRole", b =>
                {
                    b.HasOne("DigiCV.Persistence.Features.Membership.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DigiCV.Persistence.Features.Membership.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DigiCV.Persistence.Features.Membership.ApplicationUserToken", b =>
                {
                    b.HasOne("DigiCV.Persistence.Features.Membership.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DigiCV.Domain.Entities.Resume", b =>
                {
                    b.Navigation("Educations");

                    b.Navigation("Experiences");

                    b.Navigation("Projects");

                    b.Navigation("References");

                    b.Navigation("Skills");
                });

            modelBuilder.Entity("DigiCV.Domain.Entities.ResumeTemplate", b =>
                {
                    b.Navigation("Resumes");
                });

            modelBuilder.Entity("DigiCV.Domain.Entities.Skill", b =>
                {
                    b.Navigation("Resumes");
                });

            modelBuilder.Entity("DigiCV.Persistence.Features.Membership.ApplicationUser", b =>
                {
                    b.Navigation("Resumes");
                });
#pragma warning restore 612, 618
        }
    }
}
