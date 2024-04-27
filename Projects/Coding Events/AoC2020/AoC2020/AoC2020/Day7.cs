using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2020
{
    class Day7
    {
        public static Dictionary<string, string> bagsDictionary = new Dictionary<string, string>();

        public static void Execute()
        {
            bagsDictionary = FileParser.ParseFileCustomDictionary(7);
            int answer = PartTwo();
            Console.WriteLine("THE ANSWER IS: " + answer);
        }

        public static int PartOne()
        {
            int bagCount = 0;
            foreach (var key in bagsDictionary.Keys)
            {
                if (HasShinyGold(key)) bagCount++;
            }
            return bagCount;
        }

        public static bool HasShinyGold(string color)
        {
            if (bagsDictionary[color].Contains("shiny gold")) return true;

            else
            {
                foreach (var value in bagsDictionary[color].Split(new string[] { ", " }, StringSplitOptions.None))
                {
                    if (!value.Equals("no other"))
                    {
                        if (!HasShinyGold(value.Substring(2))) continue;

                        else return true;
                    }
                }
            }
            return false;
        }

        public static int PartTwo(string color = "shiny gold")
        {
            int totalBags = 0;
            foreach (var s in bagsDictionary[color].Split(new string[] { ", " }, StringSplitOptions.None))
            {
                if (!s.Equals("no other"))
                {
                    int amount = Convert.ToInt32(s.Substring(0, 1));
                    totalBags += amount + amount * PartTwo(s.Substring(2));
                }
                else break;
            }
            return totalBags;
        }
    }
}
