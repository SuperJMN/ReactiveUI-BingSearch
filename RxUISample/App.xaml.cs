using System.Windows;
using Grace.DependencyInjection;

namespace RxUISample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        private const string AppKey = @"PUT YOUR APP KEY HERE";

        protected override void OnStartup(StartupEventArgs e)
        {
            var container = new DependencyInjectionContainer();
            container.Configure(registration =>
            {
                registration
                    .Export<BingSearchService>()
                    .As<IWebSearchService>().WithCtorParam(() => AppKey)
                    .Lifestyle.Singleton();

                registration.Export<MainViewModel>()
                    .As<IMainViewModel>()
                    .Lifestyle.Singleton();
            });
                       
            var mainWindow = new MainWindow();
            mainWindow.ViewModel = container.Locate<IMainViewModel>();
            mainWindow.Show();
        }
    }

    public interface IMainViewModel
    {
    }
}
