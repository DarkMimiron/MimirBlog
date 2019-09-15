﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MimirBlog.Data;

namespace MimirBlog.Migrations
{
    [DbContext(typeof(MimirBlogContext))]
    partial class MimirBlogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MimirBlog.Models.Entry", b =>
                {
                    b.Property<int>("EntryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Text")
                        .HasMaxLength(8000);

                    b.Property<string>("Title")
                        .HasMaxLength(100);

                    b.HasKey("EntryId");

                    b.ToTable("Entry");
                });

            modelBuilder.Entity("MimirBlog.Models.EntryTag", b =>
                {
                    b.Property<int>("EntryId");

                    b.Property<int>("TagId");

                    b.HasKey("EntryId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("EntryTag");
                });

            modelBuilder.Entity("MimirBlog.Models.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(50);

                    b.HasKey("TagId");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("MimirBlog.Models.EntryTag", b =>
                {
                    b.HasOne("MimirBlog.Models.Entry", "Entry")
                        .WithMany("EntryTags")
                        .HasForeignKey("EntryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MimirBlog.Models.Tag", "Tag")
                        .WithMany("EntryTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
