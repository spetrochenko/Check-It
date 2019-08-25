using Autofac;


namespace CheckIt.Common.Container
{
    public class AppContainer
    {
        public static IContainer Container { get; set; }

        public static T GetDependency<T>() => Container.Resolve<T>();
    }
}
