using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

public class Day8 : MonoBehaviour
{
    private int width = 25;
    private int weight = 6;
    private int totalPixels;
    private string puzzleInput;
    public List<string> layers = new List<string>();
    public List<string> finalRows = new List<string>();
    private string beginningLayer;
    private string finalLayer;

    void Awake()
    {
        totalPixels = width * weight;
        puzzleInput = File.ReadAllText(@"dayeight.txt");
    }

    void Start()
    {
        for (int i = 0; i < puzzleInput.Length; i += totalPixels)
        {
            layers.Add(puzzleInput.Substring(i, totalPixels));
        }

        // SOLVE PART 1
        foreach (string layer in layers)
        {
            int zeros = layer.Count(f => f == '0');
            int ones = layer.Count(f => f == '1');
            int twos = layer.Count(f => f == '2');
            //Debug.Log(zeros + ": " + ones * twos);
        }

        beginningLayer = layers[0];
        char[] layerArray = beginningLayer.ToCharArray();
        int pos = 0;

        foreach (string layer in layers)
        {
            foreach (char c in layer)
            {
                if (layerArray[pos] == '2')
                {
                    layerArray[pos] = c;
                }
                pos++;
            }
            pos = 0;
        }

        // SOLVE PART 2
        finalLayer = new string(layerArray);
        finalLayer = finalLayer.Replace('1', '#');
        finalLayer = finalLayer.Replace('0', '_');

        for (int i = 0; i < finalLayer.Length; i += width)
        {
            finalRows.Add(finalLayer.Substring(i, width));
            Debug.Log(finalLayer.Substring(i, width));
        }
    }
}
