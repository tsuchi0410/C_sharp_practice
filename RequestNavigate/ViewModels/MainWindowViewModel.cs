using System.Security.Cryptography.X509Certificates;
using System.Windows.Data;
using Prism.Commands;
using Prism.Regions;
using Prism.Mvvm;
using BlankApp1.Views;

namespace BlankApp1.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            ShowViewAButton = new DelegateCommand(ShowViewAButtonExecute);
        }

        public DelegateCommand ShowViewAButton { get; }

        private void ShowViewAButtonExecute()
        {
            _regionManager.RequestNavigate("ContentRegion", nameof(ViewA));
        }

    }
}
