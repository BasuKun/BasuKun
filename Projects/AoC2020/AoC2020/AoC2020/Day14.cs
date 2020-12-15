using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2020
{
    static class Day14
    {
        public static List<Command> list = new List<Command>();
        public static Dictionary<long, long> addressesDict = new Dictionary<long, long>();
        private static readonly Random rng = new Random();

        public static void Execute()
        {
            list = Parser(14);
            long answer = PartTwo();

            Console.WriteLine("THE ANSWER IS: " + answer);
        }

        public static long PartOne()
        {
            foreach (Command c in list)
            {
                string binaryValue = ConvertToBinary(c.Value);

                for (int i = 0; i < binaryValue.Length; i++)
                {
                    switch (c.Mask.ElementAt(i))
                    {
                        case 'X':
                            break;
                        case '1':
                            binaryValue = ApplyBitMask(binaryValue, i, '1');
                            break;
                        case '0':
                            binaryValue = ApplyBitMask(binaryValue, i, '0');
                            break;
                    }
                }
                addressesDict[c.Mem] = Convert.ToInt64(binaryValue, 2);
            }

            long total = 0;
            foreach (var ad in addressesDict) total += ad.Value;

            return total;
        }

        public static long PartTwo()
        {
            foreach (Command c in list)
            {
                string binaryMem = ConvertToBinary(c.Mem);

                for (int i = 0; i < binaryMem.Length; i++)
                {
                    switch (c.Mask.ElementAt(i))
                    {
                        case 'X':
                            binaryMem = ApplyBitMask(binaryMem, i, 'X');
                            break;
                        case '1':
                            binaryMem = ApplyBitMask(binaryMem, i, '1');
                            break;
                        case '0':
                            break;
                    }
                }
                List<long> allVariants = GenerateAddresses(binaryMem);

                foreach (var a in allVariants)
                {
                    addressesDict[a] = c.Value;
                }
            }

            long total = 0;
            foreach (var ad in addressesDict) total += ad.Value;

            return total;
        }

        public static string ApplyBitMask(string s, int index, char bit)
        {
            StringBuilder sb = new StringBuilder(s);
            sb[index] = bit;

            return sb.ToString();
        }

        public static string ConvertToBinary(int val)
        {
            string binVal = Convert.ToString(val, 2);
            int bits = 0;
            int bitBlock = 36;

            for (int i = 0; i < binVal.Length; i = i + bitBlock) bits += bitBlock;

            return binVal.PadLeft(bits, '0');
        }

        public static List<long> GenerateAddresses(string mem)
        {
            int xCount = mem.Count(x => x == 'X');
            List<string> variants = CreateVariants(xCount);
            List<long> addresses = new List<long>();

            foreach (var variant in variants)
            {
                int index = 0;
                string address = mem;

                for (int i = 0; i < mem.Length; i++)
                {
                    switch (mem.ElementAt(i))
                    {
                        case 'X':
                            address = ApplyBitMask(address, i, variant.ElementAt(index));
                            index++;
                            break;
                        case '1':
                            break;
                        case '0':
                            break;
                    }
                }
                addresses.Add(Convert.ToInt64(address, 2));
            }

            return addresses;
        }

        public static List<string> CreateVariants(int amount)
        {
            var pool = "01";
            List<string> allVariants = new List<string>();

            while (allVariants.Count != Math.Pow(2, amount))
            {
                var builder = new StringBuilder();

                for (var i = 0; i < amount; i++)
                {
                    var c = pool[rng.Next(0, pool.Length)];
                    builder.Append(c);
                }
                string newVariant = builder.ToString();

                if (!allVariants.Contains(newVariant)) allVariants.Add(newVariant);
            }

            return allVariants;
        }

        public static List<Command> Parser(int day)
        {
            List<string> lines = new List<string>();
            List<Command> ParsedList = new List<Command>();

            string text = File.ReadAllText($@"C:\Users\Seb\Documents\GitHub\BasuKun\Projects\AoC2020\TextFiles\Day{day}.txt");
            string curMask = "";

            lines = text.Split('\n').ToList();

            foreach (string line in lines)
            {
                if (line.StartsWith("mask")) curMask = line.Substring(7);

                else
                {
                    List<string> splitLine = line.Substring(4).Split(new string[] { "] = " }, StringSplitOptions.None).ToList();
                    ParsedList.Add(new Command(curMask, int.Parse(splitLine[0]), int.Parse(splitLine[1])));
                }
            }

            return ParsedList;
        }
    }

    public struct Command
    {
        public string Mask { get; set; }
        public int Mem { get; set; }
        public int Value { get; set; }

        public Command(string mask, int mem, int value)
        {
            Mask = mask;
            Mem = mem;
            Value = value;
        }
    }
}
