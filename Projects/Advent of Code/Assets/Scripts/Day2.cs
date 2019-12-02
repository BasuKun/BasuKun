using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day2 : MonoBehaviour
{
    public int[] program = { 1, 0, 0, 3, 1, 1, 2, 3, 1, 3, 4, 3, 1, 5, 0, 3, 2, 1, 6, 19, 1, 9, 19, 23, 2, 23, 10, 27, 1, 27, 5, 31, 1, 31, 6, 35, 1, 6, 35, 39, 2, 39, 13, 43, 1, 9, 43, 47,
        2, 9, 47, 51, 1, 51, 6, 55, 2, 55, 10, 59, 1, 59, 5, 63, 2, 10, 63, 67, 2, 9, 67, 71, 1, 71, 5, 75, 2, 10, 75, 79, 1, 79, 6, 83, 2, 10, 83, 87, 1, 5, 87, 91, 2, 9, 91, 95, 1, 95, 5,
        99, 1, 99, 2, 103, 1, 103, 13, 0, 99, 2, 14, 0, 0 };

    private void Update()
    {
        while (program[0] != 19690720)
        {
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    RunProgram(i, j);
                }
            }
        }
    }

    private void RunProgram(int noun, int verb)
    {
        program[1] = noun;
        program[2] = verb;

        for (int i = 0; i < program.Length; i += 4)
        {
            if (program[i] == 1)
            {
                program[program[i + 3]] = program[program[i + 1]] + program[program[i + 2]];
            }
            else if (program[i] == 2)
            {
                program[program[i + 3]] = program[program[i + 1]] * program[program[i + 2]];
            }
            else if (program[i] == 99)
            {
                if (program[0] == 19690720)
                {
                    Debug.Log("SOLUTION FOUND:" + noun + " + " + verb + ". SOLUTION IS: " + ((100 * noun) + verb));
                    break;
                }
                else
                {
                    Debug.Log(noun + " + " + verb + ": " + program[0]);
                    program = new int[]{ 1, 0, 0, 3, 1, 1, 2, 3, 1, 3, 4, 3, 1, 5, 0, 3, 2, 1, 6, 19, 1, 9, 19, 23, 2, 23, 10, 27, 1, 27, 5, 31, 1, 31, 6, 35, 1, 6, 35, 39, 2, 39, 13, 43, 1, 9, 43, 47,
                        2, 9, 47, 51, 1, 51, 6, 55, 2, 55, 10, 59, 1, 59, 5, 63, 2, 10, 63, 67, 2, 9, 67, 71, 1, 71, 5, 75, 2, 10, 75, 79, 1, 79, 6, 83, 2, 10, 83, 87, 1, 5, 87, 91, 2, 9, 91, 95, 1, 95, 5,
                        99, 1, 99, 2, 103, 1, 103, 13, 0, 99, 2, 14, 0, 0 };
                    break;
                }
            }
        }
    }
}
