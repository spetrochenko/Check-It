using CheckIt.Common.Container;
using CheckIt.Core.Utils.BaseViewModel;
using CheckIt.Core.Utils.Navigation;
using Xamarin.Forms;

namespace CheckIt.Core.Utils.BasePage
{
    public abstract class ParameterizedBasePage<TViewModel, TParameter> : ContentPage where TViewModel : ParameterizedBaseModel<TParameter> where TParameter : BasePageParameters
    {
        public ParameterizedBaseModel<TParameter> GetViewModel { get; }

        public TParameter GetParameters { get; }

        protected ParameterizedBasePage(TParameter parameter)
        {
            GetViewModel = AppContainer.Get<TViewModel>();
            GetParameters = parameter;

            BindingContext = GetViewModel;

            Device.BeginInvokeOnMainThread(async () => await GetViewModel.InitAsync(GetParameters));
        }
    }
}
