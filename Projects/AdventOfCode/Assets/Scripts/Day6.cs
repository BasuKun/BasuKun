using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Day6 : MonoBehaviour
{
    private void Start()
    {
        Dictionary<string, Object> Objects = new Dictionary<string, Object>();

        Orbitationer(Objects);

        // SOLVE PART 1
        int orbits = 0;
        foreach (var i in Objects)
        {
            orbits += i.Value.orbitCount;
        }

        Debug.Log(orbits);

        // SOLVE PART 2
        Object current = Objects["SAN"];
        Debug.Log("SAN: " + Objects["SAN"].orbitCount);
        while (current.parent != null)
        {
            current = current.parent;
            current.SAN = true;
            Debug.Log("Put SAN to true at: " + current.orbitCount);
        }

        current = Objects["YOU"];
        Debug.Log("YOU: " + Objects["YOU"].orbitCount);
        while (current.parent != null)
        {
            current = current.parent;
            Debug.Log("Moving back to: " + current.orbitCount);
            if (current.SAN)
            {
                break;
            }
        }

        int transfers = Objects["SAN"].orbitCount + Objects["YOU"].orbitCount - (2 * current.orbitCount) - 2;

        Debug.Log(transfers);
    }

    void Orbitationer(Dictionary<string, Object> dict)
    {
        using (StreamReader reader = new StreamReader("daysix.txt"))
        {
            string[] objectArray;

            while ((objectArray = reader.ReadLine()?.Split(')')) != null)
            {
                if (!dict.ContainsKey(objectArray[0]))
                {
                    dict[objectArray[0]] = new Object(objectArray[0], null);
                }
                if (!dict.ContainsKey(objectArray[1]))
                {
                    dict[objectArray[1]] = new Object(objectArray[1], dict[objectArray[0]]);
                }
                else
                {
                    dict[objectArray[1]].parent = dict[objectArray[0]];
                }
            }
        }
    }

    public class Object
    {
        public string name;
        public Object parent;

        public int orbitCount => (parent == null) ? 0 : parent.orbitCount + 1;

        public bool YOU;
        public bool SAN;

        public Object(string name, Object parent)
        {
            this.name = name;
            this.parent = parent;
        }
    }
}

