﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day5 : MonoBehaviour
{
    private int[] program = { 3, 225, 1, 225, 6, 6, 1100, 1, 238, 225, 104, 0, 1001, 210, 88, 224, 101, -143, 224, 224, 4, 224, 1002, 223, 8, 223, 101, 3, 224, 224, 1, 223, 224, 223, 101, 42, 92, 224,
        101, -78, 224, 224, 4, 224, 1002, 223, 8, 223, 1001, 224, 3, 224, 1, 223, 224, 223, 1101, 73, 10, 225, 1102, 38, 21, 225, 1102, 62, 32, 225, 1, 218, 61, 224, 1001, 224, -132, 224, 4, 224, 102,
        8, 223, 223, 1001, 224, 5, 224, 1, 224, 223, 223, 1102, 19, 36, 225, 102, 79, 65, 224, 101, -4898, 224, 224, 4, 224, 102, 8, 223, 223, 101, 4, 224, 224, 1, 224, 223, 223, 1101, 66, 56, 224,
        1001, 224, -122, 224, 4, 224, 102, 8, 223, 223, 1001, 224, 2, 224, 1, 224, 223, 223, 1002, 58, 82, 224, 101, -820, 224, 224, 4, 224, 1002, 223, 8, 223, 101, 3, 224, 224, 1, 223, 224, 223, 2,
        206, 214, 224, 1001, 224, -648, 224, 4, 224, 102, 8, 223, 223, 101, 3, 224, 224, 1, 223, 224, 223, 1102, 76, 56, 224, 1001, 224, -4256, 224, 4, 224, 102, 8, 223, 223, 1001, 224, 6, 224, 1, 223,
        224, 223, 1102, 37, 8, 225, 1101, 82, 55, 225, 1102, 76, 81, 225, 1101, 10, 94, 225, 4, 223, 99, 0, 0, 0, 677, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1105, 0, 99999, 1105, 227, 247, 1105, 1, 99999,
        1005, 227, 99999, 1005, 0, 256, 1105, 1, 99999, 1106, 227, 99999, 1106, 0, 265, 1105, 1, 99999, 1006, 0, 99999, 1006, 227, 274, 1105, 1, 99999, 1105, 1, 280, 1105, 1, 99999, 1, 225, 225, 225,
        1101, 294, 0, 0, 105, 1, 0, 1105, 1, 99999, 1106, 0, 300, 1105, 1, 99999, 1, 225, 225, 225, 1101, 314, 0, 0, 106, 0, 0, 1105, 1, 99999, 8, 226, 677, 224, 102, 2, 223, 223, 1005, 224, 329, 101,
        1, 223, 223, 1008, 677, 677, 224, 1002, 223, 2, 223, 1006, 224, 344, 1001, 223, 1, 223, 107, 226, 677, 224, 102, 2, 223, 223, 1005, 224, 359, 1001, 223, 1, 223, 1108, 677, 677, 224, 1002, 223,
        2, 223, 1006, 224, 374, 101, 1, 223, 223, 1107, 677, 677, 224, 1002, 223, 2, 223, 1006, 224, 389, 101, 1, 223, 223, 108, 226, 677, 224, 102, 2, 223, 223, 1006, 224, 404, 101, 1, 223, 223, 7,
        677, 677, 224, 102, 2, 223, 223, 1006, 224, 419, 101, 1, 223, 223, 108, 677, 677, 224, 102, 2, 223, 223, 1006, 224, 434, 1001, 223, 1, 223, 7, 226, 677, 224, 102, 2, 223, 223, 1006, 224, 449,
        1001, 223, 1, 223, 108, 226, 226, 224, 102, 2, 223, 223, 1005, 224, 464, 101, 1, 223, 223, 8, 226, 226, 224, 1002, 223, 2, 223, 1006, 224, 479, 101, 1, 223, 223, 1008, 226, 226, 224, 102, 2,
        223, 223, 1005, 224, 494, 1001, 223, 1, 223, 1008, 677, 226, 224, 1002, 223, 2, 223, 1005, 224, 509, 101, 1, 223, 223, 7, 677, 226, 224, 102, 2, 223, 223, 1006, 224, 524, 101, 1, 223, 223,
        1007, 677, 226, 224, 1002, 223, 2, 223, 1006, 224, 539, 1001, 223, 1, 223, 1108, 677, 226, 224, 102, 2, 223, 223, 1005, 224, 554, 1001, 223, 1, 223, 8, 677, 226, 224, 1002, 223, 2, 223, 1005,
        224, 569, 101, 1, 223, 223, 1108, 226, 677, 224, 1002, 223, 2, 223, 1005, 224, 584, 101, 1, 223, 223, 1107, 677, 226, 224, 102, 2, 223, 223, 1006, 224, 599, 101, 1, 223, 223, 107, 226, 226,
        224, 102, 2, 223, 223, 1006, 224, 614, 1001, 223, 1, 223, 107, 677, 677, 224, 1002, 223, 2, 223, 1005, 224, 629, 1001, 223, 1, 223, 1107, 226, 677, 224, 1002, 223, 2, 223, 1006, 224, 644, 101,
        1, 223, 223, 1007, 677, 677, 224, 102, 2, 223, 223, 1006, 224, 659, 1001, 223, 1, 223, 1007, 226, 226, 224, 1002, 223, 2, 223, 1006, 224, 674, 1001, 223, 1, 223, 4, 223, 99, 226 };

    public int inputInstruction = 5;
    public List<int> output = new List<int>();
    private int instructionPointer = 4;

    private void Start()
    {
        RunProgram(inputInstruction, ref output, ref instructionPointer);

        foreach (int diagnostic in output)
        {
            Debug.Log(diagnostic);
        }
    }

    private void RunProgram(int input, ref List<int> output, ref int IP)
    {
        for (int i = 0; i < program.Length; i += IP)
        {

            float opcode = (int)Mathf.Abs(program[i] % 10); 
            float firstParam = (int)Mathf.Abs(program[i] / 100 % 10);
            float secondParam = (int)Mathf.Abs(program[i] / 1000 % 10);
            float thirdParam = (int)Mathf.Abs(program[i] / 10000 % 10);

            int firstInputParam = firstParam == 0 ? program[program[i + 1]] : program[i + 1];
            int secondInputParam = 0;

            IP = 4;

            if (opcode != 3)
            {
                if (opcode != 4)
                {
                    if (opcode != 9)
                    {
                        secondInputParam = secondParam == 0 ? program[program[i + 2]] : program[i + 2];
                    }
                }
            }

            if (opcode == 1)
            {
                if (thirdParam == 0)
                {
                    program[program[i + 3]] = firstInputParam + secondInputParam;
                }
                else
                {
                    program[i + 3] = firstInputParam + secondInputParam;
                }

            }

            else if (opcode == 2)
            {
                if (thirdParam == 0)
                {
                    program[program[i + 3]] = firstInputParam * secondInputParam;
                }
                else
                {
                    program[i + 3] = firstInputParam * secondInputParam;
                }
            }

            else if (opcode == 3)
            {
                program[program[i + 1]] = input;
                IP = 2;
            }

            else if (opcode == 4)
            {
                output.Add(program[program[i + 1]]);
                IP = 2;
            }

            else if (opcode == 5)
            {
                if (firstInputParam != 0)
                {
                    IP = secondInputParam - i;
                }
                else
                {
                    IP = 3;
                }
            }

            else if (opcode == 6)
            {
                if (firstInputParam == 0)
                {
                    IP = secondInputParam - i;
                }
                else
                {
                    IP = 3;
                }
            }

            else if (opcode == 7)
            {
                if (thirdParam == 0)
                {
                    program[program[i + 3]] = (firstInputParam < secondInputParam) ? 1 : 0;
                }
                else
                {
                    program[i + 3] = (firstInputParam < secondInputParam) ? 1 : 0;
                }
            }

            else if (opcode == 8)
            {
                if (thirdParam == 0)
                {
                    program[program[i + 3]] = (firstInputParam == secondInputParam) ? 1 : 0;
                }
                else
                {
                    program[i + 3] = (firstInputParam == secondInputParam) ? 1 : 0;
                }
            }

            else if (opcode == 9)
            {
                break;
            }
        }
    }
}
