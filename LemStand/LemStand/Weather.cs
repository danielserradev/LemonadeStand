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
            int tempWC = rng.Next(1, weatherCondition.Count);
            if(tempWC == 1)
            {
                condition = "Sunny";
            }
            else if(tempWC == 2)
            {
                condition = "Rainy";
            }
            else if(tempWC == 3)
            {
                condition = "Cloudy";
            }             
            return condition;
        }
        public int RandomTemerature()
        {
            temperature = rng.Next(55, 95);
            return temperature;
        }
        public void DisplayWeather()
        {
            Console.WriteLine("Todays weather is " + condition + " and " + temperature + " degrees outside.");
            
        }
        
    }
}
