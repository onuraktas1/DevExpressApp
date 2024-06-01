using CafeOtomasyon.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Entity.Concrete
{
    public class SatisKodu : IEntity
    {
        public int Id { get; set; }
        public string SatisTanimi { get; set; }
        public int Sayi { get; set; }
    }
}
