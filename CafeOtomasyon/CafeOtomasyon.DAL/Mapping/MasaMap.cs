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
    public class MasaMap : IEntityTypeConfiguration<Masa>
    {
        public void Configure(EntityTypeBuilder<Masa> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.MasaAdi).HasColumnType("varchar").HasMaxLength(15);
            builder.Property(x => x.Aciklama).HasColumnType("varchar").HasMaxLength(300);
            builder.Property(x => x.EklenmeTarihi).HasColumnType("Date");
        }
    }
}
