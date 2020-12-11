using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2020
{
    static class Day11
    {
        public static List<string> list = new List<string>();
        public static char index = ' ';
        public static char[,] seats;
        public static int occupiedSeats = 0;
        public static bool checksFurther = false;

        public static void Execute()
        {
            list = FileParser.ParseFileString(11);
            seats = new char[list.Count, list[0].Length];
            seats = GenerateSeatsMap();

            PartTwo();
            Console.WriteLine("THE ANSWER IS: " + occupiedSeats);
        }

        public static void PartOne()
        {
            checksFurther = false;
            FillSeats();
        }

        public static void PartTwo()
        {
            checksFurther = true;
            FillSeats();
        }

        public static void FillSeats()
        {
            bool canStopRecursing = false;

            while (!canStopRecursing)
            {
                bool hasChanged = false;
                int filledLimit = checksFurther ? 5 : 4;
                char[,] newSeats = new char[list.Count, list[0].Length];
                newSeats = (char[,])seats.Clone();

                for (int x = 0; x < list.Count; x++)
                {
                    for (int y = 0; y < list[0].Length - 1; y++)
                    {
                        if (seats[x, y] == 'L' && ValidateEmptySeat(x, y))
                        {
                            newSeats[x, y] = '#';
                            hasChanged = true;
                        }
                        if (seats[x, y] == '#' && !ValidateOccupiedSeat(x, y, filledLimit))
                        {
                            newSeats[x, y] = 'L';
                            hasChanged = true;
                        }
                    }
                }
                seats = (char[,])newSeats.Clone();

                canStopRecursing = !hasChanged;
            }

            foreach (char seat in seats)
                occupiedSeats += seat == '#' ? 1 : 0;
        }

        public static bool ValidateEmptySeat(int x, int y)
        {
            if (CheckW(x, y)) return false;
            if (CheckNW(x, y)) return false;
            if (CheckN(x, y)) return false;
            if (CheckNE(x, y)) return false;
            if (CheckE(x, y)) return false;
            if (CheckSE(x, y)) return false;
            if (CheckS(x, y)) return false;
            if (CheckSW(x, y)) return false;

            return true;
        }

        public static bool ValidateOccupiedSeat(int x, int y, int filledLimit)
        {
            int occupiedSeatsAround = 0;

            if (CheckW(x, y)) occupiedSeatsAround++;
            if (CheckNW(x, y)) occupiedSeatsAround++;
            if (CheckN(x, y)) occupiedSeatsAround++;
            if (CheckNE(x, y)) occupiedSeatsAround++;
            if (CheckE(x, y)) occupiedSeatsAround++;
            if (CheckSE(x, y)) occupiedSeatsAround++;
            if (CheckS(x, y)) occupiedSeatsAround++;
            if (CheckSW(x, y)) occupiedSeatsAround++;

            return occupiedSeatsAround >= filledLimit ? false : true;
        }

        public static bool CheckW(int x, int y)
        {
            int manhattanDistance = 1;

            if (checksFurther)
            {
                TryGetIndex(x - manhattanDistance, y, out index);
                while (index != '*' || index != '\0')
                {
                    TryGetIndex(x - manhattanDistance, y, out index);
                    switch (index)
                    {
                        case '#':
                            return true;
                        case 'L':
                            return false;
                        case '.':
                            manhattanDistance++;
                            break;
                        case '\0':
                            return false;
                    }
                }
                return false;
            }

            return (TryGetIndex(x-1, y, out index) && index == '#');
        }
        public static bool CheckNW(int x, int y)
        {
            int manhattanDistance = 1;

            if (checksFurther)
            {
                TryGetIndex(x - manhattanDistance, y - manhattanDistance, out index);
                while (index != '*' || index != '\0')
                {
                    TryGetIndex(x - manhattanDistance, y - manhattanDistance, out index);
                    switch (index)
                    {
                        case '#':
                            return true;
                        case 'L':
                            return false;
                        case '.':
                            manhattanDistance++;
                            break;
                        case '\0':
                            return false;
                    }
                }
                return false;
            }

            return (TryGetIndex(x-1, y-1, out index) && index == '#');
        }
        public static bool CheckN(int x, int y)
        {
            int manhattanDistance = 1;

            if (checksFurther)
            {
                TryGetIndex(x, y - manhattanDistance, out index);
                while (index != '*' || index != '\0')
                {
                    TryGetIndex(x, y - manhattanDistance, out index);
                    switch (index)
                    {
                        case '#':
                            return true;
                        case 'L':
                            return false;
                        case '.':
                            manhattanDistance++;
                            break;
                        case '\0':
                            return false;
                    }
                }
                return false;
            }

            return (TryGetIndex(x, y-1, out index) && index == '#');
        }
        public static bool CheckNE(int x, int y)
        {
            int manhattanDistance = 1;

            if (checksFurther)
            {
                TryGetIndex(x + manhattanDistance, y - manhattanDistance, out index);
                while (index != '*' || index != '\0')
                {
                    TryGetIndex(x + manhattanDistance, y - manhattanDistance, out index);
                    switch (index)
                    {
                        case '#':
                            return true;
                        case 'L':
                            return false;
                        case '.':
                            manhattanDistance++;
                            break;
                        case '\0':
                            return false;
                    }
                }
                return false;
            }

            return (TryGetIndex(x+1, y-1, out index) && index == '#');
        }
        public static bool CheckE(int x, int y)
        {
            int manhattanDistance = 1;

            if (checksFurther)
            {
                TryGetIndex(x + manhattanDistance, y, out index);
                while (index != '*' || index != '\0')
                {
                    TryGetIndex(x + manhattanDistance, y, out index);
                    switch (index)
                    {
                        case '#':
                            return true;
                        case 'L':
                            return false;
                        case '.':
                            manhattanDistance++;
                            break;
                        case '\0':
                            return false;
                    }
                }
                return false;
            }

            return (TryGetIndex(x+1, y, out index) && index == '#');
        }
        public static bool CheckSE(int x, int y)
        {
            int manhattanDistance = 1;

            if (checksFurther)
            {
                TryGetIndex(x + manhattanDistance, y + manhattanDistance, out index);
                while (index != '*' || index != '\0')
                {
                    TryGetIndex(x + manhattanDistance, y + manhattanDistance, out index);
                    switch (index)
                    {
                        case '#':
                            return true;
                        case 'L':
                            return false;
                        case '.':
                            manhattanDistance++;
                            break;
                        case '\0':
                            return false;
                    }
                }
                return false;
            }

            return (TryGetIndex(x+1, y+1, out index) && index == '#');
        }
        public static bool CheckS(int x, int y)
        {
            int manhattanDistance = 1;

            if (checksFurther)
            {
                TryGetIndex(x, y + manhattanDistance, out index);
                while (index != '*' || index != '\0')
                {
                    TryGetIndex(x, y + manhattanDistance, out index);
                    switch (index)
                    {
                        case '#':
                            return true;
                        case 'L':
                            return false;
                        case '.':
                            manhattanDistance++;
                            break;
                        case '\0':
                            return false;
                    }
                }
                return false;
            }
            return (TryGetIndex(x, y+1, out index) && index == '#');
        }
        public static bool CheckSW(int x, int y)
        {
            int manhattanDistance = 1;

            if (checksFurther)
            {
                TryGetIndex(x - manhattanDistance, y + manhattanDistance, out index);
                while (index != '*' || index != '\0')
                {
                    TryGetIndex(x - manhattanDistance, y + manhattanDistance, out index);
                    switch (index)
                    {
                        case '#':
                            return true;
                        case 'L':
                            return false;
                        case '.':
                            manhattanDistance++;
                            break;
                        case '\0':
                            return false;
                    }
                }
                return false;
            }

            return (TryGetIndex(x - 1, y+1, out index) && index == '#');
        }

        public static bool TryGetIndex(int x, int y, out char result)
        {
            bool isZeroX = x == 0 - 1 ? true : false;
            bool isLastX = x == list.Count ? true : false;
            bool isZeroY = y == 0 - 1 ? true : false;

            bool isLastY = y == list[0].Length + 1 ? true : false;
            if (!isZeroX && !isZeroY && !isLastX && !isLastY)
            {
                result = seats[x, y];
                return true;
            }

            result = '\0';
            return false;
        }

        public static char[,] GenerateSeatsMap()
        {
            char[,] array = new char[list.Count, list[0].Length];
            for (int x = 0; x < list.Count; x++)
            {
                for (int y = 0; y < list[0].Length - 1; y++)
                {
                    array[x, y] = list[x][y];
                }
            }

            return array;
        }
    }
}