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
    public class KullaniciHareketiMap : IEntityTypeConfiguration<KullaniciHareketi>
    {
        public void Configure(EntityTypeBuilder<KullaniciHareketi> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Aciklama).HasColumnType("varchar").HasMaxLength(300);
            builder.HasOne(x => x.Kullanici).WithMany(x => x.KullaniciHareketi).HasForeignKey(x => x.KullaniciId).IsRequired();
        }
    }
}
