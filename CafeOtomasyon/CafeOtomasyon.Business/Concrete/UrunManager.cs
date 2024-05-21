using CafeOtomasyon.Business.Abstract;
using CafeOtomasyon.DAL.Abstract;
using CafeOtomasyon.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Business.Concrete
{
    public class UrunManager : IUrunService
    {
        private readonly IUrunDal _urundal;

        public UrunManager(IUrunDal urundal)
        {
            _urundal = urundal;
        }

        public void Add(Urun entity)
        {
            _urundal.Add(entity);
        }

        public void Delete(Expression<Func<Urun, bool>> filter)
        {
            _urundal.Delete(filter);
        }

        public List<Urun> GetAll(Expression<Func<Urun, bool>> filter = null)
        {
            return _urundal.GetAll(filter);
        }

        public List<Urun> GetAllUrunWithMenu()
        {
            return _urundal.GetAllUrunWithMenu();
        }

        public Urun GetByFilter(Expression<Func<Urun, bool>> filter)
        {
            return _urundal.GetByFilter(filter);
        }

        public void Save()
        {
            _urundal.Save();
        }

        public void Update(Urun entity)
        {
            _urundal.Update(entity);
        }
    }
}
