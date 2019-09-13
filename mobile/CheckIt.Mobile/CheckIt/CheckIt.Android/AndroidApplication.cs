
using Android.App;
using Android.Runtime;
using CheckIt.DependencyComposition.ContainerConfiguration;
using System;
using static CheckIt.Common.Container.AppContainer;

namespace CheckIt.Droid
{
    [Application]
    internal class AndroidApplication : Application
    {
        public AndroidApplication(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        { }

        public override void OnCreate()
        {
            var container = new BootstrapContainer();

            Container = container.CreateContainer();
        }
    }
}