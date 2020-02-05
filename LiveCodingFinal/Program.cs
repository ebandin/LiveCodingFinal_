using System;
using System.Collections.Generic;


namespace LiveCodingFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> TemperatureList = new List<int>();
            TemperatureList.Add(40);
            TemperatureList.Add(50);
            TemperatureList.Add(60);
            TemperatureList.Add(70);

            List<string> WeatherList = new List<string>();
            WeatherList.Add("rainy");

            WeatherList.Add("cloudy");

            WeatherList.Add("fullmoon");

            WeatherList.Add("clear");



            Dictionary<int, string> dict = new Dictionary<int, string>(); 
            foreach (int value in TemperatureList)
            {
                foreach (string value2 in WeatherList)
                    dict.Add(value, value2);

                if value2 == rainy 
                    elif value2 == cloudy

                    elif value2 == fullmoon

                    else; 
                            value *1.25



                List<int> FinalList = new List<int>(); 

            }

        }
    }
}



//"""Halloween is coming, and you need to figure out how much candy to buy.Luckily you have tracked the weather,
 //temperature, and number of tricker treaters from years past.From your research you have tracked 4 different types of weather:
//"Clear", "Cloudy", "Raining", "Full Moon"From your research you have tracked 4 differnt types of temperature 40s, 50s, 60s, 70s
     //You get 10% more trick or treaters if the weather is clear

//You get 0% more trick or treaters if the weather is cloudy

     //You get 25% less trick or treaters if the weather is rainy

//You get 25% more trick or treaters if the weather is Full Moon

     //You get more trick or treaters the warmer the weather
//You get 5% less trick or treaters if it's in the 40s
     //You get 0% more trick or treaters if it's in the 50s
//You get 5% more trick or treaters if it's in the 60s
    // You get 20% more trick or treaters if its' in the 70s
//On average you get 250 trick or treaters, 
    // and you want to give each kid 3 pieces of candy.
     //How much candy do you need to buy if it's clear, and in the 50s?825
    // How much candy do you need to buy if it's a full moon, and in the 40s?900
    // How much candy do you need to buy if it's raining, and in the 70s?712.5"""