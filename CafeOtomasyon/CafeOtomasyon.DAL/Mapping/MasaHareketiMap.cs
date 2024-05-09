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
    public class MasaHareketiMap : IEntityTypeConfiguration<MasaHareketi>
    {
        public void Configure(EntityTypeBuilder<MasaHareketi> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.SatisKodu).HasColumnType("varchar").HasMaxLength(15);
            builder.Property(x => x.Aciklama).HasColumnType("varchar").HasMaxLength(300);
            builder.HasOne(x => x.Masa).WithMany(x => x.MasaHareketi).HasForeignKey(x => x.MasaId).IsRequired();
        }
    }
}
