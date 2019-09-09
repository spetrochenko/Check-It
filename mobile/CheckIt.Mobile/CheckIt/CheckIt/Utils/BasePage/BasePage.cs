using CheckIt.Common.Container;
using CheckIt.Core.Utils.BaseViewModel;
using Xamarin.Forms;

namespace CheckIt.Core.Utils.BasePage
{
    public abstract class BasePage<TViewModel> : ContentPage where TViewModel : BaseModel
    {
        public BaseModel GetViewModel { get; }

        protected BasePage()
        {
            GetViewModel = AppContainer.Get<TViewModel>();

            BindingContext = GetViewModel;

            Device.BeginInvokeOnMainThread(async () => await GetViewModel.InitAsync());
        }
    }
}
