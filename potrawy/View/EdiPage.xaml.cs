using potrawy.Service;
using potrawy.Model;
using potrawy.ViewModel;

namespace potrawy.View
{
    public partial class EdiPage : ContentPage
    {
        public dania SelectedDish { get; set; }
        private readonly INavigation _navigation;
        public EdiPage(dania dish, INavigation navigation)
        {
            InitializeComponent();
            BindingContext = dish; 
            SelectedDish = dish;
            _navigation = navigation;
        }
        public async void SaveEditDish(object sender, EventArgs e)
        {
            SelectedDish.SaveData(SelectedDish.Name, SelectedDish.Type, SelectedDish.Description, SelectedDish.Price, SelectedDish.Ingredients);
            await _navigation.PopAsync();  
        }
        private async void AddIngredient(object sender, EventArgs e)
        {
            SelectedDish.AddIngredients(Ing.Text);
            Ing.Text = string.Empty;
        }
    }
}
