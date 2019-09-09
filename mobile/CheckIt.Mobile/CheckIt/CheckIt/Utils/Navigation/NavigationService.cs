using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CheckIt.Core.Utils.Navigation
{
    public sealed class NavigationService : INavigationService
    {
        private readonly object sync = new object();
        private readonly Dictionary<string, Type> pagesByKey = new Dictionary<string, Type>();
        private readonly Stack<NavigationPage> navigationPageStack = new Stack<NavigationPage>();
        MasterDetailPage mainPage;
        private NavigationPage CurrentNavigationPage => navigationPageStack.Peek();

        public void Configure(string pageKey, Type pageType)
        {
            lock (sync)
            {
                if (pagesByKey.ContainsKey(pageKey))
                {
                    pagesByKey[pageKey] = pageType;
                }
                else
                {
                    pagesByKey.Add(pageKey, pageType);
                }
            }
        }

        public Page SetRootPage(string rootPageKey, BasePageParameters parameters = null)
        {
            var rootPage = GetPage(rootPageKey, parameters);
            navigationPageStack.Clear();
            var mainPage = new NavigationPage(rootPage);
            navigationPageStack.Push(mainPage);
            Application.Current.MainPage = mainPage;

            return mainPage;
        }

        public void SetMasterDetailPage(MasterDetailPage page, string pageKey, BasePageParameters parameters = null)
        {
            page.Detail = new NavigationPage(GetPage(pageKey, parameters));
            mainPage = page;
            page.IsPresented = false;
            //page.IsGestureEnabled = false;
        }

        public string CurrentPageKey
        {
            get
            {
                lock (sync)
                {
                    if (CurrentNavigationPage?.CurrentPage == null)
                    {
                        return null;
                    }

                    var pageType = CurrentNavigationPage.CurrentPage.GetType();

                    return pagesByKey.ContainsValue(pageType)
                        ? pagesByKey.First(p => p.Value == pageType).Key
                        : null;
                }
            }
        }

        public async Task GoBack()
        {
            var navigationStack = CurrentNavigationPage.Navigation;
            if (navigationStack.NavigationStack.Count > 1)
            {
                await CurrentNavigationPage.PopAsync();

                return;
            }

            if (navigationPageStack.Count > 1)
            {
                navigationPageStack.Pop();
                await CurrentNavigationPage.Navigation.PopModalAsync();

                return;
            }

            await CurrentNavigationPage.PopAsync();
        }

        public async Task NavigateModalAsync(string pageKey, bool animated = true)
        {
            await NavigateModalAsync(pageKey, null, animated);
        }

        public async Task NavigateModalAsync(string pageKey, BasePageParameters parameter, bool animated = true)
        {
            var page = GetPage(pageKey, parameter);
            NavigationPage.SetHasNavigationBar(page, false);
            var modalNavigationPage = new NavigationPage(page);
            await CurrentNavigationPage.Navigation.PushModalAsync(modalNavigationPage, animated);
            navigationPageStack.Push(modalNavigationPage);
        }

        public async Task NavigateAsync(string pageKey, bool animated = true)
        {
            await NavigateAsync(pageKey, null, animated);
        }

        public async Task NavigateAsync(string pageKey, BasePageParameters parameter, bool animated = true)
        {
            var page = GetPage(pageKey, parameter);
            await CurrentNavigationPage.Navigation.PushAsync(page, animated);
        }

        public async Task NavigateAsync(NavigationArgs args)
        {
            await NavigateAsync(args.PageKey, args.PageParameters, args.Animated);
        }

        public Page GetPage(string pageKey, BasePageParameters parameter = null)
        {
            lock (sync)
            {
                if (!pagesByKey.ContainsKey(pageKey))
                {
                    throw new ArgumentException(
                        $"No such page: {pageKey}. Did you forget to call NavigationService.Configure?");
                }

                var type = pagesByKey[pageKey];
                ConstructorInfo constructor;
                object[] parameters;

                if (parameter == null)
                {
                    constructor = type.GetTypeInfo()
                        .DeclaredConstructors
                        .FirstOrDefault(c => !c.GetParameters().Any());

                    parameters = new object[] { };
                }
                else
                {
                    var constructors = type.GetTypeInfo().DeclaredConstructors;
                    constructor = constructors
                        .FirstOrDefault(c =>
                        {
                            var p = c.GetParameters();
                            return p.Length == 1
                                   && p[0].ParameterType == parameter.GetType();
                        });

                    parameters = new[] { parameter };
                }

                if (constructor == null)
                {
                    throw new InvalidOperationException(
                        "No suitable constructor found for page " + pageKey);
                }

                try
                {
                    var page = constructor.Invoke(parameters) as Page;
                    return page;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
            }
        }

        public void ShowNavigationPage(bool flag)
        {
            mainPage.IsPresented = flag;
        }
    }
}
