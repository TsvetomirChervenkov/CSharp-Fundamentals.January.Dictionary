using System;
using System.Collections.Generic;
using System.Linq;

namespace T02.Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> count = new Dictionary<string, int>();
            foreach (string word in words)
            {
                string currWord = word.ToLower();
                if (!count.ContainsKey(currWord))
                {
                    count.Add(currWord, 1);
                }
                else
                {
                    count[currWord]++;
                }
            }
            string[] sorted = count.Where(x => x.Value % 2 != 0).Select(x => x.Key).ToArray();
            foreach (string word in sorted)
            {
                Console.Write(word + " ");
            }
        }
    }
}
