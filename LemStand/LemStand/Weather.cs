using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemStand
{
    public class Weather 
    {
        //member variables(Has a)
        public string condition;
        public int temperature;
        private List<string> weatherCondition;
        public string predictedForecast;
        public int tempWC;
        Random rng;
        public List<PredictedWeather> predictedWeather;

        //constructor(Spawner)
        public Weather()
        {
            rng = new Random();
            
        }

        //member methods(Can Do)
        public void WeatherConditions()
        {
            weatherCondition = new List<string>() { "Sunny", "Rainy", "Cloudy" };             
        }
        public string RandomWeatherCondition()
        {
            //random
            int index = UserInterface.GenerateRandomNumber(weatherCondition.Count);
            
            condition = weatherCondition[index];
            return condition;
        }
        public int RandomTemerature()
        {
            //random
            temperature = rng.Next(55, 95);
            return temperature;
        }
        public void DisplayWeather()
        {
            WeatherConditions();
            RandomWeatherCondition();
            RandomTemerature();           
        }
        
    }
}
