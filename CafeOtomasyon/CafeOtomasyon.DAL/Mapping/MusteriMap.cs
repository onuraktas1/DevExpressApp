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
    public class MusteriMap : IEntityTypeConfiguration<Musteri>
    {
        public void Configure(EntityTypeBuilder<Musteri> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.AdiSoyadi).HasColumnType("varchar").HasMaxLength(100);
            builder.Property(x => x.Telefon).HasColumnType("varchar").HasMaxLength(11);
            builder.Property(x => x.Adres).HasColumnType("varchar").HasMaxLength(200);
            builder.Property(x => x.Aciklama).HasColumnType("varchar").HasMaxLength(500);
            builder.Property(x => x.Email).HasColumnType("varchar").HasMaxLength(150);
        }
    }
}
