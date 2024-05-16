using CafeOtomasyon.Business.Abstract;
using CafeOtomasyon.Business.Tools;
using CafeOtomasyon.DAL.Abstract;
using CafeOtomasyon.DAL.Concrete;
using CafeOtomasyon.Entity.Abstract;
using CafeOtomasyon.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
namespace CafeOtomasyon.Business.Concrete
{
    public class MenuManager : IMenuService
    {
        IMenuDal _menuDal;
        Context context = new();
        public MenuManager(IMenuDal menuDal)
        {
            _menuDal = menuDal;
        }

        public void Add(Menu entity)
        {
            //ValidatorTools.Validates()
            _menuDal.Add(context, entity);
        }

        public void Delete(Expression<Func<Menu, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Menu> GetAll(Expression<Func<Menu, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Menu GetByFilter(Expression<Func<Menu, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Save(Menu context)
        {
            throw new NotImplementedException();
        }

        public void Update(Menu entity)
        {
            throw new NotImplementedException();
        }
    }

}
