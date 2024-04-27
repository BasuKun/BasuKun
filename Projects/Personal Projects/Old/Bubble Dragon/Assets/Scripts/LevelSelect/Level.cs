using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public int ID { get; set; }
    public int Stars { get; set; }
    public string LevelName { get; set; }
    public bool IsCompleted { get; set; }
    public bool IsLocked { get; set; }

    public Level(int id, int stars, string levelName, bool isCompleted, bool isLocked)
    {
        this.ID = id;
        this.Stars = stars;
        this.LevelName = levelName;
        this.IsCompleted = isCompleted;
        this.IsLocked = isLocked;
    }

    public void Complete(int stars)
    {
        this.IsCompleted = true;
        this.Stars = stars;
    }

    public void Lock()
    {
        this.IsLocked = true;
    }

    public void Unlock()
    {
        this.IsLocked = false;
    }
}
