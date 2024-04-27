using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public List<Level> levels;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (FindObjectsOfType<LevelController>().Length > 1)
        {
            Destroy(gameObject);
        }

        levels = new List<Level>
        {
            new Level(0, 3, "Introduction", true, false),
            new Level(1, 1, "1-2", true, false),
            new Level(2, 0, "1-3", false, false),
            new Level(3, 0, "1-4", false, true),
            new Level(4, 0, "1-5", false, true),
            new Level(5, 0, "1-6", false, true),
            new Level(6, 0, "1-7", false, true),
            new Level(7, 0, "1-8", false, true),
            new Level(8, 0, "1-9", false, true),
            new Level(9, 0, "1-10", false, true),
            new Level(10, 0, "2-1", false, true),
            new Level(11, 0, "2-2", false, true),
            new Level(12, 0, "2-3", false, true),
            new Level(13, 0, "2-4", false, true),
            new Level(14, 0, "2-5", false, true),
            new Level(15, 0, "2-6", false, true),
            new Level(16, 0, "2-7", false, true),
            new Level(17, 0, "2-8", false, true),
            new Level(18, 0, "2-9", false, true),
            new Level(19, 0, "2-10", false, true),
            new Level(20, 0, "3-1", false, true),
            new Level(21, 0, "3-2", false, true),
            new Level(22, 0, "3-3", false, true),
            new Level(23, 0, "3-4", false, true),
            new Level(24, 0, "3-5", false, true),
            new Level(25, 0, "3-6", false, true),
        };
    }

    public void StartLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    public void StartLevel(int id)
    {
        SceneManager.LoadScene(id);
    }

    public void CompleteLevel(string levelName, int stars)
    {
        levels.Find(i => i.LevelName == levelName).Complete(stars);
    }

    public void CompleteLevel(int id, int stars)
    {
        levels.Find(i => i.ID == id).Complete(stars);
    }

    public void UnlockLevel(int id)
    {
        levels.Find(i => i.ID == id).Unlock();
    }
}
