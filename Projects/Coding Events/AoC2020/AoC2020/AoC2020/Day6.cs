using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2020
{
    class Day6
    {
        public static List<List<string>> list = new List<List<string>>();

        public static void Execute()
        {
            list = FileParser.ParseFileList(6);
            int answer = PartTwo();
            Console.WriteLine("THE ANSWER IS: " + answer);
        }

        public static int PartOne()
        {
            int totalYesses = 0;
            foreach (var group in list)
            {
                List<char> groupYesses = new List<char>();
                foreach (var person in group)
                {
                    var personYesses = person.ToCharArray();
                    foreach (var yes in personYesses)
                    {
                        if (!groupYesses.Contains(yes))
                        {
                            groupYesses.Add(yes);
                        }
                    }
                }
                totalYesses += groupYesses.Count();
            }
            return totalYesses;
        }

        public static int PartTwo()
        {
            int totalYesses = 0;
            foreach (var group in list)
            {
                List<char> groupYesses = new List<char>();
                List<char> currentYesses = new List<char>();
                bool checkedFirstPerson = false;

                foreach (var person in group)
                {
                    var personYesses = person.ToCharArray().ToList();

                    if (!checkedFirstPerson)
                    {
                        foreach (var yes in personYesses)
                        {
                            currentYesses.Add(yes);
                            groupYesses = new List<char>(currentYesses);
                        }
                        checkedFirstPerson = true;
                    }
                    else
                    {
                        for (int i = 0; i < groupYesses.Count; i++)
                        {
                            if (!personYesses.Any(t => t.Equals(groupYesses[i])))
                            {
                                currentYesses.Remove(groupYesses[i]);
                            }
                        }
                        groupYesses = new List<char>(currentYesses);
                    }
                }
                totalYesses += groupYesses.Count();
            }
            return totalYesses;
        }
    }
}
