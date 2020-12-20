using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2020
{
    class Day17
    {
        public static List<string> list = new List<string>();
        public static Dictionary<(int, int, int, int), Cube> grid = new Dictionary<(int, int, int, int), Cube>();
        public static int cycles = 6;

        public static void Execute()
        {
            list = FileParser.ParseFileString(17);
            GenerateGrid();
            int answer = RunPocketDimension();
            Console.WriteLine("THE ANSWER IS: " + answer);
        }

        public static int RunPocketDimension()
        {
            int activatedCubes = 0;
            for (int i = 1; i <= cycles; i++) Cycle();
            foreach (var cube in grid) activatedCubes += cube.Value.IsActive ? 1 : 0;

            return activatedCubes;
        }

        public static void Cycle()
        {
            int gridSize = list[0].Length + cycles;

            for (int x = -cycles; x < gridSize; x++)
            {
                for (int y = -cycles; y < gridSize; y++)
                {
                    for (int z = -cycles; z < gridSize; z++)
                    {
                        for (int w = -cycles; w < gridSize; w++)
                        {
                            int activeNeighbors = CheckNeighbors(x, y, z, w);

                            switch (grid[(x, y, z, w)].IsActive)
                            {
                                case true:
                                    grid[(x, y, z, w)].WillActivate = activeNeighbors == 2 || activeNeighbors == 3 ? true : false;
                                    break;
                                case false:
                                    grid[(x, y, z, w)].WillActivate = activeNeighbors == 3 ? true : false;
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                }
            }

            EndCycle();
        }

        public static void EndCycle()
        {
            int gridSize = list[0].Length + cycles;

            for (int x = -cycles; x < gridSize; x++)
            {
                for (int y = -cycles; y < gridSize; y++)
                {
                    for (int z = -cycles; z < gridSize; z++)
                    {
                        for (int w = -cycles; w < gridSize; w++)
                        {
                            grid[(x, y, z, w)].ActivateCube();
                        }
                    }
                }
            }
        }

        public static int CheckNeighbors(int cubeX, int cubeY, int cubeZ, int cubeW)
        {
            int activeNeighbors = 0;

            for (int x = -1; x <= 1; x++)
            {
                for (int y = -1; y <= 1; y++)
                {
                    for (int z = -1; z <= 1; z++)
                    {
                        for (int w = -1; w <= 1; w++)
                        {
                            if (x == 0 && y == 0 && z == 0 && w == 0)
                            {
                                if (grid.ContainsKey((cubeX + x, cubeY + y, cubeZ + z, cubeW + w))) continue;
                                else
                                {
                                    grid.Add((cubeX + x, cubeY + y, cubeZ + z, cubeW + w), new Cube(false, false));
                                    continue;
                                }
                            }

                            if (grid.ContainsKey((cubeX + x, cubeY + y, cubeZ + z, cubeW + w)))
                            {
                                if (grid[(cubeX + x, cubeY + y, cubeZ + z, cubeW + w)].IsActive) activeNeighbors++;
                            }
                            else grid.Add((cubeX + x, cubeY + y, cubeZ + z, cubeW + w), new Cube(false, false));
                        }
                    }
                }
            }

            return activeNeighbors;
        }

        public static void GenerateGrid()
        {
            for (int x = 0; x < list[0].Length - 1; x++)
            {
                for (int y = 0; y < list[0].Length - 1; y++)
                {
                    if (list[x].ElementAt(y) == '#') grid.Add((x, y, 0, 0), new Cube(true, false));
                }
            }
        }
    }

    public class Cube
    {
        public bool IsActive { get; set; }
        public bool WillActivate { get; set; }

        public Cube(bool isActive, bool willActivate)
        {
            IsActive = isActive;
            WillActivate = willActivate;
        }

        public void ActivateCube()
        {
            this.IsActive = this.WillActivate;
            this.WillActivate = false;
        }
    }
}
