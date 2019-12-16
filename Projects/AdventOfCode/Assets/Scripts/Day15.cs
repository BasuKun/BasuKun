using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace intcode
{
    public class Day15 : Day9
    {
        public List<Vector2> steps = new List<Vector2>();
        public List<Vector2> walls = new List<Vector2>();
        public List<Vector2> deadends = new List<Vector2>();
        public List<Vector2> completeMap = new List<Vector2>();
        public List<Vector2> ventilated = new List<Vector2>();
        public Vector2 currentPos = new Vector2(0, 0);

        public GameObject wall;
        public GameObject robot;
        public GameObject empty;
        public GameObject oxygenSystem;
        public GameObject deadend;
        public GameObject ventilation;

        public bool randomAI = true;
        public bool foundSystem = false;
        public bool readyToVentilate = false;
        public bool mapListDone = false;

        public int movementInput;
        public int totalSteps;
        public int ventilationTime;

        GameObject robotInstance;

        void Start()
        {
            inputInstruction = 1;
            robotInstance = Instantiate(robot, currentPos, transform.rotation);
            steps.Add(currentPos);
            Instantiate(empty, currentPos, transform.rotation);
            StartCoroutine("RunProgram");
        }

        void Update()
        {
            if (output.Count == 1)
            {
                if (output[0] == 0)
                {
                    Vector2 newWall = new Vector2(0, 0);

                    switch (inputInstruction)
                    {
                        case 1:
                            newWall = new Vector2(currentPos.x, currentPos.y + 1);
                            Instantiate(wall, newWall, transform.rotation);
                            break;
                        case 2:
                            newWall = new Vector2(currentPos.x, currentPos.y - 1);
                            Instantiate(wall, newWall, transform.rotation);
                            break;
                        case 3:
                            newWall = new Vector2(currentPos.x - 1, currentPos.y);
                            Instantiate(wall, newWall, transform.rotation);
                            break;
                        case 4:
                            newWall = new Vector2(currentPos.x + 1, currentPos.y);
                            Instantiate(wall, newWall, transform.rotation);
                            break;
                    }
                    if (!walls.Contains(newWall))
                    {
                        walls.Add(newWall);
                    }
                }

                else if (output[0] == 1)
                {
                    switch (inputInstruction)
                    {
                        case 1:
                            currentPos = new Vector2(currentPos.x, currentPos.y + 1);
                            break;
                        case 2:
                            currentPos = new Vector2(currentPos.x, currentPos.y - 1);
                            break;
                        case 3:
                            currentPos = new Vector2(currentPos.x - 1, currentPos.y);
                            break;
                        case 4:
                            currentPos = new Vector2(currentPos.x + 1, currentPos.y);
                            break;
                    }
                    if (!steps.Contains(currentPos) && !deadends.Contains(currentPos))
                    {
                        Instantiate(empty, currentPos, transform.rotation);
                        steps.Add(currentPos);
                    }
                    robotInstance.transform.position = currentPos;
                }

                else if (output[0] == 2)
                {
                    switch (inputInstruction)
                    {
                        case 1:
                            currentPos = new Vector2(currentPos.x, currentPos.y + 1);
                            break;
                        case 2:
                            currentPos = new Vector2(currentPos.x, currentPos.y - 1);
                            break;
                        case 3:
                            currentPos = new Vector2(currentPos.x - 1, currentPos.y);
                            break;
                        case 4:
                            currentPos = new Vector2(currentPos.x + 1, currentPos.y);
                            break;
                    }
                    //Debug.Log("FOUND OXYGEN SYSTEM AT " + currentPos);
                    Instantiate(oxygenSystem, currentPos, transform.rotation);
                    ventilated.Add(currentPos);
                    randomAI = false;
                    foundSystem = true;
                }

                output.RemoveRange(0, 1);

                PlayerMovement();

                if (randomAI)
                {
                    RandomMovement();
                }

                FindBestRoute();
            }

            if (readyToVentilate)
            {
                if (!mapListDone)
                {
                    completeMap = steps.Concat(deadends).ToList();
                    mapListDone = true;
                }
                ventilationTime = Ventilate() ? ventilationTime + 1 : ventilationTime;
                Debug.Log(ventilationTime);
            }
        }

        public void PlayerMovement()
        {
            if (Input.GetKeyDown("up"))
            {
                inputInstruction = 1;
            }
            if (Input.GetKeyDown("down"))
            {
                inputInstruction = 2;
            }
            if (Input.GetKeyDown("left"))
            {
                inputInstruction = 3;
            }
            if (Input.GetKeyDown("right"))
            {
                inputInstruction = 4;
            }
        }

        public void RandomMovement()
        {
            movementInput = Random.Range(1, 5);
            switch (movementInput)
            {
                case 1: //north
                    if (!walls.Contains(new Vector2(currentPos.x, currentPos.y + 1)))
                    {
                        inputInstruction = 1;
                    }
                    else
                    {
                        RandomMovement();
                    }
                    break;
                case 2: //south
                    if (!walls.Contains(new Vector2(currentPos.x, currentPos.y - 1)))
                    {
                        inputInstruction = 2;
                    }
                    else
                    {
                        RandomMovement();
                    }
                    break;
                case 3: //west
                    if (!walls.Contains(new Vector2(currentPos.x - 1, currentPos.y)))
                    {
                        inputInstruction = 3;
                    }
                    else
                    {
                        RandomMovement();
                    }
                    break;
                case 4: //east
                    if (!walls.Contains(new Vector2(currentPos.x + 1, currentPos.y)))
                    {
                        inputInstruction = 4;
                    }
                    else
                    {
                        RandomMovement();
                    }
                    break;
            }
        }

        public void FindBestRoute()
        {
            foreach (Vector2 vec in steps)
            {
                if (vec == new Vector2(0, 0))
                {
                    continue;
                }

                int surrounded = 0;
                if (walls.Contains(new Vector2(vec.x, vec.y + 1)) || deadends.Contains(new Vector2(vec.x, vec.y + 1)))
                {
                    surrounded++;
                }
                if (walls.Contains(new Vector2(vec.x, vec.y - 1)) || deadends.Contains(new Vector2(vec.x, vec.y - 1)))
                {
                    surrounded++;
                }
                if (walls.Contains(new Vector2(vec.x + 1, vec.y)) || deadends.Contains(new Vector2(vec.x + 1, vec.y)))
                {
                    surrounded++;
                }
                if (walls.Contains(new Vector2(vec.x - 1, vec.y)) || deadends.Contains(new Vector2(vec.x - 1, vec.y)))
                {
                    surrounded++;
                }

                if (surrounded == 3)
                {
                    Instantiate(deadend, vec, transform.rotation);
                    deadends.Add(vec);
                    steps.Remove(vec);
                }
            }
        }

        public bool Ventilate()
        {
            bool newVentilated = false;
            List<Vector2> ventilatedToAdd = new List<Vector2>();
            List<Vector2> completeToRemove = new List<Vector2>();

            foreach (Vector2 v in ventilated)
            {
                foreach (Vector2 m in completeMap)
                {
                    if (m == new Vector2(v.x, v.y + 1) || m == new Vector2(v.x, v.y - 1) || m == new Vector2(v.x + 1, v.y) || m == new Vector2(v.x - 1, v.y))
                    {
                        ventilatedToAdd.Add(m);
                        completeToRemove.Remove(m);
                        Instantiate(ventilation, m, transform.rotation);
                        newVentilated = true;
                    }
                }
            }
            foreach (Vector2 v in ventilatedToAdd)
            {
                ventilated.Add(v);
            }
            foreach (Vector2 m in completeToRemove)
            {
                ventilated.Remove(m);
            }

            return newVentilated;
        }
    }
}
