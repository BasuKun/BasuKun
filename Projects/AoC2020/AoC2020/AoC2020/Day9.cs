using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2020
{
    class Day9
    {
        public static List<double> list = new List<double>();
        public static int preamble = 25;

        public static void Execute()
        {
            list = FileParser.ParseFileDouble(9);
            double answer = PartTwo();
            Console.WriteLine("THE ANSWER IS: " + answer);
        }

        public static double PartOne()
        {
            bool isValid;

            for (int num = preamble; num < list.Count; num++)
            {
                isValid = false;

                for (int x = num - preamble; x < num; x++)
                {
                    for (int y = num - preamble; y < num; y++)
                    {
                        if (list[x] == list[y]) continue;
                        if (list[num] == list[x] + list[y]) isValid = true;
                        if (isValid) break;
                    }
                    if (isValid) break;
                }
                if (!isValid) return list[num];
            }
            return 0;
        }

        public static double PartTwo()
        {
            double total = PartOne();

            foreach (var num in list)
            {
                double sum = num;
                List<double> range = new List<double>();
                range.Add(num);

                for (int i = 1; i < list.IndexOf(total) - i; i++)
                {
                    sum += list[list.IndexOf(num) + i];
                    range.Add(list[list.IndexOf(num) + i]);

                    if (sum > total) break;
                    if (sum == total) return range.Min() + range.Max();
                }
            }
            return 0;
        }
    }
}
