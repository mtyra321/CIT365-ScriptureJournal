﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ScriptureJournal.Data;

namespace ScriptureJournal.Migrations
{
    [DbContext(typeof(ScriptureJournalContext))]
    partial class ScriptureJournalContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ScriptureJournal.Models.Scripture", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Book")
                        .HasColumnType("nvarchar(max)");

                    

                    b.Property<int>("chapter")
                        .HasColumnType("int");

                    b.Property<int>("verse")
                        .HasColumnType("int");
                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");
                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.HasKey("ID");

                    b.ToTable("Scripture");
                });
#pragma warning restore 612, 618
        }
    }
}
