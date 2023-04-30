using System;

namespace DP_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            TemperatureStrategy.Use();

            BattleShipStrategy.Use();

            DeliverStrategyExample.Use();



            Console.ReadKey();
        }
    }
}
