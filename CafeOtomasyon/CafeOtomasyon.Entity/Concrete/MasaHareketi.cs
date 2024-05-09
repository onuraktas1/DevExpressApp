using CafeOtomasyon.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Entity.Concrete
{
    public class MasaHareketi : IEntity
    {
        public int Id { get; set; }
        public string SatisKodu { get; set; }
        public int MasaId { get; set; }
        public int Miktar { get; set; }
        public decimal BirimFiyati { get; set; }
        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }
        public Masa Masa { get; set; }
    }
}
