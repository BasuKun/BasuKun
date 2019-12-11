using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

public class Day10 : MonoBehaviour
{
    public List<string> Rows = new List<string>();
    public List<Asteroid> Asteroids = new List<Asteroid>();
    public SortedDictionary<float, List<Asteroid>> OrderedAngles = new SortedDictionary<float, List<Asteroid>>();
    public int rowX = 0;
    public int rowY = 0;
    public int highestCount = 0;

    public float angleCheck;
    public int destroyCount;

    private void Start()
    {
        using (StreamReader reader = new StreamReader("dayten.txt"))
        {
            string[] mapArray;

            while ((mapArray = reader.ReadLine()?.Split(' ')) != null)
            {
                Rows.Add(mapArray[0]);
            }
        }

        foreach (string row in Rows)
        {
            rowX = 0;
            foreach (char c in row)
            {
                if (c == '#')
                {
                    Asteroids.Add(new Asteroid(rowX, rowY));
                }
                rowX++;
            }
            rowY++;
        }

        for (int a = 0; a < Asteroids.Count; a++)
        {
            List<float> Angles = new List<float>();

            for (int b = 0; b < Asteroids.Count; b++)
            {
                if (a == b)
                {
                    continue;
                }

                float angle = (float)Mathf.Atan2(Asteroids[a].x - Asteroids[b].x, Asteroids[a].y - Asteroids[b].y);

                if (!Angles.Contains(angle))
                {
                    Angles.Add(angle);
                    Asteroids[a].losCount++;

                    if (Asteroids[a].losCount > highestCount)
                    {
                        highestCount = Asteroids[a].losCount;
                    }
                }
            }
        }

        //part 1
        Debug.Log(highestCount);

        //part 2
        var station = Asteroids.Find(e => (e.x == 20 && e.y == 19));

        for (int b = 0; b < Asteroids.Count; b++)
        {
            if (Asteroids[b].x == station.x && Asteroids[b].y == station.y)
            {
                continue;
            }

            float angleRadian = (float)Mathf.Atan2(station.x - Asteroids[b].x, station.y - Asteroids[b].y);
            float angleDegree = ((180 / Mathf.PI) * angleRadian) *-1;

            if (angleDegree < 0)
            {
                angleDegree = 360 - (angleDegree * -1);
            }
            Asteroids[b].angle = angleDegree;

            if (OrderedAngles.ContainsKey(angleDegree))
            {
                OrderedAngles[angleDegree].Add(Asteroids[b]);
            }
            else
            {
                OrderedAngles.Add(angleDegree, new List<Asteroid> { Asteroids[b] });
            }

            Asteroids[b].distance = Mathf.Abs(Asteroids[b].x - station.x) + Mathf.Abs(Asteroids[b].y - station.y);
        }

        foreach (KeyValuePair<float, List<Asteroid>> angle in OrderedAngles)
        {
            angle.Value.Sort((p1, p2) => p1.distance.CompareTo(p2.distance));
        }

        foreach (KeyValuePair<float, List<Asteroid>> angle in OrderedAngles)
        {
            destroyCount++;
            Debug.Log(angle.Value[0].x + ", " + angle.Value[0].x + " removed. " + angle.Value[0].angle + ". Destroy: " + destroyCount);
            angle.Value.RemoveAt(0);
        }
    }

    public class Asteroid
    {
        //best Asteroid: (20, 19): 284 LOS
        public int x;
        public int y;

        public float angle;
        public int distance;

        public int losCount = 0;

        public Asteroid(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
