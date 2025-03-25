using potrawy.ViewModel;

namespace potrawy.View
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel(new Service.DataService(), Navigation);

        }
    }
}
