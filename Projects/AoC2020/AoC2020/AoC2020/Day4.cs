using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AoC2020
{
    class Day4
    {
        public static List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();
        public static int validPassports;

        public static void Execute()
        {
            list = FileParser.ParseFileDict(4);
            PartTwo();
            Console.WriteLine("THE ANSWER IS: " + validPassports);
        }

        public static void PartOne()
        {
            ValidatePassports(false);
        }

        public static void PartTwo()
        {
            ValidatePassports(true);
        }

        public static void ValidatePassports(bool mustValidateData)
        {
            int requiredFields;

            foreach (var passport in list)
            {
                requiredFields = 0;
                requiredFields += passport.Keys.Contains("byr") ? 1 : 0;
                requiredFields += passport.Keys.Contains("iyr") ? 1 : 0;
                requiredFields += passport.Keys.Contains("eyr") ? 1 : 0;
                requiredFields += passport.Keys.Contains("hgt") ? 1 : 0;
                requiredFields += passport.Keys.Contains("hcl") ? 1 : 0;
                requiredFields += passport.Keys.Contains("ecl") ? 1 : 0;
                requiredFields += passport.Keys.Contains("pid") ? 1 : 0;

                if (requiredFields >= 7)
                {
                    if (!mustValidateData) validPassports++;

                    else
                    {
                        int validData = 0;
                        validData += byrCheck(passport["byr"]) ? 1 : 0;
                        validData += iyrCheck(passport["iyr"]) ? 1 : 0;
                        validData += eyrCheck(passport["eyr"]) ? 1 : 0;
                        validData += hgtCheck(passport["hgt"]) ? 1 : 0;
                        validData += hclCheck(passport["hcl"]) ? 1 : 0;
                        validData += eclCheck(passport["ecl"]) ? 1 : 0;
                        validData += pidCheck(passport["pid"]) ? 1 : 0;

                        if (validData >= 7) validPassports++;
                    }
                }
            }
        }

        public static bool byrCheck(string data)
        {
            int.TryParse(data, out int dataValue);

            if (dataValue < 1920 || dataValue > 2002) return false;
            return true;
        }

        public static bool iyrCheck(string data)
        {
            int.TryParse(data, out int dataValue);

            if (dataValue < 2010 || dataValue > 2020) return false;
            return true;
        }

        public static bool eyrCheck(string data)
        {
            int.TryParse(data, out int dataValue);

            if (dataValue < 2020 || dataValue > 2030) return false;
            return true;
        }

        public static bool hgtCheck(string data)
        {
            if (!data.Contains("cm") && !data.Contains("in")) return false;

            if (data.Contains("cm"))
            {
                data = data.Replace("cm", "");
                if (int.Parse(data) < 150 || int.Parse(data) > 193) return false;
            }
            else if (data.Contains("in"))
            {
                data = data.Replace("in", "");
                if (int.Parse(data) < 59 || int.Parse(data) > 76) return false;
            }
            return true;
        }

        public static bool hclCheck(string data)
        {
            if (data.ElementAt(0) != '#') return false;
            if (data.Length < 7) return false;
            return true;
        }

        public static bool eclCheck(string data)
        {
            if (data != "amb" && data != "blu" && data != "brn" && 
                data != "gry" && data != "grn" && data != "hzl" && data != "oth") return false;
            return true;
        }

        public static bool pidCheck(string data)
        {
            if (!int.TryParse(data, out int result)) return false;
            if (data.Length != 9) return false;
            return true;
        }
    }
}
