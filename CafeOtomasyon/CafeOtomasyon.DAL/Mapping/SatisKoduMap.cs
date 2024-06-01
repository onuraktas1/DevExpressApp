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
    public class SatisKoduMap : IEntityTypeConfiguration<SatisKodu>
    {
        public void Configure(EntityTypeBuilder<SatisKodu> builder)
        {
            builder.Property(x => x.SatisTanimi).HasMaxLength(20);
        }
    }
}
