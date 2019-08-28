using CI.Bussiness.Services.Implementations;
using CI.Bussiness.Services.Interfaces;
using CI.Data.Context;
using CI.Data.Repositories.Implementations;
using CI.Data.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CI.DependencyInjection.DependencyInjector
{
    public static class ServiceCollectionExtension
    {
        public static void AddDependency(this IServiceCollection serviceCollection)
        {
            //Registry services
            serviceCollection.AddTransient<IUserService, UserService>();
            serviceCollection.AddTransient<IBoardService, BoardService>();
            serviceCollection.AddTransient<IColumnService, ColumnService>();

            //Registry repository
            serviceCollection.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        }

        public static void AddDbConnection(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<DomainContext>();
        }
    }
}
