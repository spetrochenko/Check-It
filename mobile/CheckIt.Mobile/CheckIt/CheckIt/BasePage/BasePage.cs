using CheckIt.Common.Container;
using CheckIt.Core.ViewModelsMarker;
using Xamarin.Forms;

namespace CheckIt.Core.BasePage
{
    public class BasePage<TViewModel> : ContentPage where TViewModel : IViewModel
    {
        public IViewModel GetViewModel { get; private set; }

        public BasePage()
        {
            GetViewModel = AppContainer.Get<TViewModel>();

            BindingContext = GetViewModel;
        }
    }
}
