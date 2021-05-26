using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace OpenWeatherMap_API
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var weatherClient = new HttpClient();
            var apiKey = "0df4be140f6dd8c750c0a51f6c24ded7";

            Console.WriteLine("Enter your city:");
            var cityName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter your state:");
            var stateName = Console.ReadLine();

            var weatherUrl = $"http://api.openweathermap.org/data/2.5/weather?q={cityName},{stateName}&appid={apiKey}&units=imperial";

            var response = weatherClient.GetStringAsync(weatherUrl).Result;
            var mainResponse = JObject.Parse(response).GetValue("main").ToString();

            Console.WriteLine(mainResponse);
            Console.WriteLine();

        }
    }
}
