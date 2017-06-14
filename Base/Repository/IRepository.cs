using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JoySoftware.Intrastructure.Base.Repository
{
    /// <summary>
    /// The interface for the repository pattern. It's used to abstract the persistance 
    /// of domain model and make the coding of unit tests alot easier
    /// </summary>
    public interface IRepository<TEnity> where TEnity : class 
    {
        IQueryable<TEnity> GetAll();
        Task<List<TEnity>> GetAllAsync();
        IList<TEnity> FindBy(Expression<Func<TEnity, bool>> predicate);
        Task <IList<TEnity>> FindByAsync(Expression<Func<TEnity, bool>> predicate);

        TEnity GetById(params object[] keyValues);
        void Add(TEnity entity);
        Task AddAsync(TEnity entity);

        void Delete(TEnity entity);
        void Update(TEnity entity);
        void UpdateOrAdd(TEnity entity);

        void Save();

    }
}
