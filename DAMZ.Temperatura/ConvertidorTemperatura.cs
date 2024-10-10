using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMZ.Temperatura
{
    public class ConvertidorTemperatura
    {

        // Método para convertir de Celsius a Fahrenheit
        public double ConvertirCelsiusAFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        // Método para convertir de Fahrenheit a Celsius
        public double ConvertirFahrenheitACelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
