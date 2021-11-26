using System;
using System.Collections.Generic;

namespace Ex3Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var elements = new List<int>
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };
            Console.WriteLine(Count(elements, x => x > 5));
        }

        static int Count(List<int> elements, Predicate<int> condition)
        {
            var i = 0;

            elements.ForEach(x =>
            {
                if (condition(x))
                    i++;
            });

            return i;
        }
    }
}
