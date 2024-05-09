using CafeOtomasyon.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Entity.Concrete
{
    public class Rol : IEntity
    {
        public int Id { get; set; }
        public int KullaniciId { get; set; }
        public string ControlName { get; set; }
        public string ControlCaption { get; set; }
        public string FormName { get; set; }
    }
}
