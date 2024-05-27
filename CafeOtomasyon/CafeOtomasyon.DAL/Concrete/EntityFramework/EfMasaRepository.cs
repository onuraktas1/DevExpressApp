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
    public class EfMasaRepository : EntityRepositoryBase<Masa>, IMasaDal
    {
        private readonly Context _context = new();
        public List<Masa> GetAllMasaWithKullanici()
        {
            return _context.Masalar.Include(k => k.Kullanici).AsNoTracking().ToList();
        }
    }
}
