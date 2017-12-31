using IoC;
using StructureMap;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Windows;
using TournamentManager.View.Desktop.Registers;

namespace TournamentManager.View.Desktop
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            CultureInfo cultureInfo = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;

            Bootstrap bootstrap = new Bootstrap();
            bootstrap.Configure(new List<Registry>
            {
                new TournamentManagerRegistry(),
                new ViewRegistry()
            });
        }

        internal static void ChangeCulture(CultureInfo cultureInfo)
        {
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;

            Window oldWindow = Current.MainWindow;

            Current.MainWindow = new MainWindow();
            Current.MainWindow.Show();

            oldWindow.Close();
        }
    }
}
