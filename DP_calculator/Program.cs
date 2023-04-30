using System;

namespace DP_calculator
{
    class Program
    {
        //The Strategy design pattern defines a family of algorithms, encapsulate each one, and make them interchangeable.
        //This pattern lets the algorithm vary independently from clients that use it.

        //It is worth using this pattern when you have many similar classes in the program,
        //differing only in the way they perform some tasks.
        static void Main(string[] args)
        {
            TemperatureStrategy.Use();

            BattleShipStrategy.Use();

            DeliverStrategyExample.Use();



            Console.ReadKey();
        }
    }
}
