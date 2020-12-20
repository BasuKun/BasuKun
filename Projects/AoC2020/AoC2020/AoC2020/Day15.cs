using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2020
{
    class Day15
    {
        public static List<int> list = new List<int>();
        public static Dictionary<int, List<int>> numbers = new Dictionary<int, List<int>>();

        public static void Execute()
        {
            list = FileParser.ParseFileInt(15);
            numbers = PopulateDictionary();

            int answer = PartTwo();
            Console.WriteLine("THE ANSWER IS: " + answer);
        }

        public static int PartOne()
        {
            return PlayGame(2020);
        }

        public static int PartTwo()
        {
            return PlayGame(30000000);
        }

        public static int PlayGame(int rounds)
        {
            int lastNumber = list.Last();

            for (int i = list.Count; i < rounds; i++)
            {
                int repeats = numbers[lastNumber].Count;

                if (repeats <= 1) lastNumber = 0;
                else lastNumber = numbers[lastNumber][repeats - 1] - numbers[lastNumber][repeats - 2];

                numbers[lastNumber].Add(i);
            }

            return lastNumber;
        }

        public static Dictionary<int, List<int>> PopulateDictionary()
        {
            Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
            int index = 0;

            for (int i = 0; i < 30000000; i++) dictionary[i] = new List<int>();

            foreach (var num in list)
            {
                dictionary[num].Add(index);
                index++;
            }

            return dictionary;
        }
    }
}
