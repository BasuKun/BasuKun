using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2020
{
    class Day0
    {
        public static List<int> list = new List<int>();

        public static void Execute()
        {
            list = FileParser.ParseFileInt(0);
            for (int i = 0; i < 100000; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("THE ANSWER IS: " + 342197);
        }
    }
}
