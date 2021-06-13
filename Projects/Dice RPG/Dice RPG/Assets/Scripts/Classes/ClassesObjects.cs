using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassesObjects : MonoBehaviour
{
    public Dictionary<CurrentClass.classes, Class> characters = new Dictionary<CurrentClass.classes, Class>();
    public static ClassesObjects Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
}
