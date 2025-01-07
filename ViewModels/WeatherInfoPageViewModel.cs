using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Properties;
using WeatherApp.Services;

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
        private int _humidity;

        [ObservableProperty]
        private string _cloudCoverLevel;

        [ObservableProperty]
        private string _isDay;

        private readonly WeatherApiService _weatherApiService;

        public WeatherInfoPageViewModel()
        {
            _weatherApiService = new WeatherApiService();
        }

        [RelayCommand]
        private async Task FetchWeatherInformation()
        {
            var weatherApiResponse = await _weatherApiService.GetWeatherInformation(Latitude, Longitude);

            if (weatherApiResponse == null || weatherApiResponse.Current == null)
                return;

            WeatherIcon = weatherApiResponse.Current.WeatherIcons[0];
            Temperature = $"{weatherApiResponse.Current.Temperature}°C";
            Location = $"{weatherApiResponse.Location.Name}, {weatherApiResponse.Location.Region}, {weatherApiResponse.Location.Country}";
            WeatherDescription = weatherApiResponse.Current.WeatherDescriptions[0];
            Humidity = weatherApiResponse.Current.Humidity;
            CloudCoverLevel = $"{weatherApiResponse.Current.Cloudcover}%";
            IsDay = weatherApiResponse.Current.IsDay.ToUpper();
        }
    }
}
