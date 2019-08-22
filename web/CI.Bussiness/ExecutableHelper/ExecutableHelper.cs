using CI.Data.Repositories.Interfaces;
using System;
using System.Linq.Expressions;

namespace CI.Bussiness.ExecutableHelper
{
    internal static class ExecutableHelper
    {
        public static bool ExecuteCreateMethod<T>(IGenericRepository<T> repository, T entity) where T : class, new()
        {
            Expression<Func<IGenericRepository<T>, bool>> isExecuteExpression = repo => repo.Create(entity);

            return isExecuteExpression.Compile()
                                      .Invoke(repository);
        }

        public static bool ExecuteDeleteMethod<T>(IGenericRepository<T> repository, T entity) where T : class, new()
        {
            Expression<Func<IGenericRepository<T>, bool>> isExecuteExpression = repo => repo.Delete(entity);

            return isExecuteExpression.Compile()
                                      .Invoke(repository);
        }
    }
}
