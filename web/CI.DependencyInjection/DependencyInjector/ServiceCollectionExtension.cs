﻿using CI.Bussiness.Services.Implementations;
using CI.Bussiness.Services.Interfaces;
using CI.Data.Context;
using CI.Data.Repositories.Implementations;
using CI.Data.Repositories.Interfaces;
using CI.Models.Models;
using Microsoft.Extensions.DependencyInjection;

namespace CI.DependencyInjection.DependencyInjector
{
    public static class ServiceCollectionExtension
    {
        public static void AddDependency(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IUserService, UserService>();
            serviceCollection.AddTransient<IBoardService, BoardService>();
            serviceCollection.AddTransient<IColumnService, ColumnService>();

            serviceCollection.AddTransient<IUserRepository, UserRepository>();
            serviceCollection.AddTransient<IBoardRepository, BoardRepository>();
            serviceCollection.AddTransient<IColumnRepository, ColumnRepository>();

            serviceCollection.AddTransient<IGenericRepository<Board>, GenericRepository<Board>>();
        }

        public static void AddDbConnection(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<DomainContext>();
        }
    }
}