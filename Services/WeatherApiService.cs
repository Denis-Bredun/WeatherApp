﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Models;
using WeatherApp.Properties;

namespace WeatherApp.Services
{
    internal class WeatherApiService
    {
        private readonly HttpClient _httpClient;

        public WeatherApiService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(Resources.API_BASE_URL);
        }

        public async Task<WeatherApiResponse?> GetWeatherInformation(string latitude, string longitude)
        {
            if (Connectivity.Current.NetworkAccess != NetworkAccess.Internet)
                return null;

            return await _httpClient.GetFromJsonAsync<WeatherApiResponse>($"current?access_key={Resources.API_KEY}&query={latitude},{longitude}");
        }
    }
}
