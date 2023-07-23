﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SeaweedExplorer.Data;

#nullable disable

namespace SeaweedExplorer.Migrations
{
    [DbContext(typeof(SeeweedDbContext))]
    [Migration("20230723200005_Timestamp")]
    partial class Timestamp
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SeaweedExplorer.Data.Models.Seeweed", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NameCommon")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("NameLatin")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("Native")
                        .HasColumnType("bit");

                    b.Property<int?>("SeeweedClassId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.HasIndex("SeeweedClassId");

                    b.ToTable("Seeweed");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            NameCommon = "Tarmrørhinde",
                            NameLatin = "",
                            Native = true,
                            SeeweedClassId = 3
                        },
                        new
                        {
                            Id = 2,
                            NameCommon = "Søl",
                            NameLatin = "",
                            Native = true,
                            SeeweedClassId = 1
                        },
                        new
                        {
                            Id = 3,
                            NameCommon = "Carrageentang",
                            NameLatin = "",
                            Native = true,
                            SeeweedClassId = 1
                        },
                        new
                        {
                            Id = 4,
                            NameCommon = "Gaffeltang",
                            NameLatin = "",
                            Native = true,
                            SeeweedClassId = 1
                        },
                        new
                        {
                            Id = 5,
                            NameCommon = "Fingertang",
                            NameLatin = "",
                            Native = true,
                            SeeweedClassId = 2
                        },
                        new
                        {
                            Id = 6,
                            NameCommon = "Sukkertang",
                            NameLatin = "",
                            Native = true,
                            SeeweedClassId = 2
                        },
                        new
                        {
                            Id = 7,
                            NameCommon = "Blæretang",
                            NameLatin = "",
                            Native = true,
                            SeeweedClassId = 2
                        },
                        new
                        {
                            Id = 8,
                            NameCommon = "Savtang",
                            NameLatin = "",
                            Native = true,
                            SeeweedClassId = 2
                        });
                });

            modelBuilder.Entity("SeaweedExplorer.Data.Models.SeeweedClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NameCommon")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("NameLatin")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("SeeweedClass");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            NameCommon = "Rødalge",
                            NameLatin = "Chondrus crispus"
                        },
                        new
                        {
                            Id = 2,
                            NameCommon = "Brunalge",
                            NameLatin = "Laminaria digitata"
                        },
                        new
                        {
                            Id = 3,
                            NameCommon = "Grønalge",
                            NameLatin = "Ulva lactuca"
                        });
                });

            modelBuilder.Entity("SeaweedExplorer.Data.Models.Seeweed", b =>
                {
                    b.HasOne("SeaweedExplorer.Data.Models.SeeweedClass", "SeeweedClass")
                        .WithMany("Seeweeds")
                        .HasForeignKey("SeeweedClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SeeweedClass");
                });

            modelBuilder.Entity("SeaweedExplorer.Data.Models.SeeweedClass", b =>
                {
                    b.Navigation("Seeweeds");
                });
#pragma warning restore 612, 618
        }
    }
}