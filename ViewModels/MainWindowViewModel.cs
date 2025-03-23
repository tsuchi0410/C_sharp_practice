using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using PrismWPF.Views;
using System.Windows;

namespace PrismWPF.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public DelegateCommand OpenCommand { get; }
        public DelegateCommand SaveCommand { get; }
        public DelegateCommand ExitCommand { get; }
        public DelegateCommand SettingCommand { get; }
        public DelegateCommand AboutCommand { get; }

        private readonly IDialogService _dialogService;

        public MainWindowViewModel(IDialogService dialogService)
        {
            _dialogService = dialogService;

            OpenCommand = new DelegateCommand(OnOpenMenuClicked);
            SaveCommand = new DelegateCommand(OnSaveMenuClicked);
            ExitCommand = new DelegateCommand(OnExitMenuClicked);
            SettingCommand = new DelegateCommand(OnSettingMenuClicked);
            AboutCommand = new DelegateCommand(OnAboutMenuClicked);
        }

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        private void OnOpenMenuClicked() => MessageBox.Show("Open clicked");
        private void OnSaveMenuClicked() => MessageBox.Show("Save clicked");
        private void OnExitMenuClicked() => Application.Current.Shutdown();
        private void OnSettingMenuClicked()
        {
            _dialogService.ShowDialog("SettingWindow", null, null);
        }
        private void OnAboutMenuClicked() => MessageBox.Show("About this application");
    }
}
