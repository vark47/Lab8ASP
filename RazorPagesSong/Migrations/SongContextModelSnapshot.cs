﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using RazorPagesSong.Models;
using System;

namespace RazorPagesSong.Migrations
{
    [DbContext(typeof(SongContext))]
    partial class SongContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RazorPagesSong.Models.Song", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Album")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("Artist")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Composer")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("Rating");

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("Writer")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("ID");

                    b.ToTable("Song");
                });
#pragma warning restore 612, 618
        }
    }
}
