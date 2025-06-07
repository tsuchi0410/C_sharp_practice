using Prism.Mvvm;

namespace DataBinding.Models
{
    public class Person : BindableBase
    {
        private string _name = "初期値";
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }
    }
}
