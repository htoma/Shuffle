using System;

namespace Shuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Helper.GetRandomFromOnlineData(new []{3, 4, 5, 6, 7, 8}));
        }
    }
}
