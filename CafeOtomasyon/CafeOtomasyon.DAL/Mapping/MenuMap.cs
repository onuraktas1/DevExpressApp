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
    public class MenuMap : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(p => p.MenuAdi).HasColumnType("varchar").HasMaxLength(75);
            builder.Property(P => P.Aciklama).HasColumnType("varchar").HasMaxLength(300);
        }
    }
}
