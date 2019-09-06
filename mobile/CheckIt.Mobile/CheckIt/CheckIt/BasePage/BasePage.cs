using CheckIt.Common.Container;
using CheckIt.Core.BaseViewModel;
using Xamarin.Forms;

namespace CheckIt.Core.BasePage
{
    public class BasePage<TViewModel> : ContentPage where TViewModel : BaseModel
    {
        public BaseModel GetViewModel { get; }

        public BasePage()
        {
            GetViewModel = AppContainer.Get<TViewModel>();

            BindingContext = GetViewModel;

            Device.BeginInvokeOnMainThread(async () => await GetViewModel.InitAsync());
        }
    }
}
