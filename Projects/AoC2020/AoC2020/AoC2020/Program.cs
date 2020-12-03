using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2020
{
    class Program
    {
        public static Stopwatch sw = new Stopwatch();

        static void Main(string[] args)
        {
            sw.Restart();
            Day3.Execute();
            sw.Stop();
            Console.WriteLine("TIME NEEDED: " + sw.ElapsedMilliseconds + "ms");
            Console.ReadLine();
        }
    }
}
