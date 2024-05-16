using CafeOtomasyon.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Business.Abstract
{
    public interface IGenericService<T>
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T GetByFilter(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(Expression<Func<T, bool>> filter);
    }
}
