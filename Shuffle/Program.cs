using System;

namespace Shuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            // test random element
            //Console.WriteLine(HelperRandomData.GetRandomElement(new []{3, 4, 5, 6, 7, 8}));

            // test random subset
            //foreach (var el in HelperRandomData.GetRandomSubset(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 3))
            //{
            //    Console.WriteLine(el);
            
            // test shuffle   
            Console.WriteLine(string.Join(",", HelperRandomData.Shuffle(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9})));
        }
    }
}
