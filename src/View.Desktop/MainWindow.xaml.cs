using System.Globalization;
using System.Windows;

namespace TournamentManager.View.Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void EnglishLanguage_Click(object sender, RoutedEventArgs e)
        {
            App.ChangeCulture(new CultureInfo("en-US"));
        }

        private void PolishLanguage_Click(object sender, RoutedEventArgs e)
        {
            App.ChangeCulture(new CultureInfo("pl-PL"));
        }
    }
}
