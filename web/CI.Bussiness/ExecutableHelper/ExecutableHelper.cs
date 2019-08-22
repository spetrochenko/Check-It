using CI.Data.Repositories.Interfaces;
using System;
using System.Linq.Expressions;

namespace CI.Bussiness.ExecutableHelper
{
    internal static class ExecutableHelper
    {
        public static bool ExecuteCreateMethod<T>(ICommonRepository<T> repository, T entity) where T : class
        {
            Expression<Func<ICommonRepository<T>, bool>> isExecuteExpression = repo => repo.Create(entity);

            return isExecuteExpression.Compile()
                                      .Invoke(repository);
        }

        public static bool ExecuteDeleteMethod<T>(ICommonRepository<T> repository, T entity) where T : class
        {
            Expression<Func<ICommonRepository<T>, bool>> isExecuteExpression = repo => repo.Delete(entity);

            return isExecuteExpression.Compile()
                                      .Invoke(repository);
        }

        //public static bool ExecuteUpdateMethod<T>(ICommonRepository<T> repository, T entity) where T : class
        //{
        //    Expression<Func<ICommonRepository<T>, bool>> isExecuteExpression = repo => repo.Update(entity);

        //    return isExecuteExpression.Compile()
        //        .Invoke(repository);
        //}
    }
}
