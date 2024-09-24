using MathOrDeath_WPF.ViewModels;
using System.Windows;

namespace MathOrDeath_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
            if (DataContext is MainViewModel vm)
            {
                ViewModel = vm;
            }
            Loaded += MainWindow_Loaded;
        }
        public MainViewModel ViewModel;
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            ViewModel.Initialize();
        }
    }
}