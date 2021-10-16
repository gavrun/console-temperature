using System;

namespace console_temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            WeatherUtilities.Report("Bologna", 23, 65); 
        }
    }
}