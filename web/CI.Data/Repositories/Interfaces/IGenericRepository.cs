using System.Linq;

namespace CI.Data.Repositories.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class, new()
    {
        bool Create(TEntity entity);

        bool Update(TEntity entity);

        bool Delete(TEntity entity);

        TEntity LoadById(int id);

        IQueryable<TEntity> Load();
    }
}
