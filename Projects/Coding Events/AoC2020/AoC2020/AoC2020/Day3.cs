using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2020
{
    class Day3
    {
        public static double treesEncountered = 0;
        public static List<string> list = new List<string>();

        public static void Execute()
        {
            list = FileParser.ParseFileString(3);
            treesEncountered = PartTwo();
            Console.WriteLine("THE ANSWER IS: " + treesEncountered);
        }

        public static double PartOne()
        {
            return GoDownTheSlope(3, 1);
        }

        public static double PartTwo()
        {
            double firstSlope = GoDownTheSlope(1, 1);
            double secondSlope = GoDownTheSlope(3, 1);
            double thirdSlope = GoDownTheSlope(5, 1);
            double fourthSlope = GoDownTheSlope(7, 1);
            double fifthSlope = GoDownTheSlope(1, 2);

            return firstSlope * secondSlope * thirdSlope * fourthSlope * fifthSlope;
        }

        public static double GoDownTheSlope(int xSpeed, int ySpeed)
        {
            int xCoord = 0;
            double trees = 0;

            for (int y = 0; y < list.Count; y += ySpeed)
            {
                if (list[y].ElementAt(xCoord) == '#')
                {
                    trees++;
                }

                xCoord += xSpeed;
                if (xCoord >= list[y].Length - 1)
                {
                    xCoord -= list[y].Length - 1;
                }
            }

            return trees;
        }
    }
}
