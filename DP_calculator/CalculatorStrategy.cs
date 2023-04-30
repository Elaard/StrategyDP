using System;
using System.Collections.Generic;
using System.Text;

namespace DP_calculator
{
    public class TemperatureStrategy
    {
        static public void Use()
        {
            TemperatureConverter converter = new TemperatureConverter(new CelsiusToFahrenheitConverter());
            Console.WriteLine(converter.ConvertTemperature(25)); // powinno wyświetlić się 77

            converter.SetTemperatureConverterStrategy(new FahrenheitToCelsiusConverter());
            Console.WriteLine(converter.ConvertTemperature(77)); // powinno wyświetlić się 25

            Console.ReadKey();
        }
    }

    public abstract class ITemperatureConverterStrategy
    {
        public abstract double ConvertTemperature(double temperature);
    }
    //Concrete Strategy
    public class CelsiusToFahrenheitConverter : ITemperatureConverterStrategy
    {
        public override double ConvertTemperature(double temperature)
        {
            return temperature * 9 / 5 + 32;
        }
    }
    //Concrete Strategy
    public class FahrenheitToCelsiusConverter : ITemperatureConverterStrategy
    {
        public override double ConvertTemperature(double temperature)
        {
            return (temperature - 32) * 5 / 9;
        }
    }

    //Context 
    public class TemperatureConverter
    {
        private ITemperatureConverterStrategy _strategy;

        public TemperatureConverter(ITemperatureConverterStrategy strategy)
        {
            _strategy = strategy;
        }

        public double ConvertTemperature(double temperature)
        {
            return _strategy.ConvertTemperature(temperature);
        }

        public void SetTemperatureConverterStrategy(ITemperatureConverterStrategy strategy)
        {
            _strategy = strategy;
        }
    }

}
