using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.DAL.Abstract
{
    public interface IEntityRepository<TContext, TEntity>
        where TContext : DbContext, new()
        where TEntity : class, new()
    {
        List<TEntity> GetAll(TContext context, Expression<Func<TEntity, bool>> filter = null);
        TEntity GetByFilter(TContext context, Expression<Func<TEntity, bool>> filter);
        void Add(TContext context, TEntity entity);
        void Update(TContext context, TEntity entity);
        void Delete(TContext context, Expression<Func<TEntity, bool>> filter);
        void Save(TContext context);

    }
}
