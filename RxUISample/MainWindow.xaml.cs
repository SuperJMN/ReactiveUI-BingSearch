
namespace SearchSampleApp
{
    using ReactiveUI;

    public partial class MainWindow : IViewFor<MainViewModel>
    {
        private MainViewModel _viewModel;

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
            get { return _viewModel; }
            set
            {
                _viewModel = value;
                DataContext = value;
            }
        }
    }
}