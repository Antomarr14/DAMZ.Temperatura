using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMZ.Temperatura.UnitTestMSTest
{
    [TestClass]
    public class ConvertidorTemperaturaTests
    {
        private ConvertidorTemperatura _convertidor;

        [TestInitialize]
        public void Setup()
        {
            _convertidor = new ConvertidorTemperatura();
        }

        // Prueba unitaria para Celsius a Fahrenheit



        public void ConvertirCelsiusAFahrenheit_ValorCorrecto()
        {
            // Arrange
            double celsius = 100;
            double resultadoEsperado = 212;

            // Act
            double resultado = _convertidor.ConvertirCelsiusAFahrenheit(celsius);

            // Assert
            Assert.AreEqual(resultadoEsperado, resultado, 0.001);
        }

        // Prueba unitaria para Fahrenheit a Celsius
        [TestMethod]
        public void ConvertirFahrenheitACelsius_ValorCorrecto()
        {
            // Arrange
            double fahrenheit = 32;
            double resultadoEsperado = 0;

            // Act
            double resultado = _convertidor.ConvertirFahrenheitACelsius(fahrenheit);

            // Assert
            Assert.AreEqual(resultadoEsperado, resultado, 0.001);
        }
    }
}
