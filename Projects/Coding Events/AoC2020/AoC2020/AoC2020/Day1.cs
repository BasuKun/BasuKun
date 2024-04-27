using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2020
{
    class Day1
    {
        public static List<int> list = new List<int>();
        public static int itterations = 0;

        public static void Execute()
        {
            list = FileParser.ParseFileInt(1);
            list.Sort();
            int answer = PartTwo();
            Console.WriteLine("THE ANSWER IS: " + answer + ", " + itterations + " itterations");
        }

        public static int PartOne()
        {
            int leftover = 0;

            foreach (int entry in list)
            {
                itterations++;
                leftover = 2020 - entry;

                if (list.Contains(leftover))
                {
                    return entry * leftover;
                }
            }
            return 0;
        }

        public static int PartTwo()
        {
            int leftover = 0;

            for (int a = 0; a < list.Count; a++)
            {
                for (int b = 0; b < list.Count; b++)
                {
                    itterations++;

                    if (a == b) continue;
                    leftover = 2020 - list[a] - list[b];

                    if (list.Contains(leftover))
                    {
                        return list[a] * list[b] * leftover;
                    }
                }
            }
            return 0;
        }
    }
}
