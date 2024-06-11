using Microsoft.EntityFrameworkCore;
using WeatherApplication.Data.DAO;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WeatherApplication.Data;
using WeatherApplication.Data.Entities;

namespace WeatherApplication.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly HttpClient _httpClient;

        public WeatherService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _httpClient = new HttpClient();
        }

        public async Task<Root?> MakeApiCallAndSaveToDb(string city)
        {
            // Make the API call
            //string baseUrl = "https://api.openweathermap.org/data/2.5/weather";
            string apiKey = "3e96a88efc57125e87983fce1184ebbb"; // Replace "your_api_key_here" with your actual API key
            string apiUrl = $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";

            //HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

            HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                // Deserialize the response
                string jsonResponse = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Root?>(jsonResponse);
            }
            else
            {
                throw new HttpRequestException("Failed to connect to the weather API.");
            }
        }
    }
}
