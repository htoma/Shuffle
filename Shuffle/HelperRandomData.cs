﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Shuffle
{
    public static class HelperRandomData
    {
        /// <summary>
        /// select randomly an element from a collection whose size is unknown
        /// at step i, the probability of selecting element is 1/i
        /// </summary>
       public static T GetRandomElement<T>(IEnumerable<T> data)
        {
            //note: you can pass random as an argument
            var random = new Random();
            var result = default(T);
            int step = 0;
            foreach (var el in data)
            {
                step++;
                if (random.Next(step) == 0)
                {
                    result = el;
                }
            }
            return result;
        }

        /// <summary>
        /// select randomly a subset of size k from online data
        /// </summary>
        public static IEnumerable<T> GetRandomSubset<T>(IEnumerable<T> data, int k)
        {
            // note: you can pass random as an argument
            var random = new Random();
            var result = new List<T>();
            int step = 0;
            foreach (var el in data)
            {
                step++;
                if (step <= k)
                {
                    // initially store in the result the first k elements in the collection
                    result.Add(el);
                    continue;
                }

                // at step i, probability to be selected is k/i
                int pos = random.Next(step);
                if (pos < k)
                {
                    // store element in the result at random position
                    result[pos] = el;
                }
            }
            return result;
        }

        /// <summary>
        /// Shuffle a collection
        /// data size has to be known otherwise a converstion to IList is necessary
        /// </summary>
        public static IEnumerable<T> Shuffle<T>(IEnumerable<T> data)
        {
            // note: you can pass random as an argument
            var random = new Random();
            var result = data.ToList();
            for (int i = 0; i < result.Count; i++)
            {
                var pos = random.Next(i, result.Count);
                var temp = result[pos];
                result[pos] = result[i];
                result[i] = temp;
            }
            return result;
        }
    }
}
