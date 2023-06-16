using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class OpenWeatherMapAPI
    {

        public static void Weather() 
        {
            var client = new HttpClient();
            var apiObj = File.ReadAllText("appsettings.json");
            var apiKey = JObject.Parse(apiObj).GetValue("apiKey");
            var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?zip=30058&appid={apiKey}&units=imperial";
            var weatherResponse = client.GetStringAsync(weatherURL).Result;
            var weatherResult = JObject.Parse(weatherResponse);
            Console.WriteLine($"Weather :{weatherResult["main"]["temp"]}");
        }
    }
}




//https://api.openweathermap.org/data/2.5/weather?lat=57&lon=-2.15&appid={API key}&units=imperial