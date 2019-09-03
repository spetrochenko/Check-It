using System.Linq;

namespace CheckIt.Data.Repository.Interface
{
    public interface IGenericRepository<TEntity> where TEntity : class, new()
    {
        void Create(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        TEntity LoadById(int id);

        IQueryable<TEntity> Load();
    }
}
