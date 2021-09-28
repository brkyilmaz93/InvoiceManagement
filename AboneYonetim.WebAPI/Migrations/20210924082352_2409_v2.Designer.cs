﻿// <auto-generated />
using System;
using AboneYonetim.WebAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AboneYonetim.WebAPI.Migrations
{
    [DbContext(typeof(AboneYonetimContext))]
    [Migration("20210924082352_2409_v2")]
    partial class _2409_v2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AboneYonetim.Entities.Concrete.ABONE", b =>
                {
                    b.Property<int>("ObjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboneNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdSoyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Aktif")
                        .HasColumnType("bit");

                    b.Property<int?>("Du_KullaniciID")
                        .HasColumnType("int");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("DuzeltmeTarih")
                        .HasColumnType("datetime2");

                    b.Property<string>("Eposta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Ka_KullaniciID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("KayitTarih")
                        .HasColumnType("datetime2");

                    b.Property<int>("KulID")
                        .HasColumnType("int");

                    b.Property<int?>("Sil_KullaniciID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("SilmeTarih")
                        .HasColumnType("datetime2");

                    b.Property<string>("TcKimlikNO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelefonNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ObjectID");

                    b.HasIndex("KulID");

                    b.ToTable("ABONELER");
                });

            modelBuilder.Entity("AboneYonetim.Entities.Concrete.FATURA", b =>
                {
                    b.Property<int>("ObjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AboneID")
                        .HasColumnType("int");

                    b.Property<bool>("Aktif")
                        .HasColumnType("bit");

                    b.Property<int?>("Du_KullaniciID")
                        .HasColumnType("int");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("DuzeltmeTarih")
                        .HasColumnType("datetime2");

                    b.Property<string>("FaturaDonemi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FaturaDuzenlenmeTarih")
                        .HasColumnType("datetime2");

                    b.Property<string>("FaturaNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("FaturaOdendiMi")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("FaturaSonOdemeTarih")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("FaturaTutari")
                        .HasColumnType("decimal(18,4)");

                    b.Property<int?>("Ka_KullaniciID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("KayitTarih")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Sil_KullaniciID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("SilmeTarih")
                        .HasColumnType("datetime2");

                    b.Property<int>("TahsilatID")
                        .HasColumnType("int");

                    b.HasKey("ObjectID");

                    b.HasIndex("AboneID");

                    b.HasIndex("TahsilatID");

                    b.ToTable("FATURALAR");
                });

            modelBuilder.Entity("AboneYonetim.Entities.Concrete.KULLANICI", b =>
                {
                    b.Property<int>("ObjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdSoyad")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<bool>("Aktif")
                        .HasColumnType("bit");

                    b.Property<int?>("Du_KullaniciID")
                        .HasColumnType("int");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("DuzeltmeTarih")
                        .HasColumnType("datetime2");

                    b.Property<string>("Eposta")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("GsmNo")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int?>("Ka_KullaniciID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("KayitTarih")
                        .HasColumnType("datetime2");

                    b.Property<string>("Kulad")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("RolID")
                        .HasColumnType("int");

                    b.Property<string>("Sifre")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("Sil_KullaniciID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("SilmeTarih")
                        .HasColumnType("datetime2");

                    b.Property<string>("TcNo")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("ObjectID");

                    b.HasIndex("RolID");

                    b.ToTable("KULLANICILAR");
                });

            modelBuilder.Entity("AboneYonetim.Entities.Concrete.KULLANICI_ROL", b =>
                {
                    b.Property<int>("ObjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Aktif")
                        .HasColumnType("bit");

                    b.Property<int?>("Du_KullaniciID")
                        .HasColumnType("int");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("DuzeltmeTarih")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Ka_KullaniciID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("KayitTarih")
                        .HasColumnType("datetime2");

                    b.Property<string>("RolAd")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("Sil_KullaniciID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("SilmeTarih")
                        .HasColumnType("datetime2");

                    b.HasKey("ObjectID");

                    b.ToTable("KULLANICI_ROLLER");
                });

            modelBuilder.Entity("AboneYonetim.Entities.Concrete.TAHSILAT", b =>
                {
                    b.Property<int>("ObjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AboneID")
                        .HasColumnType("int");

                    b.Property<bool>("Aktif")
                        .HasColumnType("bit");

                    b.Property<int?>("Du_KullaniciID")
                        .HasColumnType("int");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("DuzeltmeTarih")
                        .HasColumnType("datetime2");

                    b.Property<int>("FaturaID")
                        .HasColumnType("int");

                    b.Property<int?>("Ka_KullaniciID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("KayitTarih")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Sil_KullaniciID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("SilmeTarih")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TahTarhi")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TahTutar")
                        .HasColumnType("decimal(18,4)");

                    b.HasKey("ObjectID");

                    b.HasIndex("AboneID");

                    b.HasIndex("FaturaID");

                    b.ToTable("TAHSILATLAR");
                });

            modelBuilder.Entity("AboneYonetim.Entities.Concrete.ABONE", b =>
                {
                    b.HasOne("AboneYonetim.Entities.Concrete.KULLANICI", "Kullanici")
                        .WithMany()
                        .HasForeignKey("KulID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kullanici");
                });

            modelBuilder.Entity("AboneYonetim.Entities.Concrete.FATURA", b =>
                {
                    b.HasOne("AboneYonetim.Entities.Concrete.ABONE", "Abone")
                        .WithMany()
                        .HasForeignKey("AboneID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AboneYonetim.Entities.Concrete.TAHSILAT", "Tahsilat")
                        .WithMany()
                        .HasForeignKey("TahsilatID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Abone");

                    b.Navigation("Tahsilat");
                });

            modelBuilder.Entity("AboneYonetim.Entities.Concrete.KULLANICI", b =>
                {
                    b.HasOne("AboneYonetim.Entities.Concrete.KULLANICI_ROL", "KullaniciRol")
                        .WithMany()
                        .HasForeignKey("RolID");

                    b.Navigation("KullaniciRol");
                });

            modelBuilder.Entity("AboneYonetim.Entities.Concrete.TAHSILAT", b =>
                {
                    b.HasOne("AboneYonetim.Entities.Concrete.ABONE", "Abone")
                        .WithMany()
                        .HasForeignKey("AboneID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AboneYonetim.Entities.Concrete.FATURA", "Fatura")
                        .WithMany()
                        .HasForeignKey("FaturaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Abone");

                    b.Navigation("Fatura");
                });
#pragma warning restore 612, 618
        }
    }
}
