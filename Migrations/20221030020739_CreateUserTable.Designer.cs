﻿// <auto-generated />
using System;
using JwtAuthServerApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace JwtAuthServerApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221030020739_CreateUserTable")]
    partial class CreateUserTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("JwtAuthServerApi.Models.User", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("varchar(55)");

                    b.Property<bool>("IsLocked")
                        .HasColumnType("bool");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varchar(100");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.HasKey("Guid");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
