﻿// <auto-generated />
using System;
using CafeOtomasyon.DAL.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CafeOtomasyon.DAL.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240519092529_mig_6")]
    partial class mig_6
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CafeOtomasyon.Entity.Concrete.Kullanici", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar");

                    b.Property<string>("AdSoyad")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar");

                    b.Property<bool>("AktifMi")
                        .HasColumnType("bit");

                    b.Property<string>("Cevap")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar");

                    b.Property<string>("Gorevi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<string>("HatirlatmaSorusu")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<string>("Parola")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("varchar");

                    b.HasKey("Id");

                    b.ToTable("Kullanicilar");
                });

            modelBuilder.Entity("CafeOtomasyon.Entity.Concrete.KullaniciHareketi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar");

                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("KullaniciId");

                    b.ToTable("KullaniciHareketleri");
                });

            modelBuilder.Entity("CafeOtomasyon.Entity.Concrete.Masa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<DateTime>("EklenmeTarihi")
                        .HasColumnType("Date");

                    b.Property<string>("MasaAdi")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar");

                    b.Property<bool>("RezerveMi")
                        .HasColumnType("bit");

                    b.Property<DateTime>("SonIslemTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Masalar");
                });

            modelBuilder.Entity("CafeOtomasyon.Entity.Concrete.MasaHareketi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar");

                    b.Property<decimal>("BirimFiyati")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("MasaId")
                        .HasColumnType("int");

                    b.Property<int>("MenuId")
                        .HasColumnType("int");

                    b.Property<int>("Miktar")
                        .HasColumnType("int");

                    b.Property<string>("SatisKodu")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.Property<int>("UrunId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MasaId");

                    b.ToTable("MasaHareketleri");
                });

            modelBuilder.Entity("CafeOtomasyon.Entity.Concrete.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar");

                    b.Property<string>("MenuAdi")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("varchar");

                    b.HasKey("Id");

                    b.ToTable("Menuler");
                });

            modelBuilder.Entity("CafeOtomasyon.Entity.Concrete.OdemeHareketi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar");

                    b.Property<string>("OdemeTuru")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<decimal>("Odenen")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SatisKodu")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("OdemeHareketleri");
                });

            modelBuilder.Entity("CafeOtomasyon.Entity.Concrete.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ControlCaption")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<string>("ControlName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<string>("FormName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Roller");
                });

            modelBuilder.Entity("CafeOtomasyon.Entity.Concrete.Satis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar");

                    b.Property<decimal>("Kalan")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Odenen")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SatisKodu")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar");

                    b.Property<DateTime>("SonIslemTarihi")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Tutar")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Satislar");
                });

            modelBuilder.Entity("CafeOtomasyon.Entity.Concrete.Urun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar");

                    b.Property<decimal>("BirimFiyati1")
                        .HasPrecision(28, 2)
                        .HasColumnType("decimal(28,2)");

                    b.Property<decimal>("BirimFiyati2")
                        .HasPrecision(28, 2)
                        .HasColumnType("decimal(28,2)");

                    b.Property<int>("MenuId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.Property<string>("UrunAdi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<string>("UrunKodu")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.ToTable("Urunler");
                });

            modelBuilder.Entity("CafeOtomasyon.Entity.Concrete.KullaniciHareketi", b =>
                {
                    b.HasOne("CafeOtomasyon.Entity.Concrete.Kullanici", "Kullanici")
                        .WithMany("KullaniciHareketi")
                        .HasForeignKey("KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kullanici");
                });

            modelBuilder.Entity("CafeOtomasyon.Entity.Concrete.MasaHareketi", b =>
                {
                    b.HasOne("CafeOtomasyon.Entity.Concrete.Masa", "Masa")
                        .WithMany("MasaHareketi")
                        .HasForeignKey("MasaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Masa");
                });

            modelBuilder.Entity("CafeOtomasyon.Entity.Concrete.Urun", b =>
                {
                    b.HasOne("CafeOtomasyon.Entity.Concrete.Menu", "Menu")
                        .WithMany("Urun")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Menu");
                });

            modelBuilder.Entity("CafeOtomasyon.Entity.Concrete.Kullanici", b =>
                {
                    b.Navigation("KullaniciHareketi");
                });

            modelBuilder.Entity("CafeOtomasyon.Entity.Concrete.Masa", b =>
                {
                    b.Navigation("MasaHareketi");
                });

            modelBuilder.Entity("CafeOtomasyon.Entity.Concrete.Menu", b =>
                {
                    b.Navigation("Urun");
                });
#pragma warning restore 612, 618
        }
    }
}
