using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2020
{
    class Day5
    {
        public static int highestSeat;
        public static List<string> list = new List<string>();
        public static List<int> seatIDs = new List<int>();

        public static void Execute()
        {
            list = FileParser.ParseFileString(5);
            int answer = PartTwo();
            Console.WriteLine("THE ANSWER IS: " + answer);
        }

        public static int PartOne()
        {
            BinarySeatFind();
            return highestSeat;
        }

        public static int PartTwo()
        {
            BinarySeatFind();
            seatIDs.Sort();

            for (int i = 0; i < seatIDs.Count - 1; i++)
            {
                if (seatIDs[i + 1] - seatIDs[i] == 2)
                {
                    return seatIDs[i] + 1;
                }
            }
            return 0;
        }

        public static void BinarySeatFind()
        {
            foreach (string entry in list)
            {
                int minRow = 0;
                int maxRow = 127;
                int minColumn = 0;
                int maxColumn = 7;
                int seatID = 0;
                char[] entryChars = entry.ToCharArray();

                for (int x = 0; x < 7; x++)
                {
                    minRow = entryChars[x] == 'F' ? minRow : minRow + ((maxRow - minRow) / 2 + 1);
                    maxRow = entryChars[x] == 'F' ? maxRow - ((maxRow - minRow) / 2 + 1) : maxRow;
                }
                for (int y = 7; y < 10; y++)
                {
                    minColumn = entryChars[y] == 'L' ? minColumn : minColumn + ((maxColumn - minColumn) / 2 + 1);
                    maxColumn = entryChars[y] == 'L' ? maxColumn - ((maxColumn - minColumn) / 2 + 1) : maxColumn;
                }

                seatID = (maxRow * 8) + maxColumn;
                seatIDs.Add(seatID);
                if (seatID > highestSeat) highestSeat = seatID;
            }
        }
    }
}
