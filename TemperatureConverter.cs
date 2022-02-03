using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Testing
{
    public class TemperatureConverter
    {
        public double CelsiusToFahrenheit(string celsiusTemp)
        {
            double celsius = double .Parse(celsiusTemp);
            double fahrenheit = (celsius * 9 / 5) + 32;
            return fahrenheit;
        }
        public double FahrenheitToCelsius(string fahrenheitTemp)
        {
            double fahrenheit = double .Parse(fahrenheitTemp);
            double celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;
        }
        public void convert()
        {
            
            Console.WriteLine("Please provide celsius temperature");
            string val1 = Console.ReadLine();
            double fahrenheit = CelsiusToFahrenheit(val1);
            Console.WriteLine($"value of {val1} celsius is {fahrenheit}fahrenheit");

            Console.WriteLine("Please provide fahrenheit temperature");
            string val2 = Console.ReadLine();
            double celsius = FahrenheitToCelsius(val2);
            Console.WriteLine($"value of {val2} fahrenheit is {celsius}celsius");

        }
            
    }
}
