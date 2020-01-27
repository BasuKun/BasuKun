﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("UPGRADES")]
    public float spawnSpeed = 3f;
    public float valueMultiplier = 1f;
    public double snowflakeValue = 1;
    public float radius = 0.1f;
    public float shovelSpeed = 2f;

    [Header("CURRENCIES")]
    public double snowflakesAmount = 0;
    public double intelligencePoints = 0;

    [Header("OTHERS")]
    public int absorbedSnowflakes = 0;

    public static GameManager Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void collectSnowflakes(double value)
    {
        snowflakesAmount += (int)value * (int)valueMultiplier;
        GameUI.Instance.snowflakesUpdateText();
    }
}
