using CafeOtomasyon.DAL.Mapping;
using CafeOtomasyon.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.DAL.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=CafeDb;Trusted_Connection=True;TrustServerCertificate=true");
        }

        public DbSet<Menu> Menuler { get; set; }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Masa> Masalar { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<KullaniciHareketi> KullaniciHareketleri { get; set; }
        public DbSet<MasaHareketi> MasaHareketleri { get; set; }
        public DbSet<OdemeHareketi> OdemeHareketleri { get; set; }
        public DbSet<Rol> Roller { get; set; }
        public DbSet<Satis> Satislar { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MenuMap());
            modelBuilder.ApplyConfiguration(new KullaniciHareketiMap());
            modelBuilder.ApplyConfiguration(new KullaniciMap());
            modelBuilder.ApplyConfiguration(new MasaHareketiMap());
            modelBuilder.ApplyConfiguration(new MasaMap());
            modelBuilder.ApplyConfiguration(new OdemeHareketiMap());
            modelBuilder.ApplyConfiguration(new RolMap());
            modelBuilder.ApplyConfiguration(new SatisMap());
            modelBuilder.ApplyConfiguration(new UrunMap());

        }
    }
}
