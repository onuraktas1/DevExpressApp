using CafeOtomasyon.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Entity.Concrete
{
    public class Masa : IEntity
    {
        public int Id { get; set; }
        public string MasaAdi { get; set; }
        public string Aciklama { get; set; }
        public bool Durum { get; set; }
        public bool RezerveMi { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public DateTime SonIslemTarihi { get; set; }
        public ICollection<MasaHareketi> MasaHareketi { get; set; }
    }
}
