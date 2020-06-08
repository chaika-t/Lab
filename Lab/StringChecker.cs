using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab
{
    public class StringChecker
    {
        public static string[] FindMoreThanAverage(string[] array)
        {
            int averageLength = FindAverageLength(array);

            List<string> lst = new List<string>();

            foreach (var str in array)
            {
                if (str.Length > averageLength)
                    lst.Add(str);
            }

            return lst.ToArray();
        }

        public static int FindAverageLength(string[] array)
        {
            var sum = array.Sum(str => str.Length);

            return sum / array.Length;
        }
    }
}