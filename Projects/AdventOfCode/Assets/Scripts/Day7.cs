using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Day7 : MonoBehaviour
{
    private int[] program = { 3, 8, 1001, 8, 10, 8, 105, 1, 0, 0, 21, 42, 67, 84, 97, 118, 199, 280, 361, 442, 99999, 3, 9, 101, 4, 9, 9, 102, 5, 9, 9, 101, 2, 9, 9, 1002, 9, 2, 9, 4, 9, 99, 3, 9, 101, 5,
        9, 9, 102, 5, 9, 9, 1001, 9, 5, 9, 102, 3, 9, 9, 1001, 9, 2, 9, 4, 9, 99, 3, 9, 1001, 9, 5, 9, 1002, 9, 2, 9, 1001, 9, 5, 9, 4, 9, 99, 3, 9, 1001, 9, 5, 9, 1002, 9, 3, 9, 4, 9, 99, 3, 9, 102, 4, 9,
        9, 101, 4, 9, 9, 102, 2, 9, 9, 101, 3, 9, 9, 4, 9, 99, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9,
        1001, 9, 2, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 3, 9, 101, 2, 9, 9, 4, 9, 99, 3, 9, 1001, 9, 1, 9, 4, 9, 3, 9, 101, 2, 9, 9, 4, 9, 3, 9, 1001,
        9, 2, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 101, 2, 9, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 101, 1, 9, 9, 4, 9, 3, 9, 101, 2, 9, 9, 4,
        9, 99, 3, 9, 101, 1, 9, 9, 4, 9, 3, 9, 1001, 9, 1, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3,
        9, 102, 2, 9, 9, 4, 9, 3, 9, 101, 2, 9, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 99, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 1001,
        9, 2, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 101, 1, 9, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 99, 3, 9, 101, 1, 9, 9, 4, 9, 3, 9, 101, 1, 9, 9,
        4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 101, 1, 9, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 1001, 9, 1, 9, 4, 9, 3,
        9, 1001, 9, 2, 9, 4, 9, 99 };
    public List<int> possibleSignals = new List<int>();

    private int inputInstruction = 0;
    private int output;
    private int instructionPointer = 4;
    private bool phaseSettingUsed = false;

    private void Start()
    {
        for (int PS1 = 0; PS1 <= 4; PS1++)
        {
            for (int PS2 = 0; PS2 <= 4; PS2++)
            {
                for (int PS3 = 0; PS3 <= 4; PS3++)
                {
                    for (int PS4 = 0; PS4 <= 4; PS4++)
                    {
                        for (int PS5 = 0; PS5 <= 4; PS5++)
                        {
                            if (PS1 != PS2 && PS1 != PS3 && PS1 != PS4 && PS2 != PS3 && PS2 != PS4 && PS3 != PS4 && PS5 != PS1 && PS5 != PS2 && PS5 != PS3 && PS5 != PS4)
                            {
                                Debug.Log("testing: " + PS1 + " " + PS2 + " " + PS3 + " " + PS4 + " " + PS5);
                                inputInstruction = 0;
                                RunProgram(ref inputInstruction, ref output, ref instructionPointer, ref phaseSettingUsed, PS1);
                                inputInstruction = output;
                                RunProgram(ref inputInstruction, ref output, ref instructionPointer, ref phaseSettingUsed, PS2);
                                inputInstruction = output;
                                RunProgram(ref inputInstruction, ref output, ref instructionPointer, ref phaseSettingUsed, PS3);
                                inputInstruction = output;
                                RunProgram(ref inputInstruction, ref output, ref instructionPointer, ref phaseSettingUsed, PS4);
                                inputInstruction = output;
                                RunProgram(ref inputInstruction, ref output, ref instructionPointer, ref phaseSettingUsed, PS5);
                                possibleSignals.Add(output);
                            }
                        }
                    }
                }
            }
        }

        int maxSignal = possibleSignals.Max();
        Debug.Log(maxSignal);
    }

    private void RunProgram(ref int input, ref int output, ref int IP, ref bool PSUsed, int PS)
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
                if (!PSUsed)
                {
                    program[program[i + 1]] = PS;
                    IP = 2;
                    PSUsed = true;
                }
                else
                {
                    program[program[i + 1]] = input;
                    IP = 2;
                }
            }

            else if (opcode == 4)
            {
                output = program[program[i + 1]];
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
                PSUsed = false;
                program = new int[]{ 3, 8, 1001, 8, 10, 8, 105, 1, 0, 0, 21, 42, 67, 84, 97, 118, 199, 280, 361, 442, 99999, 3, 9, 101, 4, 9, 9, 102, 5, 9, 9, 101, 2, 9, 9, 1002, 9, 2, 9, 4, 9, 99, 3, 9,
                    101, 5, 9, 9, 102, 5, 9, 9, 1001, 9, 5, 9, 102, 3, 9, 9, 1001, 9, 2, 9, 4, 9, 99, 3, 9, 1001, 9, 5, 9, 1002, 9, 2, 9, 1001, 9, 5, 9, 4, 9, 99, 3, 9, 1001, 9, 5, 9, 1002, 9, 3, 9, 4, 9,
                    99, 3, 9, 102, 4, 9, 9, 101, 4, 9, 9, 102, 2, 9, 9, 101, 3, 9, 9, 4, 9, 99, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3,
                    9, 102, 2, 9, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 3, 9, 101, 2, 9, 9, 4, 9, 99, 3, 9, 1001, 9, 1, 9, 4,
                    9, 3, 9, 101, 2, 9, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 101, 2, 9, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 1002, 9, 2, 9,
                    4, 9, 3, 9, 101, 1, 9, 9, 4, 9, 3, 9, 101, 2, 9, 9, 4, 9, 99, 3, 9, 101, 1, 9, 9, 4, 9, 3, 9, 1001, 9, 1, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 1002, 9,
                    2, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 101, 2, 9, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 99, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 102,
                    2, 9, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 101, 1, 9, 9, 4, 9, 3, 9, 1001,
                    9, 2, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 99, 3, 9, 101, 1, 9, 9, 4, 9, 3, 9, 101, 1, 9, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 3, 9,
                    1002, 9, 2, 9, 4, 9, 3, 9, 101, 1, 9, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 1001, 9, 1, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 99 };

                break;
            }
        }
    }
}
