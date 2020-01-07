using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("UPGRADES")]
    public float spawnSpeed = 3f;
    public float valueMultiplier = 1f;
    public float radius = 0.1f;

    [Header("CURRENCIES")]
    public int snowflakesAmount = 0;
    public int frostflakesAmount = 0;

    public static GameManager Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void collectSnowflakes(float value)
    {
        snowflakesAmount += (int)value * (int)valueMultiplier;
        GameUI.Instance.snowflakesUpdateText();
    }
}
