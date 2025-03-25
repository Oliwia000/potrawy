using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using potrawy.Model;
using potrawy.Service;
using potrawy.View;
using static System.Reflection.Metadata.BlobBuilder;

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
            _navigation = navigation;
            _dataService = dataService;

           Dania = _dataService.dania;

            ShowDetailedCmd = new Command<dania>(ShowDetails);
        }
        private async void ShowDetails(dania dania)
        {
            if (dania != null)
                await _navigation.PushAsync(new EdiPage(dania, _navigation));
        }
    }
}