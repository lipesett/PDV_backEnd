﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PDV_backEnd.Data;

#nullable disable

namespace PDV_backEnd.Migrations
{
    [DbContext(typeof(PDVDbContext))]
    [Migration("20240505044238_StatusIncluded")]
    partial class StatusIncluded
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("PDV_backEnd.Models.KartodromoModel", b =>
                {
                    b.Property<int>("KAR_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("KAR_ID"));

                    b.Property<int>("CID_KARTODROMO")
                        .HasColumnType("int");

                    b.Property<string>("KAR_APELIDO")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("KAR_NOME")
                        .IsRequired()
                        .HasMaxLength(130)
                        .HasColumnType("varchar(130)");

                    b.Property<string>("KAR_NOMECURTO")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.HasKey("KAR_ID");

                    b.ToTable("Kartodromos");
                });

            modelBuilder.Entity("PDV_backEnd.Models.StatusModel", b =>
                {
                    b.Property<int>("STA_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("STA_ID"));

                    b.Property<int>("STA_ATIVO")
                        .HasColumnType("int");

                    b.Property<string>("STA_DESC")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.HasKey("STA_ID");

                    b.ToTable("Status");
                });
#pragma warning restore 612, 618
        }
    }
}
