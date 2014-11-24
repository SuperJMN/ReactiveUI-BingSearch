using System.Windows;
using ReactiveUI;

namespace RxUISample
{
    public partial class MainWindow : IViewFor<IMainViewModel>
    {
        public static readonly DependencyProperty ViewModelProperty = DependencyProperty.Register("ViewModel", typeof(IMainViewModel), typeof(MainWindow));
        private IMainViewModel viewModel;

        public MainWindow()
        {
            InitializeComponent();
        }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (MainViewModel) value; }
        }

        public IMainViewModel ViewModel
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
