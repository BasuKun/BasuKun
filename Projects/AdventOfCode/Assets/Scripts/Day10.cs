using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Day10 : MonoBehaviour
{
    public List<string> Rows = new List<string>();
    public List<Asteroid> Asteroids = new List<Asteroid>();
    public int rowX = 0;
    public int rowY = 0;
    public int highestCount = 0;

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

        Debug.Log(highestCount);
    }

    public class Asteroid
    {
        public int x;
        public int y;

        public int losCount = 0;

        public Asteroid(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
