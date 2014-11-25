namespace SearchSampleApp
{
    using System.Windows;

    /// <summary>
    /// Interaction logic for AppKeyWindow.xaml
    /// </summary>
    public partial class AppKeyWindow : Window
    {
        public AppKeyWindow()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }
    }
}
