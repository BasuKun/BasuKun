using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2020
{
    class Day13
    {
        public static List<string> list = new List<string>();
        public static int timestamp = 1000104;

        public static void Execute()
        {
            list = FileParser.ParseFileString(13);
            long answer = PartTwo();
            Console.WriteLine("THE ANSWER IS: " + answer);
        }

        public static int PartOne()
        {
            Dictionary<int, int> busTimestamps = new Dictionary<int, int>();

            foreach (string bus in list)
            {
                if (!int.TryParse(bus, out int result)) continue;

                int busTimestamp = 0;
                int itteration = 1;

                while (busTimestamp < timestamp)
                {
                    busTimestamp = int.Parse(bus) * itteration;
                    itteration++;
                }
                busTimestamps.Add(int.Parse(bus), busTimestamp);
            }

            var minPair = busTimestamps.Aggregate((p1, p2) => (p1.Value < p2.Value) ? p1 : p2);
            return (minPair.Value - timestamp) * minPair.Key;
        }

        public static long PartTwo()
        {
            int firstBus = int.Parse(list.ElementAt(0));
            long increment = firstBus;
            int bussesToCheck = 2;

            List<int> validBusses = new List<int>();
            foreach (string b in list)
            {
                if (!int.TryParse(b, out int bus)) continue;
                else validBusses.Add(bus);
            }

            for (long i = firstBus; i <= double.MaxValue; i += increment)
            {
                bool isGoodAnswer = false;
                int curBus = 0;

                foreach (string b in list)
                {
                    if (!int.TryParse(b, out int bus)) continue;
                    else curBus++;
                    if (curBus > bussesToCheck) break;

                    int pos = list.IndexOf(list.Where(p => p == b).FirstOrDefault());

                    long itteration = i / bus;
                    while (bus * itteration < i + pos) itteration++;

                    if (bus * itteration != i + pos)
                    {
                        isGoodAnswer = false;
                        break;
                    }
                    else isGoodAnswer = true;
                }
                
                if (isGoodAnswer)
                {
                    if (bussesToCheck == validBusses.Count()) return i;
                    else
                    {
                        increment = 1;
                        for (int x = 0; x < bussesToCheck; x++) increment *= validBusses[x];
                        bussesToCheck++;
                    }
                }
            }

            return 0;
        }
    }
}
