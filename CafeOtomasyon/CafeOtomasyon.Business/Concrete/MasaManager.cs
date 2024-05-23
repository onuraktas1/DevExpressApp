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
    public class MasaManager : IMasaService
    {
        IMasaDal _masaDal;
        public MasaManager(IMasaDal masaDal)
        {
            _masaDal = masaDal;
        }
        public void Add(Masa entity)
        {
            _masaDal.Add(entity);
        }

        public void Delete(Expression<Func<Masa, bool>> filter)
        {
            _masaDal.Delete(filter);
        }

        public List<Masa> GetAll(Expression<Func<Masa, bool>> filter = null)
        {
            return _masaDal.GetAll(filter);
        }

        public List<Masa> GetAllMasaWithKullanici()
        {
            return _masaDal.GetAllMasaWithKullanici();
        }

        public Masa GetByFilter(Expression<Func<Masa, bool>> filter)
        {
            return _masaDal.GetByFilter(filter);
        }

        public void Save()
        {
            _masaDal.Save();
        }

        public void Update(Masa entity)
        {
            _masaDal.Update(entity);
        }
    }
}
