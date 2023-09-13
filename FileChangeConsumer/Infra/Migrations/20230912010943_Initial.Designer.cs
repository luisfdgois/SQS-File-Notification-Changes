﻿// <auto-generated />
using System;
using FileChangeConsumer.Infra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FileChangeConsumer.Migrations
{
    [DbContext(typeof(FileChangeContext))]
    [Migration("20230912010943_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("FileChangeConsumer.Domain.Entities.DomainFile", b =>
                {
                    b.Property<string>("Name")
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("Size")
                        .HasColumnType("bigint");

                    b.HasKey("Name");

                    b.ToTable("files", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}