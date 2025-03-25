using potrawy.Model;
using potrawy.Service;
using potrawy.View;
using System.Collections.ObjectModel;

namespace potrawy.ViewModel
{
    public class MainViewModel
    {
        public ObservableCollection<dania> Dania { get; set; }
        public Command ShowDetailedCmd { get; }
        private readonly INavigation _navigation;
        private readonly DataService _dataService;
        public MainViewModel(DataService dataService, INavigation navigation)
        {
            _dataService = dataService;
            _navigation = navigation;
            Dania = _dataService.dania;
            ShowDetailedCmd = new Command<dania>(ShowDetails);
        }
        private async void ShowDetails(dania dish)
        {
            if (dish != null)
                await _navigation.PushAsync(new EdiPage(dish, _navigation));
        }
        public void RefreshData()
        {
            Dania = _dataService.dania;
        }
    }
}
