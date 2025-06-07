using System.Windows;

namespace DataBinding.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // View と ViewModel のバインドは ViewModelLocator が自動で行う。 -> prism:ViewModelLocator.AutoWireViewModel="True"
            // DataContext = new ViewModels.MainWindowViewModel();
        }
    }
}
