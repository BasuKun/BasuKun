using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2020
{
    class Day10
    {
        public static List<int> list = new List<int>();

        public static void Execute()
        {
            list = FileParser.ParseFileInt(10);

            long answer = PartTwo();
            Console.WriteLine("THE ANSWER IS: " + answer);
        }

        public static long PartOne()
        {
            int oneJoltDiff = 0;
            int twoJoltDiff = 0;
            int threeJoltDiff = 0;

            list.Add(0);
            list.Add(list.Max() + 3);
            list.Sort();

            for (int i = 0; i < list.Count - 1; i++)
            {
                switch (list[i + 1] - list[i])
                {
                    case 1:
                        oneJoltDiff++;
                        break;
                    case 2:
                        twoJoltDiff++;
                        break;
                    case 3:
                        threeJoltDiff++;
                        break;
                }
            }
            return oneJoltDiff * threeJoltDiff;
        }

        public static long PartTwo()
        {
            int[] adapters = list.Append(0).OrderBy(x => x).ToArray();
            long[] paths = new long[adapters.Length];
            paths[0] = 1;

            foreach (int x in Enumerable.Range(1, adapters.Length - 1))
            {
                foreach (int y in Enumerable.Range(0, x))
                {
                    //Console.WriteLine("Checking " + adapters[x] + " and " + adapters[y]);
                    if (adapters[x] - adapters[y] <= 3)
                    {
                        //Console.WriteLine("===ADDING " + paths[y] + " TO " + paths[x]);
                        paths[x] += paths[y];
                    }
                }
            }
            return paths.Last();
        }
    }
}
