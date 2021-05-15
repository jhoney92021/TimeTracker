﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using time_tracker.DataBase;

namespace time_tracker.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20210506153354_HarvestReplacemant3")]
    partial class HarvestReplacemant3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("time_tracker.Models.CompanySection", b =>
                {
                    b.Property<int>("CompanySectionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanySectionName")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("CompanySectionName");

                    b.HasKey("CompanySectionId");

                    b.ToTable("CompanySection", "TimeTracker");
                });

            modelBuilder.Entity("time_tracker.Models.CompanySubSection", b =>
                {
                    b.Property<int>("CompanySubSectionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CompanySectionId")
                        .HasColumnType("int");

                    b.Property<string>("SubSectionName")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("SubSectionName");

                    b.HasKey("CompanySubSectionId");

                    b.HasIndex("CompanySectionId");

                    b.ToTable("CompanySubSection", "TimeTracker");
                });

            modelBuilder.Entity("time_tracker.Models.CompanyTeam", b =>
                {
                    b.Property<int>("CompanySubSectionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanySubSectionId1")
                        .HasColumnType("int");

                    b.Property<string>("CompanyTeamName")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("CompanyTeamName");

                    b.HasKey("CompanySubSectionId");

                    b.HasIndex("CompanySubSectionId1");

                    b.ToTable("CompanyTeam", "TimeTracker");
                });

            modelBuilder.Entity("time_tracker.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CompanySectionId")
                        .HasColumnType("int");

                    b.Property<int?>("CompanySubSectionId")
                        .HasColumnType("int");

                    b.Property<int?>("CompanyTeamCompanySubSectionId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("EmailAddress");

                    b.Property<string>("FirstName")
                        .HasMaxLength(30)
                        .HasColumnType(" varchar(30)")
                        .HasColumnName("FirstName");

                    b.Property<string>("LastName")
                        .HasMaxLength(30)
                        .HasColumnType(" varchar(30)")
                        .HasColumnName("LastName");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("Password");

                    b.Property<string>("Team")
                        .HasColumnType("varchar(30)")
                        .HasColumnName("Team");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasColumnType("varchar(30)")
                        .HasColumnName("UserName");

                    b.HasKey("UserId");

                    b.HasIndex("CompanyTeamCompanySubSectionId");

                    b.ToTable("User", "TimeTracker");
                });

            modelBuilder.Entity("time_tracker.Models.CompanySubSection", b =>
                {
                    b.HasOne("time_tracker.Models.CompanySection", null)
                        .WithMany("SubSections")
                        .HasForeignKey("CompanySectionId");
                });

            modelBuilder.Entity("time_tracker.Models.CompanyTeam", b =>
                {
                    b.HasOne("time_tracker.Models.CompanySubSection", null)
                        .WithMany("Teams")
                        .HasForeignKey("CompanySubSectionId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("time_tracker.Models.User", b =>
                {
                    b.HasOne("time_tracker.Models.CompanyTeam", null)
                        .WithMany("Users")
                        .HasForeignKey("CompanyTeamCompanySubSectionId");
                });

            modelBuilder.Entity("time_tracker.Models.CompanySection", b =>
                {
                    b.Navigation("SubSections");
                });

            modelBuilder.Entity("time_tracker.Models.CompanySubSection", b =>
                {
                    b.Navigation("Teams");
                });

            modelBuilder.Entity("time_tracker.Models.CompanyTeam", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
