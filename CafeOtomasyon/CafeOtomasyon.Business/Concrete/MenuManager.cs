﻿using CafeOtomasyon.Business.Abstract;
using CafeOtomasyon.Business.Tools;
using CafeOtomasyon.Business.Validators;
using CafeOtomasyon.DAL.Abstract;
using CafeOtomasyon.DAL.Concrete;
using CafeOtomasyon.Entity.Abstract;
using CafeOtomasyon.Entity.Concrete;
using FluentValidation;
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
        private readonly IMenuDal _menuDal;
        public MenuManager(IMenuDal menuDal)
        {
            _menuDal = menuDal;
        }

        public void Add(Menu entity)
        {
            _menuDal.Add(entity);
        }

        public void Delete(Expression<Func<Menu, bool>> filter)
        {
            _menuDal.Delete(filter);
        }

        public List<Menu> GetAll(Expression<Func<Menu, bool>> filter = null)
        {
            return _menuDal.GetAll(filter);
        }

        public Menu GetByFilter(Expression<Func<Menu, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            _menuDal.Save();
        }

        public void Update(Menu entity)
        {
            throw new NotImplementedException();
        }
    }

}
