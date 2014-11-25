namespace SearchSampleApp
{
    using System.Windows;

    using Grace.DependencyInjection;

    using SearchSampleApp.Properties;

    public partial class App
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;

            var appKey = this.GetAppKey();
            if (appKey == null)
            {
                Current.Shutdown();
            }

            var container = new DependencyInjectionContainer();

            container.Configure(registration =>
            {
                registration
                    .Export<BingSearchService>()
                    .As<IWebSearchService>().WithCtorParam(() => appKey)
                    .Lifestyle.Singleton();

                registration.Export<MainViewModel>()                    
                    .Lifestyle.Singleton();

                
            });

            var mainWindow = new MainWindow();
            Current.MainWindow = mainWindow;
            mainWindow.ViewModel = container.Locate<MainViewModel>();
            mainWindow.ShowDialog();
            Current.Shutdown();
        }

        private string GetAppKey()
        {
            var appKey = Settings.Default.AppKey;
            if (string.IsNullOrEmpty(appKey))
            {
                var appKeyWindow = new AppKeyWindow();
                var appKeyViewModel = new AppKeyViewModel(null);
                appKeyWindow.DataContext = appKeyViewModel;
                if (appKeyWindow.ShowDialog() == true)
                {
                    appKey = appKeyViewModel.AppKey;
                    Settings.Default.AppKey = appKey;
                    Settings.Default.Save();
                    return appKey;
                }
            }

            return appKey;
        }
    }
}
