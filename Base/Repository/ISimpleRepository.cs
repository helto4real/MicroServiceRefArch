using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JoySoftware.Intrastructure.Base.Repository
{
    public interface ISimpleRepository<TEnity> where TEnity : class
    {

        List<TEnity> All();
        Task<List<TEnity>> AllAsync();

        TEnity GetById(params object[] keyValues);

        void Add(TEnity entity);
        Task AddAsync(TEnity entity);

        void Delete(TEnity entity);

        void Update(TEnity entity);
        void UpdateOrAdd(TEnity entity);

    }
}
