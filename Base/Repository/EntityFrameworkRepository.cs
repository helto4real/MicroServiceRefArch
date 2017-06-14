using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace JoySoftware.Intrastructure.Base.Repository.Database.EF
{
    
    public abstract class EntityFrameworkRepository<TContext, TEntity> : 
        IRepository<TEntity> where TEntity : class where TContext : DbContext, new()

    {
        private TContext context = null;

        #region -- Constructors --
        public EntityFrameworkRepository()
        {
            context = new TContext();
        }

        public EntityFrameworkRepository(TContext dbContext)
        {
            context = dbContext;
        }
        #endregion

        public TContext Context
        {
            get { return context; }
        }

        public virtual void Add(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
        }
        public virtual async Task AddAsync(TEntity entity)
        {
            var x =  await context.Set<TEntity>().AddAsync(entity);

        }
        public virtual void Delete(TEntity entity)
        {
            context.Set<TEntity>().Remove(entity);
        }

        public virtual IList<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate)
        {

            IQueryable<TEntity> query = context.Set<TEntity>().Where(predicate);
            return query.ToList();
        }

        public async Task<IList<TEntity>> FindByAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await context.Set<TEntity>().Where(predicate).ToListAsync();
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

        public virtual IQueryable<TEntity> GetAll()
        {
            IQueryable<TEntity> query = context.Set<TEntity>();
            return query;
        }

        public virtual async Task<List<TEntity>> GetAllAsync()
        {
            return await context.Set<TEntity>().ToListAsync();
            
        }

        public TEntity GetById(params object[] keyValues )
        {
            return context.Set<TEntity>().Find(keyValues);
        }


    }
}
