using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace intcode
{
    public class Day11 : Day9
    {
        public Dictionary<(int, int), char> panels = new Dictionary<(int, int), char>();
        private char currentPanel = '.';
        private char direction = '^';
        private int x = 0;
        private int y = 0;
        public int totalPanels = 0;

        public Object blackSquare;
        public Object whiteSquare;

        void Start()
        {
            panels.Add((0, 0), '#');
            Instantiate(whiteSquare, new Vector3(x, y, 0), transform.rotation);
            StartCoroutine("RunProgram");
        }

        void Update()
        {
            if (output.Count == 2)
            {
                RobotPainting();
                RobotMoving();
                currentPanel = GetCurrentColor();
                inputInstruction = currentPanel == '.' ? 0 : 1;

                Debug.Log("output got! Removing " + output[0] + ", " + output[1]);
                output.RemoveRange(0, 2);
            }
        }

        public void RobotPainting()
        {
            if (panels.ContainsKey((x, y)))
            {
                if (output[0] == 0)
                {
                    panels[(x, y)] = '.';
                    Instantiate(blackSquare, new Vector3(x, y, 0), transform.rotation);
                }
                else if (output[0] == 1)
                {
                    panels[(x, y)] = '#';
                    Instantiate(whiteSquare, new Vector3(x, y, 0), transform.rotation);
                }
            }
            else
            {
                if (output[0] == 0)
                {
                    panels.Add((x, y), '.');
                    Instantiate(blackSquare, new Vector3(x, y, 0), transform.rotation);
                }
                else if (output[0] == 1)
                {
                    panels.Add((x, y), '#');
                    Instantiate(whiteSquare, new Vector3(x, y, 0), transform.rotation);
                }
                totalPanels++;
            }
        }

        public void RobotMoving()
        {
            if (direction == '^')
            {
                direction = output[1] == 0 ? '<' : '>';
            }
            else if (direction == '<')
            {
                direction = output[1] == 0 ? 'v' : '^';
            }
            else if (direction == 'v')
            {
                direction = output[1] == 0 ? '>' : '<';
            }
            else if (direction == '>')
            {
                direction = output[1] == 0 ? '^' : 'v';
            }

            if (direction == '^')
            {
                y++;
            }
            else if (direction == '<')
            {
                x--;
            }
            else if (direction == 'v')
            {
                y--;
            }
            else if (direction == '>')
            {
                x++;
            }
        }

        public char GetCurrentColor()
        {
            if (panels.ContainsKey((x, y)))
            {
                return panels[(x, y)];
            }
            else
            {
                return '.';
            }
        }
    }
}
