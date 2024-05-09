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
    public class RolMap : IEntityTypeConfiguration<Rol>
    {
        public void Configure(EntityTypeBuilder<Rol> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.ControlCaption).HasColumnType("varchar").HasMaxLength(50);
            builder.Property(x => x.ControlName).HasColumnType("varchar").HasMaxLength(50);
            builder.Property(x => x.FormName).HasColumnType("varchar").HasMaxLength(50);

        }
    }
}
