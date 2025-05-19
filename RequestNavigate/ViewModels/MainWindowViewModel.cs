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

            // コンストラクタで ShowViewAButton を生成
            // 引数に実行するメソッド ShowViewAButtonExecute を指定
            ShowViewAButton = new DelegateCommand(ShowViewAButtonExecute);
        }

        // DelegateCommand を作成
        // xaml 側のボタンとデータバインドされる
        public DelegateCommand ShowViewAButton { get; }

        private void ShowViewAButtonExecute()
        {
            // IRegionManager を使って ViewA を表示
            _regionManager.RequestNavigate("ContentRegion", nameof(ViewA));
        }

    }
}
