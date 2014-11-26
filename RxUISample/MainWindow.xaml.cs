namespace SearchSampleApp
{
    using System.Windows;

    using ReactiveUI;

    public partial class MainWindow : IViewFor<MainViewModel>
    {
        private MainViewModel viewModel;

        public MainWindow()
        {
            InitializeComponent();
        }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (MainViewModel) value; }
        }

        public MainViewModel ViewModel
        {
            get { return viewModel; }
            set
            {
                viewModel = value;
                DataContext = value;
            }
        }
    }
}
