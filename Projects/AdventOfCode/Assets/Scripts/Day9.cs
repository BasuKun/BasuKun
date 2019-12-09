﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day9 : MonoBehaviour
{
    private long[] program = { 1102, 34463338, 34463338, 63, 1007, 63, 34463338, 63, 1005, 63, 53, 1102, 1, 3, 1000, 109, 988, 209, 12, 9, 1000, 209, 6, 209, 3, 203, 0, 1008, 1000, 1, 63, 1005, 63, 65,
        1008, 1000, 2, 63, 1005, 63, 904, 1008, 1000, 0, 63, 1005, 63, 58, 4, 25, 104, 0, 99, 4, 0, 104, 0, 99, 4, 17, 104, 0, 99, 0, 0, 1102, 31, 1, 1009, 1101, 35, 0, 1006, 1102, 1, 23, 1002, 1101, 0,
        32, 1013, 1101, 0, 37, 1003, 1101, 0, 620, 1029, 1101, 0, 28, 1011, 1102, 22, 1, 1016, 1102, 1, 0, 1020, 1102, 1, 34, 1007, 1102, 1, 417, 1026, 1102, 1, 25, 1000, 1101, 27, 0, 1010, 1102, 580,
        1, 1025, 1102, 1, 629, 1028, 1101, 20, 0, 1004, 1102, 899, 1, 1022, 1101, 26, 0, 1001, 1102, 410, 1, 1027, 1102, 39, 1, 1018, 1101, 0, 30, 1008, 1101, 0, 38, 1014, 1101, 1, 0, 1021, 1102, 29, 1,
        1017, 1101, 0, 36, 1012, 1101, 585, 0, 1024, 1101, 0, 21, 1005, 1101, 0, 892, 1023, 1102, 1, 33, 1019, 1101, 24, 0, 1015, 109, 17, 1206, 3, 195, 4, 187, 1105, 1, 199, 1001, 64, 1, 64, 1002, 64,
        2, 64, 109, -7, 2108, 30, -2, 63, 1005, 63, 217, 4, 205, 1105, 1, 221, 1001, 64, 1, 64, 1002, 64, 2, 64, 109, 6, 1206, 5, 233, 1106, 0, 239, 4, 227, 1001, 64, 1, 64, 1002, 64, 2, 64, 109, -16,
        1202, 9, 1, 63, 1008, 63, 34, 63, 1005, 63, 259, 1105, 1, 265, 4, 245, 1001, 64, 1, 64, 1002, 64, 2, 64, 109, 8, 1207, -2, 34, 63, 1005, 63, 285, 1001, 64, 1, 64, 1105, 1, 287, 4, 271, 1002, 64,
        2, 64, 109, -4, 1207, -3, 27, 63, 1005, 63, 305, 4, 293, 1105, 1, 309, 1001, 64, 1, 64, 1002, 64, 2, 64, 109, -1, 21107, 40, 41, 9, 1005, 1012, 331, 4, 315, 1001, 64, 1, 64, 1105, 1, 331, 1002,
        64, 2, 64, 109, 5, 2107, 19, -4, 63, 1005, 63, 349, 4, 337, 1106, 0, 353, 1001, 64, 1, 64, 1002, 64, 2, 64, 109, 1, 1208, -5, 20, 63, 1005, 63, 371, 4, 359, 1105, 1, 375, 1001, 64, 1, 64, 1002,
        64, 2, 64, 109, -2, 21101, 41, 0, 9, 1008, 1016, 41, 63, 1005, 63, 397, 4, 381, 1106, 0, 401, 1001, 64, 1, 64, 1002, 64, 2, 64, 109, 25, 2106, 0, -5, 1001, 64, 1, 64, 1105, 1, 419, 4, 407, 1002,
        64, 2, 64, 109, -30, 2102, 1, 0, 63, 1008, 63, 26, 63, 1005, 63, 439, 1106, 0, 445, 4, 425, 1001, 64, 1, 64, 1002, 64, 2, 64, 109, 2, 2108, 32, 4, 63, 1005, 63, 465, 1001, 64, 1, 64, 1105, 1,
        467, 4, 451, 1002, 64, 2, 64, 109, -11, 1201, 10, 0, 63, 1008, 63, 34, 63, 1005, 63, 491, 1001, 64, 1, 64, 1106, 0, 493, 4, 473, 1002, 64, 2, 64, 109, 27, 21102, 42, 1, -1, 1008, 1019, 42, 63,
        1005, 63, 515, 4, 499, 1105, 1, 519, 1001, 64, 1, 64, 1002, 64, 2, 64, 109, -6, 1201, -7, 0, 63, 1008, 63, 34, 63, 1005, 63, 545, 4, 525, 1001, 64, 1, 64, 1106, 0, 545, 1002, 64, 2, 64, 109,
        -15, 1202, 3, 1, 63, 1008, 63, 23, 63, 1005, 63, 567, 4, 551, 1105, 1, 571, 1001, 64, 1, 64, 1002, 64, 2, 64, 109, 33, 2105, 1, -8, 4, 577, 1106, 0, 589, 1001, 64, 1, 64, 1002, 64, 2, 64, 109,
        -19, 1208, -4, 34, 63, 1005, 63, 605, 1105, 1, 611, 4, 595, 1001, 64, 1, 64, 1002, 64, 2, 64, 109, 7, 2106, 0, 8, 4, 617, 1001, 64, 1, 64, 1106, 0, 629, 1002, 64, 2, 64, 109, -8, 1205, 9, 647,
        4, 635, 1001, 64, 1, 64, 1106, 0, 647, 1002, 64, 2, 64, 109, -12, 2107, 38, 3, 63, 1005, 63, 667, 1001, 64, 1, 64, 1106, 0, 669, 4, 653, 1002, 64, 2, 64, 109, -3, 2102, 1, 10, 63, 1008, 63, 34,
        63, 1005, 63, 695, 4, 675, 1001, 64, 1, 64, 1105, 1, 695, 1002, 64, 2, 64, 109, 14, 21108, 43, 45, 4, 1005, 1015, 711, 1105, 1, 717, 4, 701, 1001, 64, 1, 64, 1002, 64, 2, 64, 109, 13, 1205, -4,
        733, 1001, 64, 1, 64, 1105, 1, 735, 4, 723, 1002, 64, 2, 64, 109, -30, 2101, 0, 9, 63, 1008, 63, 37, 63, 1005, 63, 761, 4, 741, 1001, 64, 1, 64, 1106, 0, 761, 1002, 64, 2, 64, 109, 17, 21102,
        44, 1, 1, 1008, 1012, 45, 63, 1005, 63, 785, 1001, 64, 1, 64, 1106, 0, 787, 4, 767, 1002, 64, 2, 64, 109, 5, 2101, 0, -9, 63, 1008, 63, 35, 63, 1005, 63, 811, 1001, 64, 1, 64, 1106, 0, 813, 4,
        793, 1002, 64, 2, 64, 109, 2, 21107, 45, 44, -5, 1005, 1013, 833, 1001, 64, 1, 64, 1106, 0, 835, 4, 819, 1002, 64, 2, 64, 109, -2, 21101, 46, 0, -6, 1008, 1010, 44, 63, 1005, 63, 855, 1106, 0,
        861, 4, 841, 1001, 64, 1, 64, 1002, 64, 2, 64, 109, 2, 21108, 47, 47, -8, 1005, 1010, 883, 4, 867, 1001, 64, 1, 64, 1106, 0, 883, 1002, 64, 2, 64, 109, 2, 2105, 1, 3, 1001, 64, 1, 64, 1106, 0,
        901, 4, 889, 4, 64, 99, 21102, 27, 1, 1, 21102, 1, 915, 0, 1105, 1, 922, 21201, 1, 28815, 1, 204, 1, 99, 109, 3, 1207, -2, 3, 63, 1005, 63, 964, 21201, -2, -1, 1, 21102, 1, 942, 0, 1105, 1, 922,
        21202, 1, 1, -1, 21201, -2, -3, 1, 21101, 0, 957, 0, 1105, 1, 922, 22201, 1, -1, -2, 1106, 0, 968, 21202, -2, 1, -2, 109, -3, 2106, 0, 0 };

    private long inputInstruction = 2;
    public List<long> output = new List<long>();
    private long instructionPointer = 4;
    private long relativeBase = 0;

    private void Start()
    {
        System.Array.Resize(ref program, program.Length + 1000000);
        RunProgram(inputInstruction, ref output, ref instructionPointer, ref relativeBase);

        foreach (long diagnostic in output)
        {
            Debug.Log(diagnostic);
        }
    }

    private void RunProgram(long input, ref List<long> output, ref long IP, ref long relative)
    {
        for (long i = 0; i < program.Length; i += IP)
        {
            Debug.LogWarning("==CHECKING POS " + i + ": " + program[i] + ", " + program[i+1] + ", " + program[i+2] + ", " + program[i+3] + "==");
            float opcode = (int)Mathf.Abs(program[i] % 10); 
            float opcodeTenth = (int)Mathf.Abs(program[i] / 10 % 10);
            float firstParam = (int)Mathf.Abs(program[i] / 100 % 10);
            float secondParam = (int)Mathf.Abs(program[i] / 1000 % 10);
            float thirdParam = (int)Mathf.Abs(program[i] / 10000 % 10);

            Debug.Log("Opcode: " + opcode + ", FirstParam: " + firstParam + ", SecondParam: " + secondParam + ", ThirdParam: " + thirdParam + ", opcodeTenth: " + opcodeTenth);

            long firstInputParam = 0;
            if (firstParam == 0)
            {
                firstInputParam = program[program[i + 1]];
            }
            else if (firstParam == 1)
            {
                firstInputParam = program[i + 1];
            }
            else if (firstParam == 2)
            {
                firstInputParam = program[program[i + 1] + relative];
            }

            IP = 4;

            long secondInputParam = 0;
            if (opcode != 3)
            {
                if (opcode != 4)
                {
                    if (opcode != 9 && opcodeTenth != 9)
                    {
                        if (secondParam == 0)
                        {
                            secondInputParam = program[program[i + 2]];
                        }
                        else if (secondParam == 1)
                        {
                            secondInputParam = program[i + 2];
                        }
                        else if (secondParam == 2)
                        {
                            secondInputParam = program[program[i + 2] + relative];
                        }
                    }
                }
            }

            if (opcode == 1)
            {
                if (thirdParam == 0)
                {
                    program[program[i + 3]] = firstInputParam + secondInputParam;
                    Debug.Log("O1P0: Changed position " + program[i + 3] + " to " + program[program[i + 3]]);
                }
                else if (thirdParam == 1)
                {
                    program[i + 3] = firstInputParam + secondInputParam;
                    Debug.Log("01P1: Changed position " + (i + 3) + " to " + program[i + 3]);
                }
                else if (thirdParam == 2)
                {
                    program[program[i + 3] + relative] = firstInputParam + secondInputParam;
                    Debug.Log("O1P2: Changed position " + program[i + 3] + relative + " to " + program[program[i + 3] + relative]);
                }
            }

            else if (opcode == 2)
            {
                if (thirdParam == 0)
                {
                    program[program[i + 3]] = firstInputParam * secondInputParam;
                    Debug.Log("O2P0: Changed position " + program[i + 3] + " to " + program[program[i + 3]]);
                }
                else if (thirdParam == 1)
                {
                    program[i + 3] = firstInputParam * secondInputParam;
                    Debug.Log("02P1: Changed position " + (i + 3) + " to " + program[i + 3]);
                }
                else if (thirdParam == 2)
                {
                    program[program[i + 3] + relative] = firstInputParam * secondInputParam;
                    Debug.Log("O2P2: Changed position " + program[i + 3] + relative + " to " + program[program[i + 3] + relative]);
                }
            }

            else if (opcode == 3)
            {
                if (firstParam == 0 || firstParam == 1)
                {
                    program[program[i + 1]] = input;
                    Debug.Log("O3P0: Changed position " + program[i + 3] + " to " + input);
                }
                else if (firstParam == 2)
                {
                    program[program[i + 1] + relative] = input;
                    Debug.Log("O3P1: Changed position " + program[i + 3] + relative + " to " + input);
                }
                IP = 2;
            }

            else if (opcode == 4)
            {
                if (firstParam == 0 || firstParam == 1)
                {
                    output.Add(program[program[i + 1]]);
                    Debug.Log("O4P0: Added output " + program[program[i + 1]]);
                }
                else if (firstParam == 2)
                {
                    output.Add(program[program[i + 1] + relative]);
                    Debug.Log("O4P0: Added output " + program[program[i + 1] + relative]);
                }
                IP = 2;
            }

            else if (opcode == 5)
            {
                if (firstInputParam != 0)
                {
                    IP = secondInputParam - i;
                    Debug.Log("O5No0: Changing IP to: " + IP);
                }
                else
                {
                    IP = 3;
                    Debug.Log("O5Yes0: Skipping");
                }
            }

            else if (opcode == 6)
            {
                if (firstInputParam == 0)
                {
                    IP = secondInputParam - i;
                    Debug.Log("O6Yes0: Changing IP to: " + IP);
                }
                else
                {
                    IP = 3;
                    Debug.Log("O6Yes0: Skipping");
                }
            }

            else if (opcode == 7)
            {
                if (thirdParam == 0)
                {
                    program[program[i + 3]] = (firstInputParam < secondInputParam) ? 1 : 0;
                    Debug.Log("O7P0: Changed position " + program[i + 3] + " to " + program[program[i + 3]]);
                }
                else if (thirdParam == 1)
                {
                    program[i + 3] = (firstInputParam < secondInputParam) ? 1 : 0;
                    Debug.Log("02P1: Changed position " + (i + 3) + " to " + program[i + 3]);
                }
                else if (thirdParam == 2)
                {
                    program[program[i + 3] + relative] = (firstInputParam < secondInputParam) ? 1 : 0;
                    Debug.Log("O2P2: Changed position " + program[i + 3] + relative + " to " + program[program[i + 3] + relative]);
                }
            }

            else if (opcode == 8)
            {
                if (thirdParam == 0)
                {
                    program[program[i + 3]] = (firstInputParam == secondInputParam) ? 1 : 0;
                }
                else if (thirdParam == 1)
                {
                    program[i + 3] = (firstInputParam == secondInputParam) ? 1 : 0;
                }
                else if (thirdParam == 2)
                {
                    program[program[i + 3] + relative] = (firstInputParam == secondInputParam) ? 1 : 0;
                }
            }

            else if (opcode == 9 && opcodeTenth != 9)
            {
                relative += firstInputParam;
                IP = 2;
            }

            else if (opcode == 9 && opcodeTenth == 9)
            {
                break;
            }
        }
    }
}
