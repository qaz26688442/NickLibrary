using System;
using System.Linq;
using System.Linq.Expressions;

namespace Repository.Interface
{
    internal interface IRepository<TEntity> : IDisposable
        where TEntity : class
    {
        void Create(TEntity obj);

        bool IsExists(int primaryKey);

        TEntity GetByID(int primaryKey);

        TEntity Get(Expression<Func<TEntity, bool>> predicate);

        IQueryable<TEntity> GetAll();

        IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> predicate);

        void Update(TEntity obj);

        void Delete(TEntity obj);

        void SaveChange();
    }
}