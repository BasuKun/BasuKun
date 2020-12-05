using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AoC2020
{
    public static class FileParser
    {
        public static List<string> ParseFileString(int day)
        {
            List<string> ParsedList = new List<string>();
            string text = File.ReadAllText($@"C:\Users\Seb\Documents\GitHub\BasuKun\Projects\AoC2020\TextFiles\Day{day}.txt");
            ParsedList = text.Split('\n').ToList();

            return ParsedList;
        }

        public static List<int> ParseFileInt(int day)
        {
            List<string> ParsedList = new List<string>();
            List<int> ParsedListInt = new List<int>();
            string text = File.ReadAllText($@"C:\Users\Seb\Documents\GitHub\BasuKun\Projects\AoC2020\TextFiles\Day{day}.txt");
            ParsedList = text.Split('\n').ToList();
            ParsedListInt = ParsedList.Select(int.Parse).ToList();

            return ParsedListInt;
        }

        public static List<float> ParseFileFloat(int day)
        {
            List<string> ParsedList = new List<string>();
            List<float> ParsedListFloat = new List<float>();
            string text = File.ReadAllText($@"C:\Users\Seb\Documents\GitHub\BasuKun\Projects\AoC2020\TextFiles\Day{day}.txt");
            ParsedList = text.Split('\n').ToList();
            ParsedListFloat = ParsedList.Select(float.Parse).ToList();

            return ParsedListFloat;
        }

        public static List<Dictionary<string, string>> ParseFileDict(int day)
        {
            var TextLines = new List<string>();
            TextLines = File.ReadAllLines($@"C:\Users\Seb\Documents\GitHub\BasuKun\Projects\AoC2020\TextFiles\Day{day}.txt").ToList();

            var dictList = new List<Dictionary<string, string>>();
            int listIndex = 0;

            foreach (string line in TextLines)
            {
                if (line.Length == 0)
                {
                    listIndex++;
                    continue;
                }

                var lineSplit = line.Split(' ').ToList();
                foreach (string entry in lineSplit)
                {
                    dictList.Add(new Dictionary<string, string>());

                    var entrySplit = entry.Split(':').ToList();
                    dictList[listIndex].Add(entrySplit[0], entrySplit[1]);
                }
            }
            return dictList;
        }
    }
}
