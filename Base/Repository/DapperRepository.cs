using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;

namespace JoySoftware.Intrastructure.Base.Repository
{
    public abstract class DapperRepository<TEntity> :
        ISimpleRepository<TEntity> where TEntity : class, new()
    {
        protected SqlConnection connection;
        private string entityName;

        #region -- Constructors --
        public DapperRepository ( string connectionString)
        {
            if (String.IsNullOrEmpty(connectionString))
                throw new NullReferenceException("Connectionstring not provided");

            connection = new SqlConnection(connectionString);


            // var t = GetType().GenericTypeArguments[0];
            entityName = typeof(TEntity).Name;
        }

        #endregion

        public virtual void Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public virtual async Task AddAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public virtual List<TEntity> All()
        {
            throw new NotImplementedException();
        }

        public virtual async Task<List<TEntity>> AllAsync()
        {
            var result = await connection.QueryAsync<TEntity>("SELECT * FROM " + entityName);

            return result.AsList();
                
        }

        public virtual void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public virtual TEntity GetById(params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public virtual void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public virtual void UpdateOrAdd(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
