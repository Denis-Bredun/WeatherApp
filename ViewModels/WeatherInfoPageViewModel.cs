using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Properties;

namespace WeatherApp.ViewModels
{
    internal partial class WeatherInfoPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _latitude;

        [ObservableProperty]
        private string _longitude;

        [ObservableProperty]
        private string _weatherIcon;

        [ObservableProperty]
        private string _temperature;

        [ObservableProperty]
        private string _weatherDescription;

        [ObservableProperty]
        private string _location;

        [ObservableProperty]
        private string _humidity;

        [ObservableProperty]
        private string _cloudCoverLevel;

        [ObservableProperty]
        private string _isDay;

        [RelayCommand]
        private async Task FetchWeatherInformation()
        {
            string apiKey = Resources.API_KEY;
            string apiBaseUrl = Resources.API_BASE_URL;


        }
    }
}
