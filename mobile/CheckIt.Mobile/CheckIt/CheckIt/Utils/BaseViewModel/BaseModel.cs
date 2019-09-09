using PropertyChanged;
using System.Threading.Tasks;

namespace CheckIt.Core.Utils.BaseViewModel
{
    [AddINotifyPropertyChangedInterface]
    public abstract class BaseModel
    {
        public abstract Task InitAsync();
    }
}
