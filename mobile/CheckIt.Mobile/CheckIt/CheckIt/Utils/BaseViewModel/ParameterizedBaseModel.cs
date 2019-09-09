using CheckIt.Core.Utils.Navigation;
using PropertyChanged;
using System.Threading.Tasks;

namespace CheckIt.Core.Utils.BaseViewModel
{
    [AddINotifyPropertyChangedInterface]
    public abstract class ParameterizedBaseModel<TParameter> where TParameter : BasePageParameters
    {
        public abstract Task InitAsync(TParameter parameter);
    }
}
