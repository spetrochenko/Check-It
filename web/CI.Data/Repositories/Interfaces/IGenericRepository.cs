using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CI.Data.Repositories.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class, new()
    {
        bool Create(TEntity entity);

        bool Update(TEntity entity);

        bool Delete(TEntity entity);

        TEntity LoadById(int id);

        IGenericRepository<TEntity> Include(Expression<Func<TEntity, object>> expression);

        IReadOnlyCollection<TEntity> Load();

        IReadOnlyCollection<TEntity> LoadBy(Expression<Func<TEntity, bool>> expression);

        IReadOnlyCollection<TEntity> OrderBy(Expression<Func<TEntity, bool>> expression);
    }
}
