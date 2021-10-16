using System;

namespace console_temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, where should we go?");

            WeatherUtilities.Report("Bologna", 23, 65);
            WeatherUtilities.Report("San Francisco", WeatherUtilities.FahrenheitToCelsius(65), 73);
            WeatherUtilities.Report("Denveer", WeatherUtilities.FahrenheitToCelsius(77), 55);
        }
    }
}