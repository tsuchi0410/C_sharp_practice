using Prism.Mvvm;
using DataBinding.Models;

namespace DataBinding.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly Person _name;
        public MainWindowViewModel()
        {
            _name = new Person();

            // Person.Name が変更されたときに通知を View へ伝える
            _name.PropertyChanged += (s, e) =>
            {
                if (e.PropertyName == nameof(Person.Name))
                    RaisePropertyChanged(nameof(PersonName));
            };  
        }

        public string PersonName
        {
            get => _name.Name;         // Model から値を取得
            set => _name.Name = value; // Model に値を渡す
        }
    }
}
