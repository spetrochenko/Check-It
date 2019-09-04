using System;
using Autofac;


namespace CheckIt.Common.Container
{
    public static class AppContainer
    {
        public static IContainer Container { get; set; }

        public static T Get<T>()
        {
            try
            {
                return Container.Resolve<T>();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
           

        }
    }
}
