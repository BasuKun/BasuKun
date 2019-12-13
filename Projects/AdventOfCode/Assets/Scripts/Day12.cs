using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Day12 : MonoBehaviour
{
    public List<Moon> MoonsList = new List<Moon>();
    public List<Moon> MoonsListCopy = new List<Moon>();
    private int systemTotalEnergy;
    private int totalIdentical;
    private long totalSteps;
    private bool isBackToOriginal = false;
    private bool ReturnedFalse = false;

    void Awake()
    {
        MoonsList.AddRange(new List<Moon>{
            new Moon("Io", new Vector3(1, 2, -9)),
            new Moon("Europa", new Vector3(-1, -9, -4)),
            new Moon("Ganymede", new Vector3(17, 6, 8)),
            new Moon("Callisto", new Vector3(12, 4, 2)) });

        MoonsListCopy.AddRange(new List<Moon>{
            new Moon("Io", new Vector3(1, 2, -9)),
            new Moon("Europa", new Vector3(-1, -9, -4)),
            new Moon("Ganymede", new Vector3(17, 6, 8)),
            new Moon("Callisto", new Vector3(12, 4, 2)) });

        //foreach (Moon moon in MoonsListCopy)
        //{
        //    Debug.Log("Moon " + moon.name + ": " + moon.pos.x + ", " + moon.pos.y + ", " + moon.pos.z + ".");
        //}
    }

    void Start()
    {
        for (long i = 0; i < long.MaxValue; i++)
        {
            Step();

            isBackToOriginal = false;
            foreach (Moon moon in MoonsList)
            {
                foreach (Moon original in MoonsListCopy)
                {
                    if (moon.name == original.name && totalSteps > 10)
                    {
                        if (moon.pos == original.pos && moon.velocity == original.velocity)
                        {
                            Debug.Log(moon.name + " is equal to " + original.name + ": " + moon.pos + " and " + original.pos);
                            isBackToOriginal = true;
                        }
                        else
                        {
                            isBackToOriginal = false;
                        }
                    }
                    else
                    {
                        continue;
                    }

                    if (!isBackToOriginal)
                    {
                        ReturnedFalse = true;
                        break;
                    }
                }

                if (ReturnedFalse)
                {
                    ReturnedFalse = false;
                    break;
                }
            }

            if (isBackToOriginal)
            {
                Debug.Log(totalSteps);
                break;
            }
        }

        // SOLVE PART 1
        EnergyCalculator();
        //Debug.Log(systemTotalEnergy);
    }

    private void Step()
    {
        foreach (Moon a in MoonsList)
        {
            foreach (Moon b in MoonsList)
            {
                if (a == b)
                {
                    continue;
                }

                for (int v = 0; v < 3; v++)
                {
                    if (a.pos[v] > b.pos[v])
                    {
                        a.velocity[v]--;
                    }
                    else if (a.pos[v] < b.pos[v])
                    {
                        a.velocity[v]++;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }

        foreach (Moon moon in MoonsList)
        {
            moon.pos += moon.velocity;
        }
        totalSteps++;
    }

    private void EnergyCalculator()
    {
        foreach (Moon moon in MoonsList)
        {
            moon.potentialEnergy = (int)Mathf.Abs(moon.pos.x) + (int)Mathf.Abs(moon.pos.y) + (int)Mathf.Abs(moon.pos.z);
            moon.kineticEnergy = (int)Mathf.Abs(moon.velocity.x) + (int)Mathf.Abs(moon.velocity.y) + (int)Mathf.Abs(moon.velocity.z);
            moon.totalEnergy = moon.potentialEnergy * moon.kineticEnergy;
            systemTotalEnergy += moon.totalEnergy;
        }
    }

    public class Moon
    {
        public string name;
        public Vector3 pos = new Vector3(0, 0, 0);
        public Vector3 velocity = new Vector3(0, 0, 0);
        public int potentialEnergy;
        public int kineticEnergy;
        public int totalEnergy;

        public Moon(string name, Vector3 pos)
        {
            this.name = name;
            this.pos = pos;
        }
    }
}
