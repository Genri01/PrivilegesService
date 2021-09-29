﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PrivilegesService.Dal;

namespace PrivilegesService.Migrations
{
    [DbContext(typeof(PrivilegesDbContext))]
    [Migration("20210929010653_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("PrivilegesService.Dal.PrivilegeEntity", b =>
                {
                    b.Property<Guid>("PrivilegeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset>("LastSavedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int[]>("Permissions")
                        .HasColumnType("integer[]");

                    b.HasKey("PrivilegeId");

                    b.ToTable("Privileges");
                });

            modelBuilder.Entity("PrivilegesService.Dal.UserEntity", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset>("LastSavedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("PrivilegeId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserSettingsId")
                        .HasColumnType("uuid");

                    b.HasKey("UserId");

                    b.HasIndex("PrivilegeId");

                    b.HasIndex("UserSettingsId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PrivilegesService.Dal.UserSettingsEntity", b =>
                {
                    b.Property<Guid>("UserSettingsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("LastSavedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("UserSettingsId");

                    b.ToTable("UserSettings");
                });

            modelBuilder.Entity("PrivilegesService.Dal.UserEntity", b =>
                {
                    b.HasOne("PrivilegesService.Dal.PrivilegeEntity", "Privilege")
                        .WithMany()
                        .HasForeignKey("PrivilegeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PrivilegesService.Dal.UserSettingsEntity", "UserSettings")
                        .WithMany()
                        .HasForeignKey("UserSettingsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Privilege");

                    b.Navigation("UserSettings");
                });
#pragma warning restore 612, 618
        }
    }
}
