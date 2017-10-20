using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PassengerStation.Service
{
    public interface IGenericRepository<TEntity>
    {
        IEnumerable<TEntity> Get();
        TEntity Find(int Id);
        IEnumerable<TEntity> Filter(Expression<Func<TEntity, bool>> expression);
        void Add(TEntity entity);
        void Attach(TEntity entity);
        void Remove(TEntity entity);
        int SaveChanges();
        Task<int> SaveChangesAsync();
    }
}