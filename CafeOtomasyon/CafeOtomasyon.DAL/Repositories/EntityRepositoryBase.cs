using CafeOtomasyon.DAL.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.DAL.Repositories
{
    public class EntityRepositoryBase<TContext, TEntity> : IEntityRepository<TContext, TEntity>
        where TContext : DbContext, new()
        where TEntity : class, new()
    {
        public void Add(TContext context, TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
        }

        public void Delete(TContext context, Expression<Func<TEntity, bool>> filter)
        {
            context.Set<TEntity>().Remove(context.Set<TEntity>().FirstOrDefault(filter));
        }

        public List<TEntity> GetAll(TContext context, Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
        }

        public TEntity GetByFilter(TContext context, Expression<Func<TEntity, bool>> filter)
        {
            return context.Set<TEntity>().FirstOrDefault(filter);
        }

        public void Save(TContext context)
        {
            context.SaveChanges();
        }

        public void Update(TContext context, TEntity entity)
        {
            context.Set<TEntity>().Update(entity);
        }
    }
}
