using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JoySoftware.Intrastructure.Base.Repository
{
    public interface ISimpleRepository<TEntity> where TEntity : class
    {

        List<TEntity> All();
        Task<List<TEntity>> AllAsync();

        TEntity GetById(params object[] keyValues);
        Task<TEntity> GetByIdAsync(params object[] keyValues);
        
        void Add(TEntity entity);
        Task AddAsync(TEntity entity);

        void Delete(TEntity entity);

        void Update(TEntity entity);
        void UpdateOrAdd(TEntity entity);

    }
}
