using Autofac;


namespace CheckIt.Common.Container
{
    public class AppContainer
    {
        public static IContainer Container { get; set; }

        public static T Get<T>() => Container.Resolve<T>();
    }
}
