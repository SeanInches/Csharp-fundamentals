using System;
using MyUtilities;

namespace CsharpFundamentals
{
    class CheckComfort
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Where to go in May?");
            WeatherUtilities.Report("San Francisco", WeatherUtilities.FahrenheitToCelsius(65), 73);
            WeatherUtilities.Report("Denver", WeatherUtilities.FahrenheitToCelsius(77), 55);
            WeatherUtilities.Report("Georgia", 23, 65); // 73F
        }

    }
    
}
