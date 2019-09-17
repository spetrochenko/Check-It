using Xamarin.Forms.Xaml;

namespace CheckIt.Core.Components.AccountCredential
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AccountCredential
    {
        public AccountCredential(AccountPageParameters parameters) : base(parameters)
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
    }
}