using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2020
{
    class Day23
    {
        public static List<int> cups = new List<int>();
        public static int currentCup;
        public static int currentIndex;
        public static int cupPlusOne;
        public static int cupPlusTwo;
        public static int cupPlusThree;
        public static int destinationCup;
        public static int destinationIndex;
        public static int[] heldCups = new int[3];
        public static string order = "";

        public static void Execute()
        {
            cups = FileParser.ParseFileInt(23);
            long answer = PartTwo();
            Console.WriteLine("THE ANSWER IS: " + answer);
        }

        public static long PartOne()
        {
            PlayMove(100);

            order = "";
            order = string.Join("", cups.ToArray());

            return long.Parse(order);
        }

        public static long PartTwo()
        {
            for (int i = 10; i <= 10000000; i++) cups.Add(i);

            PlayMove(10000000);

            int indexOfOne = cups.IndexOf(1);
            return (long)cups[indexOfOne + 1] * (long)cups[indexOfOne + 2];
        }
        
        public static void PlayMove(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                currentIndex = cups.IndexOf(currentCup) + 1;
                while (currentIndex >= cups.Count()) currentIndex -= cups.Count();
                currentCup = cups[currentIndex];

                cupPlusOne = currentIndex + 1;
                cupPlusTwo = currentIndex + 2;
                cupPlusThree = currentIndex + 3;
                while (cupPlusOne >= cups.Count()) cupPlusOne -= cups.Count();
                while (cupPlusTwo >= cups.Count()) cupPlusTwo -= cups.Count();
                while (cupPlusThree >= cups.Count()) cupPlusThree -= cups.Count();

                heldCups[0] = cups[cupPlusOne];
                heldCups[1] = cups[cupPlusTwo];
                heldCups[2] = cups[cupPlusThree];
                cups.Remove(heldCups[0]);
                cups.Remove(heldCups[1]);
                cups.Remove(heldCups[2]);

                destinationCup = currentCup - 1;
                if (destinationCup == 0) destinationCup = cups.Count() + heldCups.Count();
                while (heldCups.Contains(destinationCup))
                {
                    destinationCup -= 1;
                    if (destinationCup <= 0) destinationCup += cups.Count() + heldCups.Count();
                }
                destinationIndex = cups.IndexOf(destinationCup);

                cups.InsertRange(destinationIndex + 1, heldCups);
                heldCups = new int[3];
            }
        }
    }
}
