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
    }
}
