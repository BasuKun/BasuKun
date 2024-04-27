using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day4 : MonoBehaviour
{
    private int minInput = 372037;
    private int maxInput = 905157;

    public List<int> possiblePasswords = new List<int>();

    void Start()
    {
        for (int i = minInput; i <= maxInput; i++)
        {
            if (isAscending(i) && HasTwoAdjacentNumbers(i))
            {
                possiblePasswords.Add(i);
            }
        }

        // SOLVE
        Debug.Log(possiblePasswords.Count);
    }

    private bool isAscending(int number)
    {
        bool numberIsAscending = false;

        for (int i = 0; i < number.ToString().Length-1; i++)
        {
            numberIsAscending = int.Parse(number.ToString().Substring(i, 1)) <= int.Parse(number.ToString().Substring(i + 1, 1));

            if (!numberIsAscending)
            {
                break;
            }
        }

        return numberIsAscending;
    }

    private bool HasTwoAdjacentNumbers(int number)
    {
        bool HasTwoAdjacent = false;

        for (int i = 0; i < number.ToString().Length - 1; i++)
        {
            if (i < 1)
            {
                HasTwoAdjacent = int.Parse(number.ToString().Substring(i, 1)) == int.Parse(number.ToString().Substring(i + 1, 1))
                    && int.Parse(number.ToString().Substring(i, 1)) != int.Parse(number.ToString().Substring(i + 2, 1));
            }
            else if (i < number.ToString().Length - 2 && i >= 1)
            {
                HasTwoAdjacent = int.Parse(number.ToString().Substring(i, 1)) == int.Parse(number.ToString().Substring(i + 1, 1))
                    && int.Parse(number.ToString().Substring(i, 1)) != int.Parse(number.ToString().Substring(i + 2, 1))
                    && int.Parse(number.ToString().Substring(i, 1)) != int.Parse(number.ToString().Substring(i - 1, 1));
            }
            else
            {
                HasTwoAdjacent = int.Parse(number.ToString().Substring(i, 1)) == int.Parse(number.ToString().Substring(i + 1, 1))
                    && int.Parse(number.ToString().Substring(i, 1)) != int.Parse(number.ToString().Substring(i - 1, 1));
            }

            if (HasTwoAdjacent)
            {
                break;
            }
        }

        return HasTwoAdjacent;
    }
}
