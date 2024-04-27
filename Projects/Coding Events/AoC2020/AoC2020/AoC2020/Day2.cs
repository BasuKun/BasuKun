using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2020
{
    class Day2
    {
        public static int minAmount;
        public static int maxAmount;
        public static char charRequirement;
        public static string password;
        public static string[] leftover;
        public static int correctPasswords = 0;
        public static List<string> list = new List<string>();

        public static void Execute()
        {
            list = FileParser.ParseFileString(2);
            PartTwo();
            Console.WriteLine("THE ANSWER IS: " + correctPasswords);
        }

        public static void PartOne()
        {
            foreach (string entry in list)
            {
                SplitInformation(entry);

                int count = password.Count(x => x == charRequirement);
                if (count >= minAmount && count <= maxAmount) correctPasswords++;
            }
        }

        public static void PartTwo()
        {
            foreach (string entry in list)
            {
                SplitInformation(entry);

                int amountOfRulesRespected = 0;
                if (password.ElementAt(minAmount - 1) == charRequirement) amountOfRulesRespected++;
                if (password.ElementAt(maxAmount - 1) == charRequirement) amountOfRulesRespected++;

                if (amountOfRulesRespected == 1) correctPasswords++;
            }
        }

        public static void SplitInformation(string entry)
        {
            leftover = entry.Split('-');
            minAmount = int.Parse(leftover[0]);
            leftover = leftover[1].Split(' ');
            password = leftover[2];
            maxAmount = int.Parse(leftover[0]);
            leftover = leftover[1].Split(':');
            charRequirement = char.Parse(leftover[0]);
        }
    }
}
