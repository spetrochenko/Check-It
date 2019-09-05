using Autofac;


namespace CheckIt.Common.Container
{
    public static class AppContainer
    {
        public static IContainer Container { get; set; }

        public static T Get<T>()
        {
            return Container.Resolve<T>();
        }
    }
}
