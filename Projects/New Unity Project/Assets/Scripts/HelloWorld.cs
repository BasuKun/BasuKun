using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public string myGameIdea;

    // Start is called before the first frame update
    void Start()
    {
        PrintGame();
    }

    void PrintGame()
    {
        print("My idea is: " + myGameIdea);
    }
}
