using Autofac;
using CheckIt.Common.Entities;
using CheckIt.Data.Context;
using CheckIt.Data.Repository.Implementation;
using CheckIt.Data.Repository.Interface;

namespace CheckIt.Data.DataModule
{
    public sealed class DataModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<GenericRepository<User>>().As<IGenericRepository<User>>();
            builder.RegisterType<DomainContext>().AsSelf();
        }
    }
}
