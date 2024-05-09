using CafeOtomasyon.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Entity.Concrete
{
    public class Satis : IEntity
    {
        public int Id { get; set; }
        public string SatisKodu { get; set; }
        public decimal Tutar { get; set; }
        public decimal Odenen { get; set; }
        public decimal Kalan { get; set; }
        public string Aciklama { get; set; }
        public DateTime SonIslemTarihi { get; set; }
    }
}
