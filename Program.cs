using System;

namespace console_temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Convert temperature from F to C");
        }

        static double FahrenheitToCelsius(double temperatureFahrenheit)
        {
            double temperatureCelsius = (temperatureFahrenheit - 32) / 1.8;
            return temperatureCelsius;
        }
    }
}
