using IoC;
using StructureMap;
using System.Collections.Generic;
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
            Bootstrap bootstrap = new Bootstrap();
            bootstrap.Configure(new List<Registry>
            {
                new ViewRegistry()
            });
            base.OnStartup(e);
        }
    }
}
