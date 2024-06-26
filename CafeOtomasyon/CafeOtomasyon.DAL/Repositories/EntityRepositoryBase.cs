﻿using CafeOtomasyon.DAL.Abstract;
using CafeOtomasyon.DAL.Concrete;
using CafeOtomasyon.Entity.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.DAL.Repositories
{
    public class EntityRepositoryBase<TEntity> : IEntityRepository<TEntity>
        where TEntity : class, new()
    {
        private readonly Context _context = new();
        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            Save();
        }

        public void Delete(Expression<Func<TEntity, bool>> filter)
        {
            _context.Set<TEntity>().Remove(_context.Set<TEntity>().FirstOrDefault(filter));
            Save();
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null ? _context.Set<TEntity>().ToList() : _context.Set<TEntity>().Where(filter).ToList();
        }

        public TEntity GetByFilter(Expression<Func<TEntity, bool>> filter)
        {
            return _context.Set<TEntity>().FirstOrDefault(filter);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            Save();
        }
    }
}
