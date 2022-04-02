
using System;
using System.Collections.Generic;
using System.Linq;

namespace T01.CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            SortedDictionary<int, int> occurances = new SortedDictionary<int, int>();
            foreach (int number in numbers)
            {
                if (!occurances.Any(x => x.Key == number))
                {
                    occurances.Add(number, 1);
                }
                else
                {
                    occurances[number]++;
                }
            }

            foreach (var number in occurances)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
