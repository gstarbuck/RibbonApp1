using Catel.IoC;
using Catel.Logging;
using Orchestra.Services;
using Orchestra.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace RibbonApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static readonly ILog Log = LogManager.GetCurrentClassLogger();

        private readonly Stopwatch _stopwatch;

        public App()
        {
            _stopwatch = new Stopwatch();
            _stopwatch.Start();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
#if DEBUG
            LogManager.AddDebugListener(true);
#endif

            //FontImage.RegisterFont("FontAwesome", new FontFamily(new Uri("pack://application:,,,/OrchestraApp;component/Resources/Fonts/", UriKind.RelativeOrAbsolute), "./#FontAwesome"));
            //FontImage.DefaultFontFamily = "FontAwesome";

            var serviceLocator = ServiceLocator.Default;
            var shellService = serviceLocator.ResolveType<IShellService>();
            shellService.CreateWithSplash<ShellWindow>();

            _stopwatch.Stop();

            Log.Info("Elapsed startup stopwatch time: {0}", _stopwatch.Elapsed);

        }

    }
}
