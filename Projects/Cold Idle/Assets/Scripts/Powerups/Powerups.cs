using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerups : MonoBehaviour
{
    public static Powerups Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public float SnowstormSeeker(bool isActive)
    {
        if (!isActive) return 1;

        float bonus = 1 + (SnowflakeSpawner.Instance.currentSnowflakesList.Count * 0.01f);
        return bonus;
    }
    
    public int LuckyWinter(bool isActive)
    {
        if (!isActive) return 0;

        int bonus = 20;
        return bonus;
    }

    public float BlessedSnowflakes(bool isActive)
    {
        if (!isActive) return 0;

        float bonus = 0.5f;
        return bonus;
    }

    public float ShovelMaster(bool isActive)
    {
        if (!isActive) return 1;

        float bonus = 0.5f;
        return bonus;
    }

    public float SnowflakeBooster(bool isActive)
    {
        if (!isActive) return 1;

        float bonus = 1.2f;
        return bonus;
    }

    public float SnowpileFreezer(bool isActive)
    {
        if (!isActive) return 1;

        float bonus = 1.2f;
        return bonus;
    }
}
