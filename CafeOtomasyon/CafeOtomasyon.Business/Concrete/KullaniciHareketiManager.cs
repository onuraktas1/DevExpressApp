using CafeOtomasyon.Business.Abstract;
using CafeOtomasyon.DAL.Abstract;
using CafeOtomasyon.DAL.Mapping;
using CafeOtomasyon.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Business.Concrete
{
    public class KullaniciHareketiManager : IKullaniciHareketiService
    {
        IKullaniciHareketiDal _kullaniciHareketiDal;

        public KullaniciHareketiManager(IKullaniciHareketiDal kullaniciHareketiDal)
        {
            _kullaniciHareketiDal = kullaniciHareketiDal;
        }
        public void Add(KullaniciHareketi entity)
        {
            _kullaniciHareketiDal.Add(entity);
        }

        public void Delete(Expression<Func<KullaniciHareketi, bool>> filter)
        {
            _kullaniciHareketiDal.Delete(filter);
        }

        public List<KullaniciHareketi> GetAll(Expression<Func<KullaniciHareketi, bool>> filter = null)
        {
            return _kullaniciHareketiDal.GetAll(filter);
        }

        public KullaniciHareketi GetByFilter(Expression<Func<KullaniciHareketi, bool>> filter)
        {
            return _kullaniciHareketiDal.GetByFilter(filter);
        }

        public void Save()
        {
            _kullaniciHareketiDal.Save();
        }

        public void Update(KullaniciHareketi entity)
        {
            _kullaniciHareketiDal.Update(entity);
        }
    }
}
