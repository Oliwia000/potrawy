using potrawy.ViewModel;
using potrawy.Service;

namespace potrawy.View
{
    public partial class MainPage : ContentPage
    {
        private readonly MainViewModel _viewModel;
        public MainPage()
        {
            InitializeComponent();
            var dataService = new DataService();
            _viewModel = new MainViewModel(dataService, Navigation);
            BindingContext = _viewModel;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.RefreshData();
        }
    }}
