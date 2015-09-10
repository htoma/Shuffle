using System;
using System.Collections.Generic;

namespace Shuffle
{
    public static class Helper
    {
        /// <summary>
        /// select randomly an element from a collection whose size is unknown
        /// </summary>
       public static T GetRandomFromOnlineData<T>(IEnumerable<T> data)
        {
            var random = new Random();
            var result = default(T);
            int n = 0;
            foreach (var el in data)
            {
                n++;
                if (random.Next(n) == 0)
                {
                    result = el;
                }
            }
            return result;
        }
    }
}
