using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CI.Data.Repositories.Interfaces
{
    public interface ICommonRepository<TEntity> where TEntity : class
    {
        void Create(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        TEntity LoadById(int id);

        IReadOnlyCollection<TEntity> Load();

        IReadOnlyCollection<TEntity> LoadBy(Expression<Func<TEntity, bool>> expression);
    }
}
