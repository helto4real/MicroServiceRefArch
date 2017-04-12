using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace JoySoftware.Intrastructure.Base.Repository.Database.EF
{
    public abstract class EntityFrameworkRepository<TContext, TEntity> :
        IRepository<TEntity> where TEntity : class where TContext : DbContext, new()

    {
        private TContext context = new TContext();

        public TContext Context
        {
            get { return context; }
            set { context = value;  }
        }
        public virtual void Add(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            context.Set<TEntity>().Remove(entity);
        }

        public virtual IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate)
        {

            IQueryable<TEntity> query = context.Set<TEntity>().Where(predicate);
            return query;
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            IQueryable<TEntity> query = context.Set<TEntity>();
            return query;
        }

        public virtual void Save()
        {
            context.SaveChanges();
        }

        public virtual void Update(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }

        public virtual void UpdateOrAdd(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
