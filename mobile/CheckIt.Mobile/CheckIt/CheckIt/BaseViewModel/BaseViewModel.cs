using System.Threading.Tasks;
using PropertyChanged;

namespace CheckIt.Core.BaseViewModel
{
    [AddINotifyPropertyChangedInterface]
    public abstract class BaseModel
    {
        public abstract Task InitAsync();
    }
}
