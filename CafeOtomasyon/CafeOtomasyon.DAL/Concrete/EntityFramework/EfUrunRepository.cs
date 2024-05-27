using CafeOtomasyon.DAL.Abstract;
using CafeOtomasyon.DAL.Repositories;
using CafeOtomasyon.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.DAL.Concrete.EntityFramework
{
    public class EfUrunRepository : EntityRepositoryBase<Urun>, IUrunDal
    {
        private readonly Context _context = new();
        public List<Urun> GetAllUrunWithMenu()
        {
            return _context.Urunler.Include(u => u.Menu).AsNoTracking().ToList();
        }
    }
}
