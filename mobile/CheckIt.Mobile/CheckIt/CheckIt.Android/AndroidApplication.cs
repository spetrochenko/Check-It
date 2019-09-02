
using Android.App;
using Android.Runtime;
using CheckIt.Common.Container;
using CheckIt.DependencyComposition.ContainerConfiguration;
using System;

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

            AppContainer.Container = container.CreateContainer();
        }
    }
}