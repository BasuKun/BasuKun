using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SudokuGenerator : MonoBehaviour
{
    private int[,] digitsArray = new int[9, 9];
    private List<int> digitsTestedList = new List<int>();
    private int digitToAdd;
    public TextMeshProUGUI digitsText;

    private bool hasResetted = false;
    private bool generatedNewDigit = false;
    private bool hasBrokeSudoku = false;

    public void StartGenerateSudoku()
    {
        hasResetted = false;
        GenerateSudoku();
    }

    private void GenerateSudoku()
    {
        ResetElements();

        if (hasResetted)
        {
            for (int i = 0; i < 9; i++)
            {
                if (hasBrokeSudoku) break;

                GenerateRow(i);
            }

            if (hasBrokeSudoku) StartGenerateSudoku();
            else ArrayToString();
        }
    }

    private void ResetElements()
    {
        Array.Clear(digitsArray, 0, digitsArray.Length);
        digitsTestedList.Clear();
        digitToAdd = 0;
        digitsText.text = "";
        generatedNewDigit = false;
        hasBrokeSudoku = false;
        hasResetted = true;
    }

    private void GenerateRow(int row)
    {
        for (int i = 0; i < 9; i++)
        {
            if (hasBrokeSudoku) break;

            digitsTestedList.Clear();
            TryAddDigit(i, row);
        }
    }

    private void TryAddDigit(int position, int row)
    {
        GetNewRandomNumber();

        if (generatedNewDigit)
        {
            if (GeneratedDupeInRow(position, row) || GeneratedDupeInColumn(position, row) || GeneratedDupeInBox(position, row))
            {
                generatedNewDigit = false;
                TryAddDigit(position, row);
            }
            else
            {
                digitsArray[row, position] = digitToAdd;
                digitsTestedList.Clear();
                generatedNewDigit = false;
            }
        }
    }

    private void GetNewRandomNumber()
    {
        int digit = UnityEngine.Random.Range(1, 10);

        if (!digitsTestedList.Contains(digit) && digitsTestedList.Count < 9)
        {
            digitToAdd = digit;
            digitsTestedList.Add(digitToAdd);
            generatedNewDigit = true;
        }
        else
        {
            if (digitsTestedList.Count >= 9)
            {
                hasBrokeSudoku = true;
            }
            else
            {
                GetNewRandomNumber();
            }
        }
    }

    private bool GeneratedDupeInRow(int position, int row)
    {
        for (int i = 0; i < 9; i++)
        {
            if (digitsArray[row, i] == digitToAdd) return true;
        }
        return false;
    }

    private bool GeneratedDupeInColumn(int position, int row)
    {
        for (int i = (row - 1); i >= 0; i--)
        {
            if (digitsArray[i, position] == digitToAdd) return true;
        }
        return false;
    }

    private bool GeneratedDupeInBox(int position, int row)
    {
        int moduloRow = row % 3;
        int moduloPos = position % 3;

        for (int y = row; y >= (row - moduloRow); y--)
        {
            for (int x = (position - moduloPos); x <= (position - moduloPos + 2); x++)
            {
                if (digitsArray[y, x] == digitToAdd) return true;
            }
        }
        return false;
    }

    private void ArrayToString()
    {
        digitsText.text = "";
        for (int row = 0; row < 9; row++)
        {
            for (int pos = 0; pos < 9; pos++)
            {
                digitsText.text += digitsArray[row, pos].ToString();
            }
        }
    }
}
