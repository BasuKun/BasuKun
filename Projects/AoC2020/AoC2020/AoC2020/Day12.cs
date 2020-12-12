using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2020
{
    class Day12
    {
        public static List<string> list = new List<string>();
        public static Train train = new Train(0, 0, Direction.E);
        public static Waypoint waypoint = new Waypoint(10, 1);

        public static void Execute()
        {
            list = FileParser.ParseFileString(12);

            int answer = PartTwo();
            Console.WriteLine("THE ANSWER IS: " + answer);
        }

        public static int PartOne()
        {
            foreach (string inst in list)
            {
                switch (inst.ElementAt(0))
                {
                    case 'N':
                        train.Y += int.Parse(inst.Remove(0, 1));
                        break;
                    case 'S':
                        train.Y -= int.Parse(inst.Remove(0, 1));
                        break;
                    case 'E':
                        train.X += int.Parse(inst.Remove(0, 1));
                        break;
                    case 'W':
                        train.X -= int.Parse(inst.Remove(0, 1));
                        break;
                    case 'L':
                        train.Rotation = RotateTrain(int.Parse(inst.Remove(0, 1)) * -1);
                        break;
                    case 'R':
                        train.Rotation = RotateTrain(int.Parse(inst.Remove(0, 1)));
                        break;
                    case 'F':
                        MoveForward(int.Parse(inst.Remove(0, 1)));
                        break;
                }
            }
            return Math.Abs(train.X) + Math.Abs(train.Y);
        }

        public static int PartTwo()
        {
            foreach (string inst in list)
            {
                switch (inst.ElementAt(0))
                {
                    case 'N':
                        waypoint.Y += int.Parse(inst.Remove(0, 1));
                        break;
                    case 'S':
                        waypoint.Y -= int.Parse(inst.Remove(0, 1));
                        break;
                    case 'E':
                        waypoint.X += int.Parse(inst.Remove(0, 1));
                        break;
                    case 'W':
                        waypoint.X -= int.Parse(inst.Remove(0, 1));
                        break;
                    case 'L':
                        RotateWaypoint(int.Parse(inst.Remove(0, 1)) * -1);
                        break;
                    case 'R':
                        RotateWaypoint(int.Parse(inst.Remove(0, 1)));
                        break;
                    case 'F':
                        train.X += int.Parse(inst.Remove(0, 1)) * waypoint.X;
                        train.Y += int.Parse(inst.Remove(0, 1)) * waypoint.Y;
                        break;
                }
            }
            return Math.Abs(train.X) + Math.Abs(train.Y);
        }

        public static Direction RotateTrain(int angle)
        {
            int newRotation = ((int)train.Rotation * 90) + angle;

            while (newRotation >= 360)
                newRotation -= 360;
            while (newRotation < 0)
                newRotation += 360;

            return (Direction)Enum.Parse(typeof(Direction), (newRotation / 90).ToString());
        }

        public static void RotateWaypoint(int amount)
        {
            while (amount < 0)
                amount += 360;

            for (int i = 0; i < (amount / 90); i++)
            {
                int curX = waypoint.X;
                int curY = waypoint.Y;
                waypoint.X = curY;
                waypoint.Y = -curX;
            }
        }

        public static void MoveForward(int amount)
        {
            switch (train.Rotation)
            {
                case Direction.N:
                    train.Y += amount;
                    break;
                case Direction.E:
                    train.X += amount;
                    break;
                case Direction.S:
                    train.Y -= amount;
                    break;
                case Direction.W:
                    train.X -= amount;
                    break;
            }
        }
    }

    public struct Train
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Direction Rotation { get; set; }

        public Train(int x, int y, Direction rotation)
        {
            X = x;
            Y = y;
            Rotation = rotation;
        }
    }

    public struct Waypoint
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Waypoint(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public enum Direction
    {
        N = 0,
        E = 1,
        S = 2,
        W = 3
    }
}
