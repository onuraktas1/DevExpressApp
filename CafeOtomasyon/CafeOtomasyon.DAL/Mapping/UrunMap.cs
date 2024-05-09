using CafeOtomasyon.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.DAL.Mapping
{
    internal class UrunMap : IEntityTypeConfiguration<Urun>
    {
        public void Configure(EntityTypeBuilder<Urun> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.UrunKodu).HasColumnType("varchar").HasMaxLength(15);
            builder.Property(x => x.UrunAdi).HasColumnType("varchar").HasMaxLength(50);
            builder.Property(x => x.Aciklama).HasColumnType("varchar").HasMaxLength(300);
            builder.Property(x => x.BirimFiyati1).HasPrecision(28, 2);
            builder.Property(x => x.BirimFiyati2).HasPrecision(28, 2);
            builder.HasOne(x => x.Menu).WithMany(x => x.Urun).HasForeignKey(x => x.MenuId).IsRequired();

        }
    }
}
