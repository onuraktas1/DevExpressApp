using CafeOtomasyon.Entity.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.DAL.Mapping
{
    public class KullaniciMap : IEntityTypeConfiguration<Kullanici>
    {
        public void Configure(EntityTypeBuilder<Kullanici> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Adres).HasColumnType("varchar").HasMaxLength(500);
            builder.Property(x => x.AdSoyad).HasColumnType("varchar").HasMaxLength(100);
            builder.Property(x => x.Telefon).HasColumnType("varchar").HasMaxLength(11);
            builder.Property(x => x.Email).HasColumnType("varchar").HasMaxLength(150);
            builder.Property(x => x.Gorevi).HasColumnType("varchar").HasMaxLength(50);
            builder.Property(x => x.KullaniciAdi).HasColumnType("varchar").HasMaxLength(50);
            builder.Property(x => x.Parola).HasColumnType("varchar").HasMaxLength(20);
            builder.Property(x => x.HatirlatmaSorusu).HasColumnType("varchar").HasMaxLength(150);
            builder.Property(x => x.Cevap).HasColumnType("varchar").HasMaxLength(50);
            builder.Property(x => x.Aciklama).HasColumnType("varchar").HasMaxLength(300);
       
        }
    }
}
