using System;
using System.Collections.Generic;
using System.Text;

namespace DP_calculator
{
    public class DeliverStrategyExample
    {
        public static void Use()
        {

            Order deliverStrategy = new Order();

            deliverStrategy.SetDeliverStrategy(new DeliverMan());
            deliverStrategy.CalculateTotalCost(10);
            deliverStrategy.Deliver();

            deliverStrategy.SetDeliverStrategy(new ParcelLocker());
            deliverStrategy.CalculateTotalCost(10);
            deliverStrategy.Deliver();

            deliverStrategy.SetDeliverStrategy(new AtLocation());
            deliverStrategy.CalculateTotalCost(10);
            deliverStrategy.Deliver();
        }
    }

    interface IDeliverStrategy
    {
        void Deliver();
        double Cost { get;  }
    }

    class DeliverMan : IDeliverStrategy
    {
        public double Cost => 32;
        public void Deliver()
        {
            Console.WriteLine("delivered by courier");
        }
    }

    class ParcelLocker : IDeliverStrategy
    {
        public double Cost => 25;
        public void Deliver()
        {
            Console.WriteLine("delivered by parcer locker");
        }
    }

    class AtLocation : IDeliverStrategy
    {
        public double Cost => 0;
        public void Deliver()
        {
            Console.WriteLine("to be picked up on site");
        }
    }

    class Order
    {
        protected IDeliverStrategy _deliverStrategy;

        public void Deliver()
        {
            _deliverStrategy.Deliver();
        }

        public void CalculateTotalCost(double cartItems)
        {
            Console.WriteLine(_deliverStrategy.Cost + cartItems);
        }

        public void SetDeliverStrategy(IDeliverStrategy deliverStrategy)
        {
            _deliverStrategy = deliverStrategy;
        }

    }
}
