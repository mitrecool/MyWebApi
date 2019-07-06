using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyWebApi.Db.Repository
{
    public interface IDataRepository<TEntity>
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetAsync(Guid id);
        Task AddAsync(TEntity entity);
        Task UpdateAsync(TEntity dbEntity, TEntity entity);
        Task DeleteAsync(TEntity entity);
    }
}
