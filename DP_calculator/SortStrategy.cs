using System;
using System.Collections.Generic;
using System.Text;

namespace DP_calculator
{

    class ShortStrategyExample
    {
        public static void Use()
        {
            SortStrategy strategy = new SortStrategy(new BubbleSort());
            strategy.Sort(new int[3] { 1, 2, 3 });
        }
    }

    interface ISortStrategy
    {
        void Sort(int[] data);
    }

    class BubbleSort : ISortStrategy
    {
        public void Sort(int[] data)
        {
            Console.WriteLine("bubble sort");
        }
    }

    class QuickSort : ISortStrategy
    {
        public void Sort(int[] data)
        {
            Console.WriteLine("quick sort");
        }
    }

    class MergeSort : ISortStrategy
    {
        public void Sort(int[] data)
        {
            Console.WriteLine("merge sort");
        }
    }

    class SortStrategy
    {
        protected ISortStrategy _sortStrategy;

        public SortStrategy(ISortStrategy sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        public void Sort(int[] data)
        {
            _sortStrategy.Sort(data);
        }
    }

}
