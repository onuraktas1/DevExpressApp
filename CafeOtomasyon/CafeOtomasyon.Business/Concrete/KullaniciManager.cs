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
    public class KullaniciManager : IKullaniciService
    {
        IKullaniciDal _kullaniciDal;
        public KullaniciManager(IKullaniciDal kullaniciDal)
        {
            _kullaniciDal = kullaniciDal;
        }
        public void Add(Kullanici entity)
        {
            _kullaniciDal.Add(entity);
        }

        public void Delete(Expression<Func<Kullanici, bool>> filter)
        {
            _kullaniciDal.Delete(filter);
        }

        public List<Kullanici> GetAll(Expression<Func<Kullanici, bool>> filter = null)
        {
            return _kullaniciDal.GetAll(filter);
        }

        public Kullanici GetByFilter(Expression<Func<Kullanici, bool>> filter)
        {
            return _kullaniciDal.GetByFilter(filter);
        }

        public void Save()
        {
            _kullaniciDal.Save();
        }

        public void Update(Kullanici entity)
        {
            _kullaniciDal.Update(entity);
        }
    }
}
