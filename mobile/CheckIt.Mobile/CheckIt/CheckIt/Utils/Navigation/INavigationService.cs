using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CheckIt.Core.Utils.Navigation
{
    public interface INavigationService
    {
        string CurrentPageKey { get; }

        void Configure(string pageKey, Type pageType);

        Page SetRootPage(string rootPageKey, BasePageParameters parameters = null);

        Page GetPage(string pageKey, BasePageParameters parameter = null);

        void SetMasterDetailPage(MasterDetailPage page, string pageKey, BasePageParameters parameter = null);

        Task GoBack();

        Task NavigateModalAsync(string pageKey, bool animated = true);

        Task NavigateModalAsync(string pageKey, BasePageParameters parameter, bool animated = true);

        Task NavigateAsync(string pageKey, bool animated = true);

        Task NavigateAsync(string pageKey, BasePageParameters parameter, bool animated = true);

        Task NavigateAsync(NavigationArgs args);

        void ShowNavigationPage(bool flag);
    }
}
